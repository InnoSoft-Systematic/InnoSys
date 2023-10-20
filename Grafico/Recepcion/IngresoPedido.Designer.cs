namespace Grafico
{
    partial class IngresoPedido
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
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            btnVolver = new Button();
            txtCliente = new TextBox();
            lblCliente = new Label();
            cboMenu = new ComboBox();
            lblMenu = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label3 = new Label();
            btnBuscar = new Button();
            rboQuincenal = new RadioButton();
            rboSemanal = new RadioButton();
            rboMensual = new RadioButton();
            lblCantidad = new Label();
            chbVegetariano = new CheckBox();
            cboCeliaco = new CheckBox();
            cboBajaCalorias = new CheckBox();
            chlViandas = new CheckedListBox();
            lblTipo = new Label();
            rboPersonalizado = new RadioButton();
            rboFijo = new RadioButton();
            label7 = new Label();
            btnIngresar = new Button();
            lblTemp2 = new Label();
            label9 = new Label();
            lblInformacionCliente = new Label();
            lblTemp = new Label();
            txtCanitdadMenu = new TextBox();
            lblCanitdadMenu = new Label();
            lstPedidoCliente = new ListBox();
            lblListaPedido = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(12, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(336, 54);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "INGRESO PEDIDO";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 33;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button4_Click;
            // 
            // txtCliente
            // 
            txtCliente.Cursor = Cursors.IBeam;
            txtCliente.Location = new Point(109, 86);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(100, 23);
            txtCliente.TabIndex = 35;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(26, 90);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 34;
            lblCliente.Text = "Cliente";
            // 
            // cboMenu
            // 
            cboMenu.FormattingEnabled = true;
            cboMenu.Location = new Point(57, 230);
            cboMenu.Name = "cboMenu";
            cboMenu.Size = new Size(121, 23);
            cboMenu.TabIndex = 37;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Location = new Point(57, 212);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(46, 15);
            lblMenu.TabIndex = 36;
            lblMenu.Text = "Menú *";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(450, 92);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 41;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(228, 86);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(52, 23);
            btnBuscar.TabIndex = 42;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // rboQuincenal
            // 
            rboQuincenal.AutoSize = true;
            rboQuincenal.Location = new Point(471, 92);
            rboQuincenal.Name = "rboQuincenal";
            rboQuincenal.Size = new Size(79, 19);
            rboQuincenal.TabIndex = 44;
            rboQuincenal.TabStop = true;
            rboQuincenal.Text = "Quincenal";
            rboQuincenal.UseVisualStyleBackColor = true;
            // 
            // rboSemanal
            // 
            rboSemanal.AutoSize = true;
            rboSemanal.Location = new Point(389, 90);
            rboSemanal.Name = "rboSemanal";
            rboSemanal.Size = new Size(70, 19);
            rboSemanal.TabIndex = 43;
            rboSemanal.TabStop = true;
            rboSemanal.Text = "Semanal";
            rboSemanal.UseVisualStyleBackColor = true;
            // 
            // rboMensual
            // 
            rboMensual.AutoSize = true;
            rboMensual.Location = new Point(563, 92);
            rboMensual.Name = "rboMensual";
            rboMensual.Size = new Size(70, 19);
            rboMensual.TabIndex = 45;
            rboMensual.TabStop = true;
            rboMensual.Text = "Mensual";
            rboMensual.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidad.Location = new Point(471, 53);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(99, 30);
            lblCantidad.TabIndex = 46;
            lblCantidad.Text = "Cantidad";
            // 
            // chbVegetariano
            // 
            chbVegetariano.AutoSize = true;
            chbVegetariano.Location = new Point(304, 221);
            chbVegetariano.Name = "chbVegetariano";
            chbVegetariano.Size = new Size(88, 19);
            chbVegetariano.TabIndex = 47;
            chbVegetariano.Text = "Vegetariano";
            chbVegetariano.UseVisualStyleBackColor = true;
            // 
            // cboCeliaco
            // 
            cboCeliaco.AutoSize = true;
            cboCeliaco.Location = new Point(304, 271);
            cboCeliaco.Name = "cboCeliaco";
            cboCeliaco.Size = new Size(65, 19);
            cboCeliaco.TabIndex = 48;
            cboCeliaco.Text = "Celíaco";
            cboCeliaco.UseVisualStyleBackColor = true;
            // 
            // cboBajaCalorias
            // 
            cboBajaCalorias.AutoSize = true;
            cboBajaCalorias.Location = new Point(304, 246);
            cboBajaCalorias.Name = "cboBajaCalorias";
            cboBajaCalorias.Size = new Size(91, 19);
            cboBajaCalorias.TabIndex = 49;
            cboBajaCalorias.Text = "Baja calorías";
            cboBajaCalorias.UseVisualStyleBackColor = true;
            // 
            // chlViandas
            // 
            chlViandas.FormattingEnabled = true;
            chlViandas.Items.AddRange(new object[] { "Pure con milanesa", "Ensalada de verduras", "Pan sin harina" });
            chlViandas.Location = new Point(519, 212);
            chlViandas.Name = "chlViandas";
            chlViandas.Size = new Size(138, 202);
            chlViandas.TabIndex = 50;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.Location = new Point(336, 139);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(56, 30);
            lblTipo.TabIndex = 51;
            lblTipo.Text = "Tipo";
            // 
            // rboPersonalizado
            // 
            rboPersonalizado.AutoSize = true;
            rboPersonalizado.Location = new Point(450, 175);
            rboPersonalizado.Name = "rboPersonalizado";
            rboPersonalizado.Size = new Size(98, 19);
            rboPersonalizado.TabIndex = 54;
            rboPersonalizado.TabStop = true;
            rboPersonalizado.Text = "Personalizado";
            rboPersonalizado.UseVisualStyleBackColor = true;
            // 
            // rboFijo
            // 
            rboFijo.AutoSize = true;
            rboFijo.Location = new Point(196, 175);
            rboFijo.Name = "rboFijo";
            rboFijo.Size = new Size(44, 19);
            rboFijo.TabIndex = 53;
            rboFijo.TabStop = true;
            rboFijo.Text = "Fijo";
            rboFijo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(450, 175);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 52;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(528, 483);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(129, 68);
            btnIngresar.TabIndex = 55;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += button2_Click;
            // 
            // lblTemp2
            // 
            lblTemp2.AutoSize = true;
            lblTemp2.Location = new Point(405, 194);
            lblTemp2.Name = "lblTemp2";
            lblTemp2.Size = new Size(209, 15);
            lblTemp2.TabIndex = 56;
            lblTemp2.Text = "*Si elije personalizado, se muestra esto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(57, 307);
            label9.Name = "label9";
            label9.Size = new Size(309, 15);
            label9.TabIndex = 57;
            label9.Text = "*Si marca estos parámetros, reduce la búsqueda de menú";
            // 
            // lblInformacionCliente
            // 
            lblInformacionCliente.AutoSize = true;
            lblInformacionCliente.Location = new Point(35, 130);
            lblInformacionCliente.Name = "lblInformacionCliente";
            lblInformacionCliente.Size = new Size(134, 15);
            lblInformacionCliente.TabIndex = 61;
            lblInformacionCliente.Text = "*Información del cliente";
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Location = new Point(110, 197);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(153, 15);
            lblTemp.TabIndex = 62;
            lblTemp.Text = "*Si elije fijo, se muestra esto";
            // 
            // txtCanitdadMenu
            // 
            txtCanitdadMenu.Cursor = Cursors.IBeam;
            txtCanitdadMenu.Location = new Point(57, 273);
            txtCanitdadMenu.Name = "txtCanitdadMenu";
            txtCanitdadMenu.Size = new Size(46, 23);
            txtCanitdadMenu.TabIndex = 64;
            // 
            // lblCanitdadMenu
            // 
            lblCanitdadMenu.AutoSize = true;
            lblCanitdadMenu.Location = new Point(57, 256);
            lblCanitdadMenu.Name = "lblCanitdadMenu";
            lblCanitdadMenu.Size = new Size(55, 15);
            lblCanitdadMenu.TabIndex = 65;
            lblCanitdadMenu.Text = "Cantidad";
            // 
            // lstPedidoCliente
            // 
            lstPedidoCliente.FormattingEnabled = true;
            lstPedidoCliente.ItemHeight = 15;
            lstPedidoCliente.Location = new Point(269, 397);
            lstPedidoCliente.Name = "lstPedidoCliente";
            lstPedidoCliente.Size = new Size(152, 154);
            lstPedidoCliente.TabIndex = 66;
            // 
            // lblListaPedido
            // 
            lblListaPedido.AutoSize = true;
            lblListaPedido.Location = new Point(269, 365);
            lblListaPedido.Name = "lblListaPedido";
            lblListaPedido.Size = new Size(149, 15);
            lblListaPedido.TabIndex = 67;
            lblListaPedido.Text = "*Lista de pedido del cliente";
            // 
            // IngresoPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 563);
            ControlBox = false;
            Controls.Add(lblListaPedido);
            Controls.Add(lstPedidoCliente);
            Controls.Add(lblCanitdadMenu);
            Controls.Add(txtCanitdadMenu);
            Controls.Add(lblTemp);
            Controls.Add(lblInformacionCliente);
            Controls.Add(label9);
            Controls.Add(lblTemp2);
            Controls.Add(btnIngresar);
            Controls.Add(rboPersonalizado);
            Controls.Add(rboFijo);
            Controls.Add(label7);
            Controls.Add(lblTipo);
            Controls.Add(chlViandas);
            Controls.Add(cboBajaCalorias);
            Controls.Add(cboCeliaco);
            Controls.Add(chbVegetariano);
            Controls.Add(lblCantidad);
            Controls.Add(rboMensual);
            Controls.Add(rboQuincenal);
            Controls.Add(rboSemanal);
            Controls.Add(btnBuscar);
            Controls.Add(label3);
            Controls.Add(cboMenu);
            Controls.Add(lblMenu);
            Controls.Add(txtCliente);
            Controls.Add(lblCliente);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Name = "IngresoPedido";
            Text = "         ";
            Load += IngresoPedido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnVolver;
        private TextBox txtCliente;
        private Label lblCliente;
        private ComboBox cboMenu;
        private Label lblMenu;
        private ContextMenuStrip contextMenuStrip1;
        private Label label3;
        private Button btnBuscar;
        private RadioButton rboQuincenal;
        private RadioButton rboSemanal;
        private RadioButton rboMensual;
        private Label lblCantidad;
        private CheckBox chbVegetariano;
        private CheckBox cboCeliaco;
        private CheckBox cboBajaCalorias;
        private CheckedListBox chlViandas;
        private Label lblTipo;
        private RadioButton rboPersonalizado;
        private RadioButton rboFijo;
        private Label label7;
        private Button btnIngresar;
        private Label lblTemp2;
        private Label label9;
        private Label lblInformacionCliente;
        private Label lblTemp;
        private TextBox txtCanitdadMenu;
        private Label lblCanitdadMenu;
        private ListBox lstPedidoCliente;
        private Label lblListaPedido;
    }
}