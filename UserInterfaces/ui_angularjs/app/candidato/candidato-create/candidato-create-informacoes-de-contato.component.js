'use strict';

angular.
  module('candidato').
  component('candidatoCreateInformacoesDeContato', {
     templateUrl: '/candidato/candidato-create/candidato-create-informacoes-de-contato.template.html',
     controller: ['$rootScope', '$scope', 'DataValidation', '$location',
       function CandidatoCreateInformacoesDeContatoController($rootScope, $scope, DataValidation, $location) {
         $scope.informacoesDeContato = $rootScope.createInformacoesDeContato != null
           ? $rootScope.createInformacoesDeContato
           : {};

         $scope.informacoesDeContato.validation = {
           nomeRequiredOk: true,
           emailRequiredOk: true,
           emailValidOk: true,
           skypeRequiredOk: true,
           telefoneRequiredOk: true,
           telefoneIntegerOk: true,
           cidadeRequiredOk: true,
           estadoRequiredOk: true,
         };

         $scope.validate = function () {
           $scope.informacoesDeContato.validation.nomeRequiredOk = !$scope.informacoesDeContato.Nome ? false : true;
           $scope.informacoesDeContato.validation.emailRequiredOk = !$scope.informacoesDeContato.Email ? false : true;
           $scope.informacoesDeContato.validation.emailValidOk = $scope.informacoesDeContato.validation.emailRequiredOk ? DataValidation.isEmail($scope.informacoesDeContato.Email) : true;
           $scope.informacoesDeContato.validation.skypeRequiredOk = !$scope.informacoesDeContato.Skype ? false : true;
           $scope.informacoesDeContato.validation.telefoneRequiredOk = !$scope.informacoesDeContato.Telefone ? false : true;
           $scope.informacoesDeContato.validation.telefoneIntegerOk = $scope.informacoesDeContato.validation.telefoneRequiredOk ? DataValidation.isNumber($scope.informacoesDeContato.Telefone) : true;
           $scope.informacoesDeContato.validation.cidadeRequiredOk = !$scope.informacoesDeContato.Cidade ? false : true;
           $scope.informacoesDeContato.validation.estadoRequiredOk = !$scope.informacoesDeContato.Estado ? false : true;

           var isValid = true;
           angular.forEach($scope.informacoesDeContato.validation, function(value, key) {
            isValid = isValid && value;
           });

           return isValid;
         }

         $scope.next = function () {
           var isValid = $scope.validate();

           if (isValid) {
             $rootScope.createInformacoesDeContato = $scope.informacoesDeContato;
             $location.path("/candidato/createpreferenciasdetrabalho");
           }
         }
       }
     ]
  });
