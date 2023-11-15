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
            lblAvisoStock = new Label();
            btnModParametros = new Button();
            lblInfo = new Label();
            button1 = new Button();
            lstMenu = new ListBox();
            btnVer = new Button();
            gbModStock = new GroupBox();
            gbModStock.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(27, 38);
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
            lblCanitad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCanitad.Location = new Point(200, 111);
            lblCanitad.Name = "lblCanitad";
            lblCanitad.Size = new Size(116, 15);
            lblCanitad.TabIndex = 37;
            lblCanitad.Text = "CANTIDAD ACTUAL";
            // 
            // lblCantidadActual
            // 
            lblCantidadActual.AutoSize = true;
            lblCantidadActual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantidadActual.Location = new Point(322, 106);
            lblCantidadActual.Name = "lblCantidadActual";
            lblCantidadActual.Size = new Size(130, 21);
            lblCantidadActual.TabIndex = 38;
            lblCantidadActual.Text = "Cantidad actual";
            lblCantidadActual.Click += lblCantidadActual_Click;
            // 
            // lblProduccion
            // 
            lblProduccion.AutoSize = true;
            lblProduccion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduccion.Location = new Point(200, 152);
            lblProduccion.Name = "lblProduccion";
            lblProduccion.Size = new Size(103, 15);
            lblProduccion.TabIndex = 39;
            lblProduccion.Text = "EN PRODUCCIÓN";
            // 
            // lblProduccionActual
            // 
            lblProduccionActual.AutoSize = true;
            lblProduccionActual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduccionActual.Location = new Point(322, 146);
            lblProduccionActual.Name = "lblProduccionActual";
            lblProduccionActual.Size = new Size(148, 21);
            lblProduccionActual.TabIndex = 40;
            lblProduccionActual.Text = "Produccion actual";
            // 
            // lblProducido
            // 
            lblProducido.AutoSize = true;
            lblProducido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblProducido.Location = new Point(201, 195);
            lblProducido.Name = "lblProducido";
            lblProducido.Size = new Size(78, 15);
            lblProducido.TabIndex = 41;
            lblProducido.Text = "PRODUCIDO";
            // 
            // lblCantidadProducida
            // 
            lblCantidadProducida.AutoSize = true;
            lblCantidadProducida.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantidadProducida.Location = new Point(322, 189);
            lblCantidadProducida.Name = "lblCantidadProducida";
            lblCantidadProducida.Size = new Size(89, 21);
            lblCantidadProducida.TabIndex = 42;
            lblCantidadProducida.Text = "Producido";
            lblCantidadProducida.Click += lblCantidadProducida_Click;
            // 
            // lblAvisoStock
            // 
            lblAvisoStock.AutoSize = true;
            lblAvisoStock.ForeColor = Color.FromArgb(0, 192, 0);
            lblAvisoStock.Location = new Point(379, 111);
            lblAvisoStock.Name = "lblAvisoStock";
            lblAvisoStock.Size = new Size(12, 15);
            lblAvisoStock.TabIndex = 43;
            lblAvisoStock.Text = "*";
            // 
            // btnModParametros
            // 
            btnModParametros.Location = new Point(36, 32);
            btnModParametros.Name = "btnModParametros";
            btnModParametros.Size = new Size(244, 32);
            btnModParametros.TabIndex = 44;
            btnModParametros.Text = "MODIFICAR PARÁMETROS DE STOCK";
            btnModParametros.UseVisualStyleBackColor = true;
            btnModParametros.Click += btnModParametros_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(73, 67);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(174, 15);
            lblInfo.TabIndex = 45;
            lblInfo.Text = "Establece un mínimo y máximo";
            // 
            // button1
            // 
            button1.Location = new Point(525, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 49;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lstMenu
            // 
            lstMenu.FormattingEnabled = true;
            lstMenu.ItemHeight = 15;
            lstMenu.Location = new Point(12, 95);
            lstMenu.Name = "lstMenu";
            lstMenu.Size = new Size(166, 214);
            lstMenu.TabIndex = 51;
            lstMenu.SelectedIndexChanged += lstMenu_SelectedIndexChanged;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(52, 321);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(75, 41);
            btnVer.TabIndex = 52;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // gbModStock
            // 
            gbModStock.Controls.Add(btnModParametros);
            gbModStock.Controls.Add(lblInfo);
            gbModStock.Location = new Point(292, 262);
            gbModStock.Name = "gbModStock";
            gbModStock.Size = new Size(308, 100);
            gbModStock.TabIndex = 53;
            gbModStock.TabStop = false;
            gbModStock.Text = "Parámetros";
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 374);
            ControlBox = false;
            Controls.Add(gbModStock);
            Controls.Add(btnVer);
            Controls.Add(lstMenu);
            Controls.Add(button1);
            Controls.Add(lblAvisoStock);
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
            Load += Stock_Load;
            gbModStock.ResumeLayout(false);
            gbModStock.PerformLayout();
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
        private Label lblAvisoStock;
        private Button btnModParametros;
        private Label lblInfo;
        private Button button1;
        private ListView listView1;
        private ListBox lstMenu;
        private Button btnVer;
        private GroupBox gbModStock;
    }
}