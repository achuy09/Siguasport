using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiguaSportsApp
{
    public partial class FormConfirmacion : Form
    {
        public FormConfirmacion()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodigoproducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void FormConfirmacion_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ClassValidacion validacion = new ClassValidacion();
            ClassConexionBD autentificar = new ClassConexionBD();

            if (validacion.Espacio_Blanco(ErrorProvider, txtContraseña) || validacion.Espacio_Blanco(ErrorProvider, txtUsuario))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtContraseña))
                {
                    if (!validacion.Espacio_Blanco(ErrorProvider, txtUsuario))
                    {
                        ErrorProvider.SetError(txtUsuario, "");
                    }
                    ErrorProvider.SetError(txtContraseña, "No se ingreso una contraseña.");
                }
                if (validacion.Espacio_Blanco(ErrorProvider, txtUsuario))
                {
                    if (!validacion.Espacio_Blanco(ErrorProvider, txtContraseña))
                    {
                        ErrorProvider.SetError(txtContraseña, "");
                    }
                    ErrorProvider.SetError(txtUsuario, "No se ingreso un usuario.");
                }
            }
            else
            {
                if (autentificar.Autentificacion(txtUsuario.Text.ToString(), txtContraseña.Text.ToString()) == true)
                {
                    try
                    {                        
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
