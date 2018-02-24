using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNET_MVC5.Models.View
{
    public class CandidatoViewModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Skype { get; set; }

        public string Telefone { get; set; }

        [Display(Name = "Telefone é WhatsApp?")]
        public bool TelefoneEWhatsApp { get; set; }

        [Display(Name = "LinkedIn")]
        public string Linkedin { get; set; }

        [Display(Name = "Link para acesso ao portifólio.")]
        public string PortifolioURL { get; set; }

        public Disponibilidades Disponibilidade { get; set; }

        [Display(Name = "Horário de trabalho")]
        public HorariosDeTrabalho HorarioDeTrabalho { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        [Display(Name = "Pretenção de salário por hora")]
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
            [Display(Name = "Nome do titular")]
            public string NomeTitular { get; set; }

            public string CPF { get; set; }

            public string Banco { get; set; }

            [Display(Name = "Agência")]
            public string Agencia { get; set; }

            [Display(Name = "Número da conta")]
            public string NumeroDaConta { get; set; }

            [Display(Name = "Tipo de conta")]
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

            [Display(Name = "ASP Net MVC")]
            public int AspNetMVC { get; set; }

            public int? C { get; set; }

            [Display(Name = "C++")]
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

            [Display(Name = "Link para acesso ao CRUD")]
            public string LinkCRUDRepository { get; set; }
        }
    }
}