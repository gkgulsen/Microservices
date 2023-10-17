FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Services/Catalog/Services.Catalog/Services.Catalog.csproj", "Services/Catalog/Services.Catalog/"]
COPY ["Shared/Shared/Shared.csproj", "Shared/Shared/"]
RUN dotnet restore "Services/Catalog/Services.Catalog/Services.Catalog.csproj"
COPY . .
WORKDIR "/src/Services/Catalog/Services.Catalog"
RUN dotnet build "Services.Catalog.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Services.Catalog.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Services.Catalog.dll"]
# FROM mcr.microsoft.com/dotnet/aspnet:7.0 as build
# WORKDIR /app
# EXPOSE 80
# COPY ["Services/Catalog/Services.Catalog/Services.Catalog.csproj", "Services/Catalog/Services.Catalog/"]
# COPY ["Shared/Shared/Shared.csproj", "Shared/Shared/"]
# RUN dotnet restore Services/Catalog/Services.Catalog/*.csproj
# COPY . .
# RUN dotnet publish Services/Catalog/Services.Catalog/*.csproj -c Release -o out
# FROM mcr.microsoft.com/dotnet/aspnet:7.0 as runtime
# WORKDIR /app
# COPY --from=build /app/out .
# ENTRYPOINT [ "dotnet","Services.Catalog.dll" ]