using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternFactory.Bussines.Interfaces
{
    public interface IGeneradorMensaje
    {
        string GenerarMensaje(double _dImporte, string _cConcepto, string _cModalidad, bool _lAprobado);
    }
}
