## Trains API

By Aaron Minnick, Jacob Wilson, Christina Welch, and Hannah Young

This app is designed to model a train transportation system. There are stations that are connected via tracks and the ability to find routes along those stations and tracks. 

### Technologies Used

- C#
- .NET
- MySQL
- Entity Framework
- Swagger/OpenAPI

### Description

This is a web API that showcases our ability to develop an ASP.NET Core API with a robust backend attached to a MySQL database through Entity Framework. Routefinding is performed through graph algorithms, including depth first search.

---------

### Setup

#### Requirements

* [git](https://git-scm.com)
* [.NET](https://dotnet.microsoft.com/en-us/)
* [MySQL](https://www.mysql.com/)

#### To Start Web API

1. Download and install the [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) as required for your system. Be sure to add the .NET sdk to your PATH
2. Use terminal to navigate to desired parent directory and use `git clone https://github.com/Corgibyte/trains.git Trains.Solution`
3. Navigate into the project directory nested inside the .Solution directory: `cd Trains.Solution/Trains`
4. Create an appsettings.json file: `touch appsettings.json`
5. Edit the new appsettings.json file and add the following, making sure to replace the indicated sections with your MySQL user ID and password:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=trains_api;uid=[YOUR MYSQL USER ID];pwd=[YOUR MYSQL PASSWORD];"
  }
}
```
6. Back in the terminal, in the Trains directory build the project: `dotnet restore`
7. Create database from migration data: `dotnet ef database update`
8. Run project: `dotnet run`

### Accessing the Web API

API endpoints can be accessed using a client such as [Postman](https://www.postman.com/) or programatically using your own client. Endpoint testing can also be performed on the Swagger documentation accessed at `http://localhost:5000/swagger`

--------------------

## Endpoints

|Usage | METHOD       | URL       | Params |
| :--------| :------------| :---------| :------|
|Get all routes from origin to destination | GET    | `http://localhost:5000/api/Routes/AllRoutesBetween` | origin :int, destination :int, sortMethod<sup>†</sup>: `time` or `fare` |
|Get fastest route to all destinations from origin | GET    | `http://localhost:5000/api/Routes/AllDestinationsFrom` | origin :int |
|Get all Stations | GET    | `http://localhost:5000/api/stations` | |
|Get specific Station | GET    | `http://localhost:5000/stations/{id}` | |
|Create Station | POST    | `http://localhost:5000/stations/` | Station :schema<sup>*</sup> |
|Edit Station | PUT    | `http://localhost:5000/stations/{id}` | Station :schema<sup>*</sup> |
|Delete Station | DELETE    | `http://localhost:5000/stations/{id}` | |
|Get all Tracks | GET    | `http://localhost:5000/api/tracks` | origin<sup>†</sup> :int, destination<sup>†</sup> :int |
|Get specific Track | GET    | `http://localhost:5000/tracks/{id}` | |
|Create Track | POST    | `http://localhost:5000/tracks/` | Track :schema<sup>*</sup> |
|Edit Track | PUT    | `http://localhost:5000/tracks/{id}` | Track :schema<sup>*</sup> |
|Delete Track | DELETE    | `http://localhost:5000/tracks/{id}` | |


<sup>__*__</sup>See below for example schemas for Stations and Tracks
<sup>__†__</sup>Optional filtering parameter

### Schemas

*Station:*
```
"Station": {
        "required": [
          "name"
        ],
        "type": "object",
        "properties": {
          "stationId": {
            "type": "integer",
            "format": "int32"
          },
          "name": {
            "maxLength": 20,
            "minLength": 0,
            "type": "string"
          }
        },
        "additionalProperties": false
      }
```
*Track:*
```
"Track": {
        "type": "object",
        "properties": {
          "trackId": {
            "type": "integer",
            "format": "int32"
          },
          "originId": {
            "type": "integer",
            "format": "int32"
          },
          "destinationId": {
            "type": "integer",
            "format": "int32"
          },
          "origin": {
            "$ref": "#/components/schemas/Station"
          },
          "destination": {
            "$ref": "#/components/schemas/Station"
          },
          "travelTime": {
            "type": "integer",
            "format": "int32"
          },
          "fare": {
            "type": "number",
            "format": "double"
          }
        },
        "additionalProperties": false
      }
```
### Known bugs:

* None

### License

[Hippocratic License 3.0](https://github.com/Corgibyte/trains/blob/main/LICENSE.md), Copyright 2022 Aaron Minnick, Jacob Wilson, Christina Welch, and Hannah Young.
