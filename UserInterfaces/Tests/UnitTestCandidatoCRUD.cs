using System;
using System.Linq;
using DomainModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceModel.DTO;
using ServiceModel.Services;

namespace Tests
{
    [TestClass]
    public class UnitTestCandidatoCRUD
    {
        private static Random RandomGenerator = new Random();

        [TestMethod]
        public void UnitCadastrar()
        {
            CandidatoService service = new CandidatoService();

            var candidatoDTO = new CandidatoDTO(
                new Candidato()
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

            var Id = service.CreateCandidato(candidatoDTO);

            Assert.IsTrue(Id > 0);
        }

        [TestMethod]
        public void UnitRead()
        {
            CandidatoService service = new CandidatoService();

            var modelId = service.ListCandidatos().First().Id;

            var readModel = service.ReadCandidato(modelId);

            Assert.IsTrue(readModel != null);
        }

        [TestMethod]
        public void UnitUpdate()
        {
            CandidatoService service = new CandidatoService();

            var modelId = service.ListCandidatos().First().Id;

            var oldModel = service.ReadCandidato(modelId);

            var randomNumber = RandomGenerator.Next(99); 
            oldModel.Nome = randomNumber.ToString();

            service.UpdateCandidato(oldModel);

            var changedModel = service.ReadCandidato(modelId);

            
            Assert.IsTrue(changedModel.Nome == oldModel.Nome);
        }

        [TestMethod]
        public void UnitDelete()
        {
            CandidatoService service = new CandidatoService();

            var modelId = service.ListCandidatos().First().Id;

            service.DeleteCandidato(modelId);

            var deletedModel = service.ReadCandidato(modelId);            

            Assert.IsTrue(deletedModel == null);
        }
    }
}
