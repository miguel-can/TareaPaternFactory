using PaternFactory.Factory;
using PaternFactory.Interface;
using PaternFactory.Interfaces;
using System;
using PaternFactory.Bussines.Interfaces;
using PaternFactory.Bussines;

namespace PaternFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ITipoPagoFactory svrTipoPagoFactory = null;
            ITipoPago svrTipoPago;
            IProcesadorPedido svrProcesadorPago;
            IGeneradorMensaje svrGeneradorMensaje;

            int iOpcion = 0;
            string cRespuesta = string.Empty, cConcepto = string.Empty, cModalidad = string.Empty;
            double dImporte = 0;
            double dImporteComparar = 5000;

            Console.WriteLine("**** Sistema de pedidos *****");
            Console.WriteLine("Proporcione el concepto");
            cConcepto = Console.ReadLine();

            Console.WriteLine("Proporcione el importe");
            double.TryParse(Console.ReadLine(), out dImporte);

            Console.WriteLine("Proporcione el Tipo de Pago:");
            Console.WriteLine("Pago Efectivo: 1");
            Console.WriteLine("Pago Crédito: 2");

            int.TryParse(Console.ReadLine(), out iOpcion);

            switch (iOpcion)
            {
                case 1:
                    svrTipoPagoFactory = new TipoPagoEfectivoFactory();
                    cModalidad = "EFECTVO";
                    break;
                case 2:
                    svrTipoPagoFactory = new TipoPagoCreditoFactory();
                    cModalidad = "CRÉDITO";
                    break;
                default:
                    Console.WriteLine("Indique un Tipo de Pago correcto");
                    break;
            }
         
            if(svrTipoPagoFactory != null)
            {
                svrTipoPago = svrTipoPagoFactory.ObtenerIntanciaPago();
                svrGeneradorMensaje = new GeneradorMensaje();
                svrProcesadorPago = new ProcesadorPedido(svrTipoPago, svrGeneradorMensaje);
                cRespuesta = svrProcesadorPago.ProcesarPago(dImporte, dImporteComparar, cConcepto, cModalidad);
                Console.WriteLine(cRespuesta);
            }
                                    
            Console.Write("Presiona cualquier tecla para salir del programa...");
            Console.ReadKey();

        }
    }
}
