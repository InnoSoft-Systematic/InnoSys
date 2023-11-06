namespace InnoSys
{
    partial class AutCuentas
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
            lstAutBajas = new ListBox();
            btnAutorizar = new Button();
            rboEmpresa = new RadioButton();
            rboPersona = new RadioButton();
            groupBox1 = new GroupBox();
            btnRechazar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 8);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 40;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button4_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(12, 38);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(354, 54);
            lblTitulo.TabIndex = 39;
            lblTitulo.Text = "AUTORIZAR BAJAS";
            lblTitulo.Click += label2_Click;
            // 
            // lstAutBajas
            // 
            lstAutBajas.FormattingEnabled = true;
            lstAutBajas.ItemHeight = 15;
            lstAutBajas.Location = new Point(12, 109);
            lstAutBajas.Name = "lstAutBajas";
            lstAutBajas.Size = new Size(308, 199);
            lstAutBajas.TabIndex = 48;
            lstAutBajas.SelectedIndexChanged += lstAutAltasBajas_SelectedIndexChanged;
            // 
            // btnAutorizar
            // 
            btnAutorizar.Location = new Point(340, 208);
            btnAutorizar.Name = "btnAutorizar";
            btnAutorizar.Size = new Size(136, 70);
            btnAutorizar.TabIndex = 54;
            btnAutorizar.Text = "AUTORIZAR";
            btnAutorizar.UseVisualStyleBackColor = true;
            btnAutorizar.Click += btnAutorizar_Click;
            // 
            // rboEmpresa
            // 
            rboEmpresa.AutoSize = true;
            rboEmpresa.Location = new Point(15, 20);
            rboEmpresa.Name = "rboEmpresa";
            rboEmpresa.Size = new Size(70, 19);
            rboEmpresa.TabIndex = 61;
            rboEmpresa.TabStop = true;
            rboEmpresa.Text = "Empresa";
            rboEmpresa.UseVisualStyleBackColor = true;
            rboEmpresa.CheckedChanged += rboEmpresa_CheckedChanged;
            // 
            // rboPersona
            // 
            rboPersona.AutoSize = true;
            rboPersona.Location = new Point(15, 45);
            rboPersona.Name = "rboPersona";
            rboPersona.Size = new Size(67, 19);
            rboPersona.TabIndex = 62;
            rboPersona.TabStop = true;
            rboPersona.Text = "Persona";
            rboPersona.UseVisualStyleBackColor = true;
            rboPersona.CheckedChanged += rboPersona_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rboEmpresa);
            groupBox1.Controls.Add(rboPersona);
            groupBox1.Location = new Point(340, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(111, 75);
            groupBox1.TabIndex = 64;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar";
            // 
            // btnRechazar
            // 
            btnRechazar.Location = new Point(340, 297);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(136, 26);
            btnRechazar.TabIndex = 65;
            btnRechazar.Text = "Rechazar";
            btnRechazar.UseVisualStyleBackColor = true;
            btnRechazar.Click += btnRechazar_Click;
            // 
            // AutCuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 335);
            ControlBox = false;
            Controls.Add(btnRechazar);
            Controls.Add(btnAutorizar);
            Controls.Add(lstAutBajas);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Controls.Add(groupBox1);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "AutCuentas";
            Text = "Autorizar altas y bajas";
            Load += AutCuentas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblTitulo;
        private ListBox lstAutBajas;
        private Button btnAutorizar;
        private RadioButton rboEmpresa;
        private RadioButton rboPersona;
        private GroupBox groupBox1;
        private Button btnRechazar;
    }
}