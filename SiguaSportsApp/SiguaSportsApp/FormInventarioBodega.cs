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
        private void FormInventarioBodega_Load(object sender, EventArgs e)
        {
            string query = "SELECT cod_producto Codigo, CONCAT(p.nombre, ' ', precioVenta, ' ', precioCompra, ' ', color,  ' ', marca) Descripcion, " +
                "c.descripcion Categoria, pr.nombre Proveedor FROM Productos p inner join Proveedores pr on p.cod_proveedor = pr.cod_proveedor " +
                "inner join Categorias c on p.cod_categoria = c.cod_categoria";
            datos.CargarDatosTablas(dgvProductos, query);
        }
        ClassDatosTablas datos = new ClassDatosTablas();
        ClassConexionBD con = new ClassConexionBD();

        private void dgvProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarProducto_Click_1(object sender, EventArgs e)
        {
            con.AbrirConexion();
            con.da = new SqlDataAdapter("select * from Productos where cod_producto = '" + txtBuscar.Text + "'", con.sc);
            con.dt = new DataTable();
            con.da.Fill(con.dt);
            dgvProductos.DataSource = con.dt;
            con.CerrarConexion();
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblprecioCompra_Click(object sender, EventArgs e)
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
