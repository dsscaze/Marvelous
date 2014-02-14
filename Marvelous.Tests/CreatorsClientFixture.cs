using System.Collections.Specialized;
using NUnit.Framework;

namespace Marvelous.Tests
{
    [TestFixture]
    public class CreatorsClientFixture
    {
        [Test]
        public void Creators_Gets_Find_Request()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            marvel.Creators.Find(123);

            Assert.AreEqual("creators/{id}", client.Request.Resource);
            Assert.AreEqual("20", client.Request.Parameters[0].Value);
            Assert.AreEqual("0", client.Request.Parameters[1].Value);
            Assert.AreEqual("123", client.Request.Parameters[2].Value);
        }

        [Test]
        public async void Creators_Gets_Find_Request_Async()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            await marvel.Creators.FindAsync(123);

            Assert.AreEqual("creators/{id}", client.Request.Resource);
            Assert.AreEqual("20", client.Request.Parameters[0].Value);
            Assert.AreEqual("0", client.Request.Parameters[1].Value);
            Assert.AreEqual("123", client.Request.Parameters[2].Value);
        }

        [Test]
        public void Creators_Gets_Default_FindAll_Request()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            marvel.Creators.FindAll();

            Assert.AreEqual("creators", client.Request.Resource);
            Assert.AreEqual("20", client.Request.Parameters[0].Value);
            Assert.AreEqual("0", client.Request.Parameters[1].Value);
            Assert.AreEqual(5, client.Request.Parameters.Count);
        }

        [Test]
        public async void Creators_Gets_Default_FindAll_Request_Async()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            await marvel.Creators.FindAllAsync();

            Assert.AreEqual("creators", client.Request.Resource);
            Assert.AreEqual("20", client.Request.Parameters[0].Value);
            Assert.AreEqual("0", client.Request.Parameters[1].Value);
            Assert.AreEqual(5, client.Request.Parameters.Count);
        }

        [Test]
        public void Creators_Gets_Parametarized_FindAll_Request()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            var parametrs = new NameValueCollection
            {
                {"name", "Thor"},
                {"orderBy", "modified"}
            };
            marvel.Creators.FindAll(3, 4, parametrs);

            Assert.AreEqual("creators", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("3", client.Request.Parameters[2].Value);
            Assert.AreEqual("4", client.Request.Parameters[3].Value);
            Assert.AreEqual(7, client.Request.Parameters.Count);
        }

        [Test]
        public async void Creators_Gets_Parametarized_FindAll_Request_Async()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            var parametrs = new NameValueCollection
            {
                {"name", "Thor"},
                {"orderBy", "modified"}
            };

            await marvel.Creators.FindAllAsync(3, 4, parametrs);

            Assert.AreEqual("creators", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("3", client.Request.Parameters[2].Value);
            Assert.AreEqual("4", client.Request.Parameters[3].Value);
            Assert.AreEqual(7, client.Request.Parameters.Count);
        }

        [Test]
        public void Creators_Gets_Associated_Comics()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            var parametrs = new NameValueCollection
            {
                {"name", "Thor"},
                {"orderBy", "modified"}
            };

            marvel.Creators.Comics(123, 2, 3, parametrs);

            Assert.AreEqual("creators/{id}/comics", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public async void Creators_Gets_Associated_Comics_Async()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            var parametrs = new NameValueCollection
            {
                {"name", "Thor"},
                {"orderBy", "modified"}
            };

            await marvel.Creators.ComicsAsync(123, 2, 3, parametrs);

            Assert.AreEqual("creators/{id}/comics", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public void Creators_Gets_Associated_Events()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            var parametrs = new NameValueCollection
            {
                {"name", "Thor"},
                {"orderBy", "modified"}
            };

            marvel.Creators.Events(123, 2, 3, parametrs);

            Assert.AreEqual("creators/{id}/events", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public async void Creators_Gets_Associated_Creators_Async()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            var parametrs = new NameValueCollection
            {
                {"name", "Thor"},
                {"orderBy", "modified"}
            };

            await marvel.Creators.EventsAsync(123, 2, 3, parametrs);

            Assert.AreEqual("creators/{id}/events", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public void Creators_Gets_Associated_Series()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            var parametrs = new NameValueCollection
            {
                {"name", "Thor"},
                {"orderBy", "modified"}
            };

            marvel.Creators.Series(123, 2, 3, parametrs);

            Assert.AreEqual("creators/{id}/series", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public async void Creators_Gets_Associated_Creators_Series_Async()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            var parametrs = new NameValueCollection
            {
                {"name", "Thor"},
                {"orderBy", "modified"}
            };

            await marvel.Creators.SeriesAsync(123, 2, 3, parametrs);

            Assert.AreEqual("creators/{id}/series", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public void Creators_Gets_Associated_Stories()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            var parametrs = new NameValueCollection
            {
                {"name", "Thor"},
                {"orderBy", "modified"}
            };

            marvel.Creators.Stories(123, 2, 3, parametrs);

            Assert.AreEqual("creators/{id}/stories", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public async void Creators_Gets_Associated_Stories_Async()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            var parametrs = new NameValueCollection
            {
                {"name", "Thor"},
                {"orderBy", "modified"}
            };

            await marvel.Creators.StoriesAsync(123, 2, 3, parametrs);

            Assert.AreEqual("creators/{id}/stories", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }
    }
}
