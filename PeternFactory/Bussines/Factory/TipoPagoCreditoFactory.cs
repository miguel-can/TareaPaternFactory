using PaternFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternFactory.Factory
{
    public class TipoPagoCreditoFactory : ITipoPagoFactory
    {
        public ITipoPago ObtenerIntanciaPago()
        {
            return new TipoPagoCredito();
        }
    }
}
