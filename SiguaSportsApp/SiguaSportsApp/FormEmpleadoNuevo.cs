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
    public partial class FormEmpleadoNuevo : Form
    {
        public FormEmpleadoNuevo()
        {
            InitializeComponent();
        }

        private void FormEmpleadoNuevo_Load(object sender, EventArgs e)
        {

        }
        ClassValidacion validacion = new ClassValidacion();

        private bool letra1 = false;
        private bool letra2 = false;
        private bool letra3 = false;
        private bool numero1 = false;
        private bool numero2 = false;

        public void validar()
        {
            if (validacion.Espacio_Blanco(ErrorProvider, txtNombre) || validacion.Solo_Letras(ErrorProvider, txtNombre))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtNombre))
                    ErrorProvider.SetError(txtNombre, "no se puede dejar en blanco");
                else
                if (validacion.Solo_Letras(ErrorProvider, txtNombre))
                    ErrorProvider.SetError(txtNombre, "Solo se permite letras");
            }
            else
            {
                letra1 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtApellidos) || validacion.Solo_Letras(ErrorProvider, txtApellidos))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtApellidos))
                    ErrorProvider.SetError(txtApellidos, "no se puede dejar en blanco");
                else
                if (validacion.Solo_Letras(ErrorProvider, txtApellidos))
                    ErrorProvider.SetError(txtApellidos, "Solo se permite letras");
            }
            else
            {
                letra2 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, txtCorreo) || validacion.Solo_Letras(ErrorProvider, txtCorreo))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, txtCorreo))
                    ErrorProvider.SetError(txtCorreo, "No se puede dejar en blanco");
                else
                if (validacion.Solo_Letras(ErrorProvider, txtCorreo))
                    ErrorProvider.SetError(txtCorreo, "Solo se permite letras");
            }
            else
            {
                letra3 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider, mtxtFechaNacimiento))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, mtxtFechaNacimiento))
                    ErrorProvider.SetError(mtxtFechaNacimiento, "No se puede dejar en blanco");                
            }
            else
            {
                numero1 = true;
            }
            if (validacion.Espacio_Blanco(ErrorProvider, mtxttelefono))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, mtxttelefono))
                    ErrorProvider.SetError(mtxttelefono, "No se puede dejar en blanco");
            }
            else
            {
                numero2 = true;
            }
        }

        private void mtxtFechaNacimiento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdministracion admin = new FormAdministracion();
            admin.ShowDialog();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            letra1 = false; letra2 = false; letra3 = false; numero1 = false; numero2 = false;
            validar();
            if (letra1 && letra2 && letra3 && numero1 && numero2)
            {
                
                this.Hide();
                FormAdministracion admin = new FormAdministracion();
                admin.ShowDialog();
                this.Close();
            }
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdministracion admin = new FormAdministracion();
            admin.ShowDialog();
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtxttelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
