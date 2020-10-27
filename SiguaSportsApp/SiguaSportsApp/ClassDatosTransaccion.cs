using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiguaSportsApp
{
    class ClassDatosTransaccion
    {
        private double subtotal;
        private double descuento;
        private double impuesto;
        private double total;
        private double totalDevolucion;
        private DateTime fechaTransaccion;
        private string numFactura;
        private string idVendedor;

        public double Subtotal { get => subtotal; set => subtotal = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public double Impuesto { get => impuesto; set => impuesto = value; }
        public double Total { get => total; set => total = value; }
        public double TotalDevolucion { get => totalDevolucion; set => totalDevolucion = value; }
        public DateTime FechaTransaccion { get => fechaTransaccion; set => fechaTransaccion = value; }
        public string NumFactura { get => numFactura; set => numFactura = value; }
        public string IdVendedor { get => idVendedor; set => idVendedor = value; }

        public double CalculoSubtotal()
        {
            return subtotal;
        }

        public double CalculoDescuento()
        {
            return descuento;
        }

        public double CalculoImpuesto()
        {
            return impuesto;
        }

        public double CalculoTotal()
        {
            return total;
        }
    }
}
