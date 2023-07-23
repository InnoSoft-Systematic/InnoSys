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
            SuspendLayout();
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(356, 255);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(65, 19);
            checkBox3.TabIndex = 52;
            checkBox3.Text = "Vegano";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(356, 216);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(65, 19);
            checkBox2.TabIndex = 51;
            checkBox2.Text = "Celíaco";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(356, 176);
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 26);
            label2.Name = "label2";
            label2.Size = new Size(292, 54);
            label2.TabIndex = 53;
            label2.Text = "AÑADIR MENÚ";
            // 
            // Vianda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Vianda";
            Text = "Vianda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button4;
        private Label label2;
    }
}