'use strict';

angular.
  module('candidato').
  component('candidatoCreateInformacoesParaPagamento', {
     templateUrl: '/candidato/candidato-create/candidato-create-informacoes-para-pagamento.template.html',
     controller: ['$rootScope', '$scope', 'DataValidation', '$location', 'Candidato', 'CandidatoDTO',
       function CandidatoCreateInformacoesParaPagamentoController($rootScope, $scope, DataValidation, $location, Candidato, CandidatoDTO) {
         $scope.loading = false;
         $scope.informacoesParaPagamento =  $rootScope.createInformacoesParaPagamento != null
           ? $rootScope.createInformacoesParaPagamento
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
         console.log(CandidatoDTO);
         $scope.finish = function () {
           var isValid = $scope.validate();

           if (isValid) {
             $rootScope.createInformacoesParaPagamento = $scope.informacoesParaPagamento;

             $scope.candidato = CandidatoDTO.create({
               informacoesDeContato: $rootScope.createInformacoesDeContato,
               preferenciasDeTrabalho: $rootScope.createPreferenciasDeTrabalho,
               questionarioDeHabilidades: $rootScope.createQuestionarioDeHabilidades,
               informacoesParaPagamento: $rootScope.createInformacoesParaPagamento,
             });

             $scope.loading = true;
             Candidato.save($scope.candidato, function() {
               $scope.loading = false;
               $rootScope.createInformacoesDeContato = null;
               $rootScope.createPreferenciasDeTrabalho = null;
               $rootScope.createQuestionarioDeHabilidades = null;
               $rootScope.createInformacoesParaPagamento = null;
               $location.path("/candidato/createconcluido");
             });
           }
         }
       }
     ]
  });
