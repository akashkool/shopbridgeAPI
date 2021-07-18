CONTENTS OF THIS FILE
---------------------

 * Introduction
 * Requirements
 * Installation

INTRODUCTION
------------

ShopBridge API is a REST API to handle CRUD operations of and article.

REQUIREMENTS
------------

Below mentioned tools are required:

 * .NET Core 5.0
 * (PostgreSQL) 13.3

INSTALLATION
------------
 
 * Run db/Initialise_db.sql into postgres SQL database.

 * Change value of environment variables in Properties/launchSettings.json to update database string.

 * Build the code using dotnet build.

 * Run the code using dotnet run.

 * REST API will be accessbible on PORT metnioned in launchSettings.json.

 * Read RouteInformation.md for route documentation.


