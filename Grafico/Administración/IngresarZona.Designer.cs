namespace InnoSys.Administrador
{
    partial class IngresarZona
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
            label3 = new Label();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(21, 8);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 38;
            button4.Text = "Volver";
            button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 29);
            label2.Name = "label2";
            label2.Size = new Size(326, 54);
            label2.TabIndex = 37;
            label2.Text = "INGRESAR ZONA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 92);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 49;
            label3.Text = "Departamento";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(110, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 50;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(21, 149);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(308, 289);
            listBox1.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 131);
            label1.Name = "label1";
            label1.Size = new Size(169, 15);
            label1.TabIndex = 52;
            label1.Text = "Aparecerán la lista de ciudades";
            // 
            // button1
            // 
            button1.Location = new Point(346, 149);
            button1.Name = "button1";
            button1.Size = new Size(129, 76);
            button1.TabIndex = 53;
            button1.Text = "INCORPORAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // IngresarZona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(label2);
            Name = "IngresarZona";
            Text = "Zona";
            Load += IngresarZona_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Label label1;
        private Button button1;
    }
}