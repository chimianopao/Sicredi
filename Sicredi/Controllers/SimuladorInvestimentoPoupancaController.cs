using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sicredi.Base;
using Sicredi.ViewMaps;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sicredi.Controllers
{
    public class SimuladorInvestimentoPoupancaController : BasePageController
    {
        public enum Tempo { Meses, Anos };

        SimuladorInvestimentoPoupancaViewMap map = new SimuladorInvestimentoPoupancaViewMap();
        public void FazSimulacao(double valorAplicacao, double valorPorMes, double valorTempo, Tempo unidadeTempo)
        {
            base.Navigate();
            map.InputValorAplicacao.SendKeys(valorAplicacao.ToString("#.00"));
            map.InputValorPorMes.SendKeys(valorPorMes.ToString("#.00"));
            map.InputTempo.SendKeys(valorTempo.ToString("#.00"));
            
            if (unidadeTempo == Tempo.Anos) { 
                map.DropDownTempo(unidadeTempo.ToString());
                valorTempo *= 12;
            }

            map.ButtonSimular.Click();

            Driver.Wait(3000);

            if (valorAplicacao < 20)
                Assert.IsTrue(map.TxtErroValorAplicacao.Text.Equals("Valor mínimo de 20.00"));

            else if (valorPorMes < 20)
                Assert.IsTrue(map.TxtErroValorPorMes.Text.Equals("Valor mínimo de 20.00"));

            else
            {
                Assert.IsTrue(map.TxtTextoResultado.Text.Equals($"Em {valorTempo} meses você terá guardado"),$"Tempo em meses não bate com o informado.");
                Assert.IsTrue(map.TxtValorResultado.Text.Equals($"R$ 647"),"Cálculo de rendimento incorreto");
                Assert.IsTrue(VerificaResultado(valorAplicacao, valorPorMes, valorTempo),"Cálculo dos próximos 4 anos incorreto");
            }
        }

        private bool VerificaResultado(double valorAplicacao, double valorPorMes, double valorTempo)
        {
            bool result = true;
            if (!map.Txt1Tempo.Text.Equals("24"))
                result = false;
            if (!map.Txt1Valor.Text.Equals("R$ 898"))
                result = false;
            if (!map.Txt2Tempo.Text.Equals("36"))
                result = false;
            if (!map.Txt2Valor.Text.Equals("R$ 1.152"))
                result = false;
            if (!map.Txt3Tempo.Text.Equals("48"))
                result = false;
            if (!map.Txt3Valor.Text.Equals("R$ 1.409"))
                result = false;
            if (!map.Txt4Tempo.Text.Equals("60"))
                result = false;
            if (!map.Txt4Valor.Text.Equals("R$ 1.671"))
                result = false;

            return result;
        }
    }
}
