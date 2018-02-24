'use strict';

angular.
  module('candidato').
  component('candidatoUpdateInformacoesParaPagamento', {
     templateUrl: '/candidato/candidato-update/candidato-update-informacoes-para-pagamento.template.html',
     controller: ['$rootScope', '$scope', 'DataValidation', '$location', 'Candidato', 'CandidatoDTO',
       function CandidatoUpdateInformacoesParaPagamentoController($rootScope, $scope, DataValidation, $location, Candidato, CandidatoDTO) {
         $scope.loading = false;
         $scope.informacoesParaPagamento =  $rootScope.updateInformacoesParaPagamento != null
           ? $rootScope.updateInformacoesParaPagamento
           : {};

         $scope.informacoesParaPagamento.validation = {
           nomeTitularRequiredOk: true,
           CPFRequiredOk: true,
           CPFValidOk: true,
           bancoRequiredOk: true,
           agenciaRequiredOk: true,
           numeroDaContaRequiredOk: true,
           tipoDeContaRequiredOk: true,
         };

         $scope.validate = function () {
           $scope.informacoesParaPagamento.validation.nomeTitularRequiredOk = !$scope.informacoesParaPagamento.NomeTitular ? false : true;
           $scope.informacoesParaPagamento.validation.CPFRequiredOk = !$scope.informacoesParaPagamento.CPF ? false : true;
           $scope.informacoesParaPagamento.validation.CPFValidOk =
             $scope.informacoesParaPagamento.validation.CPFRequiredOk
             ? DataValidation.isCPFValid($scope.informacoesParaPagamento.CPF)
             : true;
           $scope.informacoesParaPagamento.validation.bancoRequiredOk = !$scope.informacoesParaPagamento.Banco ? false : true;
           $scope.informacoesParaPagamento.validation.agenciaRequiredOk = !$scope.informacoesParaPagamento.Agencia ? false : true;
           $scope.informacoesParaPagamento.validation.numeroDaContaRequiredOk = !$scope.informacoesParaPagamento.NumeroDaConta ? false : true;
           $scope.informacoesParaPagamento.validation.tipoDeContaRequiredOk = !$scope.informacoesParaPagamento.TipoDeConta ? false : true;

           var isValid = true;
           angular.forEach($scope.informacoesParaPagamento.validation, function(value, key) {
            isValid = isValid && value;
           });

           return isValid;
         }
         $scope.finish = function () {
           var isValid = $scope.validate();

           if (isValid) {
             $rootScope.updateInformacoesParaPagamento = $scope.informacoesParaPagamento;

             $rootScope.candidatoDTO = CandidatoDTO.update({
               candidatoDTO: $rootScope.candidatoDTO,
               informacoesDeContato: $rootScope.updateInformacoesDeContato,
               preferenciasDeTrabalho: $rootScope.updatePreferenciasDeTrabalho,
               questionarioDeHabilidades: $rootScope.updateQuestionarioDeHabilidades,
               informacoesParaPagamento: $rootScope.updateInformacoesParaPagamento,
             });

             $scope.loading = true;
             $rootScope.candidatoDTO.$update(function() {
               $scope.loading = false;
               var Id = $rootScope.candidatoDTO.Id;
               $rootScope.candidatoDTO = null;
               $rootScope.updateInformacoesDeContato = null;
               $rootScope.updatePreferenciasDeTrabalho = null;
               $rootScope.updateQuestionarioDeHabilidades = null;
               $rootScope.updateInformacoesParaPagamento = null;
               $location.path(`/candidato/updateconcluido/${Id}`);
             });
           }
         }
       }
     ]
  });
