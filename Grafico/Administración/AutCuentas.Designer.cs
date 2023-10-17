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
            lstAutAltasBajas = new ListBox();
            btnAutorizar = new Button();
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
            lblTitulo.Size = new Size(477, 54);
            lblTitulo.TabIndex = 39;
            lblTitulo.Text = "AUTORIZAR ALTAS/BAJAS";
            lblTitulo.Click += label2_Click;
            // 
            // lstAutAltasBajas
            // 
            lstAutAltasBajas.FormattingEnabled = true;
            lstAutAltasBajas.ItemHeight = 15;
            lstAutAltasBajas.Location = new Point(12, 109);
            lstAutAltasBajas.Name = "lstAutAltasBajas";
            lstAutAltasBajas.Size = new Size(308, 289);
            lstAutAltasBajas.TabIndex = 48;
            // 
            // btnAutorizar
            // 
            btnAutorizar.Location = new Point(337, 109);
            btnAutorizar.Name = "btnAutorizar";
            btnAutorizar.Size = new Size(136, 70);
            btnAutorizar.TabIndex = 54;
            btnAutorizar.Text = "AUTORIZAR";
            btnAutorizar.UseVisualStyleBackColor = true;
            // 
            // AutCuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 450);
            ControlBox = false;
            Controls.Add(btnAutorizar);
            Controls.Add(lstAutAltasBajas);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "AutCuentas";
            Text = "Autorizar altas y bajas";
            Load += AutCuentas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblTitulo;
        private ListBox lstAutAltasBajas;
        private Button btnAutorizar;
    }
}