namespace InnoSys.Gerente
{
    partial class Parametros
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
            btnVolver = new Button();
            lblMax = new Label();
            lblMin = new Label();
            btnActualizar = new Button();
            txtMin = new TextBox();
            txtMax = new TextBox();
            lblStock = new Label();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(9, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(51, 23);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(9, 80);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(51, 15);
            lblMax.TabIndex = 1;
            lblMax.Text = "Máximo";
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(11, 121);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(49, 15);
            lblMin.TabIndex = 2;
            lblMin.Text = "Mínimo";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(39, 166);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(73, 113);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(63, 23);
            txtMin.TabIndex = 4;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(73, 77);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(63, 23);
            txtMax.TabIndex = 5;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(12, 48);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 6;
            lblStock.Text = "Stock";
            // 
            // Parametros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(157, 203);
            ControlBox = false;
            Controls.Add(lblStock);
            Controls.Add(txtMax);
            Controls.Add(txtMin);
            Controls.Add(btnActualizar);
            Controls.Add(lblMin);
            Controls.Add(lblMax);
            Controls.Add(btnVolver);
            Name = "Parametros";
            Text = "Parametros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblMax;
        private Label lblMin;
        private Button btnActualizar;
        private TextBox txtMin;
        private TextBox txtMax;
        private Label lblStock;
    }
}