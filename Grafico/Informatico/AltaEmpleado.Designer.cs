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
            lblCargo = new Label();
            cboCargo = new ComboBox();
            btnIngresar = new Button();
            txtNombre2 = new TextBox();
            txtApellido2 = new TextBox();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(16, 5);
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
            lblTitulo.Location = new Point(12, 31);
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
            lblNombre.Size = new Size(64, 15);
            lblNombre.TabIndex = 35;
            lblNombre.Text = "Nombres *";
            lblNombre.Click += label2_Click;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(38, 223);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(39, 15);
            lblCargo.TabIndex = 41;
            lblCargo.Text = "Cargo";
            // 
            // cboCargo
            // 
            cboCargo.FormattingEnabled = true;
            cboCargo.Location = new Point(83, 220);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(121, 23);
            cboCargo.TabIndex = 42;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(124, 279);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(90, 32);
            btnIngresar.TabIndex = 43;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // txtNombre2
            // 
            txtNombre2.Cursor = Cursors.IBeam;
            txtNombre2.Location = new Point(189, 102);
            txtNombre2.Name = "txtNombre2";
            txtNombre2.Size = new Size(100, 23);
            txtNombre2.TabIndex = 44;
            // 
            // txtApellido2
            // 
            txtApellido2.Location = new Point(189, 145);
            txtApellido2.Name = "txtApellido2";
            txtApellido2.Size = new Size(100, 23);
            txtApellido2.TabIndex = 45;
            // 
            // AltaEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 329);
            ControlBox = false;
            Controls.Add(txtApellido2);
            Controls.Add(txtNombre2);
            Controls.Add(btnIngresar);
            Controls.Add(cboCargo);
            Controls.Add(lblCargo);
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
        private Label lblCargo;
        private ComboBox cboCargo;
        private Button btnIngresar;
        private TextBox txtNombre2;
        private TextBox txtApellido2;
    }
}