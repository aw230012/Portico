(function () {
   var ngPatient = angular.module("ngRegistration", []);
   ngPatient.controller("RegistrationController", function($scope, $http) {
      $scope.tweets = [
         { screenName: "Sumit", tweetText: "Test 1" },
         { screenName: "Sumit", tweetText: "Test 2" }
      ];
   });
})();

