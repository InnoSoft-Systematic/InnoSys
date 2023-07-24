namespace InnoSys
{
    partial class IngresoEnvío
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
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(21, 14);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 38;
            button4.Text = "Volver";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(333, 54);
            label2.TabIndex = 37;
            label2.Text = "INGRESAR ENVÍO";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(21, 113);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(308, 289);
            listBox1.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 94);
            label3.Name = "label3";
            label3.Size = new Size(282, 15);
            label3.TabIndex = 48;
            label3.Text = "*Se mostrará la lista de estados listos para despachar";
            // 
            // button1
            // 
            button1.Location = new Point(357, 196);
            button1.Name = "button1";
            button1.Size = new Size(144, 66);
            button1.TabIndex = 49;
            button1.Text = "DESPACHAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // IngresoEnvío
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(label2);
            Name = "IngresoEnvío";
            Text = "IngresoEnvío";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Label label2;
        private ListBox listBox1;
        private Label label3;
        private Button button1;
    }
}