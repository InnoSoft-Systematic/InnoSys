namespace Grafico
{
    partial class Recepcion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btmClientes = new Button();
            btmMenu = new Button();
            btmIngresoPedido = new Button();
            btmEstado = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 37);
            label1.TabIndex = 0;
            label1.Text = "Receptor";
            label1.Click += label1_Click;
            // 
            // btmClientes
            // 
            btmClientes.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btmClientes.Location = new Point(12, 62);
            btmClientes.Name = "btmClientes";
            btmClientes.Size = new Size(215, 185);
            btmClientes.TabIndex = 1;
            btmClientes.Text = "Clientes";
            btmClientes.UseVisualStyleBackColor = true;
            btmClientes.Click += button1_Click;
            // 
            // btmMenu
            // 
            btmMenu.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btmMenu.Location = new Point(288, 302);
            btmMenu.Name = "btmMenu";
            btmMenu.Size = new Size(215, 185);
            btmMenu.TabIndex = 2;
            btmMenu.Text = "Menú";
            btmMenu.UseVisualStyleBackColor = true;
            btmMenu.Click += button2_Click;
            // 
            // btmIngresoPedido
            // 
            btmIngresoPedido.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btmIngresoPedido.Location = new Point(288, 62);
            btmIngresoPedido.Name = "btmIngresoPedido";
            btmIngresoPedido.Size = new Size(215, 185);
            btmIngresoPedido.TabIndex = 3;
            btmIngresoPedido.Text = "Ingresar pedido";
            btmIngresoPedido.UseVisualStyleBackColor = true;
            btmIngresoPedido.Click += button3_Click;
            // 
            // btmEstado
            // 
            btmEstado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btmEstado.Location = new Point(12, 302);
            btmEstado.Name = "btmEstado";
            btmEstado.Size = new Size(215, 185);
            btmEstado.TabIndex = 4;
            btmEstado.Text = "Estados";
            btmEstado.UseVisualStyleBackColor = true;
            btmEstado.Click += btmEstado_Click;
            // 
            // Recepcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 507);
            Controls.Add(btmEstado);
            Controls.Add(btmIngresoPedido);
            Controls.Add(btmMenu);
            Controls.Add(btmClientes);
            Controls.Add(label1);
            Name = "Recepcion";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btmClientes;
        private Button btmMenu;
        private Button btmIngresoPedido;
        private Button btmEstado;
    }
}