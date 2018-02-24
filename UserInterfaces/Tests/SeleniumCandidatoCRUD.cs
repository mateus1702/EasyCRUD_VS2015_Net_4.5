using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Tests
{
    [TestClass]
    public class SeleniumCandidatoCRUD
    {
        private static Random RandomGenerator = new Random();

        private static string siteURL = "http://localhost:50754/";

        [TestMethod]
        public void SeleniumCreate()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(siteURL);

                driver.FindElement(By.LinkText("Clique aqui para começar!")).Click();


                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Cadastrar")).Displayed);

                driver.FindElement(By.LinkText("Cadastrar")).Click();


                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.Id("Nome")).Displayed);

                driver.FindElement(By.Id("Nome")).SendKeys($"Nome Candidato");
                driver.FindElement(By.Id("Email")).SendKeys("candidato@candidato.com");
                driver.FindElement(By.Id("Skype")).SendKeys("candidatoSkype");
                driver.FindElement(By.Id("Telefone")).SendKeys("7736114578");
                driver.FindElement(By.Id("TelefoneEWhatsApp")).Click();
                driver.FindElement(By.Id("Linkedin")).SendKeys("candidadoLinkedin");
                driver.FindElement(By.Id("Cidade")).SendKeys("cidade do candidato");
                driver.FindElement(By.Id("Estado")).SendKeys("estado do candidato");

                driver.FindElement(By.Id("Nome")).Submit();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.Id("Ate4HorasPorDia")).Displayed);

                driver.FindElements(By.Name("Disponibilidade"))[RandomGenerator.Next(5)].Click();
                driver.FindElements(By.Name("HorarioDeTrabalho"))[RandomGenerator.Next(5)].Click();
                driver.FindElement(By.Id("PretensaoRemuneracaoPorHora")).SendKeys("123,123");

                driver.FindElement(By.Name("Disponibilidade")).Submit();


                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.Name("Ionic")).Displayed);

                driver.FindElements(By.Name("Ionic"))[RandomGenerator.Next(5)].Click();
                driver.FindElements(By.Name("Android"))[RandomGenerator.Next(5)].Click();
                driver.FindElements(By.Name("IOS"))[RandomGenerator.Next(5)].Click();
                driver.FindElements(By.Name("Bootstrap"))[RandomGenerator.Next(5)].Click();
                driver.FindElements(By.Name("JQuery"))[RandomGenerator.Next(5)].Click();
                driver.FindElements(By.Name("AngularJS"))[RandomGenerator.Next(5)].Click();
                driver.FindElements(By.Name("AspNetMVC"))[RandomGenerator.Next(5)].Click();
                driver.FindElements(By.Name("PHP"))[RandomGenerator.Next(5)].Click();
                driver.FindElements(By.Name("Wordpress"))[RandomGenerator.Next(5)].Click();

                driver.FindElement(By.Name("Ionic")).Submit();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.Id("NomeTitular")).Displayed);

                driver.FindElement(By.Id("NomeTitular")).SendKeys("candidato nome titular");
                driver.FindElement(By.Id("CPF")).SendKeys("75375462400");
                driver.FindElement(By.Id("Banco")).SendKeys("candidato banco");
                driver.FindElement(By.Id("Agencia")).SendKeys("candidato agencia");
                driver.FindElement(By.Id("NumeroDaConta")).SendKeys("candidato numero conta");
                driver.FindElements(By.Name("TipoDeConta"))[RandomGenerator.Next(2)].Click();

                driver.FindElement(By.Id("NomeTitular")).Submit();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Cadastar novamente")).Displayed);
            }
        }

        [TestMethod]
        public void SeleniumRead()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(siteURL);

                driver.FindElement(By.LinkText("Clique aqui para começar!")).Click();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Visualizar")).Displayed);

                driver.FindElement(By.LinkText("Visualizar")).Click();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Voltar a listagem")).Displayed);               
            }
        }

        [TestMethod]
        public void SeleniumUpdate()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(siteURL);

                driver.FindElement(By.LinkText("Clique aqui para começar!")).Click();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Editar")).Displayed);

                driver.FindElement(By.LinkText("Editar")).Click();


                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.Id("Nome")).Displayed);

                driver.FindElement(By.Id("Nome")).Clear();
                driver.FindElement(By.Id("Nome")).SendKeys($"Nome Candidato {RandomGenerator.Next(99)}");
                driver.FindElement(By.Id("Email")).Clear();
                driver.FindElement(By.Id("Email")).SendKeys($"candidato@candidato{RandomGenerator.Next(99)}.com");
                driver.FindElement(By.Id("Skype")).Clear();
                driver.FindElement(By.Id("Skype")).SendKeys($"candidatoSkype{RandomGenerator.Next(99)}");
                driver.FindElement(By.Id("Telefone")).Clear();
                driver.FindElement(By.Id("Telefone")).SendKeys($"7736114578{RandomGenerator.Next(99)}");
                driver.FindElement(By.Id("TelefoneEWhatsApp")).Click();
                driver.FindElement(By.Id("Linkedin")).Clear();
                driver.FindElement(By.Id("Linkedin")).SendKeys($"candidadoLinkedin {RandomGenerator.Next(99)}");
                driver.FindElement(By.Id("Cidade")).Clear();
                driver.FindElement(By.Id("Cidade")).SendKeys($"cidade do candidato {RandomGenerator.Next(99)}");
                driver.FindElement(By.Id("Estado")).Clear();
                driver.FindElement(By.Id("Estado")).SendKeys($"estado do candidato {RandomGenerator.Next(99)}");

                driver.FindElement(By.Id("Nome")).Submit();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.Id("Ate4HorasPorDia")).Displayed);

                driver.FindElements(By.Name("Disponibilidade"))[RandomGenerator.Next(5)].Click();
                driver.FindElements(By.Name("HorarioDeTrabalho"))[RandomGenerator.Next(5)].Click();
                driver.FindElement(By.Id("PretensaoRemuneracaoPorHora")).Clear();
                driver.FindElement(By.Id("PretensaoRemuneracaoPorHora")).SendKeys($"{RandomGenerator.Next(99)},{RandomGenerator.Next(99)}");

                driver.FindElement(By.Name("Disponibilidade")).Submit();


                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.Name("Ionic")).Displayed);

                driver.FindElements(By.Name("Ionic"))[RandomGenerator.Next(5)].Click();
                driver.FindElements(By.Name("Android"))[RandomGenerator.Next(5)].Click();
                driver.FindElements(By.Name("IOS"))[RandomGenerator.Next(5)].Click();
                driver.FindElements(By.Name("Bootstrap"))[RandomGenerator.Next(5)].Click();
                driver.FindElements(By.Name("JQuery"))[RandomGenerator.Next(5)].Click();
                driver.FindElements(By.Name("AngularJS"))[RandomGenerator.Next(5)].Click();
                driver.FindElements(By.Name("AspNetMVC"))[RandomGenerator.Next(5)].Click();
                driver.FindElements(By.Name("PHP"))[RandomGenerator.Next(5)].Click();
                driver.FindElements(By.Name("Wordpress"))[RandomGenerator.Next(5)].Click();

                driver.FindElement(By.Name("Ionic")).Submit();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.Id("NomeTitular")).Displayed);

                driver.FindElement(By.Id("NomeTitular")).Clear();
                driver.FindElement(By.Id("NomeTitular")).SendKeys($"candidato nome titular {RandomGenerator.Next(99)}");
                driver.FindElement(By.Id("CPF")).Clear();
                driver.FindElement(By.Id("CPF")).SendKeys("56463961310");
                driver.FindElement(By.Id("Banco")).Clear();
                driver.FindElement(By.Id("Banco")).SendKeys($"candidato banco {RandomGenerator.Next(99)}");
                driver.FindElement(By.Id("Agencia")).Clear();
                driver.FindElement(By.Id("Agencia")).SendKeys($"candidato agencia {RandomGenerator.Next(99)}");
                driver.FindElement(By.Id("NumeroDaConta")).Clear();
                driver.FindElement(By.Id("NumeroDaConta")).SendKeys($"candidato numero conta {RandomGenerator.Next(99)}");
                driver.FindElements(By.Name("TipoDeConta"))[RandomGenerator.Next(2)].Click();

                driver.FindElement(By.Id("NomeTitular")).Submit();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Visualizar candidato")).Displayed);
            }
        }

        [TestMethod]
        public void SeleniumDelete()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(siteURL);

                driver.FindElement(By.LinkText("Clique aqui para começar!")).Click();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Deletar")).Displayed);

                driver.FindElement(By.LinkText("Deletar")).Click();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Voltar a listagem")).Displayed);

                driver.FindElement(By.ClassName("btn")).Click();

                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).
                Until(x => x.FindElement(By.LinkText("Voltar a listagem")).Displayed);                
            }
        }
    }
}
