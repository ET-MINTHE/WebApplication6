﻿pipeline {
 agent any
 environment {
  dotnet = 'C:\\Program Files\\dotnet\\dotnet.exe'
 }
 stages {
   stage('hello world') {
   steps {
   bat 'echo "Hello World"'
   }
  }
  stage('Checkout') {
   steps {
    git credentialsId: 'minthe-docker-id', url: 'https://github.com/ET-MINTHE/WebApplication6.git', branch: 'master'
   }
  }
  stage('Restore PACKAGES') {
   steps {
    bat "dotnet restore --configfile NuGet.Config"
   }
  }
  stage('Clean') {
   steps {
    bat 'dotnet clean'
   }
  }
  stage('Build') {
   steps {
    bat 'dotnet build --configuration Release'
   }
  }
  stage('Pack') {
   steps {
    bat 'dotnet pack --no-build --output nupkgs'
   }
  }
  stage('Publish') {
   steps {
    bat "dotnet nuget push **\\nupkgs\\*.nupkg -k yourApiKey -s            http://myserver/artifactory/api/nuget/nuget-internal-stable/com/sample"
   }
  }
 }
}
