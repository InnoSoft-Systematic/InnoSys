namespace InnoSys
{
    partial class ModEstados
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
            btnAlterarEstado = new Button();
            lblDescripcion = new Label();
            cboEstado = new ComboBox();
            lstEnvios = new ListBox();
            lblTitulo = new Label();
            btnVolver = new Button();
            lblEstado = new Label();
            SuspendLayout();
            // 
            // btnAlterarEstado
            // 
            btnAlterarEstado.Location = new Point(195, 211);
            btnAlterarEstado.Name = "btnAlterarEstado";
            btnAlterarEstado.Size = new Size(173, 55);
            btnAlterarEstado.TabIndex = 75;
            btnAlterarEstado.Text = "ALTERAR ESTADO";
            btnAlterarEstado.UseVisualStyleBackColor = true;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(12, 102);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(222, 15);
            lblDescripcion.TabIndex = 74;
            lblDescripcion.Text = "Selecciona el estado DE ENVÍO a cambiar";
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(217, 160);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(121, 23);
            cboEstado.TabIndex = 73;
            // 
            // lstEnvios
            // 
            lstEnvios.FormattingEnabled = true;
            lstEnvios.ItemHeight = 15;
            lstEnvios.Location = new Point(12, 132);
            lstEnvios.Name = "lstEnvios";
            lstEnvios.Size = new Size(168, 259);
            lstEnvios.TabIndex = 72;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(0, 37);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(361, 54);
            lblTitulo.TabIndex = 71;
            lblTitulo.Text = "MODIFICAR ENVÍO";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 11);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 76;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button4_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(238, 132);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(82, 15);
            lblEstado.TabIndex = 77;
            lblEstado.Text = "Elige el estado";
            // 
            // ModEstados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 450);
            ControlBox = false;
            Controls.Add(lblEstado);
            Controls.Add(btnVolver);
            Controls.Add(btnAlterarEstado);
            Controls.Add(lblDescripcion);
            Controls.Add(cboEstado);
            Controls.Add(lstEnvios);
            Controls.Add(lblTitulo);
            Name = "ModEstados";
            Text = "Modificación de envíos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAlterarEstado;
        private Label lblDescripcion;
        private ComboBox cboEstado;
        private ListBox lstEnvios;
        private Label lblTitulo;
        private Button btnVolver;
        private Label lblEstado;
    }
}