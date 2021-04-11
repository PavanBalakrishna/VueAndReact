 
// Modules, e.g. Webpack:
var AmazonCognitoIdentity = require('amazon-cognito-identity-js');




//Code

import * as AWS from 'aws-sdk/global';
 
var authenticationData = {
    Username: 'Pavan',
    Password: 'Rtba@123',
};
var authenticationDetails = new AmazonCognitoIdentity.AuthenticationDetails(
    authenticationData
);
var poolData = {
    UserPoolId: 'ap-northeast-1_hkTEkTQF4', // Your user pool id here
    ClientId: '2gjvot6ugjce7kkmjj51un5no0', // Your client id here
};
var userPool = new AmazonCognitoIdentity.CognitoUserPool(poolData);
var userData = {
    Username: 'Pavan',
    Pool: userPool,
};
var cognitoUser = new AmazonCognitoIdentity.CognitoUser(userData);
cognitoUser.authenticateUser(authenticationDetails, {
    onSuccess: function(session) {
        var accessToken = session.getAccessToken().getJwtToken();
        var refreshToken = session.getRefreshToken().getToken();
        var idToken = session.getIdToken().getJwtToken();

        var tokens = {
            accessToken:accessToken,
            refreshToken:refreshToken,
            idToken:idToken
        }
        console.log(accessToken);
        console.log(refreshToken);
        console.log(idToken);
        cognitoUser.tokens=tokens;
        //resolve(cognitoUser); // Resolve user
        //POTENTIAL: Region needs to be set if not already set previously elsewhere.
        //AWS.config.region = 'ap-northeast-1';
 
       
 
        // //refreshes credentials using AWS.CognitoIdentity.getCredentialsForIdentity()
        // AWS.config.credentials.refresh(error => {
        //     if (error) {
        //         console.error(error);
        //     } else {
        //         // Instantiate aws sdk service objects now that the credentials have been updated.
        //         // example: var s3 = new AWS.S3();
        //         console.log('Successfully logged!');
        //     }
        // });
    },
 
    onFailure: function(err) {
        alert(err.message || JSON.stringify(err));
    },
});