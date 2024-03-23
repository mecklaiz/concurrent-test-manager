FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["manager-service.csproj", "./"]
RUN dotnet restore "manager-service.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "manager-service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "manager-service.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "manager-service.dll"]
