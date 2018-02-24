'use strict';

angular.
  module('EASYCRUDApp').
  config(['$locationProvider' ,'$routeProvider',
    function config($locationProvider, $routeProvider) {
      $locationProvider.hashPrefix('!');

      $routeProvider.
        when('/candidato', {
          template: '<candidato-list></candidato-list>'
        }).
        when('/candidato/create', {
          template: '<candidato-create></candidato-create>'
        }).
        when('/candidato/createinformacoesdecontato', {
          template: '<candidato-create-informacoes-de-contato></candidato-create-informacoes-de-contato>'
        }).
        when('/candidato/createpreferenciasdetrabalho', {
          template: '<candidato-create-preferencias-de-trabalho></candidato-create-preferencias-de-trabalho>'
        }).
        when('/candidato/createquestionariodehabilidades', {
          template: '<candidato-create-questionario-de-habilidades></candidato-create-questionario-de-habilidades>'
        }).
        when('/candidato/createinformacoesparapagamento', {
          template: '<candidato-create-informacoes-para-pagamento></candidato-create-informacoes-para-pagamento>'
        }).
        when('/candidato/createconcluido', {
          template: '<candidato-create-concluido></candidato-create-concluido>'
        }).
        when('/candidato/update/:Id', {
          template: '<candidato-update></candidato-update>'
        }).
        when('/candidato/updateinformacoesdecontato', {
          template: '<candidato-update-informacoes-de-contato></candidato-update-informacoes-de-contato>'
        }).
        when('/candidato/updatepreferenciasdetrabalho', {
          template: '<candidato-update-preferencias-de-trabalho></candidato-update-preferencias-de-trabalho>'
        }).
        when('/candidato/updatequestionariodehabilidades', {
          template: '<candidato-update-questionario-de-habilidades></candidato-update-questionario-de-habilidades>'
        }).
        when('/candidato/updateinformacoesparapagamento', {
          template: '<candidato-update-informacoes-para-pagamento></candidato-update-informacoes-para-pagamento>'
        }).
        when('/candidato/updateconcluido/:Id', {
          template: '<candidato-update-concluido></candidato-update-concluido>'
        }).
        when('/candidato/read/:Id', {
          template: '<candidato-read></candidato-read>'
        }).
        when('/candidato/delete/:Id', {
          template: '<candidato-delete></candidato-delete>'
        }).
        when('/candidato/deleteconcluido', {
          template: '<candidato-delete-concluido></candidato-delete-concluido>'
        }).
        when('/home', {
          template: '<home></home>'
        }).
        otherwise('/home');
    }
  ]);
