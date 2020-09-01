using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sicredi.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sicredi.Controllers
{
    public class BasePageController
    {
        protected readonly string url = "https://www.sicredi.com.br/html/ferramenta/simulador-investimento-poupanca/";

        public BasePageController() { }

        public BasePageController(string url)
        {
            this.url = url;
        }

        protected void Navigate()
        {
            try
            {
                Driver.Browser.Navigate().GoToUrl(url);
            }
            catch (Exception e)
            {
                Assert.Fail($"Erro ao acessar o site. Detalhes do erro: {e.Message}");
            }
        }
    }
}
