FROM jenserat/samba-publicshare
MAINTAINER Frank Pommerening "frank@pommerening-online.de"
ENV REFRESHED_AT 2016-02-09
COPY smb.conf /etc/samba/smb.conf
ADD setup.sh /setup.sh
RUN /setup.sh
