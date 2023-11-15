namespace InnoSys.Gerente
{
    partial class Gerente
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
            btnStock = new Button();
            btnEstadisticas = new Button();
            btnZonas = new Button();
            btnAutProductos = new Button();
            btnPedidos = new Button();
            btnMenu = new Button();
            SuspendLayout();
            // 
            // btnStock
            // 
            btnStock.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnStock.Location = new Point(12, 12);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(290, 123);
            btnStock.TabIndex = 7;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += button4_Click;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.BackColor = SystemColors.ControlDarkDark;
            btnEstadisticas.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnEstadisticas.Location = new Point(12, 315);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(290, 123);
            btnEstadisticas.TabIndex = 9;
            btnEstadisticas.Text = "Estadísticas WIP";
            btnEstadisticas.UseVisualStyleBackColor = false;
            // 
            // btnZonas
            // 
            btnZonas.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnZonas.Location = new Point(325, 166);
            btnZonas.Name = "btnZonas";
            btnZonas.Size = new Size(290, 123);
            btnZonas.TabIndex = 10;
            btnZonas.Text = "Zonas";
            btnZonas.UseVisualStyleBackColor = true;
            btnZonas.Click += button3_Click;
            // 
            // btnAutProductos
            // 
            btnAutProductos.BackColor = Color.Coral;
            btnAutProductos.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnAutProductos.Location = new Point(325, 315);
            btnAutProductos.Name = "btnAutProductos";
            btnAutProductos.Size = new Size(290, 123);
            btnAutProductos.TabIndex = 12;
            btnAutProductos.Text = "Autorización nuevos menúes";
            btnAutProductos.UseVisualStyleBackColor = false;
            btnAutProductos.Click += button6_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnPedidos.Location = new Point(12, 166);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(290, 123);
            btnPedidos.TabIndex = 13;
            btnPedidos.Text = "Estado Pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += button7_Click;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.Location = new Point(325, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(290, 123);
            btnMenu.TabIndex = 14;
            btnMenu.Text = "Menú";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += button8_Click;
            // 
            // Gerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(629, 450);
            Controls.Add(btnMenu);
            Controls.Add(btnPedidos);
            Controls.Add(btnAutProductos);
            Controls.Add(btnZonas);
            Controls.Add(btnEstadisticas);
            Controls.Add(btnStock);
            Name = "Gerente";
            Text = "Gerente";
            Load += Gerente_Load;
            Disposed += Login_Disposed;
            ResumeLayout(false);
        }

        #endregion

        private Button btnStock;
        private Button btnEstadisticas;
        private Button btnZonas;
        private Button btnAutProductos;
        private Button btnPedidos;
        private Button btnMenu;
    }
}