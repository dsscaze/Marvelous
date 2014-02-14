Marvelous
=========

Marvel Comics C# API client

For full details on getting started with the Marvel API, go check out the official website.
https://developer.marvel.com/

##Connecting
Connecting to [Marvel's API](https://developer.marvel.com/) is simple with Marvelous.  All available operations are accessed through the MarvelClient object.

```var client = new MarvelClient("your-public-key", "your-private-key);```

Use this client object to query all API resources.

##Find All
All resources can be queried by using thier FindAll methods.  For example. to query all characters you would use the client object as follows:

```var characters = client.Characters.FindAll();```

This returns a list of the first 20 characters as a dynamic object.

*All calls to the API return a dynamic object that represents the JSON returned from the API.*

By default, all API calls that return a list will return 20 results with no offset (paging).  All client methods have optional parameters you can specify to customize your results.  For example, to query 45 characters starting on page 3 you would use:

```var characters = client.Characters.FindAll(45, 3);```

Furthermore, all list methods have an option to add a NameValueCollection object.  You can use that object to filter results based on the [relevant filter criteria for each API method](http://developer.marvel.com/docs).

##Find
Unlinke most methods, the find method returns a single result instead of a list.  To find a single resource such as a character, you must specify the character's unique ID.  For example:

```var specificCharacter = client.Characters.Find(12345);```


##Related Resources
The Marvel API also supports finding related resources.  For example, you can find all the comics a given character has appered in:

```var comics = marvel.Characters.Comics(12345);```

The first parameter, id, is required.  The remaining parameters behave like the FindAll methods allowing you to filter your query.

##Async
All methods in the client library have an Async counterpart.  You can use standard async/await syntax to call these methods:

```var characters = await marvel.Characters.FindAllAsync();```

##Available Operations
Below are the client library methods for each REST resource.  Note - italics indicates optional parameters.

###All Resources
- .Find(id)
- .FindAsync(id)
- .FindAll(limit <default is 20>, offset <default is 0>, queryParameters <default is null>)
- .FindAllAsync(limit <default is 20>, offset <default is 0>, queryParameters <default is null>)


##Characters
- .Comics(id, *limit*, *offset*, *queryParameters*)
- .ComicsAsync(id, *limit*, *offset*, *queryParameters*)
- .Events(id, *limit*, *offset*, *queryParameters*)
- .EventsAsync(id, *limit*, *offset*, *queryParameters*)
- .Series(id, *limit*, *offset*, *queryParameters*)
- .SeriesAsync(id, *limit*, *offset*, *queryParameters*)
- .Stories(id, *limit*, *offset*, *queryParameters*)
- .StoriesAsync(id, *limit*, *offset*, *queryParameters*)


##Comics
- .Characters(id, *limit*, *offset*, *queryParameters*)
- .CharactersAsync(id, *limit*, *offset*, *queryParameters*)
- .Creators(id, *limit*, *offset*, *queryParameters*)
- .CreatorsAsync(id, *limit*, *offset*, *queryParameters*)
- .Events(id, *limit*, *offset*, *queryParameters*)
- .EventsAsync(id, *limit*, *offset*, *queryParameters*)
- .Stories(id, *limit*, *offset*, *queryParameters*)
- .StoriesAsync(id, *limit*, *offset*, *queryParameters*)

##Creators
- .Comics(id, *limit*, *offset*, *queryParameters*)
- .ComicsAsync(id, *limit*, *offset*, *queryParameters*)
- .Events(id, *limit*, *offset*, *queryParameters*)
- .EventsAsync(id, *limit*, *offset*, *queryParameters*)
- .Series(id, *limit*, *offset*, *queryParameters*)
- .SeriesAsync(id, *limit*, *offset*, *queryParameters*)
- .Stories(id, *limit*, *offset*, *queryParameters*)
- .StoriesAsync(id, *limit*, *offset*, *queryParameters*)

##Events
- .Characters(id, *limit*, *offset*, *queryParameters*)
- .CharactersAsync(id, *limit*, *offset*, *queryParameters*)
- .Comics(id, *limit*, *offset*, *queryParameters*)
- .ComicsAsync(id, *limit*, *offset*, *queryParameters*)
- .Creators(id, *limit*, *offset*, *queryParameters*)
- .CreatorsAsync(id, *limit*, *offset*, *queryParameters*)
- .Series(id, *limit*, *offset*, *queryParameters*)
- .SeriesAsync(id, *limit*, *offset*, *queryParameters*)
- .Stories(id, *limit*, *offset*, *queryParameters*)
- .StoriesAsync(id, *limit*, *offset*, *queryParameters*)

##Series
- .Characters(id, *limit*, *offset*, *queryParameters*)
- .CharactersAsync(id, *limit*, *offset*, *queryParameters*)
- .Comics(id, *limit*, *offset*, *queryParameters*)
- .ComicsAsync(id, *limit*, *offset*, *queryParameters*)
- .Creators(id, *limit*, *offset*, *queryParameters*)
- .CreatorsAsync(id, *limit*, *offset*, *queryParameters*)
- .Stories(id, *limit*, *offset*, *queryParameters*)
- .StoriesAsync(id, *limit*, *offset*, *queryParameters*)

##Stories
- .Characters(id, *limit*, *offset*, *queryParameters*)
- .CharactersAsync(id, *limit*, *offset*, *queryParameters*)
- .Comics(id, *limit*, *offset*, *queryParameters*)
- .ComicsAsync(id, *limit*, *offset*, *queryParameters*)
- .Creators(id, *limit*, *offset*, *queryParameters*)
- .CreatorsAsync(id, *limit*, *offset*, *queryParameters*)
- .Events(id, *limit*, *offset*, *queryParameters*)
- .EventsAsync(id, *limit*, *offset*, *queryParameters*)
