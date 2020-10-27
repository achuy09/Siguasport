using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiguaSportsApp
{
    class ClassEmpleados
    {
        private int cod_empleado;
        private string nombre_empleado;
        private string apellidos_empleado;
        private float numID; 
        private string direccion;
        private string telefono;
        private string genero;
        private DateTime fecha_naci;

        public int Cod_empleado { get => cod_empleado; set => cod_empleado = value; }
        public string Nombre_empleado { get => nombre_empleado; set => nombre_empleado = value; }
        public string Apellidos_empleado { get => apellidos_empleado; set => apellidos_empleado = value; }
        public float NumID { get => numID; set => numID = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Genero { get => genero; set => genero = value; }
        public DateTime Fecha_naci { get => fecha_naci; set => fecha_naci = value; }
    }
}
