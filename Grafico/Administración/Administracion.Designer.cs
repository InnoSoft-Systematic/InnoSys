namespace InnoSys.Administración
{
    partial class Administracion
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
            btnPedidos = new Button();
            btnEnvíos = new Button();
            btnAutCuentas = new Button();
            btnVehículos = new Button();
            btnIngrZona = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.White;
            btnClientes.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.Location = new Point(318, 12);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(290, 123);
            btnClientes.TabIndex = 16;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += button6_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnPedidos.Location = new Point(12, 153);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(290, 123);
            btnPedidos.TabIndex = 17;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += button2_Click;
            // 
            // btnEnvíos
            // 
            btnEnvíos.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnvíos.Location = new Point(318, 153);
            btnEnvíos.Name = "btnEnvíos";
            btnEnvíos.Size = new Size(290, 123);
            btnEnvíos.TabIndex = 19;
            btnEnvíos.Text = "Envíos";
            btnEnvíos.UseVisualStyleBackColor = true;
            btnEnvíos.Click += button5_Click;
            // 
            // btnAutCuentas
            // 
            btnAutCuentas.BackColor = Color.Coral;
            btnAutCuentas.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnAutCuentas.Location = new Point(12, 12);
            btnAutCuentas.Name = "btnAutCuentas";
            btnAutCuentas.Size = new Size(290, 123);
            btnAutCuentas.TabIndex = 20;
            btnAutCuentas.Text = "Autorización cuentas clientes";
            btnAutCuentas.UseVisualStyleBackColor = false;
            btnAutCuentas.Click += button1_Click;
            // 
            // btnVehículos
            // 
            btnVehículos.BackColor = Color.White;
            btnVehículos.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnVehículos.Location = new Point(614, 12);
            btnVehículos.Name = "btnVehículos";
            btnVehículos.Size = new Size(290, 123);
            btnVehículos.TabIndex = 21;
            btnVehículos.Text = "Vehíuclos";
            btnVehículos.UseVisualStyleBackColor = false;
            btnVehículos.Click += button3_Click;
            // 
            // btnIngrZona
            // 
            btnIngrZona.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngrZona.Location = new Point(614, 153);
            btnIngrZona.Name = "btnIngrZona";
            btnIngrZona.Size = new Size(290, 123);
            btnIngrZona.TabIndex = 22;
            btnIngrZona.Text = "Ingresar Zona";
            btnIngrZona.UseVisualStyleBackColor = true;
            btnIngrZona.Click += button4_Click;
            // 
            // Administracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 306);
            Controls.Add(btnIngrZona);
            Controls.Add(btnVehículos);
            Controls.Add(btnAutCuentas);
            Controls.Add(btnEnvíos);
            Controls.Add(btnPedidos);
            Controls.Add(btnClientes);
            Name = "Administracion";
            Text = "Administracion";
            Load += Administracion_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnClientes;
        private Button btnPedidos;
        private Button btnEnvíos;
        private Button btnAutCuentas;
        private Button btnVehículos;
        private Button btnIngrZona;
    }
}