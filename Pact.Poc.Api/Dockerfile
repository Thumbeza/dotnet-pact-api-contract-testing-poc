FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Pact.Poc.Api/Pact.Poc.Api.csproj", "Pact.Poc.Api/"]
RUN dotnet restore "Pact.Poc.Api/Pact.Poc.Api.csproj"
COPY . .
WORKDIR "/src/Pact.Poc.Api"
RUN dotnet build "Pact.Poc.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Pact.Poc.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Pact.Poc.Api.dll"]
