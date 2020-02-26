using PaternFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaternFactory.Bussines.Interfaces;

namespace PaternFactory
{
    class ProcesadorPedido : IProcesadorPedido
    {
        ITipoPago svrTipoPago;
        IGeneradorMensaje svrGeneradorMensaje;
        
        public ProcesadorPedido(ITipoPago _svrTipoPago, IGeneradorMensaje _svrGeneradorMensaje)
        {
            this.svrTipoPago = _svrTipoPago;
            this.svrGeneradorMensaje = _svrGeneradorMensaje;
        }
        public string ProcesarPago(double _dImporte, double _dImporteCompara, string _cConcepto, string _cModalidad)
        {
            bool lPagoAprobado = false;
            lPagoAprobado = this.svrTipoPago.ValidarImportePago(_dImporte, _dImporteCompara);
            return this.svrGeneradorMensaje.GenerarMensaje(_dImporte, _cConcepto, _cModalidad, lPagoAprobado);
        }
    }
}
