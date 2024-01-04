// pipeline {
//     agent any
//     options {
//         // Timeout counter starts AFTER agent is allocated
//         timeout(time: 100, unit: 'SECONDS')
//     }
//     stages {
//         stage('Example') {
//             steps {
//                 echo 'Hello World'
//             }
//         }
//     }
// }
pipeline {
    agent { dockerfile true }
    stages {
        stage('Test') {
            steps {
                sh 'node --version'
                sh 'svn --version'
            }
        }
    }
}