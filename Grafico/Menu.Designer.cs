namespace InnoSys
{
    partial class Menu
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
            lstMenu = new ListBox();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 6);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 35;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button4_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(39, 32);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(136, 54);
            lblTitulo.TabIndex = 34;
            lblTitulo.Text = "MENU";
            // 
            // lstMenu
            // 
            lstMenu.FormattingEnabled = true;
            lstMenu.ItemHeight = 15;
            lstMenu.Location = new Point(12, 89);
            lstMenu.Name = "lstMenu";
            lstMenu.Size = new Size(193, 289);
            lstMenu.TabIndex = 36;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(138, 6);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 57;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 398);
            ControlBox = false;
            Controls.Add(btnActualizar);
            Controls.Add(lstMenu);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblTitulo;
        private ListBox lstMenu;
        private Button btnActualizar;
    }
}