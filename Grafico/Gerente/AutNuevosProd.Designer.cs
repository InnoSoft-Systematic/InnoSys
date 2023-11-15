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
            btnActualizar = new Button();
            btnRechazar = new Button();
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
            lblTitulo.Size = new Size(397, 54);
            lblTitulo.TabIndex = 36;
            lblTitulo.Text = "AUTORIZAR MENÚES";
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
            btnAceptar.Location = new Point(297, 129);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(148, 60);
            btnAceptar.TabIndex = 39;
            btnAceptar.Text = "AUTORIZAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(12, 111);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(183, 15);
            lblDescripcion.TabIndex = 43;
            lblDescripcion.Text = "Selecciona el menú para accionar";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(386, 12);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 44;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnRechazar
            // 
            btnRechazar.Location = new Point(297, 385);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(148, 33);
            btnRechazar.TabIndex = 45;
            btnRechazar.Text = "Rechazar";
            btnRechazar.UseVisualStyleBackColor = true;
            btnRechazar.Click += btnRechazar_Click;
            // 
            // AutNuevosProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 450);
            ControlBox = false;
            Controls.Add(btnRechazar);
            Controls.Add(btnActualizar);
            Controls.Add(lblDescripcion);
            Controls.Add(btnAceptar);
            Controls.Add(lstProductos);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Name = "AutNuevosProd";
            Text = "Autorizar nuevos productos";
            Load += AutNuevosProd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblTitulo;
        private ListBox lstProductos;
        private Button btnAceptar;
        private Label lblDescripcion;
        private Button btnActualizar;
        private Button btnRechazar;
    }
}