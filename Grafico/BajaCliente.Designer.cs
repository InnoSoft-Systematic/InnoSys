namespace InnoSys
{
    partial class BajaCliente
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
            label1 = new Label();
            button4 = new Button();
            label14 = new Label();
            button2 = new Button();
            textBox7 = new TextBox();
            label9 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(270, 54);
            label1.TabIndex = 1;
            label1.Text = "BAJA CLIENTE";
            // 
            // button4
            // 
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 33;
            button4.Text = "Volver";
            button4.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 92);
            label14.Name = "label14";
            label14.Size = new Size(405, 15);
            label14.TabIndex = 35;
            label14.Text = "El cliente ingresado quedará sujeto a aprobación de organismo competente";
            // 
            // button2
            // 
            button2.Location = new Point(168, 189);
            button2.Name = "button2";
            button2.Size = new Size(52, 23);
            button2.TabIndex = 41;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(62, 189);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 193);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 39;
            label9.Text = "RUT";
            // 
            // button1
            // 
            button1.Location = new Point(168, 150);
            button1.Name = "button1";
            button1.Size = new Size(52, 23);
            button1.TabIndex = 38;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(62, 150);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 154);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 36;
            label5.Text = "CI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 238);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 43;
            label2.Text = "Datos de cédula ingresada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 117);
            label3.Name = "label3";
            label3.Size = new Size(173, 15);
            label3.TabIndex = 44;
            label3.Text = "Puedes buscar por CI o por RUT";
            // 
            // button3
            // 
            button3.Location = new Point(125, 276);
            button3.Name = "button3";
            button3.Size = new Size(172, 34);
            button3.TabIndex = 45;
            button3.Text = "SOLICITAR BAJA";
            button3.UseVisualStyleBackColor = true;
            // 
            // BajaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 334);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(textBox7);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label14);
            Controls.Add(button4);
            Controls.Add(label1);
            Name = "BajaCliente";
            Text = "Baja de cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button4;
        private Label label14;
        private Button button2;
        private TextBox textBox7;
        private Label label9;
        private Button button1;
        private TextBox textBox3;
        private Label label5;
        private Label label2;
        private Label label3;
        private Button button3;
    }
}