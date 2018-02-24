'use strict';

angular.
  module('candidato').
  component('candidatoCreateQuestionarioDeHabilidades', {
     templateUrl: '/candidato/candidato-create/candidato-create-questionario-de-habilidades.template.html',
     controller: ['$rootScope', '$scope', 'DataValidation', '$location', '$window',
       function CandidatoCreateQuestionarioDeHabilidadesController($rootScope, $scope, DataValidation, $location, $window) {
         $scope.questionarioDeHabilidades =  $rootScope.createQuestionarioDeHabilidades != null
           ? $rootScope.createQuestionarioDeHabilidades
           : {};

         $scope.questionarioDeHabilidades.validation = {
           ionicRequiredOk: true,
           androidRequiredOk: true,
           iosRequiredOk: true,
           bootstrapRequiredOk: true,
           jqueryRequiredOk: true,
           angularjsRequiredOk: true,
           aspnetmvcRequiredOk: true,
           phpRequiredOk: true,
           wordpressRequiredOk: true,
         };

         $scope.validate = function () {
           $scope.questionarioDeHabilidades.validation.ionicRequiredOk = !$scope.questionarioDeHabilidades.Ionic ? false : true;
           $scope.questionarioDeHabilidades.validation.androidRequiredOk = !$scope.questionarioDeHabilidades.Android ? false : true;
           $scope.questionarioDeHabilidades.validation.iosRequiredOk = !$scope.questionarioDeHabilidades.IOS ? false : true;
           $scope.questionarioDeHabilidades.validation.bootstrapRequiredOk = !$scope.questionarioDeHabilidades.Bootstrap ? false : true;
           $scope.questionarioDeHabilidades.validation.jqueryRequiredOk = !$scope.questionarioDeHabilidades.JQuery ? false : true;
           $scope.questionarioDeHabilidades.validation.angularjsRequiredOk = !$scope.questionarioDeHabilidades.AngularJS ? false : true;
           $scope.questionarioDeHabilidades.validation.aspnetmvcRequiredOk = !$scope.questionarioDeHabilidades.AspNetMVC ? false : true;
           $scope.questionarioDeHabilidades.validation.phpRequiredOk = !$scope.questionarioDeHabilidades.PHP ? false : true;
           $scope.questionarioDeHabilidades.validation.wordpressRequiredOk = !$scope.questionarioDeHabilidades.Wordpress ? false : true;


           var isValid = true;
           angular.forEach($scope.questionarioDeHabilidades.validation, function(value, key) {
            isValid = isValid && value;
           });

           return isValid;
         }

         $scope.next = function () {
           var isValid = $scope.validate();

           if (isValid) {
             $rootScope.createQuestionarioDeHabilidades = $scope.questionarioDeHabilidades;
             $location.path("/candidato/createinformacoesparapagamento");
           } else {
             $window.scrollTo(0, 0);
           }
         }
       }
     ]
  });
