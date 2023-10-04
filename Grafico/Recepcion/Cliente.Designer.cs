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
            txtApellido = new TextBox();
            lblApellido = new Label();
            rboPersona = new RadioButton();
            rboEmpresa = new RadioButton();
            lblTipoCliente = new Label();
            txtCI = new TextBox();
            lblCI = new Label();
            btnBuscar = new Button();
            lblDepartamento = new Label();
            cboDepartamento = new ComboBox();
            btnBuscar2 = new Button();
            txtRUT = new TextBox();
            lblRUT = new Label();
            cboCiudad = new ComboBox();
            lblCiudad = new Label();
            cboBarrio = new ComboBox();
            lblBarrio = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtObservaciones = new TextBox();
            lblObservaciones = new Label();
            btmAceptar = new Button();
            btnVolver = new Button();
            lblInfo = new Label();
            lblInfoCI = new Label();
            btmSolBaja = new Button();
            lblInfo2 = new Label();
            lblInfoBaja = new Label();
            lblTituloBaja = new Label();
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
            lblNombre.Location = new Point(96, 211);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre *";
            lblNombre.Click += label2_Click;
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(153, 208);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(153, 248);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 4;
            txtApellido.TextChanged += textBox2_TextChanged;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(91, 251);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(64, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellidos *";
            lblApellido.Click += label3_Click;
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
            // txtCI
            // 
            txtCI.Location = new Point(545, 325);
            txtCI.Name = "txtCI";
            txtCI.Size = new Size(100, 23);
            txtCI.TabIndex = 9;
            // 
            // lblCI
            // 
            lblCI.AutoSize = true;
            lblCI.Location = new Point(508, 329);
            lblCI.Name = "lblCI";
            lblCI.Size = new Size(26, 15);
            lblCI.TabIndex = 8;
            lblCI.Text = "CI *";
            lblCI.Click += label5_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(651, 325);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(52, 23);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(68, 378);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(87, 15);
            lblDepartamento.TabIndex = 11;
            lblDepartamento.Text = "Deparamento *";
            lblDepartamento.Click += label6_Click;
            // 
            // cboDepartamento
            // 
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(153, 375);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(121, 23);
            cboDepartamento.TabIndex = 13;
            // 
            // btnBuscar2
            // 
            btnBuscar2.Location = new Point(651, 364);
            btnBuscar2.Name = "btnBuscar2";
            btnBuscar2.Size = new Size(52, 23);
            btnBuscar2.TabIndex = 20;
            btnBuscar2.Text = "Buscar";
            btnBuscar2.UseVisualStyleBackColor = true;
            btnBuscar2.Click += button2_Click;
            // 
            // txtRUT
            // 
            txtRUT.Location = new Point(545, 364);
            txtRUT.Name = "txtRUT";
            txtRUT.Size = new Size(100, 23);
            txtRUT.TabIndex = 19;
            txtRUT.TextChanged += textBox7_TextChanged;
            // 
            // lblRUT
            // 
            lblRUT.AutoSize = true;
            lblRUT.Location = new Point(508, 368);
            lblRUT.Name = "lblRUT";
            lblRUT.Size = new Size(36, 15);
            lblRUT.TabIndex = 18;
            lblRUT.Text = "RUT *";
            lblRUT.Click += label9_Click;
            // 
            // cboCiudad
            // 
            cboCiudad.FormattingEnabled = true;
            cboCiudad.Location = new Point(153, 404);
            cboCiudad.Name = "cboCiudad";
            cboCiudad.Size = new Size(121, 23);
            cboCiudad.TabIndex = 22;
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(68, 407);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(53, 15);
            lblCiudad.TabIndex = 21;
            lblCiudad.Text = "Ciudad *";
            // 
            // cboBarrio
            // 
            cboBarrio.FormattingEnabled = true;
            cboBarrio.Location = new Point(153, 433);
            cboBarrio.Name = "cboBarrio";
            cboBarrio.Size = new Size(121, 23);
            cboBarrio.TabIndex = 24;
            // 
            // lblBarrio
            // 
            lblBarrio.AutoSize = true;
            lblBarrio.Location = new Point(68, 436);
            lblBarrio.Name = "lblBarrio";
            lblBarrio.Size = new Size(46, 15);
            lblBarrio.TabIndex = 23;
            lblBarrio.Text = "Barrio *";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(153, 462);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(218, 23);
            txtDireccion.TabIndex = 26;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(68, 470);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(65, 15);
            lblDireccion.TabIndex = 25;
            lblDireccion.Text = "Dirección *";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(153, 502);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(218, 23);
            txtObservaciones.TabIndex = 28;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Location = new Point(63, 505);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(84, 15);
            lblObservaciones.TabIndex = 27;
            lblObservaciones.Text = "Observaciones";
            // 
            // btmAceptar
            // 
            btmAceptar.Location = new Point(236, 554);
            btmAceptar.Name = "btmAceptar";
            btmAceptar.Size = new Size(75, 23);
            btmAceptar.TabIndex = 31;
            btmAceptar.Text = "ACEPTAR";
            btmAceptar.UseVisualStyleBackColor = true;
            btmAceptar.Click += btmAceptar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(6, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 32;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btmVolver_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(368, 256);
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
            lblInfoCI.Location = new Point(378, 291);
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
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 616);
            ControlBox = false;
            Controls.Add(btmSolBaja);
            Controls.Add(lblInfo2);
            Controls.Add(lblInfoBaja);
            Controls.Add(lblTituloBaja);
            Controls.Add(lblInfoCI);
            Controls.Add(lblInfo);
            Controls.Add(btnVolver);
            Controls.Add(btmAceptar);
            Controls.Add(txtObservaciones);
            Controls.Add(lblObservaciones);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(cboBarrio);
            Controls.Add(lblBarrio);
            Controls.Add(cboCiudad);
            Controls.Add(lblCiudad);
            Controls.Add(btnBuscar2);
            Controls.Add(txtRUT);
            Controls.Add(lblRUT);
            Controls.Add(cboDepartamento);
            Controls.Add(lblDepartamento);
            Controls.Add(btnBuscar);
            Controls.Add(txtCI);
            Controls.Add(lblCI);
            Controls.Add(lblTipoCliente);
            Controls.Add(rboEmpresa);
            Controls.Add(rboPersona);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTituloAlta);
            Name = "Cliente";
            Text = "Alta cliente";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloAlta;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private RadioButton rboPersona;
        private RadioButton rboEmpresa;
        private Label lblTipoCliente;
        private TextBox txtCI;
        private Label lblCI;
        private Button btnBuscar;
        private Label lblDepartamento;
        private ComboBox cboDepartamento;
        private Button btnBuscar2;
        private TextBox txtRUT;
        private Label lblRUT;
        private ComboBox cboCiudad;
        private Label lblCiudad;
        private ComboBox cboBarrio;
        private Label lblBarrio;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtObservaciones;
        private Label lblObservaciones;
        private Button btmAceptar;
        private Button btnVolver;
        private Label lblInfo;
        private Label lblInfoCI;
        private Button btmSolBaja;
        private Label lblInfo2;
        private Label lblInfoBaja;
        private Label lblTituloBaja;
    }
}