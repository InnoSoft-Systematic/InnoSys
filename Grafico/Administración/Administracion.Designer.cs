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
            btnEnvíos = new Button();
            btnAutCuentas = new Button();
            btnIngreso = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.White;
            btnClientes.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.Location = new Point(318, 162);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(290, 123);
            btnClientes.TabIndex = 16;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += button6_Click;
            // 
            // btnEnvíos
            // 
            btnEnvíos.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnvíos.Location = new Point(318, 12);
            btnEnvíos.Name = "btnEnvíos";
            btnEnvíos.Size = new Size(290, 123);
            btnEnvíos.TabIndex = 19;
            btnEnvíos.Text = "Estado Pedidos";
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
            // btnIngreso
            // 
            btnIngreso.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngreso.Location = new Point(12, 162);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(290, 123);
            btnIngreso.TabIndex = 23;
            btnIngreso.Text = "Ingreso Cliente";
            btnIngreso.UseVisualStyleBackColor = true;
            btnIngreso.Click += btnIngreso_Click;
            // 
            // Administracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(615, 300);
            Controls.Add(btnIngreso);
            Controls.Add(btnAutCuentas);
            Controls.Add(btnEnvíos);
            Controls.Add(btnClientes);
            Name = "Administracion";
            Text = "Administracion";
            Load += Administracion_Load;
            Disposed += Login_Disposed;
            ResumeLayout(false);
        }

        #endregion
        private Button btnClientes;
        private Button btnEnvíos;
        private Button btnAutCuentas;
        private Button btnIngreso;
    }
}