using System;
using System.Collections.Generic;
using System.Drawing;
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

        private string codigo;
        private string descripcion;
        private double precio;
        private int cantidad;

        public double Subtotal { get => subtotal; set => subtotal = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public double Impuesto { get => impuesto; set => impuesto = value; }
        public double Total { get => total; set => total = value; }
        public double TotalDevolucion { get => totalDevolucion; set => totalDevolucion = value; }
        public DateTime FechaTransaccion { get => fechaTransaccion; set => fechaTransaccion = value; }
        public string NumFactura { get => numFactura; set => numFactura = value; }
        public string IdVendedor { get => idVendedor; set => idVendedor = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public double CalculoSubtotal(double lista, int cantidad)
        {
            subtotal = lista * cantidad;
            return subtotal;
        }

        public double CalculoDescuento()
        {
            descuento = subtotal * 0.05;
            return descuento;
        }

        public double CalculoImpuesto()
        {
            impuesto = subtotal * 0.15;
            return impuesto;
        }

        public double CalculoTotal()
        {
            total = subtotal - descuento + impuesto;
            return total;
        }
    }
}