namespace Grafico
{
    partial class Cliente
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
            lblTituloAlta = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtPrimerApe = new TextBox();
            lblPrimerApe = new Label();
            rboPersona = new RadioButton();
            rboEmpresa = new RadioButton();
            lblTipoCliente = new Label();
            txtCIbaja = new TextBox();
            lblCI = new Label();
            btnBuscar = new Button();
            btnBuscar2 = new Button();
            txtRUTbaja = new TextBox();
            lblRUT = new Label();
            cboCiudad = new ComboBox();
            lblCiudad = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            btmAceptar = new Button();
            btnVolver = new Button();
            lblNoCI = new Label();
            lblSiCI = new Label();
            btmSolBaja = new Button();
            lblInfo2 = new Label();
            lblInfoBaja = new Label();
            lblTituloBaja = new Label();
            gbAlta = new GroupBox();
            txtTel = new TextBox();
            lblTel = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtSegApe = new TextBox();
            lblSegApe = new Label();
            btnBRUT = new Button();
            txtRUTb = new TextBox();
            lblRUTb = new Label();
            btnBCI = new Button();
            txtCIb = new TextBox();
            lblCIb = new Label();
            gbBaja = new GroupBox();
            listBox1 = new ListBox();
            lstCliente = new ListBox();
            gpTipo = new GroupBox();
            gbAlta.SuspendLayout();
            gbBaja.SuspendLayout();
            gpTipo.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloAlta
            // 
            lblTituloAlta.AutoSize = true;
            lblTituloAlta.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloAlta.Location = new Point(27, 42);
            lblTituloAlta.Name = "lblTituloAlta";
            lblTituloAlta.Size = new Size(266, 54);
            lblTituloAlta.TabIndex = 0;
            lblTituloAlta.Text = "ALTA CLIENTE";
            lblTituloAlta.Click += label1_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(63, 120);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre *";
            lblNombre.Click += label2_Click;
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(121, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtPrimerApe
            // 
            txtPrimerApe.Location = new Point(121, 149);
            txtPrimerApe.Name = "txtPrimerApe";
            txtPrimerApe.Size = new Size(100, 23);
            txtPrimerApe.TabIndex = 4;
            txtPrimerApe.TextChanged += textBox2_TextChanged;
            // 
            // lblPrimerApe
            // 
            lblPrimerApe.AutoSize = true;
            lblPrimerApe.Location = new Point(27, 157);
            lblPrimerApe.Name = "lblPrimerApe";
            lblPrimerApe.Size = new Size(95, 15);
            lblPrimerApe.TabIndex = 3;
            lblPrimerApe.Text = "Primer apellido *";
            lblPrimerApe.Click += label3_Click;
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
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoCliente.Location = new Point(454, 91);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(156, 30);
            lblTipoCliente.TabIndex = 7;
            lblTipoCliente.Text = "Tipo de cliente";
            // 
            // txtCIbaja
            // 
            txtCIbaja.Location = new Point(151, 162);
            txtCIbaja.Name = "txtCIbaja";
            txtCIbaja.Size = new Size(100, 23);
            txtCIbaja.TabIndex = 9;
            // 
            // lblCI
            // 
            lblCI.AutoSize = true;
            lblCI.Location = new Point(96, 165);
            lblCI.Name = "lblCI";
            lblCI.Size = new Size(26, 15);
            lblCI.TabIndex = 8;
            lblCI.Text = "CI *";
            lblCI.Click += label5_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(257, 162);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(52, 23);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar2
            // 
            btnBuscar2.Location = new Point(257, 201);
            btnBuscar2.Name = "btnBuscar2";
            btnBuscar2.Size = new Size(52, 23);
            btnBuscar2.TabIndex = 20;
            btnBuscar2.Text = "Buscar";
            btnBuscar2.UseVisualStyleBackColor = true;
            btnBuscar2.Click += button2_Click;
            // 
            // txtRUTbaja
            // 
            txtRUTbaja.Location = new Point(151, 201);
            txtRUTbaja.Name = "txtRUTbaja";
            txtRUTbaja.Size = new Size(100, 23);
            txtRUTbaja.TabIndex = 19;
            txtRUTbaja.TextChanged += textBox7_TextChanged;
            // 
            // lblRUT
            // 
            lblRUT.AutoSize = true;
            lblRUT.Location = new Point(96, 204);
            lblRUT.Name = "lblRUT";
            lblRUT.Size = new Size(36, 15);
            lblRUT.TabIndex = 18;
            lblRUT.Text = "RUT *";
            lblRUT.Click += label9_Click;
            // 
            // cboCiudad
            // 
            cboCiudad.FormattingEnabled = true;
            cboCiudad.Location = new Point(121, 303);
            cboCiudad.Name = "cboCiudad";
            cboCiudad.Size = new Size(121, 23);
            cboCiudad.TabIndex = 22;
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(62, 311);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(42, 15);
            lblCiudad.TabIndex = 21;
            lblCiudad.Text = "Zona *";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(121, 274);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(218, 23);
            txtDireccion.TabIndex = 26;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(57, 282);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(65, 15);
            lblDireccion.TabIndex = 25;
            lblDireccion.Text = "Dirección *";
            // 
            // btmAceptar
            // 
            btmAceptar.Location = new Point(201, 349);
            btmAceptar.Name = "btmAceptar";
            btmAceptar.Size = new Size(92, 35);
            btmAceptar.TabIndex = 31;
            btmAceptar.Text = "INGRESAR";
            btmAceptar.UseVisualStyleBackColor = true;
            btmAceptar.Click += btmAceptar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 7);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 32;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btmVolver_Click;
            // 
            // lblNoCI
            // 
            lblNoCI.AutoSize = true;
            lblNoCI.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoCI.ForeColor = Color.Red;
            lblNoCI.Location = new Point(417, 275);
            lblNoCI.Name = "lblNoCI";
            lblNoCI.Size = new Size(243, 25);
            lblNoCI.TabIndex = 34;
            lblNoCI.Text = "No se encuentra CI ingresada";
            lblNoCI.Click += lblNoCI_Click;
            // 
            // lblSiCI
            // 
            lblSiCI.AutoSize = true;
            lblSiCI.BackColor = Color.Transparent;
            lblSiCI.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblSiCI.ForeColor = Color.LimeGreen;
            lblSiCI.Location = new Point(444, 275);
            lblSiCI.Name = "lblSiCI";
            lblSiCI.Size = new Size(192, 25);
            lblSiCI.TabIndex = 35;
            lblSiCI.Text = "Esta CI ya se encuentra";
            lblSiCI.Click += label15_Click;
            // 
            // btmSolBaja
            // 
            btmSolBaja.Location = new Point(137, 305);
            btmSolBaja.Name = "btmSolBaja";
            btmSolBaja.Size = new Size(172, 34);
            btmSolBaja.TabIndex = 57;
            btmSolBaja.Text = "SOLICITAR BAJA";
            btmSolBaja.UseVisualStyleBackColor = true;
            // 
            // lblInfo2
            // 
            lblInfo2.AutoSize = true;
            lblInfo2.Location = new Point(9, 131);
            lblInfo2.Name = "lblInfo2";
            lblInfo2.Size = new Size(173, 15);
            lblInfo2.TabIndex = 56;
            lblInfo2.Text = "Puedes buscar por CI o por RUT";
            // 
            // lblInfoBaja
            // 
            lblInfoBaja.AutoSize = true;
            lblInfoBaja.Location = new Point(9, 116);
            lblInfoBaja.Name = "lblInfoBaja";
            lblInfoBaja.Size = new Size(405, 15);
            lblInfoBaja.TabIndex = 48;
            lblInfoBaja.Text = "El cliente ingresado quedará sujeto a aprobación de organismo competente";
            lblInfoBaja.Click += lblInfoBaja_Click;
            // 
            // lblTituloBaja
            // 
            lblTituloBaja.AutoSize = true;
            lblTituloBaja.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloBaja.Location = new Point(86, 42);
            lblTituloBaja.Name = "lblTituloBaja";
            lblTituloBaja.Size = new Size(270, 54);
            lblTituloBaja.TabIndex = 46;
            lblTituloBaja.Text = "BAJA CLIENTE";
            // 
            // gbAlta
            // 
            gbAlta.Controls.Add(txtTel);
            gbAlta.Controls.Add(lblTel);
            gbAlta.Controls.Add(txtEmail);
            gbAlta.Controls.Add(lblEmail);
            gbAlta.Controls.Add(txtSegApe);
            gbAlta.Controls.Add(lblSegApe);
            gbAlta.Controls.Add(btmAceptar);
            gbAlta.Controls.Add(lblCiudad);
            gbAlta.Controls.Add(cboCiudad);
            gbAlta.Controls.Add(lblDireccion);
            gbAlta.Controls.Add(txtDireccion);
            gbAlta.Controls.Add(lblPrimerApe);
            gbAlta.Controls.Add(txtPrimerApe);
            gbAlta.Controls.Add(lblTituloAlta);
            gbAlta.Controls.Add(lblNombre);
            gbAlta.Controls.Add(txtNombre);
            gbAlta.Location = new Point(30, 91);
            gbAlta.Name = "gbAlta";
            gbAlta.Size = new Size(346, 395);
            gbAlta.TabIndex = 58;
            gbAlta.TabStop = false;
            gbAlta.Text = "ALTA";
            gbAlta.Enter += groupBox1_Enter;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(121, 245);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(188, 23);
            txtTel.TabIndex = 70;
            txtTel.TextChanged += txtTel_TextChanged;
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(63, 248);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(60, 15);
            lblTel.TabIndex = 69;
            lblTel.Text = "Teléfono *";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(121, 216);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(188, 23);
            txtEmail.TabIndex = 68;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(74, 219);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 67;
            lblEmail.Text = "E-mail";
            // 
            // txtSegApe
            // 
            txtSegApe.Location = new Point(121, 187);
            txtSegApe.Name = "txtSegApe";
            txtSegApe.Size = new Size(100, 23);
            txtSegApe.TabIndex = 61;
            // 
            // lblSegApe
            // 
            lblSegApe.AutoSize = true;
            lblSegApe.Location = new Point(15, 190);
            lblSegApe.Name = "lblSegApe";
            lblSegApe.Size = new Size(107, 15);
            lblSegApe.TabIndex = 32;
            lblSegApe.Text = "Segundo apellido *";
            lblSegApe.Click += label1_Click_1;
            // 
            // btnBRUT
            // 
            btnBRUT.Location = new Point(592, 223);
            btnBRUT.Name = "btnBRUT";
            btnBRUT.Size = new Size(52, 23);
            btnBRUT.TabIndex = 66;
            btnBRUT.Text = "Buscar";
            btnBRUT.UseVisualStyleBackColor = true;
            // 
            // txtRUTb
            // 
            txtRUTb.Location = new Point(486, 223);
            txtRUTb.Name = "txtRUTb";
            txtRUTb.Size = new Size(100, 23);
            txtRUTb.TabIndex = 65;
            txtRUTb.TextChanged += txtRUTb_TextChanged;
            // 
            // lblRUTb
            // 
            lblRUTb.AutoSize = true;
            lblRUTb.Location = new Point(444, 222);
            lblRUTb.Name = "lblRUTb";
            lblRUTb.Size = new Size(36, 15);
            lblRUTb.TabIndex = 64;
            lblRUTb.Text = "RUT *";
            // 
            // btnBCI
            // 
            btnBCI.Location = new Point(592, 189);
            btnBCI.Name = "btnBCI";
            btnBCI.Size = new Size(52, 23);
            btnBCI.TabIndex = 63;
            btnBCI.Text = "Buscar";
            btnBCI.UseVisualStyleBackColor = true;
            btnBCI.Click += btnBCI_Click;
            // 
            // txtCIb
            // 
            txtCIb.Location = new Point(486, 189);
            txtCIb.Name = "txtCIb";
            txtCIb.Size = new Size(100, 23);
            txtCIb.TabIndex = 62;
            txtCIb.TextChanged += txtCialta_TextChanged;
            // 
            // lblCIb
            // 
            lblCIb.AutoSize = true;
            lblCIb.Location = new Point(444, 192);
            lblCIb.Name = "lblCIb";
            lblCIb.Size = new Size(26, 15);
            lblCIb.TabIndex = 61;
            lblCIb.Text = "CI *";
            // 
            // gbBaja
            // 
            gbBaja.Controls.Add(listBox1);
            gbBaja.Controls.Add(btmSolBaja);
            gbBaja.Controls.Add(txtCIbaja);
            gbBaja.Controls.Add(lblInfo2);
            gbBaja.Controls.Add(lblTituloBaja);
            gbBaja.Controls.Add(lblCI);
            gbBaja.Controls.Add(lblInfoBaja);
            gbBaja.Controls.Add(btnBuscar);
            gbBaja.Controls.Add(lblRUT);
            gbBaja.Controls.Add(txtRUTbaja);
            gbBaja.Controls.Add(btnBuscar2);
            gbBaja.Location = new Point(684, 91);
            gbBaja.Name = "gbBaja";
            gbBaja.Size = new Size(429, 384);
            gbBaja.TabIndex = 59;
            gbBaja.TabStop = false;
            gbBaja.Text = "BAJA";
            gbBaja.Enter += groupBox2_Enter;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(9, 245);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(405, 34);
            listBox1.TabIndex = 61;
            // 
            // lstCliente
            // 
            lstCliente.FormattingEnabled = true;
            lstCliente.ItemHeight = 15;
            lstCliente.Location = new Point(279, 512);
            lstCliente.Name = "lstCliente";
            lstCliente.Size = new Size(510, 64);
            lstCliente.TabIndex = 60;
            // 
            // gpTipo
            // 
            gpTipo.Controls.Add(rboEmpresa);
            gpTipo.Controls.Add(rboPersona);
            gpTipo.Location = new Point(409, 94);
            gpTipo.Name = "gpTipo";
            gpTipo.Size = new Size(251, 169);
            gpTipo.TabIndex = 67;
            gpTipo.TabStop = false;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 616);
            ControlBox = false;
            Controls.Add(lstCliente);
            Controls.Add(btnBRUT);
            Controls.Add(lblRUTb);
            Controls.Add(lblCIb);
            Controls.Add(lblSiCI);
            Controls.Add(txtRUTb);
            Controls.Add(lblNoCI);
            Controls.Add(btnVolver);
            Controls.Add(lblTipoCliente);
            Controls.Add(btnBCI);
            Controls.Add(txtCIb);
            Controls.Add(gbAlta);
            Controls.Add(gbBaja);
            Controls.Add(gpTipo);
            Name = "Cliente";
            Text = "Alta cliente";
            Load += Form3_Load;
            gbAlta.ResumeLayout(false);
            gbAlta.PerformLayout();
            gbBaja.ResumeLayout(false);
            gbBaja.PerformLayout();
            gpTipo.ResumeLayout(false);
            gpTipo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloAlta;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtPrimerApe;
        private Label lblPrimerApe;
        private RadioButton rboPersona;
        private RadioButton rboEmpresa;
        private Label lblTipoCliente;
        private TextBox txtCIbaja;
        private Label lblCI;
        private Button btnBuscar;
        private Button btnBuscar2;
        private TextBox txtRUTbaja;
        private Label lblRUT;
        private ComboBox cboCiudad;
        private Label lblCiudad;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private Button btmAceptar;
        private Button btnVolver;
        private Label lblNoCI;
        private Label lblSiCI;
        private Button btmSolBaja;
        private Label lblInfo2;
        private Label lblInfoBaja;
        private Label lblTituloBaja;
        private GroupBox gbAlta;
        private GroupBox gbBaja;
        private ListBox lstCliente;
        private TextBox txtSegApe;
        private Label lblSegApe;
        private Button btnBRUT;
        private TextBox txtRUTb;
        private Label lblRUTb;
        private Button btnBCI;
        private TextBox txtCIb;
        private Label lblCIb;
        private TextBox txtTel;
        private Label lblTel;
        private TextBox txtEmail;
        private Label lblEmail;
        private ListBox listBox1;
        private GroupBox gpTipo;
    }
}