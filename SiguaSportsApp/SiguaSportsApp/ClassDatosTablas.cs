using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace SiguaSportsApp
{
    class ClassDatosTablas : ClassConexionBD
    {
        ClassEmpleados emp = new ClassEmpleados();
        public void CargarDatosDevoluciones(DataGridView dvg)
        {
            try
            {
                AbrirConexion();
                da = new SqlDataAdapter("SELECT B.nombre[Producto] , A.cantidad[Cantidad] , A.motivo[Motivo] ,C.fecha_devolucion[Fecha de Devolución]" +
                                         "FROM DevolucionDetalle A " +
                                         "INNER JOIN Productos B ON A.cod_producto = B.cod_producto" +
                                         "INNER JOIN Devoluciones C ON A.num_devolucion = C.num_devolucion where cod_estado = 1", sc);

                dt = new DataTable();
                da.Fill(dt);
                dvg.DataSource = dt;
                CerrarConexion();
            }
            catch (Exception error)
            {

                MessageBox.Show("No se pudieron cargar los datos: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void CargarDatosCambio(DataGridView dvg)
        {
            try
            {
                AbrirConexion();
                da = new SqlDataAdapter("SELECT (CONCAT(nombre, ' ', color, ' ', marca)) Descripcion, " +
                    "DD.cantidad Cantidad, DD.motivo Motivo, D.fecha_devolucion [Fecha Devolucion] " +
                    "FROM Devoluciones D inner join DevolucionDetalle DD " +
                    "on D.num_devolucion = DD.num_devolucion inner join Productos P " +
                    "on P.cod_producto = DD.cod_producto " +
                    "where cod_estado = 2", sc);

                dt = new DataTable();
                da.Fill(dt);
                dvg.DataSource = dt;
                CerrarConexion();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se pudieron cargar los datos: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CerrarConexion();
            }

        }

        public void EliminarEmpleado(DataGridView dgv)
        {
            AbrirConexion();
            int flag = 0;
            sql = string.Format("Delete from EmpleadodHistoricos where Codigo={0}", emp.Cod_empleado);
            cmd = new SqlCommand(sql, sc);
            flag = cmd.ExecuteNonQuery();

            if (flag == 1)
            {
                MessageBox.Show("La consulta se realizo correctamente. " +
                    "Se elimino el empleado, permanecera en la tabla empleados historicos.");
                CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se encontro el empleado.");
                CerrarConexion();
            }
        }

    }
}
