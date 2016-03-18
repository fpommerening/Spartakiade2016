mkdir processchain
cp -u /projects/Spartakiade2016/Dockerfiles/processchain/docker-compose.yml /compose/processchain/
cd processchain
/usr/local/bin/docker-compose $*
cd /compose/
rm -rf processchain
