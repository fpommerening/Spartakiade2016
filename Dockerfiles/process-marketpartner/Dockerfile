FROM mono
MAINTAINER Frank Pommerening "frank@pommerening-online.de"
ENV REFRESHED_AT 2016-03-14
COPY app/ /app
WORKDIR /app/
EXPOSE 12088
ENTRYPOINT ["mono", "MarketPartner.exe"]