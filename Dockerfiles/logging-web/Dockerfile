FROM microsoft/aspnet:1.0.0-rc1-update1
MAINTAINER Frank Pommerening "frank@pommerening-online.de"
ENV REFRESHED_AT 2016-03-06
COPY app/ /app
WORKDIR /app/WebLogger/
RUN ["dnu", "restore"]
EXPOSE 8080
ENTRYPOINT ["dnx", "web", "--server.urls", "http://0.0.0.0:8080"]