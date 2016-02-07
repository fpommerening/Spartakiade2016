# Spartakiade 2016

<p align="center"><img src="images/logo_spartakiade.png" width=100/></p>

Web: http://spartakiade.org/  
Twitter: http://twitter.com/spartakiade_org

Datum: 19. bis 20. März 2016

# Workshop: Micro Services mit .NET und RabbitMQ
mit Frank Pommerening <a href="https://twitter.com/fpommerening" class="twitter-follow-button" data-show-count="false" data-show-screen-name="false">Follow @fpommerening</a>
<script>!function(d,s,id){var js,fjs=d.getElementsByTagName(s)[0],p=/^http:/.test(d.location)?'http':'https';if(!d.getElementById(id)){js=d.createElement(s);js.id=id;js.src=p+'://platform.twitter.com/widgets.js';fjs.parentNode.insertBefore(js,fjs);}}(document, 'script', 'twitter-wjs');</script>

Hinweis: Ich überarbeite gerade diese Seite und werde Details zum Workshop in den nächsten Tagen veröffentlichen.

## Inhalt
1. [Zielgruppe](#zielgruppe)
2. [Inhalt](#inhalt)
3. [Teilnehmer-Voraussetzungen](#voraussetzungen)

<a name="zielgruppe"></a>
## 1. Zielgruppe
Dieser Workshop richtet sich an Entwickler, die mehr über zuverlässige und skalierbare verteilte .Net Anwendungen erfahren möchten.

<a name="themen"></a>
## 2. Inhalt
Die Teilnehmer erhalten Informationen über die Grundlagung von RabbitMQ und dessen Bereitstellung. Darüber hinaus jedoch setzt der Workshop einen 
deutlichen Akzent auf Nutzung von RabbitMQ in .Net Microservices. Viele praktische Beispiele und gemeinesame Übungen sollen den Teilnehmen die Vor- 
und auch Nachteile gegenüber reinen HTTP-basierten Implementierungen zeigen.

Die folgende Liste gibt einen Überblick über mögliche Themen.
- RabbitMQ
   - Grundlagen
   - Bereitstellung unter Windows und im Containerumfeld
- Einstieg in EasyNetQ
   - Warum nicht nativ?
   - Zugriffstechniken z.B. Request - Response
   - Erweiterung und Integration
- Beispiele
   - zentrales Logging
   - Webbroker
   - Prozessketten

Hinweis: Docker wird für die Bereitstellung der Infrastuktur z.B. einer Datenbank verwendet. Die Fokus liegt auf die Implementierung der .Net Microservices. 

<a name="voraussetzungen"></a>
## 3. Teilnehmer-Voraussetzungen
[x] Notebook mit Visual Studio 2013 / 2015 mit installierem <a href="https://docs.asp.net/en/latest/getting-started/installing-on-windows.html">ASP.NET 5</a><br>
[x] Git-Client </br>
[x] Virtuelle Docker-Maschine (<a href="https://docs.docker.com/engine/installation/windows/">Anleitung Docker auf Windows</a>)

Zur Vermeidung von Wartezeiten und der Entlastung der Internetleitung vor Ort sollten die Teilnehmer vorher die notwendigen Docker-Images herunterladen.
Eine entsprechende Liste wird etwa eine Woche vorher veröffentlicht.

*In diesem GitHub-Repository werden die Initial-Projekte für die Übungen sowie die Präsenation veröffentlich.* 