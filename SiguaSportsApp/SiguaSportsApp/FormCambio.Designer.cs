namespace SiguaSportsApp
{
    partial class FormCambio
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
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDevolucion = new System.Windows.Forms.TextBox();
            this.lbldevolucion = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblfecha = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtvendedor = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.txtISV = new System.Windows.Forms.TextBox();
            this.lblISV = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblventas = new System.Windows.Forms.Label();
            this.lblvendedor = new System.Windows.Forms.Label();
            this.dgvCambio = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna_descripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.lblCodProd = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCambio)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMotivo
            // 
            this.txtMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMotivo.Location = new System.Drawing.Point(588, 187);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(467, 22);
            this.txtMotivo.TabIndex = 62;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnConfirmar.Location = new System.Drawing.Point(1395, 80);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(111, 28);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1051, 114);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 24);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(1135, 116);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(132, 22);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDevolucion
            // 
            this.txtDevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDevolucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDevolucion.Location = new System.Drawing.Point(181, 17);
            this.txtDevolucion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDevolucion.Name = "txtDevolucion";
            this.txtDevolucion.ReadOnly = true;
            this.txtDevolucion.Size = new System.Drawing.Size(177, 22);
            this.txtDevolucion.TabIndex = 2;
            this.txtDevolucion.TextChanged += new System.EventHandler(this.txtDevolucion_TextChanged);
            // 
            // lbldevolucion
            // 
            this.lbldevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbldevolucion.AutoSize = true;
            this.lbldevolucion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldevolucion.Location = new System.Drawing.Point(12, 16);
            this.lbldevolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldevolucion.Name = "lbldevolucion";
            this.lbldevolucion.Size = new System.Drawing.Size(161, 24);
            this.lbldevolucion.TabIndex = 2;
            this.lbldevolucion.Text = "No. De Devolución:";
            // 
            // lblMotivo
            // 
            this.lblMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(439, 185);
            this.lblMotivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(65, 24);
            this.lblMotivo.TabIndex = 61;
            this.lblMotivo.Text = "Motivo";
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(48, 140);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(112, 24);
            this.lblID.TabIndex = 54;
            this.lblID.Text = "Id Vendedor";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtID.Location = new System.Drawing.Point(168, 142);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(233, 22);
            this.txtID.TabIndex = 55;
            this.txtID.TextChanged += new System.EventHandler(this.label_ID_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.lblfecha);
            this.panel2.Controls.Add(this.txtDevolucion);
            this.panel2.Controls.Add(this.lbldevolucion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1531, 55);
            this.panel2.TabIndex = 57;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1252, 16);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblfecha
            // 
            this.lblfecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(1187, 14);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(57, 24);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "Fecha";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnCancelar.Location = new System.Drawing.Point(1395, 43);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 28);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtvendedor
            // 
            this.txtvendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtvendedor.Location = new System.Drawing.Point(168, 187);
            this.txtvendedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtvendedor.Name = "txtvendedor";
            this.txtvendedor.ReadOnly = true;
            this.txtvendedor.Size = new System.Drawing.Size(233, 22);
            this.txtvendedor.TabIndex = 52;
            // 
            // panel4
            // 
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnConfirmar);
            this.panel4.Controls.Add(this.btnCancelar);
            this.panel4.Controls.Add(this.txtDes);
            this.panel4.Controls.Add(this.lblDes);
            this.panel4.Controls.Add(this.lblSub);
            this.panel4.Controls.Add(this.txtSub);
            this.panel4.Controls.Add(this.txtISV);
            this.panel4.Controls.Add(this.lblISV);
            this.panel4.Controls.Add(this.lblTotal);
            this.panel4.Controls.Add(this.txtTotal);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 529);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1531, 155);
            this.panel4.TabIndex = 59;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // txtDes
            // 
            this.txtDes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDes.Enabled = false;
            this.txtDes.Location = new System.Drawing.Point(1135, 49);
            this.txtDes.Margin = new System.Windows.Forms.Padding(4);
            this.txtDes.Name = "txtDes";
            this.txtDes.ReadOnly = true;
            this.txtDes.Size = new System.Drawing.Size(132, 22);
            this.txtDes.TabIndex = 10;
            this.txtDes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDes
            // 
            this.lblDes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(1010, 47);
            this.lblDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(95, 24);
            this.lblDes.TabIndex = 9;
            this.lblDes.Text = "Descuento";
            // 
            // lblSub
            // 
            this.lblSub.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.Location = new System.Drawing.Point(1024, 17);
            this.lblSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(81, 24);
            this.lblSub.TabIndex = 8;
            this.lblSub.Text = "Subtotal";
            // 
            // txtSub
            // 
            this.txtSub.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSub.Enabled = false;
            this.txtSub.Location = new System.Drawing.Point(1135, 19);
            this.txtSub.Margin = new System.Windows.Forms.Padding(4);
            this.txtSub.Name = "txtSub";
            this.txtSub.ReadOnly = true;
            this.txtSub.Size = new System.Drawing.Size(132, 22);
            this.txtSub.TabIndex = 7;
            this.txtSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtISV
            // 
            this.txtISV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtISV.Enabled = false;
            this.txtISV.Location = new System.Drawing.Point(1135, 80);
            this.txtISV.Margin = new System.Windows.Forms.Padding(4);
            this.txtISV.Name = "txtISV";
            this.txtISV.ReadOnly = true;
            this.txtISV.Size = new System.Drawing.Size(132, 22);
            this.txtISV.TabIndex = 6;
            this.txtISV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblISV
            // 
            this.lblISV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblISV.AutoSize = true;
            this.lblISV.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISV.Location = new System.Drawing.Point(1063, 80);
            this.lblISV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISV.Name = "lblISV";
            this.lblISV.Size = new System.Drawing.Size(42, 24);
            this.lblISV.TabIndex = 5;
            this.lblISV.Text = "ISV";
            // 
            // btnexit
            // 
            this.btnexit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(1480, 0);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(49, 42);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 44);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1531, 24);
            this.panel3.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.lblventas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1531, 44);
            this.panel1.TabIndex = 56;
            // 
            // lblventas
            // 
            this.lblventas.AutoSize = true;
            this.lblventas.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblventas.Location = new System.Drawing.Point(4, 2);
            this.lblventas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblventas.Name = "lblventas";
            this.lblventas.Size = new System.Drawing.Size(93, 33);
            this.lblventas.TabIndex = 1;
            this.lblventas.Text = "Cambio";
            // 
            // lblvendedor
            // 
            this.lblvendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblvendedor.AutoSize = true;
            this.lblvendedor.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvendedor.Location = new System.Drawing.Point(72, 185);
            this.lblvendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvendedor.Name = "lblvendedor";
            this.lblvendedor.Size = new System.Drawing.Size(88, 24);
            this.lblvendedor.TabIndex = 53;
            this.lblvendedor.Text = "Vendedor";
            // 
            // dgvCambio
            // 
            this.dgvCambio.AllowUserToAddRows = false;
            this.dgvCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCambio.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCambio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Unidad,
            this.Cantidad,
            this.Motivo,
            this.columna_descripcionProducto,
            this.ProductoCambio});
            this.dgvCambio.Location = new System.Drawing.Point(17, 287);
            this.dgvCambio.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCambio.Name = "dgvCambio";
            this.dgvCambio.ReadOnly = true;
            this.dgvCambio.RowHeadersVisible = false;
            this.dgvCambio.RowHeadersWidth = 51;
            this.dgvCambio.Size = new System.Drawing.Size(1501, 234);
            this.dgvCambio.TabIndex = 64;
            this.dgvCambio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCambio_CellContentClick);
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 125;
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.MinimumWidth = 6;
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            this.Unidad.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // Motivo
            // 
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.MinimumWidth = 6;
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            this.Motivo.Width = 125;
            // 
            // columna_descripcionProducto
            // 
            this.columna_descripcionProducto.HeaderText = "Descripcion Producto a Cambiar";
            this.columna_descripcionProducto.MinimumWidth = 6;
            this.columna_descripcionProducto.Name = "columna_descripcionProducto";
            this.columna_descripcionProducto.ReadOnly = true;
            this.columna_descripcionProducto.Width = 280;
            // 
            // ProductoCambio
            // 
            this.ProductoCambio.HeaderText = "Producto Cambio";
            this.ProductoCambio.MinimumWidth = 6;
            this.ProductoCambio.Name = "ProductoCambio";
            this.ProductoCambio.ReadOnly = true;
            this.ProductoCambio.Width = 280;
            // 
            // txtCodProd
            // 
            this.txtCodProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCodProd.Location = new System.Drawing.Point(588, 144);
            this.txtCodProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(164, 22);
            this.txtCodProd.TabIndex = 66;
            // 
            // lblCodProd
            // 
            this.lblCodProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProd.Location = new System.Drawing.Point(439, 142);
            this.lblCodProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(141, 24);
            this.lblCodProd.TabIndex = 65;
            this.lblCodProd.Text = "Codigo Producto";
            // 
            // FormCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 684);
            this.Controls.Add(this.txtCodProd);
            this.Controls.Add(this.lblCodProd);
            this.Controls.Add(this.dgvCambio);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtvendedor);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblvendedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCambio";
            this.Text = "FromCambio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCambio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDevolucion;
        private System.Windows.Forms.Label lbldevolucion;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtvendedor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblventas;
        private System.Windows.Forms.Label lblvendedor;
        private System.Windows.Forms.DataGridView dgvCambio;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.TextBox txtISV;
        private System.Windows.Forms.Label lblISV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna_descripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoCambio;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.Label lblCodProd;
    }
}