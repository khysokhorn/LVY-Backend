#!/bin/bash
read -p "Enter migration name: " name
dotnet ef migrations add $name
dotnet ef database update $name