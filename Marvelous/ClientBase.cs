using System;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Marvelous
{
    public abstract class ClientBase
    {
        protected const string CharactersResource = "characters";
        protected const string ComicsResource = "comics";
        protected const string CreatorsResource = "creators";
        protected const string EventsResource = "events";
        protected const string SeriesResource = "series";
        protected const string StoriesResource = "stories";

        internal const string BaseUrl = "http://gateway.marvel.com/v1/public/";
        private readonly string _publicKey;
        private readonly string _privateKey;

        internal ClientBase(string publicKey, string privateKey)
        {
            _publicKey = publicKey;
            _privateKey = privateKey;
            CreateRequestClient = () =>
            {
                var client = new RestClient(BaseUrl);
                client.AddHandler("application/json", new DynamicJsonDeserializer());
                return client;
            };
        }

        public dynamic Find(int id)
        {
            return QueryIdSubPath(id);
        }

        public async Task<dynamic> FindAsync(int id)
        {
            return await QueryIdSubPathAsync(id);
        }

        public dynamic FindAll(int limit = 20, int offset = 0, NameValueCollection queryParameters = null)
        {
            var options = queryParameters ?? new NameValueCollection();
            options.Add("limit", limit.ToString(CultureInfo.InvariantCulture));
            options.Add("offset", offset.ToString(CultureInfo.InvariantCulture));

            return Query(Resource, options);
        }

        public async Task<dynamic> FindAllAsync(int limit = 20, int offset = 0, NameValueCollection queryParameters = null)
        {
            var options = queryParameters ?? new NameValueCollection();
            options.Add("limit", limit.ToString(CultureInfo.InvariantCulture));
            options.Add("offset", offset.ToString(CultureInfo.InvariantCulture));

            return await QueryAsync(Resource, options);
        }

        protected dynamic QueryIdSubPath(int id, string path = null, int limit = 20, int offset = 0, NameValueCollection queryParameters = null)
        {
            var options = queryParameters ?? new NameValueCollection();
            options.Add("limit", limit.ToString(CultureInfo.InvariantCulture));
            options.Add("offset", offset.ToString(CultureInfo.InvariantCulture));

            var resourceUri = Resource + "/{id}";

            if (!string.IsNullOrEmpty(path))
            {
                resourceUri += "/" + path;
            }

            return Query(resourceUri, options, UrlSegmentFor("id", id));
        }

        protected async Task<dynamic> QueryIdSubPathAsync(int id, string path = null, int limit = 20, int offset = 0, NameValueCollection queryParameters = null)
        {
            var options = queryParameters ?? new NameValueCollection();
            options.Add("limit", limit.ToString(CultureInfo.InvariantCulture));
            options.Add("offset", offset.ToString(CultureInfo.InvariantCulture));

            var resourceUri = Resource + "/{id}";

            if (!string.IsNullOrEmpty(path))
            {
                resourceUri += "/" + path;
            }

            return await QueryAsync(resourceUri, options, UrlSegmentFor("id", id));
        }

        private dynamic Query(string resourcePath, NameValueCollection options, NameValueCollection urlSegments = null)
        {
            options = options ?? new NameValueCollection();
            urlSegments = urlSegments ?? new NameValueCollection();

            var client = CreateRequestClient();

            var timestamp = GetTimestamp();
            var hash = GetHash(timestamp);
            var request = new RestRequest { Resource = resourcePath };

            options.AllKeys.ToList().ForEach(o => request.AddParameter(o, options[o], ParameterType.QueryString));

            urlSegments.AllKeys.ToList().ForEach(segment => request.AddUrlSegment(segment, urlSegments[segment]));

            request.AddParameter("ts", timestamp, ParameterType.QueryString);
            request.AddParameter("apikey", _publicKey, ParameterType.QueryString);
            request.AddParameter("hash", hash, ParameterType.QueryString);

            var response = client.Execute<dynamic>(request);

            if (response.ErrorException == null)
            {
                return response.Data;
            }

            throw new ApplicationException("Error retrieving response.  Check inner exception details for details.",
                response.ErrorException);
        }

        private Task<dynamic> QueryAsync(string resourcePath, NameValueCollection options, NameValueCollection urlSegments = null)
        {
            var request = PrepareRequest(resourcePath, options, urlSegments);

            var source = new TaskCompletionSource<dynamic>();
            var client = CreateRequestClient();

            client.ExecuteAsync<dynamic>(request, response =>
            {
                if (response.ErrorException == null)
                {
                    source.SetResult(response.Data);
                }
                else
                {
                    throw new ApplicationException("Error retrieving response.  Check inner exception details for details.",
                        response.ErrorException);
                }
            });

            return source.Task;
        }

        private RestRequest PrepareRequest(string resourcePath, NameValueCollection options, NameValueCollection urlSegments = null)
        {
            options = options ?? new NameValueCollection();
            urlSegments = urlSegments ?? new NameValueCollection();

            var timestamp = GetTimestamp();
            var hash = GetHash(timestamp);
            var request = new RestRequest { Resource = resourcePath };

            options.AllKeys.ToList().ForEach(o => request.AddParameter(o, options[o], ParameterType.QueryString));

            urlSegments.AllKeys.ToList().ForEach(segment => request.AddUrlSegment(segment, urlSegments[segment]));

            request.AddParameter("ts", timestamp, ParameterType.QueryString);
            request.AddParameter("apikey", _publicKey, ParameterType.QueryString);
            request.AddParameter("hash", hash, ParameterType.QueryString);

            return request;
        }

        private string GetHash(string timestamp)
        {
            var combined = timestamp + _privateKey + _publicKey;
            var bytes = Encoding.UTF8.GetBytes(combined);
            var hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(bytes);
            var converted = BitConverter.ToString(hash);

            return converted.Replace("-", String.Empty).ToLower();
        }

        private static string GetTimestamp()
        {
            var origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            var diff = DateTime.UtcNow - origin;

            return Math.Floor(diff.TotalSeconds).ToString(CultureInfo.InvariantCulture);
        }

        private static NameValueCollection UrlSegmentFor(string segmentName, object segmentValue)
        {
            return new NameValueCollection { { segmentName, segmentValue.ToString() } };
        }

        public Func<IRestClient> CreateRequestClient { get; set; }

        protected abstract string Resource { get; }
    }
}