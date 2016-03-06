#!/bin/sh
mkdir temp
cp -r /projects/Spartakiade2016/Samples/Logging/ /build/temp/app/
cp /projects/Spartakiade2016/Dockerfiles/logging-caller/Dockerfile /build/temp/
cd /build/temp/
docker build -t fpommerening/spartakiade2016:logging-caller .
cd /build/
rm -rf /build/temp/
