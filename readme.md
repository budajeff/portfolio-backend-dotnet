# Simple dotnet core api server designed to run on AWS

## Getting Started
I followed the instructions [here](https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/dotnet-core-tutorial.html) but modified them a bit as I was on a linux machine and I want to this server to run on linux.

## Build Bundle Steps
1. <code>dotnet build</code> 
1. <code>dotnet publish -o site</code>
1. <code>cd site</code>
1. <code>zip ../site.zip *</code>
1. <code>cd ..</code>
1. <code>zip portfolio-backend-dotnet.zip site.zip aws-linux-deployment-manifest.json</code>
1. Manually upload at https://us-east-2.console.aws.amazon.com/elasticbeanstalk/home?region=us-east-2#/environments


