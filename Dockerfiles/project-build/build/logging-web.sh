#!/bin/sh
mkdir temp
cp -r /projects/Spartakiade2016/Samples/ /build/temp/app/
cp /projects/Spartakiade2016/Dockerfiles/logging-web/Dockerfile /build/temp/
cd /build/temp/
docker build -t fpommerening/spartakiade2016:logging-web .
cd /build/
rm -rf /build/temp/
