namespace InnoSys
{
    partial class ModEnvio
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
            label3 = new Label();
            button4 = new Button();
            button1 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 131);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 84;
            label3.Text = "Elige el estado";
            // 
            // button4
            // 
            button4.Location = new Point(24, 10);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 83;
            button4.Text = "Volver";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(207, 210);
            button1.Name = "button1";
            button1.Size = new Size(173, 55);
            button1.TabIndex = 82;
            button1.Text = "ALTERAR ESTADO";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 101);
            label1.Name = "label1";
            label1.Size = new Size(168, 15);
            label1.TabIndex = 81;
            label1.Text = "Selecciona el estado a cambiar";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(229, 159);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 80;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(24, 131);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(168, 259);
            listBox1.TabIndex = 79;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(382, 54);
            label2.TabIndex = 78;
            label2.Text = "MODIFICAR ENVÍOS";
            // 
            // ModEnvio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 450);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Name = "ModEnvio";
            Text = "ModEnvio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button4;
        private Button button1;
        private Label label1;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Label label2;
    }
}