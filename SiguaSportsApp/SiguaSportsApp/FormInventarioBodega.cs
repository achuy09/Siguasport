using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SiguaSportsApp
{
    public partial class FormInventarioBodega : Form
    {
        public FormInventarioBodega()
        {
            InitializeComponent();
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {

        }

        private void tpProductos_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarProducto_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = .; Initial Catalog = SiguaSports; " + "Integrated Security = true");
            SqlDataAdapter ada = new SqlDataAdapter("select count(*)from Productos where cod_producto= ' " + txtBusqueda.Text + "'", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            if (txtBusqueda.Text==" ")
            {
                MessageBox.Show("Ingrese un Numero en la casilla de busqueda");
            }
           else if (dt.Rows[0][0].ToString() == "1")
            {

              //MOSTRAR DATOS DEL PRODUCTO

            }
            else

            MessageBox.Show("Codigo de Producto Invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtBusqueda.Clear();
            txtBusqueda.Focus();

        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblprecioCompra_Click(object sender, EventArgs e)
        {

        }

        private void FormInventarioBodega_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FormRegistroBodega regisbo = new FormRegistroBodega();
            regisbo.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
