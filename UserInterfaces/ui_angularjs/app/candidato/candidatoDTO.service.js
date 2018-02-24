'use strict',

angular.
  module('candidato').
  factory('CandidatoDTO',['Candidato',
    function(Candidato) {
      return {
        create: function ({ informacoesDeContato, preferenciasDeTrabalho, questionarioDeHabilidades, informacoesParaPagamento }){
          var candidato = new Candidato();
          candidato.Nome = informacoesDeContato.Nome;
          candidato.Email = informacoesDeContato.Email;
          candidato.Skype = informacoesDeContato.Skype;
          candidato.Telefone = informacoesDeContato.Telefone;
          candidato.TelefoneEWhatsApp = informacoesDeContato.TelefoneEWhatsApp;
          candidato.Linkedin = informacoesDeContato.Linkedin;
          candidato.localizacao = {
            Cidade : informacoesDeContato.Cidade,
            Estado : informacoesDeContato.Estado
          };
          candidato.Disponibilidade = preferenciasDeTrabalho.Disponibilidade;
          candidato.HorarioDeTrabalho = preferenciasDeTrabalho.HorarioDeTrabalho;
          candidato.PretensaoRemuneracaoPorHora = parseFloat(preferenciasDeTrabalho.PretensaoRemuneracaoPorHora.replace(',','.'));
          candidato.Conhecimentos = {
            Android: questionarioDeHabilidades.Android,
            AngularJS: questionarioDeHabilidades.AngularJS,
            AspNetMVC: questionarioDeHabilidades.AspNetMVC,
            Bootstrap: questionarioDeHabilidades.Bootstrap,
            C: questionarioDeHabilidades.C,
            Cake: questionarioDeHabilidades.Cake,
            CPlusPlus: questionarioDeHabilidades.CPlusPlus,
            CSS: questionarioDeHabilidades.CSS,
            Django: questionarioDeHabilidades.Django,
            HTML: questionarioDeHabilidades.HTML,
            Illustrator: questionarioDeHabilidades.Illustrator,
            Ionic: questionarioDeHabilidades.Ionic,
            IOS: questionarioDeHabilidades.IOS,
            Java: questionarioDeHabilidades.Java,
            JQuery: questionarioDeHabilidades.JQuery,
            LinkCRUDRepository: questionarioDeHabilidades.LinkCRUDRepository,
            Magento: questionarioDeHabilidades.Magento,
            MySQL: questionarioDeHabilidades.MySQL,
            Outras: questionarioDeHabilidades.Outras,
            Photoshop: questionarioDeHabilidades.Photoshop,
            PHP: questionarioDeHabilidades.PHP,
            Phyton: questionarioDeHabilidades.Phyton,
            Ruby: questionarioDeHabilidades.Ruby,
            SalesForce: questionarioDeHabilidades.SalesForce,
            SEO: questionarioDeHabilidades.SEO,
            SQLServer: questionarioDeHabilidades.SQLServer,
            Wordpress: questionarioDeHabilidades.Wordpress
          };
          candidato.PortifolioURL = questionarioDeHabilidades.PortifolioURL;
          candidato.InformacaoParaPagamento = {
            Agencia: informacoesParaPagamento.Agencia,
            Banco: informacoesParaPagamento.Banco,
            CPF: informacoesParaPagamento.CPF,
            NomeTitular: informacoesParaPagamento.NomeTitular,
            NumeroDaConta: informacoesParaPagamento.NumeroDaConta,
            TipoDeConta: informacoesParaPagamento.TipoDeConta,
          };

          return candidato;
        },
        extractInformacoesDeContato: function (candidatoDTO) {
          return {
            Nome: candidatoDTO.Nome,
            Email: candidatoDTO.Email,
            Skype: candidatoDTO.Skype,
            Telefone: candidatoDTO.Telefone,
            TelefoneEWhatsApp: candidatoDTO.TelefoneEWhatsApp,
            Linkedin: candidatoDTO.Linkedin,
            Cidade: candidatoDTO.Localizacao.Cidade,
            Estado: candidatoDTO.Localizacao.Estado
          }
        },
        extractPreferenciasDeTrabalho: function (candidatoDTO) {
          return {
            Disponibilidade : candidatoDTO.Disponibilidade.toString(),
            HorarioDeTrabalho : candidatoDTO.HorarioDeTrabalho.toString(),
            PretensaoRemuneracaoPorHora : candidatoDTO.PretensaoRemuneracaoPorHora.toString().replace('.',',')
          }
        },
        extractQuestionarioDeHabilidades: function (candidatoDTO) {
          return {
            Android: candidatoDTO.Conhecimentos.Android,
            AngularJS: candidatoDTO.Conhecimentos.AngularJS,
            AspNetMVC: candidatoDTO.Conhecimentos.AspNetMVC,
            Bootstrap: candidatoDTO.Conhecimentos.Bootstrap,
            C: candidatoDTO.Conhecimentos.C,
            Cake: candidatoDTO.Conhecimentos.Cake,
            CPlusPlus: candidatoDTO.Conhecimentos.CPlusPlus,
            CSS: candidatoDTO.Conhecimentos.CSS,
            Django: candidatoDTO.Conhecimentos.Django,
            HTML: candidatoDTO.Conhecimentos.HTML,
            Illustrator: candidatoDTO.Conhecimentos.Illustrator,
            Ionic: candidatoDTO.Conhecimentos.Ionic,
            IOS: candidatoDTO.Conhecimentos.IOS,
            Java: candidatoDTO.Conhecimentos.Java,
            JQuery: candidatoDTO.Conhecimentos.JQuery,
            LinkCRUDRepository: candidatoDTO.Conhecimentos.LinkCRUDRepository,
            Magento: candidatoDTO.Conhecimentos.Magento,
            MySQL: candidatoDTO.Conhecimentos.MySQL,
            Outras: candidatoDTO.Conhecimentos.Outras,
            Photoshop: candidatoDTO.Conhecimentos.Photoshop,
            PHP: candidatoDTO.Conhecimentos.PHP,
            Phyton: candidatoDTO.Conhecimentos.Phyton,
            Ruby: candidatoDTO.Conhecimentos.Ruby,
            SalesForce: candidatoDTO.Conhecimentos.SalesForce,
            SEO: candidatoDTO.Conhecimentos.SEO,
            SQLServer: candidatoDTO.Conhecimentos.SQLServer,
            Wordpress: candidatoDTO.Conhecimentos.Wordpress,
            PortifolioURL: candidatoDTO.PortifolioURL,
          }
        },
        extractInformacoesParaPagamento: function (candidatoDTO) {
          return {
            Agencia: candidatoDTO.InformacaoParaPagamento.Agencia,
            Banco: candidatoDTO.InformacaoParaPagamento.Banco,
            CPF: candidatoDTO.InformacaoParaPagamento.CPF,
            NomeTitular: candidatoDTO.InformacaoParaPagamento.NomeTitular,
            NumeroDaConta: candidatoDTO.InformacaoParaPagamento.NumeroDaConta,
            TipoDeConta: candidatoDTO.InformacaoParaPagamento.TipoDeConta.toString(),
          }
        },
        update: function ({ candidatoDTO, informacoesDeContato, preferenciasDeTrabalho, questionarioDeHabilidades, informacoesParaPagamento }){
          var candidato = candidatoDTO;
          candidato.Nome = informacoesDeContato.Nome;
          candidato.Email = informacoesDeContato.Email;
          candidato.Skype = informacoesDeContato.Skype;
          candidato.Telefone = informacoesDeContato.Telefone;
          candidato.TelefoneEWhatsApp = informacoesDeContato.TelefoneEWhatsApp;
          candidato.Linkedin = informacoesDeContato.Linkedin;
          candidato.localizacao = {
            Cidade : informacoesDeContato.Cidade,
            Estado : informacoesDeContato.Estado
          };
          candidato.Disponibilidade = preferenciasDeTrabalho.Disponibilidade;
          candidato.HorarioDeTrabalho = preferenciasDeTrabalho.HorarioDeTrabalho;
          candidato.PretensaoRemuneracaoPorHora = parseFloat(preferenciasDeTrabalho.PretensaoRemuneracaoPorHora.replace(',','.'));
          candidato.Conhecimentos = {
            Android: questionarioDeHabilidades.Android,
            AngularJS: questionarioDeHabilidades.AngularJS,
            AspNetMVC: questionarioDeHabilidades.AspNetMVC,
            Bootstrap: questionarioDeHabilidades.Bootstrap,
            C: questionarioDeHabilidades.C,
            Cake: questionarioDeHabilidades.Cake,
            CPlusPlus: questionarioDeHabilidades.CPlusPlus,
            CSS: questionarioDeHabilidades.CSS,
            Django: questionarioDeHabilidades.Django,
            HTML: questionarioDeHabilidades.HTML,
            Illustrator: questionarioDeHabilidades.Illustrator,
            Ionic: questionarioDeHabilidades.Ionic,
            IOS: questionarioDeHabilidades.IOS,
            Java: questionarioDeHabilidades.Java,
            JQuery: questionarioDeHabilidades.JQuery,
            LinkCRUDRepository: questionarioDeHabilidades.LinkCRUDRepository,
            Magento: questionarioDeHabilidades.Magento,
            MySQL: questionarioDeHabilidades.MySQL,
            Outras: questionarioDeHabilidades.Outras,
            Photoshop: questionarioDeHabilidades.Photoshop,
            PHP: questionarioDeHabilidades.PHP,
            Phyton: questionarioDeHabilidades.Phyton,
            Ruby: questionarioDeHabilidades.Ruby,
            SalesForce: questionarioDeHabilidades.SalesForce,
            SEO: questionarioDeHabilidades.SEO,
            SQLServer: questionarioDeHabilidades.SQLServer,
            Wordpress: questionarioDeHabilidades.Wordpress
          };
          candidato.PortifolioURL = questionarioDeHabilidades.PortifolioURL;
          candidato.InformacaoParaPagamento = {
            Agencia: informacoesParaPagamento.Agencia,
            Banco: informacoesParaPagamento.Banco,
            CPF: informacoesParaPagamento.CPF,
            NomeTitular: informacoesParaPagamento.NomeTitular,
            NumeroDaConta: informacoesParaPagamento.NumeroDaConta,
            TipoDeConta: informacoesParaPagamento.TipoDeConta,
          };

          return candidato;
        }
      }
    }
  ]);
