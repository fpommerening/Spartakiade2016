FROM microsoft/aspnet:1.0.0-rc1-update1
MAINTAINER Frank Pommerening "frank@pommerening-online.de"
ENV REFRESHED_AT 2016-03-17
COPY app/ /app
WORKDIR /app/Webbroker/
RUN ["dnu", "restore"]
EXPOSE 9090
ENTRYPOINT ["dnx", "web", "--server.urls", "http://0.0.0.0:9090"]

