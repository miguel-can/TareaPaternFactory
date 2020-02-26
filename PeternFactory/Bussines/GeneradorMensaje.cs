using PaternFactory.Bussines.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternFactory.Bussines
{
    public class GeneradorMensaje : IGeneradorMensaje
    {
        public string GenerarMensaje(double _dImporte, string _cConcepto, string _cModalidad, bool _lAprobado)
        {
            return string.Format("Pedido {0} con importe {1} en {2} fue {3}", _cConcepto, _dImporte, 
                _cModalidad, _lAprobado ? "Autorizado" : "Rechazado");
        }
    }
}
