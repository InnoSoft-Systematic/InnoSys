namespace InnoSys.Informatico
{
    partial class AltaEmpleado
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
            btnVolver = new Button();
            lblTitulo = new Label();
            txtCI = new TextBox();
            lblCI = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblRol = new Label();
            cboCargo = new ComboBox();
            btnIngresar = new Button();
            txtApellido2 = new TextBox();
            txtContra = new TextBox();
            label1 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(5, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 34;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btmVolver_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(5, 31);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(321, 54);
            lblTitulo.TabIndex = 33;
            lblTitulo.Text = "ALTA EMPLEADO";
            // 
            // txtCI
            // 
            txtCI.Location = new Point(83, 182);
            txtCI.Name = "txtCI";
            txtCI.Size = new Size(100, 23);
            txtCI.TabIndex = 40;
            // 
            // lblCI
            // 
            lblCI.AutoSize = true;
            lblCI.Location = new Point(51, 185);
            lblCI.Name = "lblCI";
            lblCI.Size = new Size(26, 15);
            lblCI.TabIndex = 39;
            lblCI.Text = "CI *";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(83, 142);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 38;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(16, 145);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(64, 15);
            lblApellido.TabIndex = 37;
            lblApellido.Text = "Apellidos *";
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(83, 102);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 36;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(16, 105);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 15);
            lblNombre.TabIndex = 35;
            lblNombre.Text = "Nombre *";
            lblNombre.Click += label2_Click;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(37, 352);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(24, 15);
            lblRol.TabIndex = 41;
            lblRol.Text = "Rol";
            // 
            // cboCargo
            // 
            cboCargo.FormattingEnabled = true;
            cboCargo.Location = new Point(83, 349);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(121, 23);
            cboCargo.TabIndex = 42;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(93, 405);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(90, 32);
            btnIngresar.TabIndex = 43;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtApellido2
            // 
            txtApellido2.Location = new Point(189, 142);
            txtApellido2.Name = "txtApellido2";
            txtApellido2.Size = new Size(100, 23);
            txtApellido2.TabIndex = 45;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(80, 58);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(100, 23);
            txtContra.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 61);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 48;
            label1.Text = "Contraseña*";
            // 
            // txtUsuario
            // 
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Location = new Point(80, 29);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 32);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 46;
            label2.Text = "Usuario *";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtContra);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(16, 226);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 50;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuario";
            // 
            // AltaEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 450);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(txtApellido2);
            Controls.Add(btnIngresar);
            Controls.Add(cboCargo);
            Controls.Add(lblRol);
            Controls.Add(txtCI);
            Controls.Add(lblCI);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Name = "AltaEmpleado";
            Text = "AltaEmpleado";
            Load += AltaEmpleado_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblTitulo;
        private TextBox txtCI;
        private Label lblCI;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblRol;
        private ComboBox cboCargo;
        private Button btnIngresar;
        private TextBox txtApellido2;
        private TextBox txtContra;
        private Label label1;
        private TextBox txtUsuario;
        private Label label2;
        private GroupBox groupBox1;
    }
}