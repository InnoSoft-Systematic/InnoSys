namespace InnoSys.Transporte
{
    partial class Transporte
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
            btnZonas = new Button();
            btnIngrEnvios = new Button();
            btnEstEnvios = new Button();
            btnSucursales = new Button();
            btnModEnvios = new Button();
            btnVehiculos = new Button();
            SuspendLayout();
            // 
            // btnZonas
            // 
            btnZonas.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnZonas.Location = new Point(336, 12);
            btnZonas.Name = "btnZonas";
            btnZonas.Size = new Size(290, 123);
            btnZonas.TabIndex = 16;
            btnZonas.Text = "Zonas";
            btnZonas.UseVisualStyleBackColor = true;
            btnZonas.Click += button3_Click;
            // 
            // btnIngrEnvios
            // 
            btnIngrEnvios.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngrEnvios.Location = new Point(12, 12);
            btnIngrEnvios.Name = "btnIngrEnvios";
            btnIngrEnvios.Size = new Size(290, 123);
            btnIngrEnvios.TabIndex = 17;
            btnIngrEnvios.Text = "Ingreso de envíos";
            btnIngrEnvios.UseVisualStyleBackColor = true;
            btnIngrEnvios.Click += button1_Click;
            // 
            // btnEstEnvios
            // 
            btnEstEnvios.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnEstEnvios.Location = new Point(12, 295);
            btnEstEnvios.Name = "btnEstEnvios";
            btnEstEnvios.Size = new Size(290, 123);
            btnEstEnvios.TabIndex = 18;
            btnEstEnvios.Text = "Estado de envíos";
            btnEstEnvios.UseVisualStyleBackColor = true;
            btnEstEnvios.Click += button2_Click;
            // 
            // btnSucursales
            // 
            btnSucursales.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnSucursales.Location = new Point(336, 153);
            btnSucursales.Name = "btnSucursales";
            btnSucursales.Size = new Size(290, 123);
            btnSucursales.TabIndex = 19;
            btnSucursales.Text = "Sucursales";
            btnSucursales.UseVisualStyleBackColor = true;
            btnSucursales.Click += button4_Click;
            // 
            // btnModEnvios
            // 
            btnModEnvios.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnModEnvios.Location = new Point(12, 153);
            btnModEnvios.Name = "btnModEnvios";
            btnModEnvios.Size = new Size(290, 123);
            btnModEnvios.TabIndex = 20;
            btnModEnvios.Text = "Modificar estado de envíos";
            btnModEnvios.UseVisualStyleBackColor = true;
            btnModEnvios.Click += button5_Click;
            // 
            // btnVehiculos
            // 
            btnVehiculos.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnVehiculos.Location = new Point(336, 295);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Size = new Size(290, 123);
            btnVehiculos.TabIndex = 21;
            btnVehiculos.Text = "Vehículos";
            btnVehiculos.UseVisualStyleBackColor = true;
            btnVehiculos.Click += button6_Click;
            // 
            // Transporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(647, 450);
            Controls.Add(btnVehiculos);
            Controls.Add(btnModEnvios);
            Controls.Add(btnSucursales);
            Controls.Add(btnEstEnvios);
            Controls.Add(btnIngrEnvios);
            Controls.Add(btnZonas);
            Name = "Transporte";
            Text = "Transporte";
            Load += Transporte_Load;
            ResumeLayout(false);
            this.Disposed += Login_Disposed;
        }

        #endregion

        private Button btnZonas;
        private Button btnIngrEnvios;
        private Button btnEstEnvios;
        private Button btnSucursales;
        private Button btnModEnvios;
        private Button btnVehiculos;
    }
}