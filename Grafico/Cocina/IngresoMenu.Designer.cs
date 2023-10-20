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
            chbBajasCalorias = new CheckBox();
            chbCeliaco = new CheckBox();
            chbVegetariano = new CheckBox();
            btnVolver = new Button();
            lblTitulo = new Label();
            chlMenu = new CheckedListBox();
            lblDescripcion = new Label();
            btnAñadirMenu = new Button();
            SuspendLayout();
            // 
            // chbBajasCalorias
            // 
            chbBajasCalorias.AutoSize = true;
            chbBajasCalorias.Location = new Point(181, 183);
            chbBajasCalorias.Name = "chbBajasCalorias";
            chbBajasCalorias.Size = new Size(96, 19);
            chbBajasCalorias.TabIndex = 52;
            chbBajasCalorias.Text = "Bajas calorías";
            chbBajasCalorias.UseVisualStyleBackColor = true;
            // 
            // chbCeliaco
            // 
            chbCeliaco.AutoSize = true;
            chbCeliaco.Location = new Point(181, 158);
            chbCeliaco.Name = "chbCeliaco";
            chbCeliaco.Size = new Size(65, 19);
            chbCeliaco.TabIndex = 51;
            chbCeliaco.Text = "Celíaco";
            chbCeliaco.UseVisualStyleBackColor = true;
            // 
            // chbVegetariano
            // 
            chbVegetariano.AutoSize = true;
            chbVegetariano.Location = new Point(181, 133);
            chbVegetariano.Name = "chbVegetariano";
            chbVegetariano.Size = new Size(88, 19);
            chbVegetariano.TabIndex = 50;
            chbVegetariano.Text = "Vegetariano";
            chbVegetariano.UseVisualStyleBackColor = true;
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
            chlMenu.Items.AddRange(new object[] { "Pure con milanesa", "Ensalada de verduras", "Pan sin harina" });
            chlMenu.Location = new Point(12, 110);
            chlMenu.Name = "chlMenu";
            chlMenu.Size = new Size(138, 202);
            chlMenu.TabIndex = 55;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(8, 89);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(282, 15);
            lblDescripcion.TabIndex = 56;
            lblDescripcion.Text = "*Lista de todas las viandas para agregar (MAXIMO 5)";
            // 
            // btnAñadirMenu
            // 
            btnAñadirMenu.Location = new Point(63, 346);
            btnAñadirMenu.Name = "btnAñadirMenu";
            btnAñadirMenu.Size = new Size(183, 60);
            btnAñadirMenu.TabIndex = 57;
            btnAñadirMenu.Text = "AÑADIR NUEVO MENÚ";
            btnAñadirMenu.UseVisualStyleBackColor = true;
            // 
            // IngresoMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 424);
            ControlBox = false;
            Controls.Add(btnAñadirMenu);
            Controls.Add(lblDescripcion);
            Controls.Add(chlMenu);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Controls.Add(chbBajasCalorias);
            Controls.Add(chbCeliaco);
            Controls.Add(chbVegetariano);
            Name = "IngresoMenu";
            Text = "IngresoMenu";
            Load += IngresoMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chbBajasCalorias;
        private CheckBox chbCeliaco;
        private CheckBox chbVegetariano;
        private Button btnVolver;
        private Label lblTitulo;
        private CheckedListBox chlMenu;
        private Label lblDescripcion;
        private Button btnAñadirMenu;
    }
}