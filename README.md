# Foodworld

This is restaurant management app, developed using .NET 5, entity framework and SQL server.

## Docker

todo

## Requirements

1. [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
1. dotnet tool install --global dotnet-ef



## Getting Started

1. Clone this repository

    ```bash
    git clone https://github.com/abhishekgoenka/foodworld.git
    cd foodworld
    ```

1. Open `FoodWorld.sln` and build

    
1. Configure DB server settings

    - Change database connection string from `appsettings.json` file

1. Goto `foodworld\FoodWorld.Data` folder and run migrations. 

    ```bash
    dotnet-ef database update -s ..\FoodWorld.Web\FoodWorld.Web.csproj
    ``` 
## Running the app

1. Build the  app from visual studio

1. Open the browser to https://localhost:44393/

## Problems or Suggestions

[Open an issue here](https://github.com/abhishekgoenka/foodworld/issues)
