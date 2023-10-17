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
            lblDepartamento = new Label();
            cboDepartamento = new ComboBox();
            btnBuscar2 = new Button();
            txtRUTbaja = new TextBox();
            lblRUT = new Label();
            cboCiudad = new ComboBox();
            lblCiudad = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            btmAceptar = new Button();
            btnVolver = new Button();
            lblInfo = new Label();
            lblInfoCI = new Label();
            btmSolBaja = new Button();
            lblInfo2 = new Label();
            lblInfoBaja = new Label();
            lblTituloBaja = new Label();
            gbAlta = new GroupBox();
            txtTel = new TextBox();
            lblTel = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            button1 = new Button();
            txtSegApe = new TextBox();
            txtRUTalta = new TextBox();
            lblSegApe = new Label();
            label2 = new Label();
            button2 = new Button();
            txtCialta = new TextBox();
            label3 = new Label();
            gbBaja = new GroupBox();
            listBox1 = new ListBox();
            lstCliente = new ListBox();
            gbAlta.SuspendLayout();
            gbBaja.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloAlta
            // 
            lblTituloAlta.AutoSize = true;
            lblTituloAlta.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloAlta.Location = new Point(63, 153);
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
            rboPersona.Location = new Point(368, 172);
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
            rboEmpresa.Location = new Point(465, 172);
            rboEmpresa.Name = "rboEmpresa";
            rboEmpresa.Size = new Size(70, 19);
            rboEmpresa.TabIndex = 6;
            rboEmpresa.TabStop = true;
            rboEmpresa.Text = "Empresa";
            rboEmpresa.UseVisualStyleBackColor = true;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoCliente.Location = new Point(368, 139);
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
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(28, 280);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(87, 15);
            lblDepartamento.TabIndex = 11;
            lblDepartamento.Text = "Deparamento *";
            lblDepartamento.Click += label6_Click;
            // 
            // cboDepartamento
            // 
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(121, 274);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(121, 23);
            cboDepartamento.TabIndex = 13;
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
            lblCiudad.Location = new Point(48, 309);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(53, 15);
            lblCiudad.TabIndex = 21;
            lblCiudad.Text = "Ciudad *";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(100, 343);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(218, 23);
            txtDireccion.TabIndex = 26;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(15, 346);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(65, 15);
            lblDireccion.TabIndex = 25;
            lblDireccion.Text = "Dirección *";
            // 
            // btmAceptar
            // 
            btmAceptar.Location = new Point(419, 346);
            btmAceptar.Name = "btmAceptar";
            btmAceptar.Size = new Size(75, 23);
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
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(541, 16);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(187, 15);
            lblInfo.TabIndex = 34;
            lblInfo.Text = "No se encuentra el dato ingresado";
            // 
            // lblInfoCI
            // 
            lblInfoCI.AutoSize = true;
            lblInfoCI.BackColor = Color.Transparent;
            lblInfoCI.ForeColor = Color.Red;
            lblInfoCI.Location = new Point(408, 16);
            lblInfoCI.Name = "lblInfoCI";
            lblInfoCI.Size = new Size(127, 15);
            lblInfoCI.TabIndex = 35;
            lblInfoCI.Text = "Esta CI ya se encuentra";
            lblInfoCI.Click += label15_Click;
            // 
            // btmSolBaja
            // 
            btmSolBaja.Location = new Point(786, 391);
            btmSolBaja.Name = "btmSolBaja";
            btmSolBaja.Size = new Size(172, 34);
            btmSolBaja.TabIndex = 57;
            btmSolBaja.Text = "SOLICITAR BAJA";
            btmSolBaja.UseVisualStyleBackColor = true;
            // 
            // lblInfo2
            // 
            lblInfo2.AutoSize = true;
            lblInfo2.Location = new Point(684, 232);
            lblInfo2.Name = "lblInfo2";
            lblInfo2.Size = new Size(173, 15);
            lblInfo2.TabIndex = 56;
            lblInfo2.Text = "Puedes buscar por CI o por RUT";
            // 
            // lblInfoBaja
            // 
            lblInfoBaja.AutoSize = true;
            lblInfoBaja.Location = new Point(673, 207);
            lblInfoBaja.Name = "lblInfoBaja";
            lblInfoBaja.Size = new Size(405, 15);
            lblInfoBaja.TabIndex = 48;
            lblInfoBaja.Text = "El cliente ingresado quedará sujeto a aprobación de organismo competente";
            // 
            // lblTituloBaja
            // 
            lblTituloBaja.AutoSize = true;
            lblTituloBaja.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloBaja.Location = new Point(673, 153);
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
            gbAlta.Controls.Add(button1);
            gbAlta.Controls.Add(txtSegApe);
            gbAlta.Controls.Add(txtRUTalta);
            gbAlta.Controls.Add(lblSegApe);
            gbAlta.Controls.Add(label2);
            gbAlta.Controls.Add(btmAceptar);
            gbAlta.Controls.Add(button2);
            gbAlta.Controls.Add(lblDepartamento);
            gbAlta.Controls.Add(txtCialta);
            gbAlta.Controls.Add(label3);
            gbAlta.Controls.Add(cboDepartamento);
            gbAlta.Controls.Add(lblCiudad);
            gbAlta.Controls.Add(cboCiudad);
            gbAlta.Controls.Add(lblDireccion);
            gbAlta.Controls.Add(txtDireccion);
            gbAlta.Controls.Add(lblPrimerApe);
            gbAlta.Controls.Add(txtPrimerApe);
            gbAlta.Controls.Add(lblNombre);
            gbAlta.Controls.Add(txtNombre);
            gbAlta.Location = new Point(30, 91);
            gbAlta.Name = "gbAlta";
            gbAlta.Size = new Size(533, 395);
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
            // button1
            // 
            button1.Location = new Point(444, 159);
            button1.Name = "button1";
            button1.Size = new Size(52, 23);
            button1.TabIndex = 66;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtSegApe
            // 
            txtSegApe.Location = new Point(121, 187);
            txtSegApe.Name = "txtSegApe";
            txtSegApe.Size = new Size(100, 23);
            txtSegApe.TabIndex = 61;
            // 
            // txtRUTalta
            // 
            txtRUTalta.Location = new Point(338, 159);
            txtRUTalta.Name = "txtRUTalta";
            txtRUTalta.Size = new Size(100, 23);
            txtRUTalta.TabIndex = 65;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 162);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 64;
            label2.Text = "RUT *";
            // 
            // button2
            // 
            button2.Location = new Point(444, 120);
            button2.Name = "button2";
            button2.Size = new Size(52, 23);
            button2.TabIndex = 63;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtCialta
            // 
            txtCialta.Location = new Point(338, 120);
            txtCialta.Name = "txtCialta";
            txtCialta.Size = new Size(100, 23);
            txtCialta.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 123);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 61;
            label3.Text = "CI *";
            // 
            // gbBaja
            // 
            gbBaja.Controls.Add(listBox1);
            gbBaja.Controls.Add(txtCIbaja);
            gbBaja.Controls.Add(lblCI);
            gbBaja.Controls.Add(btnBuscar);
            gbBaja.Controls.Add(lblRUT);
            gbBaja.Controls.Add(txtRUTbaja);
            gbBaja.Controls.Add(btnBuscar2);
            gbBaja.Location = new Point(664, 91);
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
            lstCliente.Location = new Point(53, 499);
            lstCliente.Name = "lstCliente";
            lstCliente.Size = new Size(510, 64);
            lstCliente.TabIndex = 60;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 616);
            ControlBox = false;
            Controls.Add(lstCliente);
            Controls.Add(btmSolBaja);
            Controls.Add(lblInfo2);
            Controls.Add(lblInfoBaja);
            Controls.Add(lblTituloBaja);
            Controls.Add(lblInfoCI);
            Controls.Add(lblInfo);
            Controls.Add(btnVolver);
            Controls.Add(lblTipoCliente);
            Controls.Add(rboEmpresa);
            Controls.Add(rboPersona);
            Controls.Add(lblTituloAlta);
            Controls.Add(gbAlta);
            Controls.Add(gbBaja);
            Name = "Cliente";
            Text = "Alta cliente";
            Load += Form3_Load;
            gbAlta.ResumeLayout(false);
            gbAlta.PerformLayout();
            gbBaja.ResumeLayout(false);
            gbBaja.PerformLayout();
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
        private Label lblDepartamento;
        private ComboBox cboDepartamento;
        private Button btnBuscar2;
        private TextBox txtRUTbaja;
        private Label lblRUT;
        private ComboBox cboCiudad;
        private Label lblCiudad;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private Button btmAceptar;
        private Button btnVolver;
        private Label lblInfo;
        private Label lblInfoCI;
        private Button btmSolBaja;
        private Label lblInfo2;
        private Label lblInfoBaja;
        private Label lblTituloBaja;
        private GroupBox gbAlta;
        private GroupBox gbBaja;
        private ListBox lstCliente;
        private TextBox txtSegApe;
        private Label lblSegApe;
        private Button button1;
        private TextBox txtRUTalta;
        private Label label2;
        private Button button2;
        private TextBox txtCialta;
        private Label label3;
        private TextBox txtTel;
        private Label lblTel;
        private TextBox txtEmail;
        private Label lblEmail;
        private ListBox listBox1;
    }
}