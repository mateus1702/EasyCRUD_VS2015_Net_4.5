'use strict';

angular.
  module('candidato').
  component('candidatoUpdateConcluido', {
     templateUrl: '/candidato/candidato-update/candidato-update-concluido.template.html',
     controller: ['$scope', '$routeParams',
       function CandidatoUpdateConcluidoController($scope, $routeParams) {
         $scope.Id = $routeParams.Id;
       }
     ]
  });
