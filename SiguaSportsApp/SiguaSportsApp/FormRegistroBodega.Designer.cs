using System;

namespace SiguaSportsApp
{
    partial class FormRegistroBodega
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcRegistro = new System.Windows.Forms.TabControl();
            this.tpProductos = new System.Windows.Forms.TabPage();
            this.txtProveedorProd = new System.Windows.Forms.TextBox();
            this.lblProveedorProd = new System.Windows.Forms.Label();
            this.txtFacturaCompra = new System.Windows.Forms.TextBox();
            this.lblFactura = new System.Windows.Forms.Label();
            this.btnCancelarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.lblmarca = new System.Windows.Forms.Label();
            this.txtcodigoproducto = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.lblprecioCompra = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.tpProveedores = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCorreoProveedor = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblTelefonoProveedor = new System.Windows.Forms.Label();
            this.txtTelefonoContacto = new System.Windows.Forms.TextBox();
            this.lblTelefonoContacto = new System.Windows.Forms.Label();
            this.txtDireccionProveedor = new System.Windows.Forms.TextBox();
            this.lblDireccionProveedor = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblCodProveedor = new System.Windows.Forms.Label();
            this.txtNombreContacto = new System.Windows.Forms.TextBox();
            this.lblNombreContacto = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tcRegistro.SuspendLayout();
            this.tpProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tpProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnInventario);
            this.panel1.Controls.Add(this.btnRegistro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 622);
            this.panel1.TabIndex = 0;
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(20, 121);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(91, 71);
            this.btnInventario.TabIndex = 23;
            this.btnInventario.Text = "Invetario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(20, 22);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(91, 68);
            this.btnRegistro.TabIndex = 22;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(129, 44);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1258, 24);
            this.panel3.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(129, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1258, 44);
            this.panel2.TabIndex = 20;
            // 
            // btnexit
            // 
            this.btnexit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(1207, 0);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(49, 42);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(4, 2);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 33);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Registro Inventario";
            // 
            // tcRegistro
            // 
            this.tcRegistro.Controls.Add(this.tpProductos);
            this.tcRegistro.Controls.Add(this.tpProveedores);
            this.tcRegistro.Location = new System.Drawing.Point(129, 69);
            this.tcRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcRegistro.Name = "tcRegistro";
            this.tcRegistro.SelectedIndex = 0;
            this.tcRegistro.Size = new System.Drawing.Size(1320, 540);
            this.tcRegistro.TabIndex = 22;
            // 
            // tpProductos
            // 
            this.tpProductos.Controls.Add(this.txtProveedorProd);
            this.tpProductos.Controls.Add(this.lblProveedorProd);
            this.tpProductos.Controls.Add(this.txtFacturaCompra);
            this.tpProductos.Controls.Add(this.lblFactura);
            this.tpProductos.Controls.Add(this.btnCancelarProducto);
            this.tpProductos.Controls.Add(this.btnAgregarProducto);
            this.tpProductos.Controls.Add(this.dgvProductos);
            this.tpProductos.Controls.Add(this.txtEstado);
            this.tpProductos.Controls.Add(this.lblEstado);
            this.tpProductos.Controls.Add(this.txtColor);
            this.tpProductos.Controls.Add(this.lblColor);
            this.tpProductos.Controls.Add(this.txtPrecioVenta);
            this.tpProductos.Controls.Add(this.lblPrecioVenta);
            this.tpProductos.Controls.Add(this.txtmarca);
            this.tpProductos.Controls.Add(this.lblmarca);
            this.tpProductos.Controls.Add(this.txtcodigoproducto);
            this.tpProductos.Controls.Add(this.lblcodigo);
            this.tpProductos.Controls.Add(this.txtprecio);
            this.tpProductos.Controls.Add(this.lblprecioCompra);
            this.tpProductos.Controls.Add(this.txtnombre);
            this.tpProductos.Controls.Add(this.lblnombre);
            this.tpProductos.Controls.Add(this.txtcantidad);
            this.tpProductos.Controls.Add(this.lblcantidad);
            this.tpProductos.Location = new System.Drawing.Point(4, 25);
            this.tpProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpProductos.Name = "tpProductos";
            this.tpProductos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpProductos.Size = new System.Drawing.Size(1309, 511);
            this.tpProductos.TabIndex = 0;
            this.tpProductos.Text = "Productos";
            this.tpProductos.UseVisualStyleBackColor = true;
            // 
            // txtProveedorProd
            // 
            this.txtProveedorProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProveedorProd.Location = new System.Drawing.Point(1048, 52);
            this.txtProveedorProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtProveedorProd.Name = "txtProveedorProd";
            this.txtProveedorProd.Size = new System.Drawing.Size(193, 22);
            this.txtProveedorProd.TabIndex = 54;
            this.txtProveedorProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblProveedorProd
            // 
            this.lblProveedorProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProveedorProd.AutoSize = true;
            this.lblProveedorProd.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedorProd.Location = new System.Drawing.Point(1044, 14);
            this.lblProveedorProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveedorProd.Name = "lblProveedorProd";
            this.lblProveedorProd.Size = new System.Drawing.Size(93, 24);
            this.lblProveedorProd.TabIndex = 53;
            this.lblProveedorProd.Text = "Proveedor";
            // 
            // txtFacturaCompra
            // 
            this.txtFacturaCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFacturaCompra.Location = new System.Drawing.Point(852, 98);
            this.txtFacturaCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtFacturaCompra.Name = "txtFacturaCompra";
            this.txtFacturaCompra.Size = new System.Drawing.Size(162, 22);
            this.txtFacturaCompra.TabIndex = 52;
            this.txtFacturaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFactura
            // 
            this.lblFactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.Location = new System.Drawing.Point(700, 96);
            this.lblFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(131, 24);
            this.lblFactura.TabIndex = 51;
            this.lblFactura.Text = "Factura Origen";
            // 
            // btnCancelarProducto
            // 
            this.btnCancelarProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelarProducto.Location = new System.Drawing.Point(1048, 468);
            this.btnCancelarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarProducto.Name = "btnCancelarProducto";
            this.btnCancelarProducto.Size = new System.Drawing.Size(91, 37);
            this.btnCancelarProducto.TabIndex = 50;
            this.btnCancelarProducto.Text = "Cancelar";
            this.btnCancelarProducto.UseVisualStyleBackColor = true;
            this.btnCancelarProducto.Click += new System.EventHandler(this.btnCancelarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregarProducto.Location = new System.Drawing.Point(1150, 468);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(91, 37);
            this.btnAgregarProducto.TabIndex = 49;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(4, 140);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(1238, 322);
            this.dgvProductos.TabIndex = 48;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstado.Location = new System.Drawing.Point(548, 55);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(111, 22);
            this.txtEstado.TabIndex = 47;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(443, 53);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(66, 24);
            this.lblEstado.TabIndex = 46;
            this.lblEstado.Text = "Estado";
            // 
            // txtColor
            // 
            this.txtColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtColor.Location = new System.Drawing.Point(548, 11);
            this.txtColor.Margin = new System.Windows.Forms.Padding(4);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(111, 22);
            this.txtColor.TabIndex = 45;
            // 
            // lblColor
            // 
            this.lblColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(443, 9);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(53, 24);
            this.lblColor.TabIndex = 44;
            this.lblColor.Text = "Color";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(852, 57);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(80, 22);
            this.txtPrecioVenta.TabIndex = 43;
            this.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.Location = new System.Drawing.Point(719, 55);
            this.lblPrecioVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(112, 24);
            this.lblPrecioVenta.TabIndex = 42;
            this.lblPrecioVenta.Text = "Precio Venta";
            // 
            // txtmarca
            // 
            this.txtmarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmarca.Location = new System.Drawing.Point(159, 100);
            this.txtmarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(225, 22);
            this.txtmarca.TabIndex = 41;
            // 
            // lblmarca
            // 
            this.lblmarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmarca.AutoSize = true;
            this.lblmarca.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarca.Location = new System.Drawing.Point(7, 98);
            this.lblmarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(60, 24);
            this.lblmarca.TabIndex = 40;
            this.lblmarca.Text = "Marca";
            // 
            // txtcodigoproducto
            // 
            this.txtcodigoproducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcodigoproducto.Location = new System.Drawing.Point(159, 11);
            this.txtcodigoproducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigoproducto.Name = "txtcodigoproducto";
            this.txtcodigoproducto.Size = new System.Drawing.Size(168, 22);
            this.txtcodigoproducto.TabIndex = 39;
            this.txtcodigoproducto.TextChanged += new System.EventHandler(this.txtcodigoproducto_TextChanged);
            // 
            // lblcodigo
            // 
            this.lblcodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(7, 14);
            this.lblcodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(141, 24);
            this.lblcodigo.TabIndex = 38;
            this.lblcodigo.Text = "Código Producto";
            // 
            // txtprecio
            // 
            this.txtprecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtprecio.Location = new System.Drawing.Point(852, 9);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(80, 22);
            this.txtprecio.TabIndex = 37;
            this.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblprecioCompra
            // 
            this.lblprecioCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblprecioCompra.AutoSize = true;
            this.lblprecioCompra.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecioCompra.Location = new System.Drawing.Point(707, 9);
            this.lblprecioCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprecioCompra.Name = "lblprecioCompra";
            this.lblprecioCompra.Size = new System.Drawing.Size(124, 24);
            this.lblprecioCompra.TabIndex = 36;
            this.lblprecioCompra.Text = "Precio Compra";
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnombre.Location = new System.Drawing.Point(159, 53);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(225, 22);
            this.txtnombre.TabIndex = 35;
            // 
            // lblnombre
            // 
            this.lblnombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(7, 50);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(75, 24);
            this.lblnombre.TabIndex = 34;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.Click += new System.EventHandler(this.lbldescripcion_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcantidad.Location = new System.Drawing.Point(548, 98);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(45, 22);
            this.txtcantidad.TabIndex = 33;
            this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblcantidad
            // 
            this.lblcantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.Location = new System.Drawing.Point(443, 100);
            this.lblcantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(79, 24);
            this.lblcantidad.TabIndex = 32;
            this.lblcantidad.Text = "Cántidad";
            // 
            // tpProveedores
            // 
            this.tpProveedores.Controls.Add(this.btnCancelar);
            this.tpProveedores.Controls.Add(this.btnAgregarProveedor);
            this.tpProveedores.Controls.Add(this.dgvProveedores);
            this.tpProveedores.Controls.Add(this.textBox2);
            this.tpProveedores.Controls.Add(this.lblCorreoProveedor);
            this.tpProveedores.Controls.Add(this.textBox3);
            this.tpProveedores.Controls.Add(this.lblTelefonoProveedor);
            this.tpProveedores.Controls.Add(this.txtTelefonoContacto);
            this.tpProveedores.Controls.Add(this.lblTelefonoContacto);
            this.tpProveedores.Controls.Add(this.txtDireccionProveedor);
            this.tpProveedores.Controls.Add(this.lblDireccionProveedor);
            this.tpProveedores.Controls.Add(this.textBox6);
            this.tpProveedores.Controls.Add(this.lblCodProveedor);
            this.tpProveedores.Controls.Add(this.txtNombreContacto);
            this.tpProveedores.Controls.Add(this.lblNombreContacto);
            this.tpProveedores.Controls.Add(this.txtNombreProveedor);
            this.tpProveedores.Controls.Add(this.lblNombreProveedor);
            this.tpProveedores.Location = new System.Drawing.Point(4, 25);
            this.tpProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpProveedores.Name = "tpProveedores";
            this.tpProveedores.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpProveedores.Size = new System.Drawing.Size(1312, 511);
            this.tpProveedores.TabIndex = 1;
            this.tpProveedores.Text = "Proveedores";
            this.tpProveedores.UseVisualStyleBackColor = true;
            this.tpProveedores.Click += new System.EventHandler(this.tpProveedores_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1033, 466);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 37);
            this.btnCancelar.TabIndex = 69;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(1154, 466);
            this.btnAgregarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(91, 37);
            this.btnAgregarProveedor.TabIndex = 68;
            this.btnAgregarProveedor.Text = "Agregar";
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProveedores.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(5, 138);
            this.dgvProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowHeadersWidth = 51;
            this.dgvProveedores.RowTemplate.Height = 24;
            this.dgvProveedores.Size = new System.Drawing.Size(1240, 322);
            this.dgvProveedores.TabIndex = 67;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(518, 53);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 22);
            this.textBox2.TabIndex = 66;
            // 
            // lblCorreoProveedor
            // 
            this.lblCorreoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorreoProveedor.AutoSize = true;
            this.lblCorreoProveedor.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoProveedor.Location = new System.Drawing.Point(435, 50);
            this.lblCorreoProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreoProveedor.Name = "lblCorreoProveedor";
            this.lblCorreoProveedor.Size = new System.Drawing.Size(66, 24);
            this.lblCorreoProveedor.TabIndex = 65;
            this.lblCorreoProveedor.Text = "Correo";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(518, 9);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 22);
            this.textBox3.TabIndex = 64;
            // 
            // lblTelefonoProveedor
            // 
            this.lblTelefonoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefonoProveedor.AutoSize = true;
            this.lblTelefonoProveedor.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoProveedor.Location = new System.Drawing.Point(416, 7);
            this.lblTelefonoProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoProveedor.Name = "lblTelefonoProveedor";
            this.lblTelefonoProveedor.Size = new System.Drawing.Size(85, 24);
            this.lblTelefonoProveedor.TabIndex = 63;
            this.lblTelefonoProveedor.Text = "Teléfono";
            this.lblTelefonoProveedor.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTelefonoContacto
            // 
            this.txtTelefonoContacto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefonoContacto.Location = new System.Drawing.Point(981, 53);
            this.txtTelefonoContacto.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoContacto.Name = "txtTelefonoContacto";
            this.txtTelefonoContacto.Size = new System.Drawing.Size(239, 22);
            this.txtTelefonoContacto.TabIndex = 62;
            this.txtTelefonoContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTelefonoContacto.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblTelefonoContacto
            // 
            this.lblTelefonoContacto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefonoContacto.AutoSize = true;
            this.lblTelefonoContacto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoContacto.Location = new System.Drawing.Point(810, 50);
            this.lblTelefonoContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoContacto.Name = "lblTelefonoContacto";
            this.lblTelefonoContacto.Size = new System.Drawing.Size(163, 24);
            this.lblTelefonoContacto.TabIndex = 61;
            this.lblTelefonoContacto.Text = "Telefono Contacto";
            this.lblTelefonoContacto.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDireccionProveedor
            // 
            this.txtDireccionProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccionProveedor.Location = new System.Drawing.Point(160, 98);
            this.txtDireccionProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionProveedor.Name = "txtDireccionProveedor";
            this.txtDireccionProveedor.Size = new System.Drawing.Size(228, 22);
            this.txtDireccionProveedor.TabIndex = 60;
            // 
            // lblDireccionProveedor
            // 
            this.lblDireccionProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDireccionProveedor.AutoSize = true;
            this.lblDireccionProveedor.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionProveedor.Location = new System.Drawing.Point(8, 96);
            this.lblDireccionProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionProveedor.Name = "lblDireccionProveedor";
            this.lblDireccionProveedor.Size = new System.Drawing.Size(85, 24);
            this.lblDireccionProveedor.TabIndex = 59;
            this.lblDireccionProveedor.Text = "Dirección";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(160, 9);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(171, 22);
            this.textBox6.TabIndex = 58;
            // 
            // lblCodProveedor
            // 
            this.lblCodProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodProveedor.AutoSize = true;
            this.lblCodProveedor.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProveedor.Location = new System.Drawing.Point(8, 12);
            this.lblCodProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodProveedor.Name = "lblCodProveedor";
            this.lblCodProveedor.Size = new System.Drawing.Size(151, 24);
            this.lblCodProveedor.TabIndex = 57;
            this.lblCodProveedor.Text = "Código Proveedor";
            // 
            // txtNombreContacto
            // 
            this.txtNombreContacto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreContacto.Location = new System.Drawing.Point(981, 12);
            this.txtNombreContacto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreContacto.Name = "txtNombreContacto";
            this.txtNombreContacto.Size = new System.Drawing.Size(264, 22);
            this.txtNombreContacto.TabIndex = 56;
            this.txtNombreContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNombreContacto
            // 
            this.lblNombreContacto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreContacto.AutoSize = true;
            this.lblNombreContacto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreContacto.Location = new System.Drawing.Point(820, 12);
            this.lblNombreContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreContacto.Name = "lblNombreContacto";
            this.lblNombreContacto.Size = new System.Drawing.Size(153, 24);
            this.lblNombreContacto.TabIndex = 55;
            this.lblNombreContacto.Text = "Nombre Contacto";
            this.lblNombreContacto.Click += new System.EventHandler(this.lblNombreContacto_Click);
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreProveedor.Location = new System.Drawing.Point(160, 50);
            this.txtNombreProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(228, 22);
            this.txtNombreProveedor.TabIndex = 54;
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProveedor.Location = new System.Drawing.Point(8, 49);
            this.lblNombreProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(75, 24);
            this.lblNombreProveedor.TabIndex = 53;
            this.lblNombreProveedor.Text = "Nombre";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FormRegistroBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 622);
            this.Controls.Add(this.tcRegistro);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRegistroBodega";
            this.Text = "FormRegistroBodega";
            this.Load += new System.EventHandler(this.FormRegistroBodega_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tcRegistro.ResumeLayout(false);
            this.tpProductos.ResumeLayout(false);
            this.tpProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tpProveedores.ResumeLayout(false);
            this.tpProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        private void txtcodigoproducto_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.TabControl tcRegistro;
        private System.Windows.Forms.TabPage tpProductos;
        private System.Windows.Forms.TabPage tpProveedores;
        private System.Windows.Forms.TextBox txtcodigoproducto;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lblprecioCompra;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Button btnCancelarProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCorreoProveedor;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblTelefonoProveedor;
        private System.Windows.Forms.TextBox txtTelefonoContacto;
        private System.Windows.Forms.Label lblTelefonoContacto;
        private System.Windows.Forms.TextBox txtDireccionProveedor;
        private System.Windows.Forms.Label lblDireccionProveedor;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblCodProveedor;
        private System.Windows.Forms.TextBox txtNombreContacto;
        private System.Windows.Forms.Label lblNombreContacto;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.TextBox txtFacturaCompra;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.TextBox txtProveedorProd;
        private System.Windows.Forms.Label lblProveedorProd;
    }
}