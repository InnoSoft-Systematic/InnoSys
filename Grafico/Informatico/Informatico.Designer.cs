using Grafico;

namespace InnoSys.Administrador
{
    partial class Informatico
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
            btnClientes = new Button();
            btnZonas = new Button();
            btnMenu = new Button();
            btnEnvíos = new Button();
            btnCambiarRol = new Button();
            btnVehiculos = new Button();
            btnStock = new Button();
            btnCuerpoDir = new Button();
            btnAñadirZonas = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.White;
            btnClientes.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.Location = new Point(12, 12);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(290, 123);
            btnClientes.TabIndex = 13;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += button6_Click;
            // 
            // btnZonas
            // 
            btnZonas.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnZonas.Location = new Point(321, 12);
            btnZonas.Name = "btnZonas";
            btnZonas.Size = new Size(290, 123);
            btnZonas.TabIndex = 15;
            btnZonas.Text = "Zonas";
            btnZonas.UseVisualStyleBackColor = true;
            btnZonas.Click += button3_Click;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.Location = new Point(633, 141);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(290, 123);
            btnMenu.TabIndex = 17;
            btnMenu.Text = "Menú";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += button4_Click;
            // 
            // btnEnvíos
            // 
            btnEnvíos.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnvíos.Location = new Point(633, 12);
            btnEnvíos.Name = "btnEnvíos";
            btnEnvíos.Size = new Size(290, 123);
            btnEnvíos.TabIndex = 18;
            btnEnvíos.Text = "Envíos";
            btnEnvíos.UseVisualStyleBackColor = true;
            btnEnvíos.Click += btnEnvíos_Click;
            // 
            // btnCambiarRol
            // 
            btnCambiarRol.BackColor = Color.Brown;
            btnCambiarRol.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnCambiarRol.Location = new Point(646, 426);
            btnCambiarRol.Name = "btnCambiarRol";
            btnCambiarRol.Size = new Size(290, 65);
            btnCambiarRol.TabIndex = 19;
            btnCambiarRol.Text = "CAMBIAR ROL";
            btnCambiarRol.UseVisualStyleBackColor = false;
            btnCambiarRol.Click += button7_Click;
            // 
            // btnVehiculos
            // 
            btnVehiculos.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnVehiculos.Location = new Point(12, 141);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Size = new Size(290, 123);
            btnVehiculos.TabIndex = 21;
            btnVehiculos.Text = "Vehículos";
            btnVehiculos.UseVisualStyleBackColor = true;
            btnVehiculos.Click += button9_Click;
            // 
            // btnStock
            // 
            btnStock.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnStock.Location = new Point(321, 141);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(290, 123);
            btnStock.TabIndex = 22;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += button10_Click;
            // 
            // btnCuerpoDir
            // 
            btnCuerpoDir.BackColor = Color.FromArgb(255, 128, 0);
            btnCuerpoDir.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnCuerpoDir.Location = new Point(12, 276);
            btnCuerpoDir.Name = "btnCuerpoDir";
            btnCuerpoDir.Size = new Size(290, 123);
            btnCuerpoDir.TabIndex = 23;
            btnCuerpoDir.Text = "Cuerpo directivo";
            btnCuerpoDir.UseVisualStyleBackColor = false;
            btnCuerpoDir.Click += button1_Click;
            // 
            // btnAñadirZonas
            // 
            btnAñadirZonas.BackColor = Color.FromArgb(255, 255, 192);
            btnAñadirZonas.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnAñadirZonas.Location = new Point(12, 412);
            btnAñadirZonas.Name = "btnAñadirZonas";
            btnAñadirZonas.Size = new Size(290, 93);
            btnAñadirZonas.TabIndex = 20;
            btnAñadirZonas.Text = "Sucursal";
            btnAñadirZonas.UseVisualStyleBackColor = false;
            btnAñadirZonas.Click += button8_Click;
            // 
            // Informatico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(957, 516);
            Controls.Add(btnCuerpoDir);
            Controls.Add(btnStock);
            Controls.Add(btnVehiculos);
            Controls.Add(btnAñadirZonas);
            Controls.Add(btnCambiarRol);
            Controls.Add(btnEnvíos);
            Controls.Add(btnMenu);
            Controls.Add(btnZonas);
            Controls.Add(btnClientes);
            Name = "Informatico";
            Text = "Informático";
            Load += Informatico_Load;
            Disposed += Login_Disposed;
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnZonas;
        private Button btnMenu;
        private Button btnEnvíos;
        private Button btnCambiarRol;
        private Button btnVehiculos;
        private Button btnStock;
        private Button btnCuerpoDir;
        private Button btnAñadirZonas;
    }
}