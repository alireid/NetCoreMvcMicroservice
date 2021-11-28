FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["NetCoreMvcMicroservice/NetCoreMvcMicroservice.csproj", "NetCoreMvcMicroservice/"]
RUN dotnet restore "NetCoreMvcMicroservice/NetCoreMvcMicroservice.csproj"
COPY . .
WORKDIR "/src/NetCoreMvcMicroservice"
RUN dotnet build "NetCoreMvcMicroservice.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "NetCoreMvcMicroservice.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "NetCoreMvcMicroservice.dll"]