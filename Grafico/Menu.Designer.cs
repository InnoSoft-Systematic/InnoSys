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
            lblTitulo.Location = new Point(12, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(136, 54);
            lblTitulo.TabIndex = 34;
            lblTitulo.Text = "MENU";
            // 
            // lstMenu
            // 
            lstMenu.FormattingEnabled = true;
            lstMenu.ItemHeight = 15;
            lstMenu.Location = new Point(12, 90);
            lstMenu.Name = "lstMenu";
            lstMenu.Size = new Size(308, 289);
            lstMenu.TabIndex = 36;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 398);
            ControlBox = false;
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
    }
}