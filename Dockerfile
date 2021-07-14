# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
COPY . /app
WORKDIR /app/BinDaysApi
RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]
EXPOSE 80/tcp
WORKDIR /app
# RUN chmod +x ./entrypoint.sh
# CMD /bin/bash ./entrypoint.sh