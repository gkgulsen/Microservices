FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Frontends/MVC/FreeCourse.Web.csproj", "Frontends/MVC/"]
COPY ["Shared/Shared/Shared.csproj", "Shared/Shared/"]
RUN dotnet restore "Frontends/MVC/FreeCourse.Web.csproj"
COPY . .
WORKDIR "/src/Frontends/MVC"
RUN dotnet build "FreeCourse.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FreeCourse.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FreeCourse.Web.dll"]