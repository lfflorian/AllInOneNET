# All in one API
This its a Web Rest API created in ASP.NET core 5.0 All in one. 

The objective of this project its to search a person by a unique Id, by POST method, using Entity Framework, but implementing all features that its commonly necessary in the building of Web Api's on NET Core

## Packages
List of all package installed from NuGet
-   Entity Framework Core: ORM for work with Database
-   Entity Framework Core InMemory : used for create Mock data on EF
-   Auto Mapper : entity mapper to apply data transfer object
-   Asp Net Core Versioning : created for version control of the web API 

## Project organization
The solution was divided in different class projects with the purpose of having a better organization, implementing the separation of interests and for its scalability and maintenance.

-   Entities: were its defined the entities from database
-   Database: were it's the logic for connecting to database (inMemory)
-   Service: the Data Access Layer were its the logic of getting the data from database and register into IoC container or Net Core
-   Web Api: the main project
--  Controllers : definition of the controllers
--  middleware : utilities classes using as middleware 
--  Mock : definition and implementation of Mock Data for Database
--  Model : definition of models and entities used inside web api project

## Features
Description of different features implemented on project
-   InMemory : static class and package installed for created a Mock data for testing database
-   Dto : Data Transfer object, used for separate entities that communicate with the database between client endpoint
-   Handling Error Globally : static class used for handling error globally, with this, we can have a clean controllers without try catch
-   Action Filter : used for validate the user request schema
-   Asynchronous : used asynchronous code for avoid performance bottlenecks and improve the responsiveness of our application
-   IoC : registration of services and tools for access by constructor injection

## How To Test
for test the web api, you just make a POST request to the next url:
-   https://localhost:5001/api/v1.0/Person
or if you using IIExpress
-   https://localhost:44368/api/v1.0/Person

and just need to send a JSON with a unique id on integer for get the person data like this:

```
{
    "UniqueId" : 1
}
```

and the web api response like this:
```
{
    "name": "Name",
    "age": 1
}
```