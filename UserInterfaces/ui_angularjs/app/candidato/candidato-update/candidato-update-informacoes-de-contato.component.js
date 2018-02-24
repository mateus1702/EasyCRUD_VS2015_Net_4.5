'use strict';

angular.
  module('candidato').
  component('candidatoUpdateInformacoesDeContato', {
     templateUrl: '/candidato/candidato-update/candidato-update-informacoes-de-contato.template.html',
     controller: ['$rootScope', '$scope', 'DataValidation', '$location',
       function CandidatoUpdateInformacoesDeContatoController($rootScope, $scope, DataValidation, $location) {
         $scope.informacoesDeContato = $rootScope.updateInformacoesDeContato != null
           ? $rootScope.updateInformacoesDeContato
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
             $rootScope.updateInformacoesDeContato = $scope.informacoesDeContato;
             $location.path("/candidato/updatepreferenciasdetrabalho");
           }
         }
       }
     ]
  });
