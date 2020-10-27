namespace SiguaSportsApp
{
    partial class FormReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentasBrutas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compras_Brutas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utilidad_Bruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crecimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje_Frente_Meses_Anteriores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Valor_Utilidad = new System.Windows.Forms.Label();
            this.trb_Utilidad = new System.Windows.Forms.TrackBar();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.bnt_Buscar = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Utilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 44);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1522, 24);
            this.panel3.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1522, 44);
            this.panel1.TabIndex = 25;
            // 
            // btnexit
            // 
            this.btnexit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(1471, 0);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(49, 42);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(4, 2);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(226, 33);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Reporte Financiero";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Mes,
            this.VentasBrutas,
            this.Compras_Brutas,
            this.Utilidad_Bruta,
            this.Crecimiento,
            this.Porcentaje_Frente_Meses_Anteriores});
            this.dataGridView1.Location = new System.Drawing.Point(11, 191);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1498, 452);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 125;
            // 
            // Mes
            // 
            this.Mes.HeaderText = "Mes";
            this.Mes.MinimumWidth = 6;
            this.Mes.Name = "Mes";
            this.Mes.ReadOnly = true;
            this.Mes.Width = 125;
            // 
            // VentasBrutas
            // 
            this.VentasBrutas.HeaderText = "Ventas Brutas";
            this.VentasBrutas.MinimumWidth = 6;
            this.VentasBrutas.Name = "VentasBrutas";
            this.VentasBrutas.ReadOnly = true;
            this.VentasBrutas.Width = 125;
            // 
            // Compras_Brutas
            // 
            this.Compras_Brutas.HeaderText = "Compras Brutas";
            this.Compras_Brutas.MinimumWidth = 6;
            this.Compras_Brutas.Name = "Compras_Brutas";
            this.Compras_Brutas.ReadOnly = true;
            this.Compras_Brutas.Width = 220;
            // 
            // Utilidad_Bruta
            // 
            this.Utilidad_Bruta.HeaderText = "Utilidad Brutas";
            this.Utilidad_Bruta.MinimumWidth = 6;
            this.Utilidad_Bruta.Name = "Utilidad_Bruta";
            this.Utilidad_Bruta.ReadOnly = true;
            this.Utilidad_Bruta.Width = 220;
            // 
            // Crecimiento
            // 
            this.Crecimiento.HeaderText = "Crecimiento";
            this.Crecimiento.MinimumWidth = 6;
            this.Crecimiento.Name = "Crecimiento";
            this.Crecimiento.ReadOnly = true;
            this.Crecimiento.Width = 220;
            // 
            // Porcentaje_Frente_Meses_Anteriores
            // 
            this.Porcentaje_Frente_Meses_Anteriores.HeaderText = "% Frente a Meses Anteriores";
            this.Porcentaje_Frente_Meses_Anteriores.MinimumWidth = 6;
            this.Porcentaje_Frente_Meses_Anteriores.Name = "Porcentaje_Frente_Meses_Anteriores";
            this.Porcentaje_Frente_Meses_Anteriores.ReadOnly = true;
            this.Porcentaje_Frente_Meses_Anteriores.Width = 280;
            // 
            // lbl_Valor_Utilidad
            // 
            this.lbl_Valor_Utilidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Valor_Utilidad.AutoSize = true;
            this.lbl_Valor_Utilidad.Location = new System.Drawing.Point(552, 143);
            this.lbl_Valor_Utilidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Valor_Utilidad.Name = "lbl_Valor_Utilidad";
            this.lbl_Valor_Utilidad.Size = new System.Drawing.Size(92, 17);
            this.lbl_Valor_Utilidad.TabIndex = 38;
            this.lbl_Valor_Utilidad.Text = "Valor Utilidad";
            // 
            // trb_Utilidad
            // 
            this.trb_Utilidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trb_Utilidad.Location = new System.Drawing.Point(524, 100);
            this.trb_Utilidad.Margin = new System.Windows.Forms.Padding(4);
            this.trb_Utilidad.Maximum = 10000;
            this.trb_Utilidad.Name = "trb_Utilidad";
            this.trb_Utilidad.Size = new System.Drawing.Size(433, 56);
            this.trb_Utilidad.TabIndex = 37;
            this.trb_Utilidad.TickFrequency = 500;
            this.trb_Utilidad.Scroll += new System.EventHandler(this.trb_Utilidad_Scroll);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Limpiar.Location = new System.Drawing.Point(1012, 131);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(100, 28);
            this.btn_Limpiar.TabIndex = 36;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // bnt_Buscar
            // 
            this.bnt_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bnt_Buscar.Location = new System.Drawing.Point(1012, 88);
            this.bnt_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.bnt_Buscar.Name = "bnt_Buscar";
            this.bnt_Buscar.Size = new System.Drawing.Size(100, 28);
            this.bnt_Buscar.TabIndex = 35;
            this.bnt_Buscar.Text = "Buscar";
            this.bnt_Buscar.UseVisualStyleBackColor = true;
            this.bnt_Buscar.Click += new System.EventHandler(this.bnt_Buscar_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.Location = new System.Drawing.Point(269, 132);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(171, 22);
            this.dateTimePicker2.TabIndex = 32;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(269, 90);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 22);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 29;
            this.label1.Text = "Desde:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Location = new System.Drawing.Point(444, 123);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Location = new System.Drawing.Point(444, 81);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresar.Location = new System.Drawing.Point(1409, 654);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 28);
            this.btnRegresar.TabIndex = 40;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 695);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Valor_Utilidad);
            this.Controls.Add(this.trb_Utilidad);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.bnt_Buscar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Utilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_Valor_Utilidad;
        private System.Windows.Forms.TrackBar trb_Utilidad;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button bnt_Buscar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasBrutas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compras_Brutas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utilidad_Bruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crecimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje_Frente_Meses_Anteriores;
        private System.Windows.Forms.Button btnRegresar;
    }
}