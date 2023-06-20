FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["HW6_Clinic/HW6_Clinic.csproj", "HW6_Clinic/"]
RUN dotnet restore "HW6_Clinic/HW6_Clinic.csproj"
COPY . .
WORKDIR "/src/HW6_Clinic"
RUN dotnet build "HW6_Clinic.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HW6_Clinic.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HW6_Clinic.dll"]
