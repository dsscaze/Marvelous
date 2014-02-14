using System.Collections.Specialized;
using NUnit.Framework;

namespace Marvelous.Tests
{
    [TestFixture]
    public class ComicsClientFixture
    {
        [Test]
        public void Comics_Gets_Find_Request()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };
            marvel.Characters.Comics(12345);
            marvel.Comics.Find(123);

            Assert.AreEqual("comics/{id}", client.Request.Resource);
            Assert.AreEqual("20", client.Request.Parameters[0].Value);
            Assert.AreEqual("0", client.Request.Parameters[1].Value);
            Assert.AreEqual("123", client.Request.Parameters[2].Value);
        }

        [Test]
        public async void Comics_Gets_Find_Request_Async()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            await marvel.Comics.FindAsync(123);

            Assert.AreEqual("comics/{id}", client.Request.Resource);
            Assert.AreEqual("20", client.Request.Parameters[0].Value);
            Assert.AreEqual("0", client.Request.Parameters[1].Value);
            Assert.AreEqual("123", client.Request.Parameters[2].Value);
        }

        [Test]
        public void Comics_Gets_Default_FindAll_Request()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            marvel.Comics.FindAll();

            Assert.AreEqual("comics", client.Request.Resource);
            Assert.AreEqual("20", client.Request.Parameters[0].Value);
            Assert.AreEqual("0", client.Request.Parameters[1].Value);
            Assert.AreEqual(5, client.Request.Parameters.Count);
        }

        [Test]
        public async void Comics_Gets_Default_FindAll_Request_Async()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            await marvel.Comics.FindAllAsync();

            Assert.AreEqual("comics", client.Request.Resource);
            Assert.AreEqual("20", client.Request.Parameters[0].Value);
            Assert.AreEqual("0", client.Request.Parameters[1].Value);
            Assert.AreEqual(5, client.Request.Parameters.Count);
        }

        [Test]
        public void Comics_Gets_Parametarized_FindAll_Request()
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
            marvel.Comics.FindAll(3, 4, parametrs);

            Assert.AreEqual("comics", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("3", client.Request.Parameters[2].Value);
            Assert.AreEqual("4", client.Request.Parameters[3].Value);
            Assert.AreEqual(7, client.Request.Parameters.Count);
        }

        [Test]
        public async void Comics_Gets_Parametarized_FindAll_Request_Async()
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

            await marvel.Comics.FindAllAsync(3, 4, parametrs);

            Assert.AreEqual("comics", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("3", client.Request.Parameters[2].Value);
            Assert.AreEqual("4", client.Request.Parameters[3].Value);
            Assert.AreEqual(7, client.Request.Parameters.Count);
        }

        [Test]
        public void Comics_Gets_Associated_Characters()
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

            marvel.Comics.Characters(123, 2, 3, parametrs);

            Assert.AreEqual("comics/{id}/characters", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public async void Comics_Gets_Associated_Characters_Async()
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

            await marvel.Comics.CharactersAsync(123, 2, 3, parametrs);

            Assert.AreEqual("comics/{id}/characters", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public void Comics_Gets_Associated_Creators()
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

            marvel.Comics.Creators(123, 2, 3, parametrs);

            Assert.AreEqual("comics/{id}/creators", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public async void Comics_Gets_Associated_Comics_Async()
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

            await marvel.Comics.EventsAsync(123, 2, 3, parametrs);

            Assert.AreEqual("comics/{id}/events", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public void Comics_Gets_Associated_Events()
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

            marvel.Comics.Events(123, 2, 3, parametrs);

            Assert.AreEqual("comics/{id}/events", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public async void Comics_Gets_Associated_Events_Async()
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

            await marvel.Comics.EventsAsync(123, 2, 3, parametrs);

            Assert.AreEqual("comics/{id}/events", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public void Comics_Gets_Associated_Stories()
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

            marvel.Comics.Stories(123, 2, 3, parametrs);

            Assert.AreEqual("comics/{id}/stories", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public async void Comics_Gets_Associated_Stories_Async()
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

            await marvel.Comics.StoriesAsync(123, 2, 3, parametrs);

            Assert.AreEqual("comics/{id}/stories", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }
    }  
}
