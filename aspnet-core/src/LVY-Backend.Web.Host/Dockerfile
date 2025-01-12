FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/LVY-Backend.Web.Host/LVY-Backend.Web.Host.csproj", "src/LVY-Backend.Web.Host/"]
COPY ["src/LVY-Backend.Web.Core/LVY-Backend.Web.Core.csproj", "src/LVY-Backend.Web.Core/"]
COPY ["src/LVY-Backend.Application/LVY-Backend.Application.csproj", "src/LVY-Backend.Application/"]
COPY ["src/LVY-Backend.Core/LVY-Backend.Core.csproj", "src/LVY-Backend.Core/"]
COPY ["src/LVY-Backend.EntityFrameworkCore/LVY-Backend.EntityFrameworkCore.csproj", "src/LVY-Backend.EntityFrameworkCore/"]
WORKDIR "/src/src/LVY-Backend.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/LVY-Backend.Web.Host", "src/LVY-Backend.Web.Host"]
COPY ["src/LVY-Backend.Web.Core", "src/LVY-Backend.Web.Core"]
COPY ["src/LVY-Backend.Application", "src/LVY-Backend.Application"]
COPY ["src/LVY-Backend.Core", "src/LVY-Backend.Core"]
COPY ["src/LVY-Backend.EntityFrameworkCore", "src/LVY-Backend.EntityFrameworkCore"]
WORKDIR "/src/src/LVY-Backend.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "LVY-Backend.Web.Host.dll"]
