FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["AppMvcBasico/AppMvcBasico.csproj", "AppMvcBasico/"]
RUN dotnet restore "AppMvcBasico/AppMvcBasico.csproj"
COPY ["AppMvcBasico/entrypoint.sh", "entrypoint.sh"]
RUN chmod +x ./src/entrypoint.sh
COPY . .

WORKDIR "/src/AppMvcBasico"
RUN dotnet build "AppMvcBasico.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AppMvcBasico.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AppMvcBasico.dll"]

CMD /bin/bash ./src/entrypoint.sh