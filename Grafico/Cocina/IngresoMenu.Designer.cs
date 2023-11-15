namespace InnoSys.Administrador
{
    partial class IngresoMenu
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
            chlMenu = new CheckedListBox();
            btnAñadirMenu = new Button();
            btnActualizar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            groupBox1 = new GroupBox();
            chlDieta = new CheckedListBox();
            gbTipoMenu = new GroupBox();
            rboMensual = new RadioButton();
            rboSemanal = new RadioButton();
            rboQuincenal = new RadioButton();
            label3 = new Label();
            groupBox1.SuspendLayout();
            gbTipoMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 9);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 54;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button4_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(8, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(310, 54);
            lblTitulo.TabIndex = 53;
            lblTitulo.Text = "INGRESO MENÚ";
            // 
            // chlMenu
            // 
            chlMenu.FormattingEnabled = true;
            chlMenu.Location = new Point(6, 30);
            chlMenu.Name = "chlMenu";
            chlMenu.Size = new Size(304, 184);
            chlMenu.TabIndex = 55;
            // 
            // btnAñadirMenu
            // 
            btnAñadirMenu.Location = new Point(162, 444);
            btnAñadirMenu.Name = "btnAñadirMenu";
            btnAñadirMenu.Size = new Size(183, 44);
            btnAñadirMenu.TabIndex = 57;
            btnAñadirMenu.Text = "AÑADIR NUEVO MENÚ";
            btnAñadirMenu.UseVisualStyleBackColor = true;
            btnAñadirMenu.Click += btnAñadirMenu_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(399, 9);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 58;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 239);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 61;
            label1.Text = "Nombre del menú *";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(248, 236);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(99, 23);
            txtNombre.TabIndex = 62;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chlDieta);
            groupBox1.Controls.Add(gbTipoMenu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(chlMenu);
            groupBox1.Location = new Point(8, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(466, 334);
            groupBox1.TabIndex = 63;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo menú";
            // 
            // chlDieta
            // 
            chlDieta.FormattingEnabled = true;
            chlDieta.Location = new Point(322, 30);
            chlDieta.Name = "chlDieta";
            chlDieta.Size = new Size(138, 184);
            chlDieta.TabIndex = 87;
            // 
            // gbTipoMenu
            // 
            gbTipoMenu.Controls.Add(rboMensual);
            gbTipoMenu.Controls.Add(rboSemanal);
            gbTipoMenu.Controls.Add(rboQuincenal);
            gbTipoMenu.Location = new Point(80, 269);
            gbTipoMenu.Name = "gbTipoMenu";
            gbTipoMenu.Size = new Size(304, 60);
            gbTipoMenu.TabIndex = 86;
            gbTipoMenu.TabStop = false;
            gbTipoMenu.Text = "Tipo de menú";
            // 
            // rboMensual
            // 
            rboMensual.AutoSize = true;
            rboMensual.Location = new Point(212, 22);
            rboMensual.Name = "rboMensual";
            rboMensual.Size = new Size(70, 19);
            rboMensual.TabIndex = 55;
            rboMensual.TabStop = true;
            rboMensual.Text = "Mensual";
            rboMensual.UseVisualStyleBackColor = true;
            rboMensual.CheckedChanged += rboMenusal_CheckedChanged;
            // 
            // rboSemanal
            // 
            rboSemanal.AutoSize = true;
            rboSemanal.Location = new Point(23, 22);
            rboSemanal.Name = "rboSemanal";
            rboSemanal.Size = new Size(70, 19);
            rboSemanal.TabIndex = 53;
            rboSemanal.TabStop = true;
            rboSemanal.Text = "Semanal";
            rboSemanal.UseVisualStyleBackColor = true;
            rboSemanal.CheckedChanged += rboSemanal_CheckedChanged;
            // 
            // rboQuincenal
            // 
            rboQuincenal.AutoSize = true;
            rboQuincenal.Location = new Point(108, 22);
            rboQuincenal.Name = "rboQuincenal";
            rboQuincenal.Size = new Size(79, 19);
            rboQuincenal.TabIndex = 54;
            rboQuincenal.TabStop = true;
            rboQuincenal.Text = "Quincenal";
            rboQuincenal.UseVisualStyleBackColor = true;
            rboQuincenal.CheckedChanged += rboQuincenal_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 278);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 85;
            // 
            // IngresoMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 500);
            ControlBox = false;
            Controls.Add(btnActualizar);
            Controls.Add(btnAñadirMenu);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Controls.Add(groupBox1);
            Name = "IngresoMenu";
            Text = "IngresoMenu";
            Load += IngresoMenu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbTipoMenu.ResumeLayout(false);
            gbTipoMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnVolver;
        private Label lblTitulo;
        private CheckedListBox chlMenu;
        private Button btnAñadirMenu;
        private Button btnActualizar;
        private Label label1;
        private TextBox txtNombre;
        private GroupBox groupBox1;
        private GroupBox gbTipoMenu;
        private RadioButton rboMensual;
        private RadioButton rboSemanal;
        private RadioButton rboQuincenal;
        private Label label3;
        private CheckedListBox chlDieta;
    }
}