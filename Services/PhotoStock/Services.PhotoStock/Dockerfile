FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Services/PhotoStock/Services.PhotoStock/Services.PhotoStock.csproj", "Services/PhotoStock/Services.PhotoStock/"]
COPY ["Shared/Shared/Shared.csproj", "Shared/Shared/"]
RUN dotnet restore "Services/PhotoStock/Services.PhotoStock/Services.PhotoStock.csproj"
COPY . .
WORKDIR "/src/Services/PhotoStock/Services.PhotoStock"
RUN dotnet build "Services.PhotoStock.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Services.PhotoStock.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Services.PhotoStock.dll"]