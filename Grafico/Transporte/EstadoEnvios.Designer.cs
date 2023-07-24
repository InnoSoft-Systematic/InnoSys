namespace InnoSys
{
    partial class EstadoEnvios
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
            btmVolver = new Button();
            lblInfo = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btmVolver
            // 
            btmVolver.Location = new Point(16, 6);
            btmVolver.Name = "btmVolver";
            btmVolver.Size = new Size(75, 23);
            btmVolver.TabIndex = 34;
            btmVolver.Text = "Volver";
            btmVolver.UseVisualStyleBackColor = true;
            btmVolver.Click += btmVolver_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.Location = new Point(12, 32);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(314, 54);
            lblInfo.TabIndex = 33;
            lblInfo.Text = "ESTADO ENVÍOS";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(16, 100);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(743, 229);
            listBox1.TabIndex = 35;
            // 
            // EstadoEnvios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 362);
            Controls.Add(listBox1);
            Controls.Add(btmVolver);
            Controls.Add(lblInfo);
            Name = "EstadoEnvios";
            Text = "Estado Envios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btmVolver;
        private Label lblInfo;
        private ListBox listBox1;
    }
}