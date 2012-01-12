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
            return Math.Floor(5.0 * totalVendas) / 100;
        }
    }
}
