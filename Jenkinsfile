pipeline {
    agent any
    environment {
        DOTNET_SYSTEM_GLOBALIZATION_INVARIANT = 1
    }
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
                withDotNet (sdk : '.NET 8') {
                sh "dotnet restore ${workspace}/GymSpot.sln"
                    
                }
            }
        }
    }
}
