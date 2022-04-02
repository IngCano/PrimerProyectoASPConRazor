#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PrimerProyectoASPConRazor/PrimerProyectoASPConRazor.csproj", "PrimerProyectoASPConRazor/"]
RUN dotnet restore "PrimerProyectoASPConRazor/PrimerProyectoASPConRazor.csproj"
COPY . .
WORKDIR "/src/PrimerProyectoASPConRazor"
RUN dotnet build "PrimerProyectoASPConRazor.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PrimerProyectoASPConRazor.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PrimerProyectoASPConRazor.dll"]