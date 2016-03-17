#!/bin/sh
mkdir temp
cp -r /projects/Spartakiade2016/Samples/MarketPartner/Web/bin/Release/ /build/temp/app/
cp /projects/Spartakiade2016/Dockerfiles/process-marketpartner/Dockerfile /build/temp/
cd /build/temp/
docker build -t fpommerening/spartakiade2016:process-marketpartner .
cd /build/
rm -rf /build/temp/
