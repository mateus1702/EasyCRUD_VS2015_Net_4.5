'use strict';

angular.
  module('candidato').
  component('candidatoUpdate', {
     templateUrl: '/candidato/candidato-update/candidato-update.template.html',
     controller: ['Candidato', '$rootScope', '$routeParams', 'CandidatoDTO', '$location',
       function CandidatoUpdateController(Candidato, $rootScope, $routeParams, CandidatoDTO, $location) {

         $rootScope.candidatoDTO = Candidato.get({ Id: $routeParams.Id }, function(response) {
           $rootScope.updateInformacoesDeContato = CandidatoDTO.extractInformacoesDeContato(response);
           $rootScope.updatePreferenciasDeTrabalho = CandidatoDTO.extractPreferenciasDeTrabalho(response);
           $rootScope.updateQuestionarioDeHabilidades = CandidatoDTO.extractQuestionarioDeHabilidades(response);
           $rootScope.updateInformacoesParaPagamento = CandidatoDTO.extractInformacoesParaPagamento(response);
           $location.path("/candidato/updateinformacoesdecontato");
         });
       }
     ]
  });
