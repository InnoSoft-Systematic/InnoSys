namespace InnoSys
{
    partial class Estados
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
            btnVolver = new Button();
            lblTitulo = new Label();
            lstEstados = new ListBox();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 8);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 35;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button4_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(1, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(187, 54);
            lblTitulo.TabIndex = 34;
            lblTitulo.Text = "ESTADOS";
            // 
            // lstEstados
            // 
            lstEstados.FormattingEnabled = true;
            lstEstados.ItemHeight = 15;
            lstEstados.Location = new Point(12, 111);
            lstEstados.Name = "lstEstados";
            lstEstados.Size = new Size(308, 289);
            lstEstados.TabIndex = 37;
            // 
            // Estados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 412);
            ControlBox = false;
            Controls.Add(lstEstados);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Name = "Estados";
            Text = "Estados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblTitulo;
        private ListBox lstEstados;
    }
}