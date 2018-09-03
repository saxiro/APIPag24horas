FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY APIPag24horas/APIPag24horas.csproj APIPag24horas/
RUN dotnet restore APIPag24horas/APIPag24horas.csproj
COPY . .
WORKDIR /src/APIPag24horas
RUN dotnet build APIPag24horas.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish APIPag24horas.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "APIPag24horas.dll"]