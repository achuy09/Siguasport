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
    public partial class FormRegistroBodega : Form
    {
        public FormRegistroBodega()
        {
            InitializeComponent();
        }
        ClassValidacion validacion = new ClassValidacion();

        bool numero2 = false;

        public void validar()
        {
            if (validacion.Espacio_Blanco(ErrorProvider,txtcodigoproducto))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtcodigoproducto))
                    ErrorProvider.SetError(txtcodigoproducto, "No se puede dejar en blanco");
                else
                if (validacion.Solo_Numeros(ErrorProvider, txtcodigoproducto))
                    ErrorProvider.SetError(txtcodigoproducto, "Solo se permite letras");
            }
            else
            {
                numero2 = true;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormRegistroBodega_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInventarioBodega InvBo = new FormInventarioBodega();
            InvBo.ShowDialog();
        }

        private void tpProductos_Click(object sender, EventArgs e)
        {

        }

        private void lbldescripcion_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tpProveedores_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreContacto_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = .; Initial Catalog = SiguaSports; " + "Integrated Security = true");
            SqlDataAdapter ada = new SqlDataAdapter("select count(*) from Productos where cod_producto= ' " + txtcodigoproducto.Text + "'", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            if (txtcodigoproducto.Text=="")
            {
                MessageBox.Show("Ingrese un codigo de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtnombre.Text=="")
            {
                MessageBox.Show("Ingrese un nombre de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtmarca.Text=="")
            {
                MessageBox.Show("Ingrese la marca del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtColor.Text=="")
            {
                MessageBox.Show("Ingrese un color del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEstado.Text=="")
            {
                MessageBox.Show("Ingrese el estado del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtcantidad.Text=="")
            {
                MessageBox.Show("Ingrese la cantidad de productos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtprecio.Text=="")
            {
                MessageBox.Show("Ingrese el precio del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPrecioVenta.Text == "")
            {
                MessageBox.Show("Ingrese el precio a venta del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Ingrese un codigo de producto", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                //ingresar producto a base
            }
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
