# NOTE:  The expected context for this Dockerfile is the MyFirstRepository/ directory.
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ./src .

ARG PROJ="MyFirstRepository.Web"

RUN dotnet publish "${PROJ}/${PROJ}.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "${PROJ}.dll"]
