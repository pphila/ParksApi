# National and State Parks API

#### An ASP.NET Core REST API That Catalogs National and State Parks.
-------------------------
## Authored By:
Peter Philavanh

-------------------------
## Table of Contents
1. [Description](#description)
2. [Technologies Used](#technologies-used)
3. [Setup Instruction](#installation-and-setup)
4. [API Documentaion](#api-documentation)
5. [Known Bugs](#known-bugs)
6. [Licence Information](#license)

-------------------------
## About the Project

### Description
An API that functions as parks archive for those that love the natural and scenic United States. This API utilizes RESTful principles and version control. The user is able to see both available version of the API using Postman.

-------------------------
## Technologies Used
- _C#_
- _.NET 6_
- _ASP.NET Core_
- _MySQL_
- _Entity Framework Core_
- _REST API_

-------------------------
## Installation and Setup

### Install .Net Core
  
  #### Installation Steps
  1. To begin, the user must install a compatible version of .NET 6. An acceptable version can be found [here](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).
  2. Follow the prompts throught the installation of the program. Using default settings as they originally appear in the setup.
  
  #### File and Package Installation
  - Using your terminal, clone or download this project onto your local machine.
  - Open the project via your text editor or IDE.
  - `$ cd` into the production file 'NationalParkApi' and enter `$ dotnet restore` to install the necessary packages for this program.
  - Add in a .gitignore with `obj`, `bin`, `appsettings.json`, `appsettings.*.json` within.
  - Initialize project, add .gitignore, and commit your the changes.
  
  #### Setting Up the Database
   - _In the production file enter `$ touch appsettings.json` within your terminal_
   - _Enter the following code within the newly made .json file:_
   ```javascript
            {
              "Logging": {
                "LogLevel": {
                  "Default": "Information",
                  "Microsoft.AspNetCore": "Warning"
                }
              },
              "AllowedHosts": "*",
              "ConnectionStrings": {
                "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR_DATABASE_NAME];uid=[UID];pwd=[PASSWORD];"
              }
            }
  ```
  - _Enter `$ dotnet ef migrations add Initial` to create your first database migration with seeded data_
  - _Enter `$ dotnet ef database update` to push migration information to your MySql workbench_

-------------------------
### API Documentation
  
  #### Using Postman
  - _Run API application by entering `$ dotnet run` in your terminal._
  - _Open Postman_
  
  #### Endpoits
  Base URL: `http://localhost:5000` or `https://localhost:5001`

  #### HTTP Request Structure
  - _Available versions thus far: 1 and 2_
  
  ```
    GET /api/v{version}/parks
    POST /api/v{version}/parks
    PUT /api/v{version}/parks/{id}
    DELETE /api/v{version}/parks/{id}
  ```

  #### Example Query
  ```
  http://localhost:5000/api/v1/parks/1
  ```
  #### Response
  ```
  {
    "parkId": 1,
    "name": "Yellowstone",
    "state": "Wyoming",
    "type": "national",
    "description": "Expansive park with large networks of geothermal areas including boiling mud pots, vividly colored hot springs such as Grand Prismatic Spring, geysers, yellow hued grand canyon of the Yellowstone river, mountians, and bounties of wildlife.",
    "dateEst": "March 1, 1872"
  }
  ```
  #### Example Search Query With V2.0
  ```
  http://localhost:5000/api/v2/parks?state=california
  ```

  #### Search Response
  ```
  [
    {
        "parkId": 2,
        "name": "Sequoia",
        "state": "California",
        "type": "national",
        "description": "Home to the giant Sequoia forest, known for being the largest trees found in the world.",
        "dateEst": "September 25, 1890"
    },
    {
        "parkId": 3,
        "name": "Yosemite",
        "state": "California",
        "type": "national",
        "description": "Known for giant shear granit cliffs and exceptionally tall water falls, old growth forests, Noteable landmarks include: El Capitan, Half Dome, and the glacier carved Yosemite Valley",
        "dateEst": "October 1, 1890"
    }
  ]
```

-------------------------
## Known Bugs

_No known bugs at this time_
_Please email efl2ice89@gmail.com to report any bugs_

-------------------------
## Licence

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2023 Peter Philavanh. All Rights Reserved.