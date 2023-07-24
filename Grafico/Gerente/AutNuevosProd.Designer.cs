namespace InnoSys
{
    partial class AutNuevosProd
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
            button4 = new Button();
            label2 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 37;
            button4.Text = "Volver";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 42);
            label2.Name = "label2";
            label2.Size = new Size(469, 54);
            label2.TabIndex = 36;
            label2.Text = "AUTORIZAR PRODUCTOS";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 129);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(262, 289);
            listBox1.TabIndex = 38;
            // 
            // button1
            // 
            button1.Location = new Point(308, 150);
            button1.Name = "button1";
            button1.Size = new Size(148, 60);
            button1.TabIndex = 39;
            button1.Text = "AUTORIZAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 96);
            label5.Name = "label5";
            label5.Size = new Size(244, 15);
            label5.TabIndex = 43;
            label5.Text = "Selecciona los productos de la lista y autoriza";
            // 
            // AutNuevosProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 450);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(label2);
            Name = "AutNuevosProd";
            Text = "Autorizar nuevos productos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Label label2;
        private ListBox listBox1;
        private Button button1;
        private Label label5;
    }
}