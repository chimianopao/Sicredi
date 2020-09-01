using Sicredi.Base;
using Sicredi.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using static Sicredi.Controllers.SimuladorInvestimentoPoupancaController;

namespace Sicredi.Validations.FrontEnd
{
    public class SimuladorInvestimentoPoupancaFrontEndValidator
    {
        public void ValidacaoPadrao()
        {
            Driver.StartBrowser();
            
            var controller = new SimuladorInvestimentoPoupancaController();
            controller.FazSimulacao(400, 20, 12, Tempo.Meses);

            Driver.StopBrowser();
        }

        public void ValidacaoMenosQue20()
        {
            Driver.StartBrowser();

            var controller = new SimuladorInvestimentoPoupancaController();
            controller.FazSimulacao(5, 10, 12, Tempo.Meses);

            Driver.StopBrowser();
        }

        public void ValidacaoAnos()
        {
            Driver.StartBrowser();

            var controller = new SimuladorInvestimentoPoupancaController();
            controller.FazSimulacao(400, 20, 1, Tempo.Anos);

            Driver.StopBrowser();
        }

    }
}
