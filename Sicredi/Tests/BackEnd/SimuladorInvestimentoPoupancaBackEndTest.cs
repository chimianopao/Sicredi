using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using Sicredi.Services;
using Sicredi.Validations.BackEnd;
using System;
using System.Collections.Generic;
using System.Text;
//using FluentAssertions;

namespace Sicredi.Tests.BackEnd
{
    [TestClass()]
    public class SimuladorInvestimentoPoupancaBackEndTest
    {
        /// <summary>
        /// Teste da API.
        /// </summary>
        [TestMethod()]
        public void SimulaInvestimentoPoupanca()
        {
            var validator = new SimuladorInvestimentoPoupancaBackEndValidator();
            validator.ValidaServicoSimuladorPoupanca();
        }
    }
}
