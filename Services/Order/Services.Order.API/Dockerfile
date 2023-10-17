FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

COPY ["Services/Order/Services.Order.Application/Services.Order.Application.csproj", "Services/Order/Services.Order.Application/"]
COPY ["Services/Order/Services.Order.Domain/Services.Order.Domain.csproj", "Services/Order/Services.Order.Domain/"]
COPY ["Services/Order/Services.Order.Domain.Core/Services.Order.Domain.Core.csproj", "Services/Order/Services.Order.Domain.Core/"]
COPY ["Services/Order/Services.Order.Infrastructure/Services.Order.Infrastructure.csproj", "Services/Order/Services.Order.Infrastructure/"]
COPY ["Shared/Shared/Shared.csproj", "Shared/Shared/"]

COPY ["Services/Order/Services.Order.API/Services.Order.API.csproj", "Services/Order/Services.Order.API/"]
RUN dotnet restore "Services/Order/Services.Order.API/Services.Order.API.csproj"
COPY . .
WORKDIR "/src/Services/Order/Services.Order.API"
RUN dotnet build "Services.Order.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Services.Order.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Services.Order.API.dll"]