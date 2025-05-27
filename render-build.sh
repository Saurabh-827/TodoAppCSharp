#!/usr/bin/env bash
dotnet restore
dotnet ef database update
dotnet publish -c Release -o out