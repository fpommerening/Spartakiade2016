mkdir weblogger
cp /projects/Spartakiade2016/Dockerfiles/weblogger/docker-compose.yml /compose/weblogger/
cd weblogger
/usr/local/bin/docker-compose $1
cd /compose/
rm -rf weblogger
