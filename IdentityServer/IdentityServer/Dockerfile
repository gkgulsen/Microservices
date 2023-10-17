# FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
# WORKDIR /app
# EXPOSE 80

# FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
# WORKDIR /src
# COPY ["IdentityServer/IdentityServer/IdentityServer.csproj", "IdentityServer/IdentityServer/"]
# COPY ["Shared/Shared/Shared.csproj", "Shared/Shared/"]
# RUN dotnet restore "IdentityServer/IdentityServer/IdentityServer.csproj"
# COPY . .
# WORKDIR "/src/IdentityServer/IdentityServer"
# RUN dotnet build "IdentityServer.csproj" -c Release -o /app/build

# FROM build AS publish
# RUN dotnet publish "IdentityServer.csproj" -c Release -o /app/publish /p:UseAppHost=false

# FROM base AS final
# WORKDIR /app
# COPY --from=publish /app/publish .
# ENTRYPOINT ["dotnet", "IdentityServer.dll"]
FROM mcr.microsoft.com/dotnet/sdk:3.1 as build
WORKDIR /app
EXPOSE 80
COPY ["IdentityServer/IdentityServer/IdentityServer.csproj", "IdentityServer/IdentityServer/"] 
COPY ["Shared/Shared/Shared.csproj", "Shared/Shared/"]
RUN dotnet restore  IdentityServer/IdentityServer/*.csproj
COPY . .
RUN dotnet publish IdentityServer/IdentityServer/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:3.1 as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","IdentityServer.dll" ]