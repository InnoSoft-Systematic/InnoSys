namespace InnoSys
{
    partial class Sucursales
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
            lstSucursarles = new ListBox();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 42;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button4_Click;
            // 
            // lstSucursarles
            // 
            lstSucursarles.FormattingEnabled = true;
            lstSucursarles.ItemHeight = 15;
            lstSucursarles.Location = new Point(12, 85);
            lstSucursarles.Name = "lstSucursarles";
            lstSucursarles.Size = new Size(308, 289);
            lstSucursarles.TabIndex = 41;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(12, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(254, 54);
            lblTitulo.TabIndex = 40;
            lblTitulo.Text = "SUCURSALES";
            // 
            // Sucursales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 402);
            ControlBox = false;
            Controls.Add(btnVolver);
            Controls.Add(lstSucursarles);
            Controls.Add(lblTitulo);
            Name = "Sucursales";
            Text = "Sucursales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private ListBox lstSucursarles;
        private Label lblTitulo;
    }
}