namespace InnoSys.Administrador
{
    partial class Administrador
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
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(12, 12);
            button6.Name = "button6";
            button6.Size = new Size(290, 123);
            button6.TabIndex = 13;
            button6.Text = "Clientes";
            button6.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 152);
            button1.Name = "button1";
            button1.Size = new Size(290, 123);
            button1.TabIndex = 14;
            button1.Text = "Autorización cuentas clientes";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(321, 12);
            button3.Name = "button3";
            button3.Size = new Size(290, 123);
            button3.TabIndex = 15;
            button3.Text = "Zonas";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(647, 12);
            button2.Name = "button2";
            button2.Size = new Size(290, 123);
            button2.TabIndex = 16;
            button2.Text = "Pedidos";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(647, 152);
            button4.Name = "button4";
            button4.Size = new Size(290, 123);
            button4.TabIndex = 17;
            button4.Text = "Menú";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(321, 152);
            button5.Name = "button5";
            button5.Size = new Size(290, 123);
            button5.TabIndex = 18;
            button5.Text = "Envíos";
            button5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackColor = Color.Brown;
            button7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(647, 334);
            button7.Name = "button7";
            button7.Size = new Size(290, 65);
            button7.TabIndex = 19;
            button7.Text = "Cambiar de rol";
            button7.UseVisualStyleBackColor = false;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(957, 450);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button6);
            Name = "Administrador";
            Text = "Administrador";
            ResumeLayout(false);
        }

        #endregion

        private Button button6;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button7;
    }
}