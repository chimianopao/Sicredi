using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Sicredi.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sicredi.Validations.BackEnd
{
    public class SimuladorInvestimentoPoupancaBackEndValidator
    {
        public void ValidaServicoSimuladorPoupanca()
        {
            string dados = "{\"id\":1,\"meses\":[\"112\",\"124\",\"136\",\"148\"],\"valor\":[\"2.802\",\"3.174\",\"3.564\",\"3.971\"]}";

            var service = new InvestimentoService();
            var result = service.GetService().Content;
            Assert.AreEqual(result, dados,"O resultado difere do valor esperado.");
        }
    }
}