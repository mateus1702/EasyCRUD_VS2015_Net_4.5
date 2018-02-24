using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceModel.DTO
{
    public class CandidatoDTO
    {
        public CandidatoDTO()
        {

        }

        public CandidatoDTO(Candidato candidato)
        {
            Id = candidato.Id;
            Nome = candidato.Nome;
            Email = candidato.Email;
            Skype = candidato.Skype;
            Telefone = candidato.Telefone;
            TelefoneEWhatsApp = candidato.TelefoneEWhatsApp;
            Linkedin = candidato.Linkedin;
            PortifolioURL = candidato.PortifolioURL;
            Disponibilidade = (int)candidato.Disponibilidade;
            HorarioDeTrabalho = (int)candidato.HorarioDeTrabalho;
            PretensaoRemuneracaoPorHora = candidato.PretensaoRemuneracaoPorHora;

            Localizacao = candidato.Localizacao != null ? new LocalizacaoDTO()
            {
                Cidade = candidato.Localizacao.Cidade,
                Estado = candidato.Localizacao.Estado
            } : new LocalizacaoDTO();

            InformacaoParaPagamento = candidato.InformacaoParaPagamento != null ? new InformacaoParaPagamentoDTO()
            {
                Agencia = candidato.InformacaoParaPagamento.Agencia,
                Banco = candidato.InformacaoParaPagamento.Banco,
                CPF = candidato.InformacaoParaPagamento.CPF,
                NomeTitular = candidato.InformacaoParaPagamento.NomeTitular,
                NumeroDaConta = candidato.InformacaoParaPagamento.NumeroDaConta,
                TipoDeConta = (int)candidato.InformacaoParaPagamento.TipoDeConta
            } : new InformacaoParaPagamentoDTO();

            Conhecimentos = candidato.Conhecimentos != null ? new ConhecimentosDTO()
            {
                Android = (int)candidato.Conhecimentos.Android,
                AngularJS = (int)candidato.Conhecimentos.AngularJS,
                AspNetMVC = (int)candidato.Conhecimentos.AspNetMVC,
                Bootstrap = (int)candidato.Conhecimentos.Bootstrap,
                C = (int?)candidato.Conhecimentos.C,
                Cake = (int?)candidato.Conhecimentos.Cake,
                CPlusPlus = (int?)candidato.Conhecimentos.CPlusPlus,
                CSS = (int?)candidato.Conhecimentos.CSS,
                Django = (int?)candidato.Conhecimentos.Django,
                HTML = (int?)candidato.Conhecimentos.HTML,
                Illustrator = (int?)candidato.Conhecimentos.Illustrator,
                Ionic = (int)candidato.Conhecimentos.Ionic,
                IOS = (int)candidato.Conhecimentos.IOS,
                Java = (int?)candidato.Conhecimentos.Java,
                JQuery = (int)candidato.Conhecimentos.JQuery,
                LinkCRUDRepository = candidato.Conhecimentos.LinkCRUDRepository,
                Magento = (int?)candidato.Conhecimentos.Magento,
                MySQL = (int?)candidato.Conhecimentos.MySQL,
                Outras = candidato.Conhecimentos.Outras,
                Photoshop = (int?)candidato.Conhecimentos.Photoshop,
                PHP = (int)candidato.Conhecimentos.PHP,
                Phyton = (int?)candidato.Conhecimentos.Phyton,
                Ruby = (int?)candidato.Conhecimentos.Ruby,
                SalesForce = (int?)candidato.Conhecimentos.SalesForce,
                SEO = (int?)candidato.Conhecimentos.SEO,
                SQLServer = (int?)candidato.Conhecimentos.SQLServer,
                Wordpress = (int)candidato.Conhecimentos.Wordpress,
            } : new ConhecimentosDTO();
        }

        public Candidato ToModel()
        {
            return new Candidato()
            {
                Conhecimentos = Conhecimentos != null ? new Conhecimentos()
                {
                    //Same Id / one to one relation
                    Id = Id,
                    Android = (Conhecimentos.NivelDeConhecimento)Conhecimentos.Android,
                    AngularJS = (Conhecimentos.NivelDeConhecimento)Conhecimentos.AngularJS,
                    AspNetMVC = (Conhecimentos.NivelDeConhecimento)Conhecimentos.AspNetMVC,
                    Bootstrap = (Conhecimentos.NivelDeConhecimento)Conhecimentos.Bootstrap,
                    C = (Conhecimentos.NivelDeConhecimento?)Conhecimentos.C,
                    Cake = (Conhecimentos.NivelDeConhecimento?)Conhecimentos.Cake,
                    CPlusPlus = (Conhecimentos.NivelDeConhecimento?)Conhecimentos.CPlusPlus,
                    CSS = (Conhecimentos.NivelDeConhecimento?)Conhecimentos.CSS,
                    Django = (Conhecimentos.NivelDeConhecimento?)Conhecimentos.Django,
                    HTML = (Conhecimentos.NivelDeConhecimento?)Conhecimentos.HTML,
                    Illustrator = (Conhecimentos.NivelDeConhecimento?)Conhecimentos.Illustrator,
                    Ionic = (Conhecimentos.NivelDeConhecimento)Conhecimentos.Ionic,
                    IOS = (Conhecimentos.NivelDeConhecimento)Conhecimentos.IOS,
                    Java = (Conhecimentos.NivelDeConhecimento?)Conhecimentos.Java,
                    JQuery = (Conhecimentos.NivelDeConhecimento)Conhecimentos.JQuery,
                    LinkCRUDRepository = Conhecimentos.LinkCRUDRepository,
                    Magento = (Conhecimentos.NivelDeConhecimento?)Conhecimentos.Magento,
                    MySQL = (Conhecimentos.NivelDeConhecimento?)Conhecimentos.MySQL,
                    Outras = Conhecimentos.Outras,
                    Photoshop = (Conhecimentos.NivelDeConhecimento?)Conhecimentos.Photoshop,
                    PHP = (Conhecimentos.NivelDeConhecimento)Conhecimentos.PHP,
                    Phyton = (Conhecimentos.NivelDeConhecimento?)Conhecimentos.Phyton,
                    Ruby = (Conhecimentos.NivelDeConhecimento?)Conhecimentos.Ruby,
                    SalesForce = (Conhecimentos.NivelDeConhecimento?)Conhecimentos.SalesForce,
                    SEO = (Conhecimentos.NivelDeConhecimento?)Conhecimentos.SEO,
                    SQLServer = (Conhecimentos.NivelDeConhecimento?)Conhecimentos.SQLServer,
                    Wordpress = (Conhecimentos.NivelDeConhecimento)Conhecimentos.Wordpress,
                } : new Conhecimentos(),
                InformacaoParaPagamento = InformacaoParaPagamento != null ? new InformacaoParaPagamento()
                {
                    //Same Id / one to one relation
                    Id = Id,
                    Agencia = InformacaoParaPagamento.Agencia,
                    Banco = InformacaoParaPagamento.Banco,
                    CPF = InformacaoParaPagamento.CPF,
                    NomeTitular = InformacaoParaPagamento.NomeTitular,
                    NumeroDaConta = InformacaoParaPagamento.NumeroDaConta,
                    TipoDeConta = (InformacaoParaPagamento.TiposDeConta)InformacaoParaPagamento.TipoDeConta,
                } : new InformacaoParaPagamento(),
                Linkedin = Linkedin,
                Localizacao = Localizacao != null ? new Localizacao()
                {
                    //Same Id / one to one relation
                    Id = Id,
                    Cidade = Localizacao.Cidade,
                    Estado = Localizacao.Estado,
                } : new Localizacao(),
                Disponibilidade = (Candidato.Disponibilidades)Disponibilidade,
                Email = Email,
                HorarioDeTrabalho = (Candidato.HorariosDeTrabalho)HorarioDeTrabalho,
                Nome = Nome,
                PortifolioURL = PortifolioURL,
                PretensaoRemuneracaoPorHora = PretensaoRemuneracaoPorHora,
                Skype = Skype,
                Telefone = Telefone,
                TelefoneEWhatsApp = TelefoneEWhatsApp,
                Id = Id
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
