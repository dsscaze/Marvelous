﻿using System.Collections.Specialized;
using System.Threading.Tasks;

namespace Marvelous
{
    public class CreatorsClient : ClientBase
    {
        internal CreatorsClient(string publicKey, string privateKey) : base(publicKey, privateKey)
        { }
       
        #region Sync
        public dynamic Comics(int id, int limit = 20, int offset = 0, NameValueCollection queryParameters = null)
        {
            return QueryIdSubPath(id, ComicsResource, limit, offset, queryParameters);
        }
        
        public dynamic Events(int id, int limit = 20, int offset = 0, NameValueCollection queryParameters = null)
        {
            return QueryIdSubPath(id, EventsResource, limit, offset, queryParameters);
        }

        public dynamic Series(int id, int limit = 20, int offset = 0, NameValueCollection queryParameters = null)
        {
            return QueryIdSubPath(id, SeriesResource, limit, offset, queryParameters);
        }

        public dynamic Stories(int id, int limit = 20, int offset = 0, NameValueCollection queryParameters = null)
        {
            return QueryIdSubPath(id, StoriesResource, limit, offset, queryParameters);
        }
        #endregion

        #region Async
        public async Task<dynamic> ComicsAsync(int id, int limit = 20, int offset = 0, NameValueCollection queryParameters = null)
        {
            return await QueryIdSubPathAsync(id, ComicsResource, limit, offset, queryParameters);
        }

        public async Task<dynamic> EventsAsync(int id, int limit = 20, int offset = 0, NameValueCollection queryParameters = null)
        {
            return await QueryIdSubPathAsync(id, EventsResource, limit, offset, queryParameters);
        }

        public async Task<dynamic> SeriesAsync(int id, int limit = 20, int offset = 0, NameValueCollection queryParameters = null)
        {
            return await QueryIdSubPathAsync(id, SeriesResource, limit, offset, queryParameters);
        }

        public async Task<dynamic> StoriesAsync(int id, int limit = 20, int offset = 0, NameValueCollection queryParameters = null)
        {
            return await QueryIdSubPathAsync(id, StoriesResource, limit, offset, queryParameters);
        }
        #endregion

        protected override string Resource
        {
            get { return "creators"; }
        }
    }
}