FROM mono:latest

RUN mkdir -p release
COPY bin/Debug/* /release/

EXPOSE 8080
CMD [ "mono", "release/WebApp.exe"]