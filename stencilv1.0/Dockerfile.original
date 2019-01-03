FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 24939
EXPOSE 44351

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["stencilv1.0/stencilv1.0.csproj", "stencilv1.0/"]
RUN dotnet restore "stencilv1.0/stencilv1.0.csproj"
COPY . .
WORKDIR "/src/stencilv1.0"
RUN dotnet build "stencilv1.0.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "stencilv1.0.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "stencilv1.0.dll"]