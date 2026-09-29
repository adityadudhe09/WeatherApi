#!/bin/bash
echo "=================Install Git in RHEL 9================="
sudo dnf install git -y
echo "================= DOT NET SDK 10 Installation ================="
sudo dnf install dotnet-sdk-10.0 -y
echo "================= ASP NET CORE Runtime 10 Installation ================="
sudo dnf install aspnetcore-runtime-10.0 -y
echo "================= DOT NET Runtime 10 Installation ================="
sudo dnf install dotnet-runtime-10.0 -y
echo "================= DOT NET Version =================" 
dotnet --version