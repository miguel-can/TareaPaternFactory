using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternFactory
{
    public interface ITipoPago
    {
        bool ValidarImportePago(double dImporte, double dImporteCompara);
    }
}
