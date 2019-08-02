# People Search Application
This repository holds a simple application built to search for people. This application was built using Visual Studio 2019, Asp.net Core Web Api, and Angular.

## Installation
Once you have cloned this repository and installed the dependencies below, the next step is to install and setup the .Net Core backend then the Angular Frontend.
* .Net Core Rest Api
	* MS Sql Server Database
		* Open a cmd window in the PeopleSearchApp\PeopleSearchApi directory
		* Execute 'dotnet ef database update'
	* Web Api 
		* Open Visual Studio 2019
		* Make sure PeopleSearchApi is set as your startup project (right click on the project and chose "Set as Startup Project")
		* Type ctrl-f5 to start the api

* Angular Frontend
	* Open a cmd window in the PeopleSearchApp\PeopleSearchClient directory
	* Execute 'npm install'
	* Execute 'ng serve'
	* open your browser to http://localhost:4200

### Dependencies
* Visual Studio 2019 community edition installed with the web application workflow
* [.NET Core 2.2.401 SDK](https://dotnet.microsoft.com/download/dotnet-core/2.2)
* [Node version 10.16.0 LTS](https://nodejs.org/en/)
* [NPM Task Runner Extension](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.NPMTaskRunner) (Optional, but recommended)
