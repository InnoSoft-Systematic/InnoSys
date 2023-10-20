namespace InnoSys
{
    partial class Stock
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
            lblTitulo = new Label();
            btnVolver = new Button();
            lblCanitad = new Label();
            lblCantidadActual = new Label();
            lblProduccion = new Label();
            lblProduccionActual = new Label();
            lblProducido = new Label();
            lblCantidadProducida = new Label();
            lblAviso = new Label();
            btnModParametros = new Button();
            lblInfo = new Label();
            lstViandasPreparadas = new ListBox();
            lblTemp = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(12, 42);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(141, 54);
            lblTitulo.TabIndex = 35;
            lblTitulo.Text = "STOCK";
            lblTitulo.Click += label2_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 36;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button4_Click;
            // 
            // lblCanitad
            // 
            lblCanitad.AutoSize = true;
            lblCanitad.Location = new Point(12, 107);
            lblCanitad.Name = "lblCanitad";
            lblCanitad.Size = new Size(112, 15);
            lblCanitad.TabIndex = 37;
            lblCanitad.Text = "CANTIDAD ACTUAL";
            // 
            // lblCantidadActual
            // 
            lblCantidadActual.AutoSize = true;
            lblCantidadActual.Location = new Point(130, 107);
            lblCantidadActual.Name = "lblCantidadActual";
            lblCantidadActual.Size = new Size(209, 15);
            lblCantidadActual.TabIndex = 38;
            lblCantidadActual.Text = "*Este label se modifica con la cantidad";
            // 
            // lblProduccion
            // 
            lblProduccion.AutoSize = true;
            lblProduccion.Location = new Point(12, 160);
            lblProduccion.Name = "lblProduccion";
            lblProduccion.Size = new Size(101, 15);
            lblProduccion.TabIndex = 39;
            lblProduccion.Text = "EN PRODUCCIÓN";
            // 
            // lblProduccionActual
            // 
            lblProduccionActual.AutoSize = true;
            lblProduccionActual.Location = new Point(130, 160);
            lblProduccionActual.Name = "lblProduccionActual";
            lblProduccionActual.Size = new Size(352, 15);
            lblProduccionActual.TabIndex = 40;
            lblProduccionActual.Text = "*Este label se modifica con la cantidad DE PRODUCCIÓN ACTUAL";
            // 
            // lblProducido
            // 
            lblProducido.AutoSize = true;
            lblProducido.Location = new Point(13, 191);
            lblProducido.Name = "lblProducido";
            lblProducido.Size = new Size(74, 15);
            lblProducido.TabIndex = 41;
            lblProducido.Text = "PRODUCIDO";
            // 
            // lblCantidadProducida
            // 
            lblCantidadProducida.AutoSize = true;
            lblCantidadProducida.Location = new Point(130, 191);
            lblCantidadProducida.Name = "lblCantidadProducida";
            lblCantidadProducida.Size = new Size(278, 15);
            lblCantidadProducida.TabIndex = 42;
            lblCantidadProducida.Text = "*Este label se modifica con la cantidad PRODUCIDA";
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.ForeColor = Color.FromArgb(0, 192, 0);
            lblAviso.Location = new Point(363, 107);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(237, 15);
            lblAviso.TabIndex = 43;
            lblAviso.Text = "*Este lbl avisa si esta por debajo del mínimo";
            // 
            // btnModParametros
            // 
            btnModParametros.Location = new Point(12, 246);
            btnModParametros.Name = "btnModParametros";
            btnModParametros.Size = new Size(244, 32);
            btnModParametros.TabIndex = 44;
            btnModParametros.Text = "MODIFICAR PARÁMETROS DE STOCK";
            btnModParametros.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(262, 255);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(174, 15);
            lblInfo.TabIndex = 45;
            lblInfo.Text = "Establece un mínimo y máximo";
            // 
            // lstViandasPreparadas
            // 
            lstViandasPreparadas.FormattingEnabled = true;
            lstViandasPreparadas.ItemHeight = 15;
            lstViandasPreparadas.Location = new Point(633, 42);
            lstViandasPreparadas.Name = "lstViandasPreparadas";
            lstViandasPreparadas.Size = new Size(308, 289);
            lstViandasPreparadas.TabIndex = 46;
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Location = new Point(623, 81);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(318, 15);
            lblTemp.TabIndex = 47;
            lblTemp.Text = "*Viandas preparadas con fecha de creación y venciminento";
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 374);
            ControlBox = false;
            Controls.Add(lblTemp);
            Controls.Add(lstViandasPreparadas);
            Controls.Add(lblInfo);
            Controls.Add(btnModParametros);
            Controls.Add(lblAviso);
            Controls.Add(lblCantidadProducida);
            Controls.Add(lblProducido);
            Controls.Add(lblProduccionActual);
            Controls.Add(lblProduccion);
            Controls.Add(lblCantidadActual);
            Controls.Add(lblCanitad);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Name = "Stock";
            Text = "Stock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnVolver;
        private Label lblCanitad;
        private Label lblCantidadActual;
        private Label lblProduccion;
        private Label lblProduccionActual;
        private Label lblProducido;
        private Label lblCantidadProducida;
        private Label lblAviso;
        private Button btnModParametros;
        private Label lblInfo;
        private ListBox lstViandasPreparadas;
        private Label lblTemp;
    }
}