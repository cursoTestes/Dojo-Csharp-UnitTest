using System;
using Vendas.negocio;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class CalculadoraComissaoUnitTest
    {
        [TestMethod]
        public void testaValor100EsperaRetorno5()
        {
            double totalVenda = 100;
            double comissaoEsperada = 5.0;


            CalculadoraComissao calculadora = new CalculadoraComissao();
            double comissaoObtida = calculadora.calculaComissao(totalVenda);

            Assert.AreEqual(comissaoEsperada, comissaoObtida);
        }

        [TestMethod]
        public void testaValor200EsperaRetorno10()
        {
            double totalVenda = 200;
            double comissaoEsperada = 10.0;


            CalculadoraComissao calculadora = new CalculadoraComissao();
            double comissaoObtida = calculadora.calculaComissao(totalVenda);

            Assert.AreEqual(comissaoEsperada, comissaoObtida);
        }

        [TestMethod]
        public void testaValor200e33centsEsperaRetorno10e1cent()
        {
            double totalVenda = 200.33;
            double comissaoEsperada = 10.01;


            CalculadoraComissao calculadora = new CalculadoraComissao();
            double comissaoObtida = calculadora.calculaComissao(totalVenda);

            Assert.AreEqual(comissaoEsperada, comissaoObtida);
        }
    }
}
