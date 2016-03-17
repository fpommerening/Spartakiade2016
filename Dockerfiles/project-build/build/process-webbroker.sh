#!/bin/sh
mkdir temp
cp -r /projects/Spartakiade2016/Samples/ProcessChain/ /build/temp/app/
cp /projects/Spartakiade2016/Dockerfiles/process-webbroker/Dockerfile /build/temp/
cd /build/temp/
docker build -t fpommerening/spartakiade2016:process-webbroker .
cd /build/
rm -rf /build/temp/
