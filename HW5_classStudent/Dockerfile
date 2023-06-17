FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["HW5_classStudent/HW5_classStudent.csproj", "HW5_classStudent/"]
RUN dotnet restore "HW5_classStudent/HW5_classStudent.csproj"
COPY . .
WORKDIR "/src/HW5_classStudent"
RUN dotnet build "HW5_classStudent.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HW5_classStudent.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HW5_classStudent.dll"]
