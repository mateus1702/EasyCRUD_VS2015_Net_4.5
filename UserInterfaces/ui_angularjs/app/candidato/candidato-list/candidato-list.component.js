'use strict';

angular.
  module('candidato').
  component('candidatoList', {
     templateUrl: '/candidato/candidato-list/candidato-list.template.html',
     controller: ['$scope', 'Candidato', '$location',
       function CandidatoListController($scope, Candidato, $location) {
         $scope.loading = true;
         this.candidatos = Candidato.query(function() {
           $scope.loading = false;
         });
       }
     ]
  });
