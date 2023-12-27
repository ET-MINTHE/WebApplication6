pipeline {
 agent any
 environment {
  dotnet = 'C:\\Program Files\\dotnet\\dotnet.exe'
 }
 stages {
   stage('hello world') {
   steps {
    echo "Hello World"
   }
  }
  stage('Checkout') {
   steps {
    git credentialsId: 'minthe-docker-id', url: 'https://github.com/ET-MINTHE/WebApplication6.git', branch: 'master'
   }
  }
 
 }
}
