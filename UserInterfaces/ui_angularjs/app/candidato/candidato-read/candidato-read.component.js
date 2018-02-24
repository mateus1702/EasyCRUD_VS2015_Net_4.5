'use strict';

angular.
  module('candidato').
  component('candidatoRead', {
     templateUrl: '/candidato/candidato-read/candidato-read.template.html',
     controller: ['Candidato', '$routeParams', '$scope', '$location',
       function CandidatoReadController(Candidato, $routeParams, $scope, $location) {
         $scope.Id = $routeParams.Id;
         $scope.loading = true;
         $scope.candidato = Candidato.get({ Id: $routeParams.Id }, function(response) {
           $scope.loading = false;
         });

         $scope.getDisponibilidadeDescription = function (value) {
           switch (value) {
             case 0:
                return "Até 4 horas por dia."
             case 1:
                return "De 4 a 6 horas por dia."
             case 2:
                return "De 6 a 8 horas por dia."
             case 3:
                return "Acima de 8 horas por dia."
             case 4:
                return "Apenas nos finais de semana."
           }
         }

         $scope.getHorarioDeTrabalhoDescription = function (value) {
           switch (value) {
             case 0:
                return "Das 8 as 12."
             case 1:
                return "Das 13 as 18."
             case 2:
                return "Das 19 as 22."
             case 3:
                return "Das 22 em diante."
             case 4:
                return "Horário comercial."
           }
         }

         $scope.getTipoDeContaDescription = function (value) {
           switch (value) {
             case 0:
                return "Corrente"
             case 1:
                return "Poupança"
           }
         }
       }
     ]
  });
