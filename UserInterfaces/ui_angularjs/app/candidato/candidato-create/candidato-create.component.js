'use strict';

angular.
  module('candidato').
  component('candidatoCreate', {
     templateUrl: '/candidato/candidato-create/candidato-create.template.html',
     controller: ['$rootScope', '$location',
       function CandidatoCreateController($rootScope, $location) {
         $rootScope.createInformacoesDeContato = null;
         $rootScope.createPreferenciasDeTrabalho = null;
         $rootScope.createQuestionarioDeHabilidades = null;
         $rootScope.createInformacoesParaPagamento = null;
         $location.path("/candidato/createinformacoesdecontato");
       }
     ]
  });
