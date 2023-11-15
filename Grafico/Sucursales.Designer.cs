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
            lstSucursales = new ListBox();
            lblTitulo = new Label();
            btnActualizar = new Button();
            cboZona = new ComboBox();
            lblZona = new Label();
            button1 = new Button();
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
            // lstSucursales
            // 
            lstSucursales.FormattingEnabled = true;
            lstSucursales.ItemHeight = 15;
            lstSucursales.Location = new Point(22, 87);
            lstSucursales.Name = "lstSucursales";
            lstSucursales.Size = new Size(134, 214);
            lstSucursales.TabIndex = 41;
            lstSucursales.SelectedIndexChanged += lstSucursales_SelectedIndexChanged;
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
            lblTitulo.Click += lblTitulo_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(240, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 43;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // cboZona
            // 
            cboZona.FormattingEnabled = true;
            cboZona.Location = new Point(175, 105);
            cboZona.Name = "cboZona";
            cboZona.Size = new Size(121, 23);
            cboZona.TabIndex = 44;
            cboZona.SelectedIndexChanged += cboZona_SelectedIndexChanged;
            // 
            // lblZona
            // 
            lblZona.AutoSize = true;
            lblZona.Location = new Point(175, 87);
            lblZona.Name = "lblZona";
            lblZona.Size = new Size(86, 15);
            lblZona.TabIndex = 45;
            lblZona.Text = "Filtrar por zona";
            // 
            // button1
            // 
            button1.Location = new Point(175, 190);
            button1.Name = "button1";
            button1.Size = new Size(124, 111);
            button1.TabIndex = 46;
            button1.Text = "DEFINIR SUCURSAL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Sucursales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 310);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(lblZona);
            Controls.Add(cboZona);
            Controls.Add(btnActualizar);
            Controls.Add(btnVolver);
            Controls.Add(lstSucursales);
            Controls.Add(lblTitulo);
            Name = "Sucursales";
            Text = "Sucursales";
            Load += Sucursales_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private ListBox lstSucursales;
        private Label lblTitulo;
        private Button btnActualizar;
        private ComboBox cboZona;
        private Label lblZona;
        private Button button1;
    }
}