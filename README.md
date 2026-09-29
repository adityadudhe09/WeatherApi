## WeatherApi

### Install Git and DotNet
sudo dnf install git -y
sudo dnf install dotnet-sdk-10.0 -y
sudo dnf install aspnetcore-runtime-10.0 -y
sudo dnf install dotnet-runtime-10.0 -y

dotnet --version

--------------------------------------------------------------------------
## Create the application:
dotnet new webapi --name WeatherApi --framework net10.0   --use-controllers
