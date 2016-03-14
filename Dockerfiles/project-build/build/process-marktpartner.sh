#!/bin/sh
mkdir temp
cp -r /projects/Spartakiade2016/Samples/ProcessChain/MarktPartner/ /build/temp/app/
cp /projects/Spartakiade2016/Dockerfiles/process-marktpartner/Dockerfile /build/temp/
cd /build/temp/
docker build -t fpommerening/spartakiade2016:process-marktpartner .
cd /build/
rm -rf /build/temp/
