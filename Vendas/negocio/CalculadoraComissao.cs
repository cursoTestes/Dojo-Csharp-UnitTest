using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vendas.negocio
{
    public class CalculadoraComissao
    {
        public double calculaComissao(double totalVendas)
        {
            return Math.Round(totalVendas * 0.05, 2);
        }
    }
}
