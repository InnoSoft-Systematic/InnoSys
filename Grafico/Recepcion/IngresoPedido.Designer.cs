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
            cboMenu = new ComboBox();
            lblMenu = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label3 = new Label();
            rboQuincenal = new RadioButton();
            rboSemanal = new RadioButton();
            rboMensual = new RadioButton();
            chbVegetariano = new CheckBox();
            cboCeliaco = new CheckBox();
            cboBajaCalorias = new CheckBox();
            chlViandas = new CheckedListBox();
            rboPersonalizado = new RadioButton();
            rboFijo = new RadioButton();
            label7 = new Label();
            lblInformacionClienteCI = new Label();
            lstPedidoCliente = new ListBox();
            lblListaPedido = new Label();
            btnBRUT = new Button();
            lblRUTb = new Label();
            lblCIb = new Label();
            txtRUTb = new TextBox();
            lblTipoCliente = new Label();
            btnBCI = new Button();
            txtCIb = new TextBox();
            rboPersona = new RadioButton();
            rboEmpresa = new RadioButton();
            gbCliente = new GroupBox();
            lblInformacionClienteRUT = new Label();
            gbTipo = new GroupBox();
            gbFijo = new GroupBox();
            btnAñadir = new Button();
            gbFijog = new GroupBox();
            gbFiltro = new GroupBox();
            btnActualizar = new Button();
            label1 = new Label();
            button1 = new Button();
            gbTipoMenu = new GroupBox();
            gbPersonalizado = new GroupBox();
            gbCliente.SuspendLayout();
            gbTipo.SuspendLayout();
            gbFijo.SuspendLayout();
            gbFijog.SuspendLayout();
            gbFiltro.SuspendLayout();
            gbTipoMenu.SuspendLayout();
            gbPersonalizado.SuspendLayout();
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
            lblTitulo.Click += lblTitulo_Click;
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
            // cboMenu
            // 
            cboMenu.FormattingEnabled = true;
            cboMenu.Location = new Point(28, 34);
            cboMenu.Name = "cboMenu";
            cboMenu.Size = new Size(121, 23);
            cboMenu.TabIndex = 37;
            cboMenu.SelectedIndexChanged += cboMenu_SelectedIndexChanged;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Location = new Point(28, 16);
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
            label3.Location = new Point(487, 64);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 41;
            // 
            // rboQuincenal
            // 
            rboQuincenal.AutoSize = true;
            rboQuincenal.Location = new Point(82, 33);
            rboQuincenal.Name = "rboQuincenal";
            rboQuincenal.Size = new Size(79, 19);
            rboQuincenal.TabIndex = 44;
            rboQuincenal.TabStop = true;
            rboQuincenal.Text = "Quincenal";
            rboQuincenal.UseVisualStyleBackColor = true;
            rboQuincenal.CheckedChanged += rboQuincenal_CheckedChanged;
            // 
            // rboSemanal
            // 
            rboSemanal.AutoSize = true;
            rboSemanal.Location = new Point(6, 33);
            rboSemanal.Name = "rboSemanal";
            rboSemanal.Size = new Size(70, 19);
            rboSemanal.TabIndex = 43;
            rboSemanal.TabStop = true;
            rboSemanal.Text = "Semanal";
            rboSemanal.UseVisualStyleBackColor = true;
            rboSemanal.CheckedChanged += rboSemanal_CheckedChanged;
            // 
            // rboMensual
            // 
            rboMensual.AutoSize = true;
            rboMensual.Location = new Point(165, 35);
            rboMensual.Name = "rboMensual";
            rboMensual.Size = new Size(70, 19);
            rboMensual.TabIndex = 45;
            rboMensual.TabStop = true;
            rboMensual.Text = "Mensual";
            rboMensual.UseVisualStyleBackColor = true;
            rboMensual.CheckedChanged += rboMensual_CheckedChanged;
            // 
            // chbVegetariano
            // 
            chbVegetariano.AutoSize = true;
            chbVegetariano.Location = new Point(24, 22);
            chbVegetariano.Name = "chbVegetariano";
            chbVegetariano.Size = new Size(88, 19);
            chbVegetariano.TabIndex = 47;
            chbVegetariano.Text = "Vegetariano";
            chbVegetariano.UseVisualStyleBackColor = true;
            // 
            // cboCeliaco
            // 
            cboCeliaco.AutoSize = true;
            cboCeliaco.Location = new Point(24, 72);
            cboCeliaco.Name = "cboCeliaco";
            cboCeliaco.Size = new Size(65, 19);
            cboCeliaco.TabIndex = 48;
            cboCeliaco.Text = "Celíaco";
            cboCeliaco.UseVisualStyleBackColor = true;
            // 
            // cboBajaCalorias
            // 
            cboBajaCalorias.AutoSize = true;
            cboBajaCalorias.Location = new Point(24, 47);
            cboBajaCalorias.Name = "cboBajaCalorias";
            cboBajaCalorias.Size = new Size(91, 19);
            cboBajaCalorias.TabIndex = 49;
            cboBajaCalorias.Text = "Baja calorías";
            cboBajaCalorias.UseVisualStyleBackColor = true;
            // 
            // chlViandas
            // 
            chlViandas.FormattingEnabled = true;
            chlViandas.Location = new Point(75, 120);
            chlViandas.Name = "chlViandas";
            chlViandas.Size = new Size(138, 184);
            chlViandas.TabIndex = 50;
            chlViandas.SelectedIndexChanged += chlViandas_SelectedIndexChanged;
            // 
            // rboPersonalizado
            // 
            rboPersonalizado.AutoSize = true;
            rboPersonalizado.Location = new Point(101, 38);
            rboPersonalizado.Name = "rboPersonalizado";
            rboPersonalizado.Size = new Size(98, 19);
            rboPersonalizado.TabIndex = 54;
            rboPersonalizado.TabStop = true;
            rboPersonalizado.Text = "Personalizado";
            rboPersonalizado.UseVisualStyleBackColor = true;
            rboPersonalizado.CheckedChanged += rboPersonalizado_CheckedChanged;
            // 
            // rboFijo
            // 
            rboFijo.AutoSize = true;
            rboFijo.Location = new Point(33, 38);
            rboFijo.Name = "rboFijo";
            rboFijo.Size = new Size(44, 19);
            rboFijo.TabIndex = 53;
            rboFijo.TabStop = true;
            rboFijo.Text = "Fijo";
            rboFijo.UseVisualStyleBackColor = true;
            rboFijo.CheckedChanged += rboFijo_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(450, 175);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 52;
            // 
            // lblInformacionClienteCI
            // 
            lblInformacionClienteCI.AutoSize = true;
            lblInformacionClienteCI.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblInformacionClienteCI.Location = new Point(68, 270);
            lblInformacionClienteCI.Name = "lblInformacionClienteCI";
            lblInformacionClienteCI.Size = new Size(157, 17);
            lblInformacionClienteCI.TabIndex = 61;
            lblInformacionClienteCI.Text = "*Información del cliente";
            // 
            // lstPedidoCliente
            // 
            lstPedidoCliente.FormattingEnabled = true;
            lstPedidoCliente.ItemHeight = 15;
            lstPedidoCliente.Location = new Point(72, 323);
            lstPedidoCliente.Name = "lstPedidoCliente";
            lstPedidoCliente.Size = new Size(152, 94);
            lstPedidoCliente.TabIndex = 66;
            // 
            // lblListaPedido
            // 
            lblListaPedido.AutoSize = true;
            lblListaPedido.Location = new Point(68, 305);
            lblListaPedido.Name = "lblListaPedido";
            lblListaPedido.Size = new Size(163, 15);
            lblListaPedido.TabIndex = 67;
            lblListaPedido.Text = "Lista de pedidos por el cliente";
            // 
            // btnBRUT
            // 
            btnBRUT.Location = new Point(204, 215);
            btnBRUT.Name = "btnBRUT";
            btnBRUT.Size = new Size(52, 23);
            btnBRUT.TabIndex = 76;
            btnBRUT.Text = "Buscar";
            btnBRUT.UseVisualStyleBackColor = true;
            btnBRUT.Click += btnBRUT_Click;
            // 
            // lblRUTb
            // 
            lblRUTb.AutoSize = true;
            lblRUTb.Location = new Point(56, 214);
            lblRUTb.Name = "lblRUTb";
            lblRUTb.Size = new Size(36, 15);
            lblRUTb.TabIndex = 74;
            lblRUTb.Text = "RUT *";
            // 
            // lblCIb
            // 
            lblCIb.AutoSize = true;
            lblCIb.Location = new Point(56, 184);
            lblCIb.Name = "lblCIb";
            lblCIb.Size = new Size(26, 15);
            lblCIb.TabIndex = 71;
            lblCIb.Text = "CI *";
            // 
            // txtRUTb
            // 
            txtRUTb.Location = new Point(98, 215);
            txtRUTb.MaxLength = 11;
            txtRUTb.Name = "txtRUTb";
            txtRUTb.Size = new Size(100, 23);
            txtRUTb.TabIndex = 75;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoCliente.Location = new Point(51, -3);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(156, 30);
            lblTipoCliente.TabIndex = 70;
            lblTipoCliente.Text = "Tipo de cliente";
            // 
            // btnBCI
            // 
            btnBCI.Location = new Point(204, 181);
            btnBCI.Name = "btnBCI";
            btnBCI.Size = new Size(52, 23);
            btnBCI.TabIndex = 73;
            btnBCI.Text = "Buscar";
            btnBCI.UseVisualStyleBackColor = true;
            btnBCI.Click += btnBCI_Click;
            // 
            // txtCIb
            // 
            txtCIb.Location = new Point(98, 181);
            txtCIb.MaxLength = 8;
            txtCIb.Name = "txtCIb";
            txtCIb.Size = new Size(100, 23);
            txtCIb.TabIndex = 72;
            // 
            // rboPersona
            // 
            rboPersona.AutoSize = true;
            rboPersona.Location = new Point(35, 49);
            rboPersona.Name = "rboPersona";
            rboPersona.Size = new Size(67, 19);
            rboPersona.TabIndex = 5;
            rboPersona.TabStop = true;
            rboPersona.Text = "Persona";
            rboPersona.UseVisualStyleBackColor = true;
            rboPersona.CheckedChanged += rboPersona_CheckedChanged;
            // 
            // rboEmpresa
            // 
            rboEmpresa.AutoSize = true;
            rboEmpresa.Location = new Point(150, 49);
            rboEmpresa.Name = "rboEmpresa";
            rboEmpresa.Size = new Size(70, 19);
            rboEmpresa.TabIndex = 6;
            rboEmpresa.TabStop = true;
            rboEmpresa.Text = "Empresa";
            rboEmpresa.UseVisualStyleBackColor = true;
            rboEmpresa.CheckedChanged += rboEmpresa_CheckedChanged;
            // 
            // gbCliente
            // 
            gbCliente.Controls.Add(rboEmpresa);
            gbCliente.Controls.Add(rboPersona);
            gbCliente.Controls.Add(lblTipoCliente);
            gbCliente.Location = new Point(26, 86);
            gbCliente.Name = "gbCliente";
            gbCliente.Size = new Size(251, 175);
            gbCliente.TabIndex = 77;
            gbCliente.TabStop = false;
            // 
            // lblInformacionClienteRUT
            // 
            lblInformacionClienteRUT.AutoSize = true;
            lblInformacionClienteRUT.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblInformacionClienteRUT.Location = new Point(69, 270);
            lblInformacionClienteRUT.Name = "lblInformacionClienteRUT";
            lblInformacionClienteRUT.Size = new Size(157, 17);
            lblInformacionClienteRUT.TabIndex = 78;
            lblInformacionClienteRUT.Text = "*Información del cliente";
            lblInformacionClienteRUT.Click += lblInformacionClienteRUT_Click;
            // 
            // gbTipo
            // 
            gbTipo.Controls.Add(rboSemanal);
            gbTipo.Controls.Add(rboQuincenal);
            gbTipo.Controls.Add(rboMensual);
            gbTipo.Location = new Point(14, 28);
            gbTipo.Name = "gbTipo";
            gbTipo.Size = new Size(241, 68);
            gbTipo.TabIndex = 79;
            gbTipo.TabStop = false;
            gbTipo.Text = "Tipo";
            // 
            // gbFijo
            // 
            gbFijo.Controls.Add(btnAñadir);
            gbFijo.Controls.Add(cboMenu);
            gbFijo.Controls.Add(lblMenu);
            gbFijo.Location = new Point(6, 43);
            gbFijo.Name = "gbFijo";
            gbFijo.Size = new Size(158, 115);
            gbFijo.TabIndex = 80;
            gbFijo.TabStop = false;
            gbFijo.Text = "Fijo";
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(41, 69);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(88, 31);
            btnAñadir.TabIndex = 82;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // gbFijog
            // 
            gbFijog.Controls.Add(gbFijo);
            gbFijog.Location = new Point(297, 103);
            gbFijog.Name = "gbFijog";
            gbFijog.Size = new Size(185, 170);
            gbFijog.TabIndex = 81;
            gbFijog.TabStop = false;
            gbFijog.Text = "Fijo";
            // 
            // gbFiltro
            // 
            gbFiltro.Controls.Add(chbVegetariano);
            gbFiltro.Controls.Add(cboBajaCalorias);
            gbFiltro.Controls.Add(cboCeliaco);
            gbFiltro.Location = new Point(331, 313);
            gbFiltro.Name = "gbFiltro";
            gbFiltro.Size = new Size(119, 94);
            gbFiltro.TabIndex = 82;
            gbFiltro.TabStop = false;
            gbFiltro.Text = "Filtrar";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(654, 12);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 83;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 102);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 81;
            label1.Text = "Selecciona las viandas";
            // 
            // button1
            // 
            button1.Location = new Point(75, 310);
            button1.Name = "button1";
            button1.Size = new Size(138, 23);
            button1.TabIndex = 83;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // gbTipoMenu
            // 
            gbTipoMenu.Controls.Add(rboFijo);
            gbTipoMenu.Controls.Add(rboPersonalizado);
            gbTipoMenu.Location = new Point(373, 26);
            gbTipoMenu.Name = "gbTipoMenu";
            gbTipoMenu.Size = new Size(220, 71);
            gbTipoMenu.TabIndex = 84;
            gbTipoMenu.TabStop = false;
            gbTipoMenu.Text = "Tipo de menú";
            // 
            // gbPersonalizado
            // 
            gbPersonalizado.Controls.Add(chlViandas);
            gbPersonalizado.Controls.Add(button1);
            gbPersonalizado.Controls.Add(gbTipo);
            gbPersonalizado.Controls.Add(label1);
            gbPersonalizado.Location = new Point(499, 103);
            gbPersonalizado.Name = "gbPersonalizado";
            gbPersonalizado.Size = new Size(261, 342);
            gbPersonalizado.TabIndex = 85;
            gbPersonalizado.TabStop = false;
            gbPersonalizado.Text = "Personalizado";
            // 
            // IngresoPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 463);
            ControlBox = false;
            Controls.Add(gbPersonalizado);
            Controls.Add(gbTipoMenu);
            Controls.Add(btnActualizar);
            Controls.Add(gbFiltro);
            Controls.Add(lblInformacionClienteRUT);
            Controls.Add(btnBRUT);
            Controls.Add(lblRUTb);
            Controls.Add(lblCIb);
            Controls.Add(txtRUTb);
            Controls.Add(btnBCI);
            Controls.Add(txtCIb);
            Controls.Add(gbCliente);
            Controls.Add(lblListaPedido);
            Controls.Add(lstPedidoCliente);
            Controls.Add(lblInformacionClienteCI);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Controls.Add(gbFijog);
            Name = "IngresoPedido";
            Text = "         ";
            Load += IngresoPedido_Load;
            gbCliente.ResumeLayout(false);
            gbCliente.PerformLayout();
            gbTipo.ResumeLayout(false);
            gbTipo.PerformLayout();
            gbFijo.ResumeLayout(false);
            gbFijo.PerformLayout();
            gbFijog.ResumeLayout(false);
            gbFiltro.ResumeLayout(false);
            gbFiltro.PerformLayout();
            gbTipoMenu.ResumeLayout(false);
            gbTipoMenu.PerformLayout();
            gbPersonalizado.ResumeLayout(false);
            gbPersonalizado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnVolver;
        private ComboBox cboMenu;
        private Label lblMenu;
        private ContextMenuStrip contextMenuStrip1;
        private Label label3;
        private RadioButton rboQuincenal;
        private RadioButton rboSemanal;
        private RadioButton rboMensual;
        private CheckBox chbVegetariano;
        private CheckBox cboCeliaco;
        private CheckBox cboBajaCalorias;
        private CheckedListBox chlViandas;
        private Label lblTipo;
        private RadioButton rboPersonalizado;
        private RadioButton rboFijo;
        private Label label7;
        private Label lblInformacionClienteCI;
        private ListBox lstPedidoCliente;
        private Label lblListaPedido;
        private Button btnBRUT;
        private Label lblRUTb;
        private Label lblCIb;
        private TextBox txtRUTb;
        private Label lblTipoCliente;
        private Button btnBCI;
        private TextBox txtCIb;
        private RadioButton rboPersona;
        private RadioButton rboEmpresa;
        private GroupBox gbCliente;
        private Label lblInformacionClienteRUT;
        private GroupBox gbTipo;
        private GroupBox gbFijo;
        private Button btnAñadir;
        private GroupBox gbFijog;
        private GroupBox gbFiltro;
        private Button btnActualizar;
        private Button button1;
        private Label label1;
        private GroupBox gbTipoMenu;
        private GroupBox gbPersonalizado;
    }
}