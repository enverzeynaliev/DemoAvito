FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/DemoAvito/Hosts/DemoAvito.Api/DemoAvito.Api.csproj", "src/DemoAvito/Hosts/DemoAvito.Api/"]
RUN dotnet restore "src/DemoAvito/Hosts/DemoAvito.Api/DemoAvito.Api.csproj"
COPY . .
WORKDIR "/src/src/DemoAvito/Hosts/DemoAvito.Api"
RUN dotnet build "DemoAvito.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DemoAvito.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DemoAvito.Api.dll"]
