FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["weebbot.csproj", "./"]
RUN dotnet restore "weebbot.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "weebbot.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "weebbot.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "weebbot.dll"]
