namespace InnoSys.Informatico
{
    partial class AltaEmpleado
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
            textBox3 = new TextBox();
            label5 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // btmVolver
            // 
            btmVolver.Location = new Point(16, 5);
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
            lblInfo.Location = new Point(12, 31);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(321, 54);
            lblInfo.TabIndex = 33;
            lblInfo.Text = "ALTA EMPLEADO";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(83, 182);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 185);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 39;
            label5.Text = "CI *";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(83, 142);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 145);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 37;
            label3.Text = "Apellidos *";
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(83, 102);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 105);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 35;
            label2.Text = "Nombres *";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 223);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 41;
            label1.Text = "Cargo";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(83, 220);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 42;
            // 
            // button1
            // 
            button1.Location = new Point(124, 279);
            button1.Name = "button1";
            button1.Size = new Size(90, 32);
            button1.TabIndex = 43;
            button1.Text = "INGRESAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(189, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 44;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(189, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 45;
            // 
            // AltaEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 329);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(btmVolver);
            Controls.Add(lblInfo);
            Name = "AltaEmpleado";
            Text = "AltaEmpleado";
            Load += AltaEmpleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btmVolver;
        private Label lblInfo;
        private TextBox textBox3;
        private Label label5;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}