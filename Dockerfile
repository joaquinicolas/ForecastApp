FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ForecastApp.csproj .
RUN dotnet restore ForecastApp.csproj
COPY . .
RUN dotnet build ForecastApp.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish ForecastApp.csproj -c Release -o /app/publish
