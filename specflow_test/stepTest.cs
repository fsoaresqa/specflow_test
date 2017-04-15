using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;


namespace specflow_test
{
    [Binding]


    class stepTest
    {
        //declarar o Selenium WebDriver..
        private IWebDriver driver;


        //testando

        [Given(@"que acesse a pagina ""(.*)""")]
        public void DadoQueAcesseAPagina(string url)
        {
            //driver = new FirefoxDriver();
            //inicializar o driver do selenium para o google chrome..
            driver = new ChromeDriver("c:\\"); //pasta onde esta o driver do chrome..
            //acessar a página...
            driver.Navigate().GoToUrl(url);
        }

        [Given(@"faça a pesquisa (.*)")]
        public void DadoFacaAPesquisa(string pesquisa)
        {
            driver.FindElement(By.Id("searchInput")).Clear();
            driver.FindElement(By.Id("searchInput")).SendKeys(pesquisa);
        }

        [When(@"acionar o botão")]
        public void QuandoAcionarOBotao()
        {
            driver.FindElement(By.Id("searchButton")).Click();

        }

        [Then(@"resultado é exibido ""(.*)""")]
  
        public void EntaoResultadoEExibido(string paginasucesso)
        {
            //Ler a mensagem para verificação da pagina que está logado
            string resultado = driver.FindElement(By.Id("firstHeading")).Text;
            //Comparar a variavel resultado com a mensagem da feature
            Assert.IsTrue(resultado.Contains(paginasucesso));
        }

        [Then(@"fechar pagina")]
        public void EntaoFecharPagina()
        {
            driver.Quit();
        }



    }
}
