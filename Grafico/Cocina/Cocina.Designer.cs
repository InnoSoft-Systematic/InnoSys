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
            btnStock = new Button();
            btnMenu = new Button();
            btnIngrMenu = new Button();
            btnModEstados = new Button();
            SuspendLayout();
            // 
            // btnStock
            // 
            btnStock.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnStock.Location = new Point(324, 150);
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
            btnMenu.Location = new Point(12, 150);
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
            btnIngrMenu.Location = new Point(12, 12);
            btnIngrMenu.Name = "btnIngrMenu";
            btnIngrMenu.Size = new Size(290, 123);
            btnIngrMenu.TabIndex = 25;
            btnIngrMenu.Text = "Ingreso menú";
            btnIngrMenu.UseVisualStyleBackColor = true;
            btnIngrMenu.Click += button1_Click;
            // 
            // btnModEstados
            // 
            btnModEstados.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnModEstados.Location = new Point(324, 12);
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
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(637, 291);
            Controls.Add(btnModEstados);
            Controls.Add(btnIngrMenu);
            Controls.Add(btnMenu);
            Controls.Add(btnStock);
            Name = "Cocina";
            Text = "Cocina";
            Load += Cocina_Load;
            Disposed += Login_Disposed;
            ResumeLayout(false);
        }

        #endregion
        private Button btnStock;
        private Button btnMenu;
        private Button btnIngrMenu;
        private Button btnModEstados;
    }
}