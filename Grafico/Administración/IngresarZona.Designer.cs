namespace InnoSys.Administrador
{
    partial class IngresarZona
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
            lblDepartamento = new Label();
            cboDepartamento = new ComboBox();
            lstZonas = new ListBox();
            label1 = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(21, 8);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 38;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(12, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(326, 54);
            lblTitulo.TabIndex = 37;
            lblTitulo.Text = "INGRESAR ZONA";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(21, 92);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(83, 15);
            lblDepartamento.TabIndex = 49;
            lblDepartamento.Text = "Departamento";
            // 
            // cboDepartamento
            // 
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(110, 89);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(121, 23);
            cboDepartamento.TabIndex = 50;
            // 
            // lstZonas
            // 
            lstZonas.FormattingEnabled = true;
            lstZonas.ItemHeight = 15;
            lstZonas.Location = new Point(21, 149);
            lstZonas.Name = "lstZonas";
            lstZonas.Size = new Size(308, 289);
            lstZonas.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 131);
            label1.Name = "label1";
            label1.Size = new Size(169, 15);
            label1.TabIndex = 52;
            label1.Text = "Aparecerán la lista de ciudades";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(346, 149);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(129, 76);
            btnAceptar.TabIndex = 53;
            btnAceptar.Text = "INCORPORAR";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // IngresarZona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 450);
            Controls.Add(btnAceptar);
            Controls.Add(label1);
            Controls.Add(lstZonas);
            Controls.Add(cboDepartamento);
            Controls.Add(lblDepartamento);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Name = "IngresarZona";
            Text = "Zona";
            Load += IngresarZona_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblTitulo;
        private Label lblDepartamento;
        private ComboBox cboDepartamento;
        private ListBox lstZonas;
        private Label label1;
        private Button btnAceptar;
    }
}