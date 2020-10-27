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
    class ClassConexionBD
    {
        public SqlConnection sc = new SqlConnection();

        protected SqlDataAdapter da;
        protected DataTable dt;

        protected string sql;
        protected SqlCommand cmd;
        private int codigoPuesto;

        string conexion = "Data Source = .; Initial Catalog = SiguaSports; " + "Integrated Security = true";

        public int CodigoPuesto { get => codigoPuesto; set => codigoPuesto = value; }

        public ClassConexionBD()
        {
            sc.ConnectionString = conexion;
        }

        public void AbrirConexion()
        {
            try
            {
                sc.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR en la conexion" + ex, "Error de Conexion: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CerrarConexion()
        {
            sc.Close();
        }

        public bool Autentificacion(string usuario, string contra)
        {
            bool verificacion = false;

            sql = string.Format("SELECT (CONCAT(nombres, ' ', apellidos)) Nombre, " +
                "U.cod_usuario Usuario, U.contraseña Contraseña, E.cod_puesto Codigo " +
                "FROM Empleados E inner join Usuarios U on E.cod_usuario = U.cod_usuario " +
                "where U.cod_usuario = '{0}' and U.contraseña = '{1}'", usuario, contra);
            cmd = new SqlCommand(sql, sc);
            sc.Open();

            try
            {
                SqlDataReader lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    string Nombre = lector["Nombre"].ToString();
                    codigoPuesto = int.Parse(lector["Codigo"].ToString());

                    verificacion = true;
                    MessageBox.Show("Bienvenido:  " + Nombre + "! Codigo de Puesto " + codigoPuesto, "Login Sunshine Network",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario/Contraseña incorrectos", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("" + e);
            }
            
            
            CerrarConexion();
            return verificacion;
        }
    }
}
