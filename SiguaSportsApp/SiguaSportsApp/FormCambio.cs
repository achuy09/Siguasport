using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiguaSportsApp
{
    public partial class FormCambio : Form
    {
        public FormCambio()
        {
            InitializeComponent();
        }

        ClassConexionBD con = new ClassConexionBD();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCambio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dgvCambio.Rows.Count == 0)

                MessageBox.Show("No hay datos seleccionados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                con.AbrirConexion();
                con.da = new SqlDataAdapter("select count(*)from Productos where cod_producto= ' " + txtCodProd.Text.ToString() + "'", con.sc);
                con.dt = new DataTable();
                con.da.Fill(con.dt);

                if (dgvCambio.Rows.Count == 0)
                {
                    MessageBox.Show("No existe el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FormConfirmacion conf = new FormConfirmacion();
                    conf.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVentas venta = new FormVentas();
            venta.ShowDialog();
            this.Close();
        }

        private void txtDevolucion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
