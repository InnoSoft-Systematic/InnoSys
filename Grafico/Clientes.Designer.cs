namespace InnoSys
{
    partial class Clientes
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
            lstClientes = new ListBox();
            lblTipoCliente = new Label();
            cboTipoCliente = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(12, 36);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(190, 54);
            lblTitulo.TabIndex = 54;
            lblTitulo.Text = "CLIENTES";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 55;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button4_Click;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.ItemHeight = 15;
            lstClientes.Location = new Point(12, 106);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(308, 289);
            lstClientes.TabIndex = 56;
            lstClientes.SelectedIndexChanged += lstClientes_SelectedIndexChanged;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Location = new Point(341, 106);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(115, 15);
            lblTipoCliente.TabIndex = 57;
            lblTipoCliente.Text = "Filtrar tipo de cliente";
            // 
            // cboTipoCliente
            // 
            cboTipoCliente.FormattingEnabled = true;
            cboTipoCliente.Location = new Point(341, 133);
            cboTipoCliente.Name = "cboTipoCliente";
            cboTipoCliente.Size = new Size(121, 23);
            cboTipoCliente.TabIndex = 58;
            // 
            // button1
            // 
            button1.Location = new Point(395, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 59;
            button1.Text = "Cargar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 450);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(cboTipoCliente);
            Controls.Add(lblTipoCliente);
            Controls.Add(lstClientes);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnVolver;
        private ListBox lstClientes;
        private Label lblTipoCliente;
        private ComboBox cboTipoCliente;
        private Button button1;
    }
}