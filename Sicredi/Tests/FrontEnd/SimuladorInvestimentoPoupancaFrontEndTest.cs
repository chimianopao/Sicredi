using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sicredi.Validations.FrontEnd;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sicredi.Tests.FrontEnd
{
    [TestClass()]
    public class SimuladorInvestimentoPoupancaFrontEndTest
    {
        /// <summary>
        /// Teste padrão com valores corretos.
        /// </summary>
        [TestMethod()]
        public void SimulaInvestimentoPoupanca()
        {
            var validator = new SimuladorInvestimentoPoupancaFrontEndValidator();
            validator.ValidacaoPadrao();
        }

        /// <summary>
        /// Teste com inputs menores que 20, para checar a mensagem de erro.
        /// </summary>
        [TestMethod()]
        public void SimulaInvestimentoPoupancaComErro()
        {
            var validator = new SimuladorInvestimentoPoupancaFrontEndValidator();
            validator.ValidacaoMenosQue20();
        }

        /// <summary>
        /// Teste selecionando unidade de tempos Anos ao invés de Meses.
        /// </summary>
        [TestMethod()]
        public void SimulaInvestimentoPoupancaAnos()
        {
            var validator = new SimuladorInvestimentoPoupancaFrontEndValidator();
            validator.ValidacaoAnos();
        }
    }
}
