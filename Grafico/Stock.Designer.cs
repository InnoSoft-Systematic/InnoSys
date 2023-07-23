namespace InnoSys
{
    partial class Stock
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
            label2 = new Label();
            button4 = new Button();
            label5 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            label9 = new Label();
            listBox1 = new ListBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(141, 54);
            label2.TabIndex = 35;
            label2.Text = "STOCK";
            label2.Click += label2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 36;
            button4.Text = "Volver";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 107);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 37;
            label5.Text = "CANTIDAD ACTUAL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 107);
            label1.Name = "label1";
            label1.Size = new Size(209, 15);
            label1.TabIndex = 38;
            label1.Text = "*Este label se modifica con la cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 160);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 39;
            label3.Text = "EN PRODUCCIÓN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 160);
            label4.Name = "label4";
            label4.Size = new Size(352, 15);
            label4.TabIndex = 40;
            label4.Text = "*Este label se modifica con la cantidad DE PRODUCCIÓN ACTUAL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 191);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 41;
            label6.Text = "PRODUCIDO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(130, 191);
            label7.Name = "label7";
            label7.Size = new Size(278, 15);
            label7.TabIndex = 42;
            label7.Text = "*Este label se modifica con la cantidad PRODUCIDA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(0, 192, 0);
            label8.Location = new Point(363, 107);
            label8.Name = "label8";
            label8.Size = new Size(237, 15);
            label8.TabIndex = 43;
            label8.Text = "*Este lbl avisa si esta por debajo del mínimo";
            // 
            // button1
            // 
            button1.Location = new Point(12, 246);
            button1.Name = "button1";
            button1.Size = new Size(244, 32);
            button1.TabIndex = 44;
            button1.Text = "MODIFICAR PARÁMETROS DE STOCK";
            button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(262, 255);
            label9.Name = "label9";
            label9.Size = new Size(174, 15);
            label9.TabIndex = 45;
            label9.Text = "Establece un mínimo y máximo";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(633, 42);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(308, 289);
            listBox1.TabIndex = 46;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(623, 81);
            label10.Name = "label10";
            label10.Size = new Size(318, 15);
            label10.TabIndex = 47;
            label10.Text = "*Viandas preparadas con fecha de creación y venciminento";
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 374);
            Controls.Add(label10);
            Controls.Add(listBox1);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(label2);
            Name = "Stock";
            Text = "Stock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button4;
        private Label label5;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Label label9;
        private ListBox listBox1;
        private Label label10;
    }
}