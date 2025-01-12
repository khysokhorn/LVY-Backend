#!/bin/bash
short_hash=$(git rev-parse --short HEAD)
description=$(git log --format=%B -n 1 HEAD)
echo $short_hash
echo $description
git pull origin main
# Move file into Desktop first before create new Release 
dotnet dotnet publish -c Release
sudo systemctl restart rental.service
sudo systemctl restart nginx.service