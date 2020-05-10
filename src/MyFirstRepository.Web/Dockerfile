#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/MyFirstRepository.Web/MyFirstRepository.Web.csproj", "src/MyFirstRepository.Web/"]
COPY ["src/MyFirstRepository.Infrastructure/MyFirstRepository.Infrastructure.csproj", "src/MyFirstRepository.Infrastructure/"]
COPY ["src/MyFirstRepository.Core/MyFirstRepository.Core.csproj", "src/MyFirstRepository.Core/"]
RUN dotnet restore "src/MyFirstRepository.Web/MyFirstRepository.Web.csproj"
COPY . .
WORKDIR "/src/src/MyFirstRepository.Web"
RUN dotnet build "MyFirstRepository.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyFirstRepository.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyFirstRepository.Web.dll"]