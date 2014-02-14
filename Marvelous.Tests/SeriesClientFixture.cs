using System.Collections.Specialized;
using NUnit.Framework;

namespace Marvelous.Tests
{
    [TestFixture]
    public class StoriesClientFixture
    {
        [Test]
        public void Stories_Gets_Find_Request()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            marvel.Series.Find(123);

            Assert.AreEqual("series/{id}", client.Request.Resource);
            Assert.AreEqual("20", client.Request.Parameters[0].Value);
            Assert.AreEqual("0", client.Request.Parameters[1].Value);
            Assert.AreEqual("123", client.Request.Parameters[2].Value);
        }

        [Test]
        public async void Stories_Gets_Find_Request_Async()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            await marvel.Series.FindAsync(123);

            Assert.AreEqual("series/{id}", client.Request.Resource);
            Assert.AreEqual("20", client.Request.Parameters[0].Value);
            Assert.AreEqual("0", client.Request.Parameters[1].Value);
            Assert.AreEqual("123", client.Request.Parameters[2].Value);
        }

        [Test]
        public void Stories_Gets_Default_FindAll_Request()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            marvel.Series.FindAll();

            Assert.AreEqual("series", client.Request.Resource);
            Assert.AreEqual("20", client.Request.Parameters[0].Value);
            Assert.AreEqual("0", client.Request.Parameters[1].Value);
            Assert.AreEqual(5, client.Request.Parameters.Count);
        }

        [Test]
        public async void Stories_Gets_Default_FindAll_Request_Async()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            await marvel.Series.FindAllAsync();

            Assert.AreEqual("series", client.Request.Resource);
            Assert.AreEqual("20", client.Request.Parameters[0].Value);
            Assert.AreEqual("0", client.Request.Parameters[1].Value);
            Assert.AreEqual(5, client.Request.Parameters.Count);
        }

        [Test]
        public void Stories_Gets_Parametarized_FindAll_Request()
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
            marvel.Series.FindAll(3, 4, parametrs);

            Assert.AreEqual("series", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("3", client.Request.Parameters[2].Value);
            Assert.AreEqual("4", client.Request.Parameters[3].Value);
            Assert.AreEqual(7, client.Request.Parameters.Count);
        }

        [Test]
        public async void Stories_Gets_Parametarized_FindAll_Request_Async()
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

            await marvel.Series.FindAllAsync(3, 4, parametrs);

            Assert.AreEqual("series", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("3", client.Request.Parameters[2].Value);
            Assert.AreEqual("4", client.Request.Parameters[3].Value);
            Assert.AreEqual(7, client.Request.Parameters.Count);
        }

        [Test]
        public void Stories_Gets_Associated_Characters()
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

            marvel.Series.Characters(123, 2, 3, parametrs);

            Assert.AreEqual("series/{id}/characters", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public async void Stories_Gets_Associated_Characters_Async()
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

            await marvel.Series.CharactersAsync(123, 2, 3, parametrs);

            Assert.AreEqual("series/{id}/characters", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public void Stories_Gets_Associated_Comics()
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

            marvel.Series.Comics(123, 2, 3, parametrs);

            Assert.AreEqual("series/{id}/comics", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public async void Stories_Gets_Associated_Comics_Async()
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

            await marvel.Series.ComicsAsync(123, 2, 3, parametrs);

            Assert.AreEqual("series/{id}/comics", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public void Stories_Gets_Associated_Creators()
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

            marvel.Series.Creators(123, 2, 3, parametrs);

            Assert.AreEqual("series/{id}/creators", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public async void Stories_Gets_Associated_Creators_Async()
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

            await marvel.Series.CreatorsAsync(123, 2, 3, parametrs);

            Assert.AreEqual("series/{id}/creators", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public void Stories_Gets_Associated_Events()
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

            marvel.Series.Events(123, 2, 3, parametrs);

            Assert.AreEqual("series/{id}/events", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public async void Stories_Gets_Associated_Stories_Events_Async()
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

            await marvel.Series.EventsAsync(123, 2, 3, parametrs);

            Assert.AreEqual("series/{id}/events", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }
    }
}
