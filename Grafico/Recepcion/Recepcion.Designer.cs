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
            lblRecepcion = new Label();
            btnClientes = new Button();
            btnMenu = new Button();
            btnIngresoPedido = new Button();
            btnEstado = new Button();
            SuspendLayout();
            // 
            // lblRecepcion
            // 
            lblRecepcion.AutoSize = true;
            lblRecepcion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecepcion.Location = new Point(12, 9);
            lblRecepcion.Name = "lblRecepcion";
            lblRecepcion.Size = new Size(138, 37);
            lblRecepcion.TabIndex = 0;
            lblRecepcion.Text = "Recepción";
            lblRecepcion.Click += label1_Click;
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.Location = new Point(12, 62);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(215, 185);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += button1_Click;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.Location = new Point(258, 272);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(215, 185);
            btnMenu.TabIndex = 2;
            btnMenu.Text = "Menú";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += button2_Click;
            // 
            // btnIngresoPedido
            // 
            btnIngresoPedido.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresoPedido.Location = new Point(258, 62);
            btnIngresoPedido.Name = "btnIngresoPedido";
            btnIngresoPedido.Size = new Size(215, 185);
            btnIngresoPedido.TabIndex = 3;
            btnIngresoPedido.Text = "Ingresar pedido";
            btnIngresoPedido.UseVisualStyleBackColor = true;
            btnIngresoPedido.Click += button3_Click;
            // 
            // btnEstado
            // 
            btnEstado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnEstado.Location = new Point(12, 272);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(215, 185);
            btnEstado.TabIndex = 4;
            btnEstado.Text = "Estados";
            btnEstado.UseVisualStyleBackColor = true;
            btnEstado.Click += btmEstado_Click;
            // 
            // Recepcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 479);
            Controls.Add(btnEstado);
            Controls.Add(btnIngresoPedido);
            Controls.Add(btnMenu);
            Controls.Add(btnClientes);
            Controls.Add(lblRecepcion);
            Name = "Recepcion";
            Text = "Recepción";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
            this.Disposed += Login_Disposed;
        }

        #endregion

        private Label lblRecepcion;
        private Button btnClientes;
        private Button btnMenu;
        private Button btnIngresoPedido;
        private Button btnEstado;
    }
}