'use strict';

angular.
  module('candidato').
  component('candidatoDelete', {
     templateUrl: '/candidato/candidato-delete/candidato-delete.template.html',
     controller: ['Candidato', '$routeParams', '$scope', '$location',
       function CandidatoDeleteController(Candidato, $routeParams, $scope, $location) {
         $scope.loading = true;
         $scope.candidato = Candidato.get({ Id: $routeParams.Id }, function(response) {
           $scope.loading = false;
         });

         $scope.delete = function () {
           $scope.loading = true;
           $scope.candidato.$delete(function() {
             $scope.loading = false;
             $location.path( "/candidato/deleteconcluido" );
           });
         }
       }
     ]
  });
