using System.Collections.Specialized;
using NUnit.Framework;

namespace Marvelous.Tests
{
    [TestFixture]
    public class CharactersClientFixture
    {
        [Test]
        public void Character_Gets_Find_Request()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            marvel.Characters.Find(123);

            Assert.AreEqual("characters/{id}", client.Request.Resource);
            Assert.AreEqual("20", client.Request.Parameters[0].Value);
            Assert.AreEqual("0", client.Request.Parameters[1].Value);
            Assert.AreEqual("123", client.Request.Parameters[2].Value);
        }

        [Test]
        public async void Character_Gets_Find_Request_Async()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            await marvel.Characters.FindAsync(123);

            Assert.AreEqual("characters/{id}", client.Request.Resource);
            Assert.AreEqual("20", client.Request.Parameters[0].Value);
            Assert.AreEqual("0", client.Request.Parameters[1].Value);
            Assert.AreEqual("123", client.Request.Parameters[2].Value);
        }

        [Test]
        public void Character_Gets_Default_FindAll_Request()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            marvel.Characters.FindAll();

            Assert.AreEqual("characters", client.Request.Resource);
            Assert.AreEqual("20", client.Request.Parameters[0].Value);
            Assert.AreEqual("0", client.Request.Parameters[1].Value);
            Assert.AreEqual(5, client.Request.Parameters.Count);
        }

        [Test]
        public async void Character_Gets_Default_FindAll_Request_Async()
        {
            var client = new FakeRquestClient();

            var marvel = new MarvelClient("public", "private")
            {
                CreateRequestClient = () => client
            };

            await marvel.Characters.FindAllAsync();

            Assert.AreEqual("characters", client.Request.Resource);
            Assert.AreEqual("20", client.Request.Parameters[0].Value);
            Assert.AreEqual("0", client.Request.Parameters[1].Value);
            Assert.AreEqual(5, client.Request.Parameters.Count);
        }

        [Test]
        public void Character_Gets_Parametarized_FindAll_Request()
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
            marvel.Characters.FindAll(3, 4, parametrs);

            Assert.AreEqual("characters", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("3", client.Request.Parameters[2].Value);
            Assert.AreEqual("4", client.Request.Parameters[3].Value);
            Assert.AreEqual(7, client.Request.Parameters.Count);
        }

        [Test]
        public async void Character_Gets_Parametarized_FindAll_Request_Async()
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

            await marvel.Characters.FindAllAsync(3, 4, parametrs);

            Assert.AreEqual("characters", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("3", client.Request.Parameters[2].Value);
            Assert.AreEqual("4", client.Request.Parameters[3].Value);
            Assert.AreEqual(7, client.Request.Parameters.Count);
        }

        [Test]
        public void Characters_Gets_Associated_Comics()
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

            marvel.Characters.Comics(123, 2, 3, parametrs);

            Assert.AreEqual("characters/{id}/comics", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public async void Characters_Gets_Associated_Comics_Async()
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

            await marvel.Characters.ComicsAsync(123, 2, 3, parametrs);

            Assert.AreEqual("characters/{id}/comics", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public void Characters_Gets_Associated_Events()
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

            marvel.Characters.Events(123, 2, 3, parametrs);

            Assert.AreEqual("characters/{id}/events", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public async void Characters_Gets_Associated_Characters_Async()
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

            await marvel.Characters.EventsAsync(123, 2, 3, parametrs);

            Assert.AreEqual("characters/{id}/events", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public void Characters_Gets_Associated_Series()
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

            marvel.Characters.Series(123, 2, 3, parametrs);

            Assert.AreEqual("characters/{id}/series", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public async void Characters_Gets_Associated_Series_Async()
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

            await marvel.Characters.SeriesAsync(123, 2, 3, parametrs);

            Assert.AreEqual("characters/{id}/series", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public void Characters_Gets_Associated_Stories()
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

            marvel.Characters.Stories(123, 2, 3, parametrs);

            Assert.AreEqual("characters/{id}/stories", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }

        [Test]
        public async void Characters_Gets_Associated_Stories_Async()
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

            await marvel.Characters.StoriesAsync(123, 2, 3, parametrs);

            Assert.AreEqual("characters/{id}/stories", client.Request.Resource);
            Assert.AreEqual("Thor", client.Request.Parameters[0].Value);
            Assert.AreEqual("modified", client.Request.Parameters[1].Value);
            Assert.AreEqual("2", client.Request.Parameters[2].Value);
            Assert.AreEqual("3", client.Request.Parameters[3].Value);
            Assert.AreEqual(8, client.Request.Parameters.Count);
        }
    }
}
