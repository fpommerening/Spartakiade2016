# Dockerimages für den Workshop Microservices mit .NET und RabbitMQ

Im Workshop werden zahlreiche Basisimages für Docker verwendet. 
Um Wartezeiten vermeiden bzw. die Internetanbindung zu schonen ladet die Images der folgenden Liste bereits zu Hause herunter.


Dazu verbindet ihr euch auf einen Docker-Host.<br />
Dort gebt ihr  den Befehl ein: <b><a href="https://docs.docker.com/engine/reference/commandline/pull/" target="_blank">docker pull</a></b>
 <i>Imagenamen</i> <br/>
Beispiel: docker pull fpommerening/sparatakiade2016:project-data


- fpommerening/spartakiade2016:project-build
- fpommerening/spartakiade2016:project-data
- fpommerening/spartakiade2016:project-share
- fpommerening/spartakiade2016:loadbalancer
- fpommerening/spartakiade2016:process-data
- microsoft/aspnet:1.0.0-rc1-update1
- mono
- maxexcloo/phppgadmin
- rabbitmq:3-management
- tutum/mongodb
