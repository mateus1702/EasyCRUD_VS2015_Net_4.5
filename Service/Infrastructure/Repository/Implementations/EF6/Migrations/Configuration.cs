namespace EF6.Migrations
{
    using DomainModel;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EF6_DbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(EF6.EF6_DbContext context)
        {
            context.Set<Candidato>().Add(new Candidato()
            {
                Nome = "Mateus Ribeiro de Oliveira",
                Email = "mateus@mateusribeiroliveira.com",
                Linkedin = "https://www.linkedin.com/in/mateus-oliveira-a0819b2a/",
                Localizacao = new Localizacao()
                {
                    Cidade = "Barreiras",
                    Estado = "Bahia"
                },
                Telefone = "77999046252",
                Skype = "Mateus1702",
                TelefoneEWhatsApp = true,
                Disponibilidade = Candidato.Disponibilidades.Ate4HorasPorDia,
                HorarioDeTrabalho = Candidato.HorariosDeTrabalho.De13as18,
                PretensaoRemuneracaoPorHora = 35,                
                PortifolioURL = "https://github.com/mateus1702",
                Conhecimentos = new Conhecimentos()
                {
                    Android = Conhecimentos.NivelDeConhecimento.dois,
                    AngularJS = Conhecimentos.NivelDeConhecimento.quatro,
                    AspNetMVC = Conhecimentos.NivelDeConhecimento.quatro,
                    Bootstrap = Conhecimentos.NivelDeConhecimento.quatro,
                    C = Conhecimentos.NivelDeConhecimento.tres,
                    Cake = Conhecimentos.NivelDeConhecimento.um,
                    CPlusPlus = Conhecimentos.NivelDeConhecimento.dois,
                    CSS = Conhecimentos.NivelDeConhecimento.tres,
                    Django = Conhecimentos.NivelDeConhecimento.um,
                    HTML = Conhecimentos.NivelDeConhecimento.quatro,
                    Illustrator = Conhecimentos.NivelDeConhecimento.um,
                    Ionic = Conhecimentos.NivelDeConhecimento.tres,
                    IOS = Conhecimentos.NivelDeConhecimento.um,
                    Java = Conhecimentos.NivelDeConhecimento.tres,
                    JQuery = Conhecimentos.NivelDeConhecimento.quatro,
                    Magento = Conhecimentos.NivelDeConhecimento.um,
                    MySQL = Conhecimentos.NivelDeConhecimento.tres,
                    LinkCRUDRepository = "https://github.com/mateus1702",
                    Outras = "React Native - 4 / React - 4",
                    Photoshop = Conhecimentos.NivelDeConhecimento.tres,
                    PHP = Conhecimentos.NivelDeConhecimento.tres,
                    Phyton = Conhecimentos.NivelDeConhecimento.um,
                    Ruby = Conhecimentos.NivelDeConhecimento.um,
                    SalesForce = Conhecimentos.NivelDeConhecimento.um,
                    SEO = Conhecimentos.NivelDeConhecimento.tres,
                    SQLServer = Conhecimentos.NivelDeConhecimento.tres,
                    Wordpress = Conhecimentos.NivelDeConhecimento.um                    
                },
                InformacaoParaPagamento = new InformacaoParaPagamento()
                {
                    NomeTitular = "Mateus R Oliveira",
                    CPF = "69684359187",
                    Banco = "Itau",
                    Agencia = "1010",
                    NumeroDaConta = "096806",
                    TipoDeConta = InformacaoParaPagamento.TiposDeConta.Corrente
                }
            });

            context.Set<Candidato>().Add(new Candidato()
            {
                Nome = "satoshi nakamoto",
                Email = "satoshi@nakamoto.com",
                Linkedin = "https://www.linkedin.com/in/satoshi-nakamoto-a0819b2a/",
                Localizacao = new Localizacao()
                {
                    Cidade = "Tokio",
                    Estado = "Kanto"
                },
                Telefone = "31245984",
                Skype = "satoshiNakamoto",
                TelefoneEWhatsApp = true,
                Disponibilidade = Candidato.Disponibilidades.AcimaDe8HorasPorDia,
                HorarioDeTrabalho = Candidato.HorariosDeTrabalho.De22emDiante,
                PretensaoRemuneracaoPorHora = 60,
                PortifolioURL = "https://github.com/satoshi",
                Conhecimentos = new Conhecimentos()
                {
                    Android = Conhecimentos.NivelDeConhecimento.um,
                    AngularJS = Conhecimentos.NivelDeConhecimento.um,
                    AspNetMVC = Conhecimentos.NivelDeConhecimento.um,
                    Bootstrap = Conhecimentos.NivelDeConhecimento.um,
                    C = Conhecimentos.NivelDeConhecimento.um,
                    Cake = Conhecimentos.NivelDeConhecimento.um,
                    CPlusPlus = Conhecimentos.NivelDeConhecimento.um,
                    CSS = Conhecimentos.NivelDeConhecimento.um,
                    Django = Conhecimentos.NivelDeConhecimento.um,
                    HTML = Conhecimentos.NivelDeConhecimento.um,
                    Illustrator = Conhecimentos.NivelDeConhecimento.um,
                    Ionic = Conhecimentos.NivelDeConhecimento.um,
                    IOS = Conhecimentos.NivelDeConhecimento.um,
                    Java = Conhecimentos.NivelDeConhecimento.um,
                    JQuery = Conhecimentos.NivelDeConhecimento.um,
                    Magento = Conhecimentos.NivelDeConhecimento.um,
                    MySQL = Conhecimentos.NivelDeConhecimento.um,
                    LinkCRUDRepository = "https://github.com/satoshi",
                    Outras = "I created the blockchain technology.",
                    Photoshop = Conhecimentos.NivelDeConhecimento.um,
                    PHP = Conhecimentos.NivelDeConhecimento.um,
                    Phyton = Conhecimentos.NivelDeConhecimento.um,
                    Ruby = Conhecimentos.NivelDeConhecimento.um,
                    SalesForce = Conhecimentos.NivelDeConhecimento.um,
                    SEO = Conhecimentos.NivelDeConhecimento.um,
                    SQLServer = Conhecimentos.NivelDeConhecimento.um,
                    Wordpress = Conhecimentos.NivelDeConhecimento.um
                },
                InformacaoParaPagamento = new InformacaoParaPagamento()
                {
                    NomeTitular = "Satoshi Nakamoto",
                    CPF = "01674220812",
                    Banco = "1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa",
                    Agencia = "1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa",
                    NumeroDaConta = "1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa",
                    TipoDeConta = InformacaoParaPagamento.TiposDeConta.Corrente
                }
            });



            context.SaveChanges();
        }
    }
}
