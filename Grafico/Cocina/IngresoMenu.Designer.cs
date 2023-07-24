namespace InnoSys.Administrador
{
    partial class IngresoMenu
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
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button4 = new Button();
            label2 = new Label();
            checkedListBox1 = new CheckedListBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(181, 183);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(96, 19);
            checkBox3.TabIndex = 52;
            checkBox3.Text = "Bajas calorías";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(181, 158);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(65, 19);
            checkBox2.TabIndex = 51;
            checkBox2.Text = "Celíaco";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(181, 133);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 19);
            checkBox1.TabIndex = 50;
            checkBox1.Text = "Vegetariano";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 9);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 54;
            button4.Text = "Volver";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 35);
            label2.Name = "label2";
            label2.Size = new Size(310, 54);
            label2.TabIndex = 53;
            label2.Text = "INGRESO MENÚ";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Pure con milanesa", "Ensalada de verduras", "Pan sin harina" });
            checkedListBox1.Location = new Point(12, 110);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(138, 202);
            checkedListBox1.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 89);
            label1.Name = "label1";
            label1.Size = new Size(282, 15);
            label1.TabIndex = 56;
            label1.Text = "*Lista de todas las viandas para agregar (MAXIMO 5)";
            // 
            // button1
            // 
            button1.Location = new Point(63, 346);
            button1.Name = "button1";
            button1.Size = new Size(183, 60);
            button1.TabIndex = 57;
            button1.Text = "AÑADIR NUEVO MENÚ";
            button1.UseVisualStyleBackColor = true;
            // 
            // IngresoMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 424);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(checkedListBox1);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "IngresoMenu";
            Text = "IngresoMenu";
            Load += IngresoMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button4;
        private Label label2;
        private CheckedListBox checkedListBox1;
        private Label label1;
        private Button button1;
    }
}