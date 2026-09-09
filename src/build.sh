#!/bin/sh

dotnet publish -f net40 -o dist MemConqueror/MemConqueror.n.csproj

cd dist
wine MemConqueror.exe
cd ..


