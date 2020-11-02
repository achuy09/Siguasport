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
        public void CargarDatosTablas(DataGridView dvg, string query)
        {
            try
            {
                AbrirConexion();
                da = new SqlDataAdapter(query, sc);
                dt = new DataTable();
                da.Fill(dt);
                dvg.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show("No se pudieron cargar los datos: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CerrarConexion();
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
                    "Se elimino el empleado, permanecera en la tabla empleados historicos.", "Empleado Historico", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else
            {
                MessageBox.Show("No se encontro el empleado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CerrarConexion();
        }

        public void AgregarDatos(string codigo, int cantidad)
        {
            string mensaje = "";

            sql = string.Format("if exists(Select cod_producto from Productos where cod_producto = @codigo) begin" +
                "SELECT existencia, cod_producto [Codigo Producto], " +
                "CONCAT(nombre, ' ', marca, ' ', color) [Descripcion], precioVenta [Precio Unitario], " +
                "SUM(existencia - (existencia - @cantidad)) Cantidad FROM Productos P where cod_producto = {0} " +
                "group by existencia, cod_producto, nombre, marca, color, precioVenta" +
                "end else begin select 'No se encontro el producto.' Mensaje end", codigo);
            cmd = new SqlCommand(sql, sc);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);
            AbrirConexion();

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                mensaje = reader["Mensaje"].ToString();
            }
            CerrarConexion();
            if (mensaje == "")
            {
                ClassDatosTransaccion datos = new ClassDatosTransaccion();
                AbrirConexion();
                if (reader.Read())
                {
                    datos.Codigo = reader["Codigo Producto"].ToString();
                    datos.Descripcion = reader["Descripion"].ToString();
                    datos.Precio = double.Parse(reader["Precio Unitario"].ToString());
                    datos.Cantidad = int.Parse(reader["Cantidad"].ToString());
                }
                CerrarConexion();
            }
            else
            {
                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        public void ReporteFinanciero(DataGridView dgv, DateTimePicker fecha1, DateTimePicker fecha2)
        {
            AbrirConexion();
            try
            {                
                da = new SqlDataAdapter("WITH CALCULO AS(SELECT [Año] = YEAR([fecha_Venta])," +
                    "[Mes] = MONTH([fecha_Venta]),[Ventas Brutas] = SUM(precioVenta * vd.cantidad)," +
                    "[Compras Brutas] = SUM(precioCompra * cd.cantidad),[Utilidad Bruta] = SUM(precioVenta * vd.cantidad - precioCompra * cd.cantidad)," +
                    "[Utilidad del Mes Pasado] = LAG(SUM((precioVenta * vd.cantidad - precioCompra * cd.cantidad))) OVER(ORDER BY Month([fecha_Venta])) FROM Ventas v " +
                    "inner join VentaDetalle vd on v.num_factura = vd.num_factura inner join CompraDetalle cd  on vd.cod_prducto = cd.cod_producto " +
                    "where fecha_Venta between '"+fecha1.Value.ToString()+"' and '"+fecha2.Value.ToString()+"' GROUP BY YEAR([fecha_Venta]), MONTH([fecha_Venta])) " +
                    "SELECT [Año],[Mes],[Ventas Brutas],[Compras Brutas],[Utilidad Bruta],[Utilidad del Mes Pasado]," +
                    "[Crecimiento Mensual] = 100.0 * ([Utilidad Bruta] - [Ventas del Mes Pasado]) / [Ventas del Mes Pasado] FROM[CALCULO] ORDER BY[Year], [Month] ", sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception e)
            {
                MessageBox.Show("ERROR " + e, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CerrarConexion();
        }
    }
}
