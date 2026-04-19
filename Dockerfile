FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY . .

WORKDIR /src/ProjetoCiCd

RUN dotnet restore
RUN dotnet publish -c Release -o /app/out

FROM mcr.microsoft.com/dotnet/runtime:7.0
WORKDIR /app

COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "ProjetoCiCd.dll"]