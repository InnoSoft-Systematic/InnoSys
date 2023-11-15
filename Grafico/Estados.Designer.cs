namespace InnoSys
{
    partial class Estados
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
            btnActualizar = new Button();
            dgEstados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgEstados).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 8);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 35;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button4_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(30, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(417, 54);
            lblTitulo.TabIndex = 34;
            lblTitulo.Text = "ESTADOS DE PEDIDOS";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(394, 8);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 36;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dgEstados
            // 
            dgEstados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEstados.Location = new Point(12, 91);
            dgEstados.Name = "dgEstados";
            dgEstados.RowTemplate.Height = 25;
            dgEstados.Size = new Size(457, 376);
            dgEstados.TabIndex = 37;
            dgEstados.CellContentClick += dgEstados_CellContentClick;
            // 
            // Estados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 488);
            ControlBox = false;
            Controls.Add(dgEstados);
            Controls.Add(btnActualizar);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Name = "Estados";
            Text = "Estados";
            Load += Estados_Load;
            ((System.ComponentModel.ISupportInitialize)dgEstados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblTitulo;
        private Button btnActualizar;
        private DataGridView dgEstados;
    }
}