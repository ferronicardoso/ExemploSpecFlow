using ExemploSpecFlow.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Xunit;

namespace ExemploSpecFlow.Steps
{
    [Binding]
    public sealed class GoogleSearchSteps
    {
        /* REFERENCES
         *      https://cucumber.io
         *      https://cucumber.io/docs/gherkin 
         *      https://cucumber.io/docs/gherkin/reference
         *      https://cucumber.io/docs/gherkin/step-organization
         *      https://specflow.org
         *      https://specflow.org/documentation
         *      https://specflow.org/documentation/Using-Gherkin-Language-in-SpecFlow
         *      https://www.seleniumhq.org
         *      https://www.seleniumhq.org/download/#thirdPartyDrivers
         */

        private readonly WebDriver _webDriver;

        public GoogleSearchSteps(WebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [Given(@"que o usuário acesse o link '(.*)'")]
        public void DadoQueOUsuarioAcesseOLink(string link)
        {
            _webDriver.Current.Manage().Window.Maximize();
            _webDriver.Current.Navigate().GoToUrl(link);
        }

        [Given(@"informe o termo '(.*)' para ser pesquisado")]
        public void DadoInformeOTermoParaSerPesquisado(string termo)
        {
            var el = _webDriver.Wait.Until(u => u.FindElement(By.Name("q")));
            el.SendKeys(termo);
        }

        [When(@"a tecla Enter for pressionada")]
        public void QuandoATeclaEnterForPressionada()
        {
            var el = _webDriver.Wait.Until(u => u.FindElement(By.Name("q")));
            el.SendKeys(Keys.Return);
        }

        [Then(@"o resultado será apresentado na primeira posição com o '(.*)'")]
        public void EntaoOResultadoSeraApresentadoNaPrimeiraPosicao(string link)
        {
            var el = _webDriver.Wait.Until(u => u.FindElement(By.CssSelector("div.r > a:nth-child(1)")));
            var href = el.GetAttribute("href");

            Assert.Contains(link, href);

            _webDriver.Quit();
        }
    }
}
