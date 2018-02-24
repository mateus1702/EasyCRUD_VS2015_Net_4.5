using ASPNET_MVC5.Models.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET_MVC5.Models.DTO
{
    public class CandidatoDTO
    {
        public CandidatoDTO() { }

        public CandidatoDTO(InformacoesDeContatoInputModel contato, PreferenciasDeTrabalhoInputModel trabalho, QuestionarioDeHabilidadesInputModel questionario, InformacoesParaPagamentoInputModel pagamento)
        {
            Nome = contato.Nome;
            Email = contato.Email;
            Skype = contato.Skype;
            Telefone = contato.Telefone;
            TelefoneEWhatsApp = contato.TelefoneEWhatsApp;
            Linkedin = contato.Linkedin;
            Localizacao = new CandidatoDTO.LocalizacaoDTO()
            {
                Cidade = contato.Cidade,
                Estado = contato.Estado
            };
            Disponibilidade = (int)trabalho.Disponibilidade;
            HorarioDeTrabalho = (int)trabalho.HorarioDeTrabalho;
            PretensaoRemuneracaoPorHora = Decimal.Parse(trabalho.PretensaoRemuneracaoPorHora);
            Conhecimentos = new CandidatoDTO.ConhecimentosDTO()
            {
                Android = (int)questionario.Android,
                AngularJS = (int)questionario.AngularJS,
                AspNetMVC = (int)questionario.AspNetMVC,
                Bootstrap = (int)questionario.Bootstrap,
                C = (int?)questionario.C,
                Cake = (int?)questionario.Cake,
                CPlusPlus = (int?)questionario.CPlusPlus,
                CSS = (int?)questionario.CSS,
                Django = (int?)questionario.Django,
                HTML = (int?)questionario.HTML,
                Illustrator = (int?)questionario.Illustrator,
                Ionic = (int)questionario.Ionic,
                IOS = (int)questionario.IOS,
                Java = (int?)questionario.Java,
                JQuery = (int)questionario.JQuery,
                LinkCRUDRepository = questionario.LinkCRUDRepository,
                Magento = (int?)questionario.Magento,
                MySQL = (int?)questionario.MySQL,
                Outras = questionario.Outras,
                Photoshop = (int?)questionario.Photoshop,
                PHP = (int)questionario.PHP,
                Phyton = (int?)questionario.Phyton,
                Ruby = (int?)questionario.Ruby,
                SalesForce = (int?)questionario.SalesForce,
                SEO = (int?)questionario.SEO,
                SQLServer = (int?)questionario.SQLServer,
                Wordpress = (int)questionario.Wordpress,
            };
            PortifolioURL = questionario.PortifolioURL;
            InformacaoParaPagamento = new CandidatoDTO.InformacaoParaPagamentoDTO()
            {
                Agencia = pagamento.Agencia,
                Banco = pagamento.Banco,
                CPF = pagamento.CPF,
                NomeTitular = pagamento.NomeTitular,
                NumeroDaConta = pagamento.NumeroDaConta,
                TipoDeConta = (int)pagamento.TipoDeConta,
            };
        }


        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Skype { get; set; }

        public string Telefone { get; set; }

        public bool TelefoneEWhatsApp { get; set; }

        public string Linkedin { get; set; }

        public string PortifolioURL { get; set; }

        public int Disponibilidade { get; set; }

        public int HorarioDeTrabalho { get; set; }

        public decimal PretensaoRemuneracaoPorHora { get; set; }


        public LocalizacaoDTO Localizacao { get; set; }

        public class LocalizacaoDTO
        {
            public string Cidade { get; set; }

            public string Estado { get; set; }
        }


        public InformacaoParaPagamentoDTO InformacaoParaPagamento { get; set; }

        public class InformacaoParaPagamentoDTO
        {
            public string NomeTitular { get; set; }

            public string CPF { get; set; }

            public string Banco { get; set; }

            public string Agencia { get; set; }

            public string NumeroDaConta { get; set; }

            public int TipoDeConta { get; set; }
        }


        public ConhecimentosDTO Conhecimentos { get; set; }

        public class ConhecimentosDTO
        {
            public int Ionic { get; set; }

            public int Android { get; set; }

            public int IOS { get; set; }

            public int? HTML { get; set; }

            public int? CSS { get; set; }

            public int Bootstrap { get; set; }

            public int JQuery { get; set; }

            public int AngularJS { get; set; }

            public int? Java { get; set; }

            public int AspNetMVC { get; set; }

            public int? C { get; set; }

            public int? CPlusPlus { get; set; }

            public int? Cake { get; set; }

            public int? Django { get; set; }

            public int? Magento { get; set; }

            public int PHP { get; set; }

            public int Wordpress { get; set; }

            public int? Phyton { get; set; }

            public int? Ruby { get; set; }

            public int? SQLServer { get; set; }

            public int? MySQL { get; set; }

            public int? SalesForce { get; set; }

            public int? Photoshop { get; set; }

            public int? Illustrator { get; set; }

            public int? SEO { get; set; }

            public string Outras { get; set; }

            public string LinkCRUDRepository { get; set; }
        }
    }
}


                