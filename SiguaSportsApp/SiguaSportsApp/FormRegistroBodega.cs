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
        private void FormRegistroBodega_Load(object sender, EventArgs e)
        {
            string query = "SELECT cod_producto Codigo, CONCAT(p.nombre, ' ', precioVenta, ' ', precioCompra, ' ', color,  ' ', marca) Descripcion, " +
                "c.descripcion Categoria, pr.nombre Proveedor FROM Productos p inner join Proveedores pr on p.cod_proveedor = pr.cod_proveedor " +
                "inner join Categorias c on p.cod_categoria = c.cod_categoria";
            string query1 = "Select cod_proveedor Codigo, nombre Nombre, direccion Direccion, telefono Telefono, correo Correo, " +
                "nombre_contacto [Nombre Contacto], telefono_contacto [Telefono Contacto] from Proveedores";
            datos.CargarDatosTablas(dgvProductos, query);
            datos.CargarDatosTablas(dgvProveedores, query1);
        }
        ClassDatosTablas datos = new ClassDatosTablas();
        ClassValidacion validacion = new ClassValidacion();
        ClassConexionBD con = new ClassConexionBD();

        bool letra1 = false;
        bool letra2 = false;
        bool letra3 = false;
        bool letra4 = false;
        bool letra5 = false;
        bool numero2 = false;
        bool numero1 = false;
        bool numero3 = false;
        bool numero4 = false;
        bool numero5 = false;

        public void validar()
        {
            if (validacion.Espacio_Blanco(ErrorProvider, txtProveedorProd))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtProveedorProd))
                    ErrorProvider.SetError(txtProveedorProd, "No se puede dejar en blanco.");
                else
                if (validacion.Solo_Letras(ErrorProvider, txtProveedorProd))
                    ErrorProvider.SetError(txtProveedorProd, "Solo se permiten letras.");
            }
            else
            {
                letra1 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtcantidad))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtcantidad))
                    ErrorProvider.SetError(txtcantidad, "No se puede dejar en blanco.");
                else
                if (validacion.Solo_Numeros(ErrorProvider, txtcantidad))
                    ErrorProvider.SetError(txtcantidad, "Solo se permiten numeros.");
            }
            else
            {
                numero1 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtcodigoproducto))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtcodigoproducto))
                    ErrorProvider.SetError(txtcodigoproducto, "No se puede dejar en blanco.");
                else
                if (validacion.Solo_Numeros(ErrorProvider, txtcodigoproducto))
                    ErrorProvider.SetError(txtcodigoproducto, "Solo se permite numeros.");
            }
            else
            {
                numero2 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtFacturaCompra))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtFacturaCompra))
                    ErrorProvider.SetError(txtFacturaCompra, "No se puede dejar en blanco.");
                else
                if (validacion.Solo_Numeros(ErrorProvider, txtFacturaCompra))
                    ErrorProvider.SetError(txtFacturaCompra, "Solo se permiten numeros.");
            }
            else
            {
                numero3 = true;
            }
        }

        public void validar2()
        {
            if (validacion.Espacio_Blanco(ErrorProvider, txtnombre))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtnombre))
                    ErrorProvider.SetError(txtnombre, "No se puede dejar en blanco.");
                else
                if (validacion.Solo_Letras(ErrorProvider, txtnombre))
                    ErrorProvider.SetError(txtnombre, "Solo se permiten letras.");
            }
            else
            {
                letra2 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtmarca))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtmarca))
                    ErrorProvider.SetError(txtmarca, "No se puede dejar en blanco.");
                else
                if (validacion.Solo_Letras(ErrorProvider, txtmarca))
                    ErrorProvider.SetError(txtmarca, "Solo se permiten letras.");
            }
            else
            {
                letra3 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtColor))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtColor))
                    ErrorProvider.SetError(txtColor, "No se puede dejar en blanco.");
                else
                if (validacion.Solo_Letras(ErrorProvider, txtColor))
                    ErrorProvider.SetError(txtColor, "Solo se permiten letras.");
            }
            else
            {
                letra4 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtEstado))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtEstado))
                    ErrorProvider.SetError(txtEstado, "No se puede dejar en blanco.");
                else
                if (validacion.Solo_Letras(ErrorProvider, txtEstado))
                    ErrorProvider.SetError(txtEstado, "Solo se permiten letras.");
            }
            else
            {
                letra5 = true;
            }
        }

        bool letra6 = false;
        bool letra7 = false;
        bool direccion = false;
        bool letra9 = false;
        bool correo = false;
        bool numero6 = false;

        public void validarProveedor()
        {
            if (validacion.Espacio_Blanco(ErrorProvider, txtCodProveedor))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtCodProveedor))
                    ErrorProvider.SetError(txtCodProveedor, "No se puede dejar en blanco.");
                else
                if (validacion.Solo_Letras(ErrorProvider, txtCodProveedor))
                    ErrorProvider.SetError(txtCodProveedor, "Solo se permiten letras.");
            }
            else
            {
                letra6 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtNombreProveedor))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtNombreProveedor))
                    ErrorProvider.SetError(txtNombreProveedor, "No se puede dejar en blanco.");
                else
                if (validacion.Solo_Letras(ErrorProvider, txtNombreProveedor))
                    ErrorProvider.SetError(txtNombreProveedor, "Solo se permiten letras.");
            }
            else
            {
                letra7 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtDireccionProveedor))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtDireccionProveedor))
                    ErrorProvider.SetError(txtDireccionProveedor, "No se puede dejar en blanco.");
            }
            else
            {
                direccion = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtCorreoProveedor))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtCorreoProveedor))
                    ErrorProvider.SetError(txtCorreoProveedor, "No se puede dejar en blanco.");
            }
            else
            {
                correo = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtTelefonoContacto))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtTelefonoContacto))
                    ErrorProvider.SetError(txtTelefonoContacto, "No se puede dejar en blanco.");
                else
                if (validacion.Solo_Numeros(ErrorProvider, txtTelefonoContacto))
                    ErrorProvider.SetError(txtTelefonoContacto, "Solo se permiten numeros.");
            }
            else
            {
                numero6 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtNombreContacto))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtTelefonoContacto))
                    ErrorProvider.SetError(txtTelefonoContacto, "No se puede dejar en blanco.");
                else
                if (validacion.Solo_Numeros(ErrorProvider, txtTelefonoContacto))
                    ErrorProvider.SetError(txtTelefonoContacto, "Solo se permiten numeros.");
            }
            else
            {
                letra9 = true;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInventarioBodega InvBo = new FormInventarioBodega();
            InvBo.ShowDialog();
            this.Close();
        }

        private void lbldescripcion_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            con.AbrirConexion();
            con.da = new SqlDataAdapter("select count(*) from Productos where cod_producto = '" + txtcodigoproducto.Text.ToString() + "'", con.sc);
            con.dt = new DataTable();
            con.da.Fill(con.dt);

            if (letra1)
            {
                validar();
                if(letra1 && numero1 && numero2 && numero3)
                {
                    //imprimr txt y cambiar existencia
                }
                else
                {

                }
            }
            else
            {
                validar();
                validar2();
                //ingresar producto a base
            }
            con.CerrarConexion();
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ya se encuentra en la ventana.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            validarProveedor();
            if (letra6 && letra7 && direccion && letra9 && correo && numero6)
            {

            }
        }
    }
}
