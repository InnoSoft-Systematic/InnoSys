namespace InnoSys.Gerente
{
    partial class Gerente
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(290, 123);
            button4.TabIndex = 7;
            button4.Text = "Stock";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 166);
            button1.Name = "button1";
            button1.Size = new Size(290, 123);
            button1.TabIndex = 8;
            button1.Text = "Estado pedidos";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 315);
            button2.Name = "button2";
            button2.Size = new Size(290, 123);
            button2.TabIndex = 9;
            button2.Text = "Estadísticas";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(325, 315);
            button3.Name = "button3";
            button3.Size = new Size(290, 123);
            button3.TabIndex = 10;
            button3.Text = "Zonas";
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = Color.Coral;
            button5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(630, 315);
            button5.Name = "button5";
            button5.Size = new Size(290, 123);
            button5.TabIndex = 11;
            button5.Text = "Autorización cuentas clientes";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Coral;
            button6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(630, 166);
            button6.Name = "button6";
            button6.Size = new Size(290, 123);
            button6.TabIndex = 12;
            button6.Text = "Autorización nuevos productos";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(325, 166);
            button7.Name = "button7";
            button7.Size = new Size(290, 123);
            button7.TabIndex = 13;
            button7.Text = "Pedidos";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(325, 12);
            button8.Name = "button8";
            button8.Size = new Size(290, 123);
            button8.TabIndex = 14;
            button8.Text = "Menú";
            button8.UseVisualStyleBackColor = true;
            // 
            // Gerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Name = "Gerente";
            Text = "Gerente";
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}