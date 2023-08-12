namespace InnoSys
{
    partial class Vehículos
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
            lstVehiculos = new ListBox();
            lblAñadir = new Label();
            txtMatricula = new TextBox();
            lblMatricula = new Label();
            txtCapacidad = new TextBox();
            lblCapacidad = new Label();
            btnAñadirVehiculo = new Button();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 8);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 38;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button4_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(12, 38);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(228, 54);
            lblTitulo.TabIndex = 37;
            lblTitulo.Text = "VEHÍCULOS";
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(12, 95);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(308, 289);
            lstVehiculos.TabIndex = 47;
            // 
            // lblAñadir
            // 
            lblAñadir.AutoSize = true;
            lblAñadir.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAñadir.Location = new Point(364, 95);
            lblAñadir.Name = "lblAñadir";
            lblAñadir.Size = new Size(142, 46);
            lblAñadir.TabIndex = 48;
            lblAñadir.Text = "AÑADIR";
            // 
            // txtMatricula
            // 
            txtMatricula.Cursor = Cursors.IBeam;
            txtMatricula.Location = new Point(435, 159);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 50;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(364, 162);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(65, 15);
            lblMatricula.TabIndex = 49;
            lblMatricula.Text = "Matrícula *";
            // 
            // txtCapacidad
            // 
            txtCapacidad.Cursor = Cursors.IBeam;
            txtCapacidad.Location = new Point(435, 196);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(100, 23);
            txtCapacidad.TabIndex = 52;
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Location = new Point(358, 199);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(71, 15);
            lblCapacidad.TabIndex = 51;
            lblCapacidad.Text = "Capacidad *";
            // 
            // btnAñadirVehiculo
            // 
            btnAñadirVehiculo.Location = new Point(399, 234);
            btnAñadirVehiculo.Name = "btnAñadirVehiculo";
            btnAñadirVehiculo.Size = new Size(136, 23);
            btnAñadirVehiculo.TabIndex = 53;
            btnAñadirVehiculo.Text = "AÑADIR VEHÍCULO";
            btnAñadirVehiculo.UseVisualStyleBackColor = true;
            // 
            // Vehículos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 450);
            Controls.Add(btnAñadirVehiculo);
            Controls.Add(txtCapacidad);
            Controls.Add(lblCapacidad);
            Controls.Add(txtMatricula);
            Controls.Add(lblMatricula);
            Controls.Add(lblAñadir);
            Controls.Add(lstVehiculos);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Name = "Vehículos";
            Text = "Vehículos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblTitulo;
        private ListBox lstVehiculos;
        private Label lblAñadir;
        private TextBox txtMatricula;
        private Label lblMatricula;
        private TextBox txtCapacidad;
        private Label lblCapacidad;
        private Button btnAñadirVehiculo;
    }
}