namespace InnoSys
{
    partial class VerZonas
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
            lstZonas = new ListBox();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(12, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(153, 54);
            lblTitulo.TabIndex = 35;
            lblTitulo.Text = "ZONAS";
            // 
            // lstZonas
            // 
            lstZonas.FormattingEnabled = true;
            lstZonas.ItemHeight = 15;
            lstZonas.Location = new Point(12, 92);
            lstZonas.Name = "lstZonas";
            lstZonas.Size = new Size(308, 289);
            lstZonas.TabIndex = 38;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 39;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button4_Click;
            // 
            // VerZonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 403);
            ControlBox = false;
            Controls.Add(btnVolver);
            Controls.Add(lstZonas);
            Controls.Add(lblTitulo);
            Name = "VerZonas";
            Text = "VerZonas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ListBox lstZonas;
        private Button btnVolver;
    }
}