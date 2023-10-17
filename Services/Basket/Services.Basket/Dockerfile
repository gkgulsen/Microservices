FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Services/Basket/Services.Basket/Services.Basket.csproj", "Services/Basket/Services.Basket/"]
COPY ["Shared/Shared/Shared.csproj", "Shared/Shared/"]
RUN dotnet restore "Services/Basket/Services.Basket/Services.Basket.csproj"
COPY . .
WORKDIR "/src/Services/Basket/Services.Basket"
RUN dotnet build "Services.Basket.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Services.Basket.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Services.Basket.dll"]