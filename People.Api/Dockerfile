FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["People.Api/People.Api.csproj", "People.Api/"]
RUN dotnet restore "People.Api/People.Api.csproj"
COPY . .
WORKDIR "/src/People.Api"
RUN dotnet build "People.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "People.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "People.Api.dll"]
