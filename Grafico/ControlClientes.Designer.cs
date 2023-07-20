namespace Grafico
{
    partial class ControlClientes
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
            btmAltaCliente = new Button();
            btmBajaCliente = new Button();
            SuspendLayout();
            // 
            // btmAltaCliente
            // 
            btmAltaCliente.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btmAltaCliente.Location = new Point(45, 48);
            btmAltaCliente.Name = "btmAltaCliente";
            btmAltaCliente.Size = new Size(215, 185);
            btmAltaCliente.TabIndex = 2;
            btmAltaCliente.Text = "Alta clientes";
            btmAltaCliente.UseVisualStyleBackColor = true;
            btmAltaCliente.Click += button1_Click;
            // 
            // btmBajaCliente
            // 
            btmBajaCliente.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btmBajaCliente.Location = new Point(361, 48);
            btmBajaCliente.Name = "btmBajaCliente";
            btmBajaCliente.Size = new Size(215, 185);
            btmBajaCliente.TabIndex = 3;
            btmBajaCliente.Text = "Baja clientes";
            btmBajaCliente.UseVisualStyleBackColor = true;
            btmBajaCliente.Click += button2_Click;
            // 
            // ControlClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 280);
            Controls.Add(btmBajaCliente);
            Controls.Add(btmAltaCliente);
            Name = "ControlClientes";
            Text = "Control clientes";
            ResumeLayout(false);
        }

        #endregion

        private Button btmAltaCliente;
        private Button btmBajaCliente;
    }
}