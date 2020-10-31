using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiguaSportsApp
{
    public partial class FormDevoluciones : Form
    {
        public FormDevoluciones()
        {
            InitializeComponent();
        }

        ClassDatosTablas conexion = new ClassDatosTablas();
        string query = "SELECT B.nombre[Producto] , A.cantidad[Cantidad] , A.motivo[Motivo] ,C.fecha_devolucion[Fecha de Devolución]" +
                                         "FROM DevolucionDetalle A " +
                                         "INNER JOIN Productos B ON A.cod_producto = B.cod_producto" +
                                         "INNER JOIN Devoluciones C ON A.num_devolucion = C.num_devolucion where cod_estado = 1";

        private void FromDevoluciones_Load(object sender, EventArgs e)
        {
            conexion.CargarDatosTablas(dgvHistorial, query);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvDevoluciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            conexion.AbrirConexion();
            conexion.da = new SqlDataAdapter("select count(*)from Productos where cod_producto= '" + txtCodProd.Text.ToString() + "'", conexion.sc);
            conexion.dt = new DataTable();
            conexion.da.Fill(conexion.dt);

            if (dgvDevoluciones.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos a devolver.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormConfirmacion conf = new FormConfirmacion();
                conf.ShowDialog();
                this.Close();
            }
            conexion.CerrarConexion();
        }
    }
}
