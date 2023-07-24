namespace InnoSys
{
    partial class ModEstados
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
            button1 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            label2 = new Label();
            button4 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(195, 211);
            button1.Name = "button1";
            button1.Size = new Size(173, 55);
            button1.TabIndex = 75;
            button1.Text = "ALTERAR ESTADO";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 102);
            label1.Name = "label1";
            label1.Size = new Size(222, 15);
            label1.TabIndex = 74;
            label1.Text = "Selecciona el estado DE ENVÍO a cambiar";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(217, 160);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 73;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 132);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(168, 259);
            listBox1.TabIndex = 72;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 37);
            label2.Name = "label2";
            label2.Size = new Size(361, 54);
            label2.TabIndex = 71;
            label2.Text = "MODIFICAR ENVÍO";
            // 
            // button4
            // 
            button4.Location = new Point(12, 11);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 76;
            button4.Text = "Volver";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 132);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 77;
            label3.Text = "Elige el estado";
            // 
            // ModEstados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 450);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Name = "ModEstados";
            Text = "Modificación de envíos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Label label2;
        private Button button4;
        private Label label3;
    }
}