#!/bin/sh
mkdir temp
cp -r /projects/Spartakiade2016/Samples/ProcessChain/ /build/temp/app/
cp /projects/Spartakiade2016/Dockerfiles/process-processes/Dockerfile /build/temp/
cd /build/temp/
docker build -t fpommerening/spartakiade2016:process-processes .
cd /build/
rm -rf /build/temp/
