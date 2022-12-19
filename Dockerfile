FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Forum.API/Forum.API.csproj", "Forum.API/"]
COPY ["Forum.Application/Forum.Application/Forum.Application.csproj", "Forum.Application/"]
COPY ["Forum.Domain/Forum.Domain.csproj", "Forum.Domain/"]
COPY ["Forum.Infrastructure/Forum.Infrastructure.csproj", "Forum.Infrastructure/"]

RUN dotnet restore "Forum.API/Forum.API.csproj"
COPY . .
WORKDIR "/src/Forum.API"
RUN dotnet build "Forum.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Forum.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Forum.API.dll"]