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
            btnRecepcion = new Button();
            btnGerente = new Button();
            btnAdministracion = new Button();
            btnCocina = new Button();
            btnTransporte = new Button();
            SuspendLayout();
            // 
            // btnRecepcion
            // 
            btnRecepcion.BackColor = Color.White;
            btnRecepcion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecepcion.Location = new Point(12, 264);
            btnRecepcion.Name = "btnRecepcion";
            btnRecepcion.Size = new Size(290, 57);
            btnRecepcion.TabIndex = 14;
            btnRecepcion.Text = "Recepción";
            btnRecepcion.UseVisualStyleBackColor = false;
            btnRecepcion.Click += button6_Click;
            // 
            // btnGerente
            // 
            btnGerente.BackColor = Color.White;
            btnGerente.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnGerente.Location = new Point(12, 12);
            btnGerente.Name = "btnGerente";
            btnGerente.Size = new Size(290, 57);
            btnGerente.TabIndex = 19;
            btnGerente.Text = "Gerente";
            btnGerente.UseVisualStyleBackColor = false;
            btnGerente.Click += button5_Click;
            // 
            // btnAdministracion
            // 
            btnAdministracion.BackColor = Color.White;
            btnAdministracion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdministracion.Location = new Point(12, 75);
            btnAdministracion.Name = "btnAdministracion";
            btnAdministracion.Size = new Size(290, 57);
            btnAdministracion.TabIndex = 21;
            btnAdministracion.Text = "Adminsitración";
            btnAdministracion.UseVisualStyleBackColor = false;
            btnAdministracion.Click += button8_Click;
            // 
            // btnCocina
            // 
            btnCocina.BackColor = Color.White;
            btnCocina.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnCocina.Location = new Point(12, 138);
            btnCocina.Name = "btnCocina";
            btnCocina.Size = new Size(290, 57);
            btnCocina.TabIndex = 22;
            btnCocina.Text = "Cocina";
            btnCocina.UseVisualStyleBackColor = false;
            btnCocina.Click += button9_Click;
            // 
            // btnTransporte
            // 
            btnTransporte.BackColor = Color.White;
            btnTransporte.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnTransporte.Location = new Point(12, 201);
            btnTransporte.Name = "btnTransporte";
            btnTransporte.Size = new Size(290, 57);
            btnTransporte.TabIndex = 23;
            btnTransporte.Text = "Transporte";
            btnTransporte.UseVisualStyleBackColor = false;
            btnTransporte.Click += button10_Click;
            // 
            // CambioRol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 330);
            Controls.Add(btnTransporte);
            Controls.Add(btnCocina);
            Controls.Add(btnAdministracion);
            Controls.Add(btnGerente);
            Controls.Add(btnRecepcion);
            Name = "CambioRol";
            Text = "CambioRol";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRecepcion;
        private Button btnGerente;
        private Button btnAdministracion;
        private Button btnCocina;
        private Button btnTransporte;
    }
}