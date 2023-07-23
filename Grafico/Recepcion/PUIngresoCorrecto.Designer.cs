namespace InnoSys
{
    partial class PUIngresoCorrecto
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
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Chocolate;
            button1.Location = new Point(212, 97);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 41;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Location = new Point(46, 47);
            label5.Name = "label5";
            label5.Size = new Size(198, 15);
            label5.TabIndex = 42;
            label5.Text = "ALTA INGRESADA CORRECTAMENTE";
            label5.Click += label5_Click;
            // 
            // PUIngresoCorrecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 129);
            Controls.Add(label5);
            Controls.Add(button1);
            Name = "PUIngresoCorrecto";
            Text = "Ingreso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label5;
    }
}