namespace InnoSys
{
    partial class Clientes
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
            listBox1 = new ListBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(190, 54);
            label2.TabIndex = 54;
            label2.Text = "CLIENTES";
            // 
            // button4
            // 
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 55;
            button4.Text = "Volver";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 106);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(308, 289);
            listBox1.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 106);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 57;
            label3.Text = "Filtrar tipo de cliente";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(341, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 58;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 450);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(label2);
            Name = "Clientes";
            Text = "Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button4;
        private ListBox listBox1;
        private Label label3;
        private ComboBox comboBox1;
    }
}