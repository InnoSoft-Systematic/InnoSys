namespace InnoSys
{
    partial class Cocina
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
            btnPedidos = new Button();
            btnStock = new Button();
            btnMenu = new Button();
            btnIngrMenu = new Button();
            btnEstados = new Button();
            btnModEstados = new Button();
            SuspendLayout();
            // 
            // btnPedidos
            // 
            btnPedidos.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnPedidos.Location = new Point(12, 12);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(290, 123);
            btnPedidos.TabIndex = 17;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += button2_Click;
            // 
            // btnStock
            // 
            btnStock.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnStock.Location = new Point(324, 12);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(290, 123);
            btnStock.TabIndex = 23;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += button10_Click;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.Location = new Point(324, 141);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(290, 123);
            btnMenu.TabIndex = 24;
            btnMenu.Text = "Menú";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += button4_Click;
            // 
            // btnIngrMenu
            // 
            btnIngrMenu.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngrMenu.Location = new Point(324, 279);
            btnIngrMenu.Name = "btnIngrMenu";
            btnIngrMenu.Size = new Size(290, 123);
            btnIngrMenu.TabIndex = 25;
            btnIngrMenu.Text = "Ingreso menú";
            btnIngrMenu.UseVisualStyleBackColor = true;
            btnIngrMenu.Click += button1_Click;
            // 
            // btnEstados
            // 
            btnEstados.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnEstados.Location = new Point(12, 141);
            btnEstados.Name = "btnEstados";
            btnEstados.Size = new Size(290, 123);
            btnEstados.TabIndex = 26;
            btnEstados.Text = "Estados";
            btnEstados.UseVisualStyleBackColor = true;
            btnEstados.Click += button3_Click;
            // 
            // btnModEstados
            // 
            btnModEstados.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnModEstados.Location = new Point(12, 279);
            btnModEstados.Name = "btnModEstados";
            btnModEstados.Size = new Size(290, 123);
            btnModEstados.TabIndex = 27;
            btnModEstados.Text = "Modificar estados";
            btnModEstados.UseVisualStyleBackColor = true;
            btnModEstados.Click += button5_Click;
            // 
            // Cocina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 419);
            Controls.Add(btnModEstados);
            Controls.Add(btnEstados);
            Controls.Add(btnIngrMenu);
            Controls.Add(btnMenu);
            Controls.Add(btnStock);
            Controls.Add(btnPedidos);
            Name = "Cocina";
            Text = "Cocina";
            Load += Cocina_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnPedidos;
        private Button btnStock;
        private Button btnMenu;
        private Button btnIngrMenu;
        private Button btnEstados;
        private Button btnModEstados;
    }
}