FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5002
EXPOSE 5004

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["*", "MicroService-2/"]
RUN dotnet restore "MicroService-2/MicroService-2.csproj"
COPY . .
WORKDIR "/src/MicroService-2"
RUN dotnet build "MicroService-2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroService-2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroService-2.dll"]
