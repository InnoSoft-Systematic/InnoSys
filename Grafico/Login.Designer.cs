namespace InnoSys
{
    partial class Login
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
            txtContraseña = new TextBox();
            txtNombre = new TextBox();
            button4 = new Button();
            button1 = new Button();
            label5 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(137, 75);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = 'X';
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 38;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(137, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 39;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(119, 136);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 40;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Chocolate;
            button1.Location = new Point(209, 136);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 41;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 42);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 42;
            label5.Text = "USUARIO";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 83);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 43;
            label1.Text = "CONTRASEÑA";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 173);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(txtNombre);
            Controls.Add(txtContraseña);
            Name = "Login";
            Text = "Ingreso";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContraseña;
        private TextBox txtNombre;
        private Button button4;
        private Button button1;
        private Label label5;
        private Label label1;
    }
}