using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternFactory.Interface
{
    public interface ITipoPagoFactory
    {
        ITipoPago ObtenerIntanciaPago();
    }
}
