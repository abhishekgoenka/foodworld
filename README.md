# Foodworld

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

    Change database connection string from `appsettings.json` file


## Running the app

1. Build the  app from visual studio

1. Open the browser to http://localhost:3000

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

[Open an issue here](https://github.com/abhishekgoenka/angular-cosmos/issues)
