'use strict';

angular.
  module('candidato').
  component('candidatoUpdatePreferenciasDeTrabalho', {
     templateUrl: '/candidato/candidato-update/candidato-update-preferencias-de-trabalho.template.html',
     controller: ['$rootScope', '$scope', 'DataValidation', '$location',
       function CandidatoUpdatePreferenciasDeTrabalhoController($rootScope, $scope, DataValidation, $location) {
         $scope.preferenciasDeTrabalho =  $rootScope.updatePreferenciasDeTrabalho != null
           ? $rootScope.updatePreferenciasDeTrabalho
           : {};

         $scope.preferenciasDeTrabalho.validation = {
           disponibilidadeRequiredOk: true,
           horarioDeTrabalhoRequiredOk: true,
           PretensaoRemuneracaoPorHoraRequiredOk: true,
           PretensaoRemuneracaoPorHoraDecimalOk: true
         };

         $scope.validate = function () {
           $scope.preferenciasDeTrabalho.validation.disponibilidadeRequiredOk = !$scope.preferenciasDeTrabalho.Disponibilidade ? false : true;
           $scope.preferenciasDeTrabalho.validation.horarioDeTrabalhoRequiredOk = !$scope.preferenciasDeTrabalho.HorarioDeTrabalho ? false : true;
           $scope.preferenciasDeTrabalho.validation.PretensaoRemuneracaoPorHoraRequiredOk = !$scope.preferenciasDeTrabalho.PretensaoRemuneracaoPorHora ? false : true;
           $scope.preferenciasDeTrabalho.validation.PretensaoRemuneracaoPorHoraDecimalOk =
             $scope.preferenciasDeTrabalho.validation.PretensaoRemuneracaoPorHoraRequiredOk
             ? DataValidation.isDecimal($scope.preferenciasDeTrabalho.PretensaoRemuneracaoPorHora)
             : true;
           var isValid = true;
           angular.forEach($scope.preferenciasDeTrabalho.validation, function(value, key) {
            isValid = isValid && value;
           });

           return isValid;
         }

         $scope.next = function () {
           var isValid = $scope.validate();

           if (isValid) {
             $rootScope.updatePreferenciasDeTrabalho = $scope.preferenciasDeTrabalho;
             $location.path("/candidato/updatequestionariodehabilidades");
           }
         }
       }
     ]
  });
