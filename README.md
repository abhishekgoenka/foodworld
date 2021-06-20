# Foodworld
[![ci-build](https://github.com/abhishekgoenka/foodworld/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/abhishekgoenka/foodworld/actions/workflows/dotnet.yml)

This is restaurant management app, developed using .NET 5, entity framework and SQL server.

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

1. Open the browser to https://localhost:5001/

## Health Check
https://localhost:5001/hc

## Dockerize the App 


### To start the containers
> docker-compose up

### To stop the containers
> docker-compose down

### Install docker compose if not already installed
> sudo apt  install docker-compose

### Pull and Run image from registry
> docker run -p 80:80 abhishek1950/react-hello-world

## Problems or Suggestions

[Open an issue here](https://github.com/abhishekgoenka/foodworld/issues)
