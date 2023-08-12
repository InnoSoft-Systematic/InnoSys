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
            txtPass = new TextBox();
            txtUsuario = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            lblUsuario = new Label();
            lblPass = new Label();
            SuspendLayout();
            // 
            // txtPass
            // 
            txtPass.Location = new Point(263, 137);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = 'X';
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 38;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(263, 101);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 39;
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(245, 198);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 40;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Chocolate;
            btnAceptar.Location = new Point(335, 198);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 41;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += button1_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(167, 104);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(56, 15);
            lblUsuario.TabIndex = 42;
            lblUsuario.Text = "USUARIO";
            lblUsuario.Click += label5_Click;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(167, 145);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(83, 15);
            lblPass.TabIndex = 43;
            lblPass.Text = "CONTRASEÑA";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 254);
            Controls.Add(lblPass);
            Controls.Add(lblUsuario);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(txtUsuario);
            Controls.Add(txtPass);
            Name = "Login";
            Text = "Ingreso";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPass;
        private TextBox txtUsuario;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblUsuario;
        private Label lblPass;
    }
}