using OpenQA.Selenium;
using Sicredi.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sicredi.ViewMaps
{
    public class SimuladorInvestimentoPoupancaViewMap : BasePageViewMap
    {
        #region Busca
        public IWebElement BtnAccordionOverview => GetWebElementByXPath("//p-accordiontab/div/a/span[contains(text(), 'Overview')]");
        public IWebElement InputValorAplicacao => GetWebElementById("valorAplicar");
        public IWebElement InputValorPorMes => GetWebElementById("valorInvestir");
        public IWebElement InputTempo => GetWebElementById("tempo");
        public void DropDownTempo(string tempo)
        {
            GetWebElementByXPath("//*[@id='formInvestimento']/div[4]/div[2]/div[2]/a").Click();
            GetWebElementByXPath($"//*[@id='formInvestimento']/div[4]/div[2]/div[2]/ul/li//a[contains(text(), '{tempo}')]").Click();
        }
        public IWebElement ButtonSimular => GetWebElementByClassName("simular");
        #endregion

        #region Erros
        public IWebElement TxtErroValorAplicacao => GetWebElementById("valorAplicar-error");
        public IWebElement TxtErroValorPorMes => GetWebElementById("valorInvestir-error");
        #endregion

        #region Resultado
        public IWebElement TxtTextoResultado => GetWebElementByXPath("/html/body/div[3]/div/div/div[1]/div/div[2]/span[1]");
        public IWebElement TxtValorResultado => GetWebElementByXPath("/html/body/div[3]/div/div/div[1]/div/div[2]/span[2]");

        public IWebElement Txt1Tempo => GetWebElementByXPath("//table/tbody/tr[1]/td[1]");
        public IWebElement Txt1Valor => GetWebElementByXPath("//table/tbody/tr[1]/td[2]");
        public IWebElement Txt2Tempo => GetWebElementByXPath("//table/tbody/tr[2]/td[1]");
        public IWebElement Txt2Valor => GetWebElementByXPath("//table/tbody/tr[2]/td[2]");
        public IWebElement Txt3Tempo => GetWebElementByXPath("//table/tbody/tr[3]/td[1]");
        public IWebElement Txt3Valor => GetWebElementByXPath("//table/tbody/tr[3]/td[2]");
        public IWebElement Txt4Tempo => GetWebElementByXPath("//table/tbody/tr[4]/td[1]");
        public IWebElement Txt4Valor => GetWebElementByXPath("//table/tbody/tr[4]/td[2]");
        #endregion
    }
}
