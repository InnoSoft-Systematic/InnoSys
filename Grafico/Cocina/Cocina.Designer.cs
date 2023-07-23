namespace InnoSys
{
    partial class Cocina
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
            button2 = new Button();
            button10 = new Button();
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(290, 123);
            button2.TabIndex = 17;
            button2.Text = "Pedidos";
            button2.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(324, 12);
            button10.Name = "button10";
            button10.Size = new Size(290, 123);
            button10.TabIndex = 23;
            button10.Text = "Stock";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(324, 141);
            button4.Name = "button4";
            button4.Size = new Size(290, 123);
            button4.TabIndex = 24;
            button4.Text = "Menú";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(324, 279);
            button1.Name = "button1";
            button1.Size = new Size(290, 123);
            button1.TabIndex = 25;
            button1.Text = "Ingreso menú";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(12, 141);
            button3.Name = "button3";
            button3.Size = new Size(290, 123);
            button3.TabIndex = 26;
            button3.Text = "Estados";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(12, 279);
            button5.Name = "button5";
            button5.Size = new Size(290, 123);
            button5.TabIndex = 27;
            button5.Text = "Modificar estados";
            button5.UseVisualStyleBackColor = true;
            // 
            // Cocina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 419);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button10);
            Controls.Add(button2);
            Name = "Cocina";
            Text = "Inicio";
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button10;
        private Button button4;
        private Button button1;
        private Button button3;
        private Button button5;
    }
}