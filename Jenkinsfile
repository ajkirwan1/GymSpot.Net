pipeline {
    agent any
    options {
        // Timeout counter starts AFTER agent is allocated
        timeout(time: 100, unit: 'SECONDS')
    }
    stages {
        stage('Example') {
            steps {
                echo 'Hello World'
            }
        }
        stage ('Git Checkout') {
            steps {
                git branch: 'master', url: 'https://github.com/ajkirwan1/GymSpot.Net'
                }
        }
        stage('Restore packages') {
            steps {
                bat "dotnet restore ${workspace}\\GymSpot.sln"
            }
        }
    }
}
