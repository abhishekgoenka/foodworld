# build stage
FROM mcr.microsoft.com/dotnet/sdk:5.0 as build
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.sln .
COPY FoodWorld.Core/*.csproj ./FoodWorld.Core/
COPY FoodWorld.Data/*.csproj ./FoodWorld.Data/
COPY FoodWorld.Web/*.csproj ./FoodWorld.Web/
RUN dotnet restore

# Copy everything else and build website
COPY FoodWorld.Core/. ./FoodWorld.Core/
COPY FoodWorld.Data/. ./FoodWorld.Data/
COPY FoodWorld.Web/. ./FoodWorld.Web/
WORKDIR /app/FoodWorld.Web
RUN dotnet publish -c release -o /app/Website --no-restore

# Final stage / image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app/Website
COPY --from=build /app/Website ./
ENTRYPOINT ["dotnet", "FoodWorld.Web.dll"]