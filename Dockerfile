FROM microsoft/dotnet:1.1-sdk-projectjson
 
RUN apt-get -qq update && \
    apt-get install -y \
    apt-transport-https \
    curl && \
    apt-get install -y vim

COPY ./src /app
WORKDIR /app/Wizard.Service

RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]
 
EXPOSE 5000
ENV ASPNETCORE_URLS http://*:5000

ENTRYPOINT ["dotnet", "run"]