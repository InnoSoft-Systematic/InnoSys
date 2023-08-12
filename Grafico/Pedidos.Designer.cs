namespace InnoSys
{
    partial class Pedidos
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
            lblTitulo = new Label();
            btnVolver = new Button();
            lstPedidos = new ListBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(12, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(183, 54);
            lblTitulo.TabIndex = 35;
            lblTitulo.Text = "PEDIDOS";
            lblTitulo.Click += label2_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(21, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 36;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button4_Click;
            // 
            // lstPedidos
            // 
            lstPedidos.FormattingEnabled = true;
            lstPedidos.ItemHeight = 15;
            lstPedidos.Location = new Point(12, 104);
            lstPedidos.Name = "lstPedidos";
            lstPedidos.Size = new Size(308, 289);
            lstPedidos.TabIndex = 38;
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 450);
            Controls.Add(lstPedidos);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Name = "Pedidos";
            Text = "Pedidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnVolver;
        private ListBox lstPedidos;
    }
}