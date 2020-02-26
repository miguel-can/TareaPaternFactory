using PaternFactory.Interface;

namespace PaternFactory.Factory
{
    public class TipoPagoEfectivoFactory : ITipoPagoFactory
    {
        public ITipoPago ObtenerIntanciaPago()
        {
            return new TipoPagoEfectivo();
        }
    }
}
