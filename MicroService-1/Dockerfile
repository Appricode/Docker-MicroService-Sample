FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5001
EXPOSE 5003

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["*", "MicroService-1/"]
RUN dotnet restore "MicroService-1/MicroService-1.csproj"
COPY . .
WORKDIR "/src/MicroService-1"
RUN dotnet build "MicroService-1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroService-1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroService-1.dll"]
