#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY NetKeites.Store.sln ./
COPY ["NetKeites.Store.API/", "NetKeites.Store.API/"]
COPY ["NetKeites.Store.Messages/NetKeites.Store.Messages.csproj", "NetKeites.Store.Messages/"]
RUN dotnet restore
COPY . .

WORKDIR "/src/NetKeites.Store.Messages"
RUN dotnet build -c Release -o /app/build

WORKDIR "/src/NetKeites.Store.API"
RUN dotnet build -c Release -o /app/build

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NetKeites.Store.API.dll"]