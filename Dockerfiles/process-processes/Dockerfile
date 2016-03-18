FROM microsoft/aspnet:1.0.0-rc1-update1
MAINTAINER Frank Pommerening "frank@pommerening-online.de"
ENV REFRESHED_AT 2016-03-17
ENV PROCESSNAME none
COPY app/ /app
WORKDIR /app/Processes/
RUN ["dnu", "restore"]
