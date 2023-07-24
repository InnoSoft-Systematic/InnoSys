namespace InnoSys.Administración
{
    partial class Administracion
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
            button2 = new Button();
            button5 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(318, 12);
            button6.Name = "button6";
            button6.Size = new Size(290, 123);
            button6.TabIndex = 16;
            button6.Text = "Clientes";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 153);
            button2.Name = "button2";
            button2.Size = new Size(290, 123);
            button2.TabIndex = 17;
            button2.Text = "Pedidos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(318, 153);
            button5.Name = "button5";
            button5.Size = new Size(290, 123);
            button5.TabIndex = 19;
            button5.Text = "Envíos";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(290, 123);
            button1.TabIndex = 20;
            button1.Text = "Autorización cuentas clientes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(614, 12);
            button3.Name = "button3";
            button3.Size = new Size(290, 123);
            button3.TabIndex = 21;
            button3.Text = "Vehíuclos";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(614, 153);
            button4.Name = "button4";
            button4.Size = new Size(290, 123);
            button4.TabIndex = 22;
            button4.Text = "Ingresar Zona";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Administracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 306);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button6);
            Name = "Administracion";
            Text = "Administracion";
            Load += Administracion_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button6;
        private Button button2;
        private Button button5;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}