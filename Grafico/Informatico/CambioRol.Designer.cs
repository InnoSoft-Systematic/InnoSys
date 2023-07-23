namespace InnoSys.Informatico
{
    partial class CambioRol
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
            button6 = new Button();
            button5 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(12, 264);
            button6.Name = "button6";
            button6.Size = new Size(290, 57);
            button6.TabIndex = 14;
            button6.Text = "Recepción";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(12, 12);
            button5.Name = "button5";
            button5.Size = new Size(290, 57);
            button5.TabIndex = 19;
            button5.Text = "Gerente";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(12, 75);
            button8.Name = "button8";
            button8.Size = new Size(290, 57);
            button8.TabIndex = 21;
            button8.Text = "Adminsitración";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(12, 138);
            button9.Name = "button9";
            button9.Size = new Size(290, 57);
            button9.TabIndex = 22;
            button9.Text = "Cocina";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.White;
            button10.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(12, 201);
            button10.Name = "button10";
            button10.Size = new Size(290, 57);
            button10.TabIndex = 23;
            button10.Text = "Transporte";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // CambioRol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 330);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button6);
            Name = "CambioRol";
            Text = "CambioRol";
            ResumeLayout(false);
        }

        #endregion

        private Button button6;
        private Button button5;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}