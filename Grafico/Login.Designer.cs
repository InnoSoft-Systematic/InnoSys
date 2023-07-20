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
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            button4 = new Button();
            button1 = new Button();
            label5 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(137, 75);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 38;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 39;
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
            button1.Location = new Point(209, 136);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 41;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
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
            Controls.Add(textBox1);
            Controls.Add(textBox3);
            Name = "Login";
            Text = "Ingreso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private TextBox textBox1;
        private Button button4;
        private Button button1;
        private Label label5;
        private Label label1;
    }
}