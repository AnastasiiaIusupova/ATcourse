FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["HW4_strings/HW4_strings.csproj", "HW4_strings/"]
RUN dotnet restore "HW4_strings/HW4_strings.csproj"
COPY . .
WORKDIR "/src/HW4_strings"
RUN dotnet build "HW4_strings.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HW4_strings.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HW4_strings.dll"]
