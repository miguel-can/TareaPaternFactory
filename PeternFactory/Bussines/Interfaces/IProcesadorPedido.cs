using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternFactory.Interfaces
{
    public interface IProcesadorPedido
    {
        string ProcesarPago(double _dImporte, double _dImporteCompara, string _cConcepto, string _cModalidad);
    }
}
