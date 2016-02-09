FROM base/arch
RUN useradd -u 1000 spartakiade
RUN mkdir /projects
RUN chown -R spartakiade:spartakiade /projects
VOLUME ["/projects"]
ENTRYPOINT ["/bin/bash"]
