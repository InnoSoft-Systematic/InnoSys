namespace InnoSys
{
    partial class Vehículos
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
            label1 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(12, 8);
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
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(228, 54);
            label2.TabIndex = 37;
            label2.Text = "VEHÍCULOS";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 95);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(308, 289);
            listBox1.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(364, 95);
            label1.Name = "label1";
            label1.Size = new Size(142, 46);
            label1.TabIndex = 48;
            label1.Text = "AÑADIR";
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(435, 159);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(364, 162);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 49;
            label3.Text = "Matrícula *";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(435, 196);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(358, 199);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 51;
            label4.Text = "Capacidad *";
            // 
            // button1
            // 
            button1.Location = new Point(399, 234);
            button1.Name = "button1";
            button1.Size = new Size(136, 23);
            button1.TabIndex = 53;
            button1.Text = "AÑADIR VEHÍCULO";
            button1.UseVisualStyleBackColor = true;
            // 
            // Vehículos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(label2);
            Name = "Vehículos";
            Text = "Vehículos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Label label2;
        private ListBox listBox1;
        private Label label1;
        private TextBox txtNombre;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Button button1;
    }
}