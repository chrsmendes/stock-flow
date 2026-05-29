FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["stock-flow.csproj", "./"]
RUN dotnet restore "stock-flow.csproj"
COPY . .
RUN dotnet publish "stock-flow.csproj" -c Release -o /app/publish


FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "stock-flow.dll"]
