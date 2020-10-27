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
    public partial class FormAdministracion : Form
    {
        public FormAdministracion()
        {
            InitializeComponent();
        }

        private void FormAdministracion_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmpleadoNuevo ingreso = new FormEmpleadoNuevo();
            ingreso.ShowDialog();
            this.Close();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmpleadoEgreso egreso = new FormEmpleadoEgreso();
            egreso.ShowDialog();
            this.Close();
        }

        private void btnHistorialEmpleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmpleadosHistorial histo = new FormEmpleadosHistorial();
            histo.ShowDialog();
            this.Close();
        }

        private void btnReporteFinanciero_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReportes repos = new FormReportes();
            repos.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
