using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternFactory
{
    public class TipoPagoCredito : ITipoPago
    {
        public bool ValidarImportePago(double dImporte, double dImporteCompara)
        {
            return (dImporte > dImporteCompara);
        }
    }
}
