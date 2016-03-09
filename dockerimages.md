# Dockerimages für den Workshop Microservices mit .NET und RabbitMQ

Im Workshop werden zahlreiche Basisimages für Docker verwendet. 
Um Wartezeiten vermeiden bzw. die Internetanbindung zu schonen ladet die Images bereits Hause herunter.

 

Dazu verbindet ihr euch auf einen Docker-Host. 
Dort gebt ihr  den Befehl ein: <b>docker pull</b> <i>Imagenamen</i> <br/>
Beispiel: docker pull fpommerening/sparatakiade2016:project-data


<b>Die folgende Liste ist der erste Entwurf. Der finale Version wird etwa eine Woche vorher veröffentlicht. </b>

- fpommerening/spartakiade2016:project-build
- fpommerening/spartakiade2016:project-data
- fpommerening/spartakiade2016:project-share
- fpommerening/spartakiade2016:loadbalancer
- fpommerening/spartakiade2016:process-data
- maxexcloo/phppgadmin
- rabbitmq:3-management
- tutum/mongodb
