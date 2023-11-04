using Grafico;

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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPass
            // 
            txtPass.Location = new Point(311, 80);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = 'X';
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 38;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(311, 44);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 39;
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(246, 136);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 40;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Chocolate;
            btnAceptar.Location = new Point(336, 136);
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
            lblUsuario.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.Location = new Point(215, 47);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(66, 16);
            lblUsuario.TabIndex = 42;
            lblUsuario.Text = "USUARIO";
            lblUsuario.Click += label5_Click;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.Location = new Point(209, 87);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(96, 16);
            lblPass.TabIndex = 43;
            lblPass.Text = "CONTRASEÑA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Isologo_2_Transparente;
            pictureBox1.Location = new Point(35, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(439, 184);
            Controls.Add(pictureBox1);
            Controls.Add(lblPass);
            Controls.Add(lblUsuario);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(txtUsuario);
            Controls.Add(txtPass);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Login";
            Text = "Ingreso";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}