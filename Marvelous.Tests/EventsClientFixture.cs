using System.Collections.Specialized;
using NUnit.Framework;

namespace Marvelous.Tests
{
    [TestFixture]
    public class EventsClientFixture
    {
        [Test]
        public void Events_Gets_Find_Request()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            marvel.Events.Find(123);

            Assert.AreEqual("events/{id}", client.Request.Resource);
            Assert.AreEqual("20", client.Request.Parameters[0].Value);
            Assert.AreEqual("0", client.Request.Parameters[1].Value);
            Assert.AreEqual("123", client.Request.Parameters[2].Value);
        }

        [Test]
        public async void Events_Gets_Find_Request_Async()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            await marvel.Events.FindAsync(123);

            Assert.AreEqual("events/{id}", client.Request.Resource);
            Assert.AreEqual("20", client.Request.Parameters[0].Value);
            Assert.AreEqual("0", client.Request.Parameters[1].Value);
            Assert.AreEqual("123", client.Request.Parameters[2].Value);
        }

        [Test]
        public void Events_Gets_Default_FindAll_Request()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            marvel.Events.FindAll();

            Assert.AreEqual("events", client.Request.Resource);
            Assert.AreEqual("20", client.Request.Parameters[0].Value);
            Assert.AreEqual("0", client.Request.Parameters[1].Value);
            Assert.AreEqual(5, client.Request.Parameters.Count);
        }

        [Test]
        public async void Events_Gets_Default_FindAll_Request_Async()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            await marvel.Events.FindAllAsync();

            Assert.AreEqual("events", client.Request.Resource);
            Assert.AreEqual("20", client.Request.Parameters[0].Value);
            Assert.AreEqual("0", client.Request.Parameters[1].Value);
            Assert.AreEqual(5, client.Request.Parameters.Count);
        }

        [Test]
        public void Events_Gets_Parametarized_FindAll_Request()
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
            marvel.Events.FindAll(3, 4, parametrs);

            Assert.AreEqual("events", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("3", client.Request.Parameters[2].Value);
            Assert.AreEqual("4", client.Request.Parameters[3].Value);
            Assert.AreEqual(7, client.Request.Parameters.Count);
        }

        [Test]
        public async void Events_Gets_Parametarized_FindAll_Request_Async()
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

            await marvel.Events.FindAllAsync(3, 4, parametrs);

            Assert.AreEqual("events", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("3", client.Request.Parameters[2].Value);
            Assert.AreEqual("4", client.Request.Parameters[3].Value);
            Assert.AreEqual(7, client.Request.Parameters.Count);
        }

        [Test]
        public void Events_Gets_Associated_Characters()
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

            marvel.Events.Characters(123, 2, 3, parametrs);

            Assert.AreEqual("events/{id}/characters", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public async void Events_Gets_Associated_Characters_Async()
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

            await marvel.Events.CharactersAsync(123, 2, 3, parametrs);

            Assert.AreEqual("events/{id}/characters", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public void Events_Gets_Associated_Comics()
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

            marvel.Events.Comics(123, 2, 3, parametrs);

            Assert.AreEqual("events/{id}/comics", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public async void Events_Gets_Associated_Comics_Async()
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

            await marvel.Events.ComicsAsync(123, 2, 3, parametrs);

            Assert.AreEqual("events/{id}/comics", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public void Events_Gets_Associated_Creators()
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

            marvel.Events.Creators(123, 2, 3, parametrs);

            Assert.AreEqual("events/{id}/creators", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public async void Events_Gets_Associated_Creators_Async()
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

            await marvel.Events.CreatorsAsync(123, 2, 3, parametrs);

            Assert.AreEqual("events/{id}/creators", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public void Events_Gets_Associated_Series()
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

            marvel.Events.Series(123, 2, 3, parametrs);

            Assert.AreEqual("events/{id}/series", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public async void Events_Gets_Associated_Events_Series_Async()
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

            await marvel.Events.SeriesAsync(123, 2, 3, parametrs);

            Assert.AreEqual("events/{id}/series", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public void Events_Gets_Associated_Stories()
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

            marvel.Events.Stories(123, 2, 3, parametrs);

            Assert.AreEqual("events/{id}/stories", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public async void Events_Gets_Associated_Stories_Async()
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

            await marvel.Events.StoriesAsync(123, 2, 3, parametrs);

            Assert.AreEqual("events/{id}/stories", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }
    }
}
