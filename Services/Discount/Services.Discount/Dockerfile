FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Services/Discount/Services.Discount/Services.Discount.csproj", "Services/Discount/Services.Discount/"]
COPY ["Shared/Shared/Shared.csproj", "Shared/Shared/"]
RUN dotnet restore "Services/Discount/Services.Discount/Services.Discount.csproj"
COPY . .
WORKDIR "/src/Services/Discount/Services.Discount"
RUN dotnet build "Services.Discount.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Services.Discount.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Services.Discount.dll"]