FROM mono:latest


ADD . /WebApp
WORKDIR /WebApp

# RUN mono nuget.exe restore
RUN xbuild /p:Configuration=Release

CMD [ "mono", "/WebApp/WebApp/bin/Release/WebApp.exe"]