namespace InnoSys
{
    partial class EstadoEnvios
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
            lblTitulos = new Label();
            lstEnvios = new ListBox();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(16, 6);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 34;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btmVolver_Click;
            // 
            // lblTitulos
            // 
            lblTitulos.AutoSize = true;
            lblTitulos.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulos.Location = new Point(12, 32);
            lblTitulos.Name = "lblTitulos";
            lblTitulos.Size = new Size(314, 54);
            lblTitulos.TabIndex = 33;
            lblTitulos.Text = "ESTADO ENVÍOS";
            // 
            // lstEnvios
            // 
            lstEnvios.FormattingEnabled = true;
            lstEnvios.ItemHeight = 15;
            lstEnvios.Location = new Point(16, 100);
            lstEnvios.Name = "lstEnvios";
            lstEnvios.Size = new Size(743, 229);
            lstEnvios.TabIndex = 35;
            // 
            // EstadoEnvios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 362);
            Controls.Add(lstEnvios);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulos);
            Name = "EstadoEnvios";
            Text = "Estado Envios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblTitulos;
        private ListBox lstEnvios;
    }
}