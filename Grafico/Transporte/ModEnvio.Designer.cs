namespace InnoSys
{
    partial class ModEnvio
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
            lblEstado = new Label();
            btnVolver = new Button();
            btnAlterarEstado = new Button();
            lbl = new Label();
            cboEstado = new ComboBox();
            lstModEnvios = new ListBox();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(250, 131);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(82, 15);
            lblEstado.TabIndex = 84;
            lblEstado.Text = "Elige el estado";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(24, 10);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 83;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button4_Click;
            // 
            // btnAlterarEstado
            // 
            btnAlterarEstado.Location = new Point(207, 210);
            btnAlterarEstado.Name = "btnAlterarEstado";
            btnAlterarEstado.Size = new Size(173, 55);
            btnAlterarEstado.TabIndex = 82;
            btnAlterarEstado.Text = "ALTERAR ESTADO";
            btnAlterarEstado.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(24, 101);
            lbl.Name = "lbl";
            lbl.Size = new Size(168, 15);
            lbl.TabIndex = 81;
            lbl.Text = "Selecciona el estado a cambiar";
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(229, 159);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(121, 23);
            cboEstado.TabIndex = 80;
            // 
            // lstModEnvios
            // 
            lstModEnvios.FormattingEnabled = true;
            lstModEnvios.ItemHeight = 15;
            lstModEnvios.Location = new Point(24, 131);
            lstModEnvios.Name = "lstModEnvios";
            lstModEnvios.Size = new Size(168, 259);
            lstModEnvios.TabIndex = 79;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(12, 36);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(382, 54);
            lblTitulo.TabIndex = 78;
            lblTitulo.Text = "MODIFICAR ENVÍOS";
            // 
            // ModEnvio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 450);
            ControlBox = false;
            Controls.Add(lblEstado);
            Controls.Add(btnVolver);
            Controls.Add(btnAlterarEstado);
            Controls.Add(lbl);
            Controls.Add(cboEstado);
            Controls.Add(lstModEnvios);
            Controls.Add(lblTitulo);
            Name = "ModEnvio";
            Text = "ModEnvio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEstado;
        private Button btnVolver;
        private Button btnAlterarEstado;
        private Label lbl;
        private ComboBox cboEstado;
        private ListBox lstModEnvios;
        private Label lblTitulo;
    }
}