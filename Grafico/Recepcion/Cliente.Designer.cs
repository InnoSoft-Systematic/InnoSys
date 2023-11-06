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
            cboCiudad = new ComboBox();
            lblCiudad = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            btnAceptar = new Button();
            btnVolver = new Button();
            lblNoCI = new Label();
            lblSiCI = new Label();
            gbAlta = new GroupBox();
            btnActualizar = new Button();
            lblEmpresa = new Label();
            txtEmpresa = new TextBox();
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
            lstCliente = new ListBox();
            gpTipo = new GroupBox();
            btnModificar = new Button();
            btnBaja = new Button();
            lblNoRUT = new Label();
            lblSiRUT = new Label();
            gbAlta.SuspendLayout();
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
            // cboCiudad
            // 
            cboCiudad.FormattingEnabled = true;
            cboCiudad.Location = new Point(121, 303);
            cboCiudad.Name = "cboCiudad";
            cboCiudad.Size = new Size(121, 23);
            cboCiudad.TabIndex = 22;
            cboCiudad.SelectedIndexChanged += cboCiudad_SelectedIndexChanged;
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
            // btnAceptar
            // 
            btnAceptar.Location = new Point(129, 354);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(92, 35);
            btnAceptar.TabIndex = 31;
            btnAceptar.Text = "INGRESAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btmAceptar_Click;
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
            lblNoCI.Location = new Point(417, 289);
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
            lblSiCI.Location = new Point(444, 289);
            lblSiCI.Name = "lblSiCI";
            lblSiCI.Size = new Size(192, 25);
            lblSiCI.TabIndex = 35;
            lblSiCI.Text = "Esta CI ya se encuentra";
            lblSiCI.Click += label15_Click;
            // 
            // gbAlta
            // 
            gbAlta.Controls.Add(btnActualizar);
            gbAlta.Controls.Add(lblEmpresa);
            gbAlta.Controls.Add(txtEmpresa);
            gbAlta.Controls.Add(txtTel);
            gbAlta.Controls.Add(lblTel);
            gbAlta.Controls.Add(txtEmail);
            gbAlta.Controls.Add(lblEmail);
            gbAlta.Controls.Add(txtSegApe);
            gbAlta.Controls.Add(lblSegApe);
            gbAlta.Controls.Add(btnAceptar);
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
            gbAlta.Size = new Size(356, 395);
            gbAlta.TabIndex = 58;
            gbAlta.TabStop = false;
            gbAlta.Text = "ALTA";
            gbAlta.Enter += groupBox1_Enter;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(236, 354);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(103, 35);
            btnActualizar.TabIndex = 63;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(62, 190);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(60, 15);
            lblEmpresa.TabIndex = 71;
            lblEmpresa.Text = "Empresa *";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Cursor = Cursors.IBeam;
            txtEmpresa.Location = new Point(121, 187);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(100, 23);
            txtEmpresa.TabIndex = 72;
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
            btnBRUT.Click += btnBRUT_Click;
            // 
            // txtRUTb
            // 
            txtRUTb.Location = new Point(486, 223);
            txtRUTb.MaxLength = 11;
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
            txtCIb.MaxLength = 8;
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
            // lstCliente
            // 
            lstCliente.FormattingEnabled = true;
            lstCliente.ItemHeight = 15;
            lstCliente.Location = new Point(30, 511);
            lstCliente.Name = "lstCliente";
            lstCliente.Size = new Size(510, 79);
            lstCliente.TabIndex = 60;
            // 
            // gpTipo
            // 
            gpTipo.Controls.Add(btnModificar);
            gpTipo.Controls.Add(rboEmpresa);
            gpTipo.Controls.Add(rboPersona);
            gpTipo.Location = new Point(409, 94);
            gpTipo.Name = "gpTipo";
            gpTipo.Size = new Size(251, 192);
            gpTipo.TabIndex = 67;
            gpTipo.TabStop = false;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(95, 163);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(73, 23);
            btnModificar.TabIndex = 62;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.Red;
            btnBaja.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaja.ForeColor = Color.White;
            btnBaja.Location = new Point(546, 553);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(128, 37);
            btnBaja.TabIndex = 62;
            btnBaja.Text = "BAJA";
            btnBaja.UseVisualStyleBackColor = false;
            btnBaja.Click += btnBaja_Click;
            // 
            // lblNoRUT
            // 
            lblNoRUT.AutoSize = true;
            lblNoRUT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoRUT.ForeColor = Color.Red;
            lblNoRUT.Location = new Point(409, 295);
            lblNoRUT.Name = "lblNoRUT";
            lblNoRUT.Size = new Size(261, 25);
            lblNoRUT.TabIndex = 68;
            lblNoRUT.Text = "No se encuentra RUT ingresado";
            // 
            // lblSiRUT
            // 
            lblSiRUT.AutoSize = true;
            lblSiRUT.BackColor = Color.Transparent;
            lblSiRUT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblSiRUT.ForeColor = Color.LimeGreen;
            lblSiRUT.Location = new Point(436, 295);
            lblSiRUT.Name = "lblSiRUT";
            lblSiRUT.Size = new Size(208, 25);
            lblSiRUT.TabIndex = 69;
            lblSiRUT.Text = "Este RUT ya se encuentra";
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 616);
            ControlBox = false;
            Controls.Add(btnBaja);
            Controls.Add(lblSiRUT);
            Controls.Add(lblNoRUT);
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
            Controls.Add(gpTipo);
            Name = "Cliente";
            Text = "Alta cliente";
            Load += Form3_Load;
            gbAlta.ResumeLayout(false);
            gbAlta.PerformLayout();
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
        private ComboBox cboCiudad;
        private Label lblCiudad;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private Button btnAceptar;
        private Button btnVolver;
        private Label lblNoCI;
        private Label lblSiCI;
        private GroupBox gbAlta;
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
        private GroupBox gpTipo;
        private Label lblNoRUT;
        private Label lblSiRUT;
        private Button btnBaja;
        private Button btnModificar;
        private Label lblEmpresa;
        private TextBox txtEmpresa;
        private Button btnActualizar;
    }
}