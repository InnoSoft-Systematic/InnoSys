namespace InnoSys
{
    partial class AutNuevosProd
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
            lblTitulo = new Label();
            lstProductos = new ListBox();
            btnAceptar = new Button();
            lblDescripcion = new Label();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 37;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button4_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(3, 42);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(469, 54);
            lblTitulo.TabIndex = 36;
            lblTitulo.Text = "AUTORIZAR PRODUCTOS";
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 15;
            lstProductos.Location = new Point(12, 129);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(262, 289);
            lstProductos.TabIndex = 38;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(308, 150);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(148, 60);
            btnAceptar.TabIndex = 39;
            btnAceptar.Text = "AUTORIZAR";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(12, 96);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(244, 15);
            lblDescripcion.TabIndex = 43;
            lblDescripcion.Text = "Selecciona los productos de la lista y autoriza";
            // 
            // AutNuevosProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 450);
            Controls.Add(lblDescripcion);
            Controls.Add(btnAceptar);
            Controls.Add(lstProductos);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Name = "AutNuevosProd";
            Text = "Autorizar nuevos productos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblTitulo;
        private ListBox lstProductos;
        private Button btnAceptar;
        private Label lblDescripcion;
    }
}