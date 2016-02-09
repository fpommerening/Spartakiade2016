#!/bin/bash
export USERNAME="spartakiade"
export PASSWORD="SportF3#"
adduser -u 1000 --system --shell /bin/false --group --disabled-password $USERNAME
echo -ne "$PASSWORD\n$PASSWORD\n" | smbpasswd -a -s $USERNAME
mkdir /projects/
chown -R $USERNAME:$USERNAME /projects/
chmod -R ugo+rwx /projects/

