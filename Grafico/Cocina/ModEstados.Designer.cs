namespace InnoSys
{
    partial class ModEstados
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
            btnVerConsulta = new Button();
            lblTitulo = new Label();
            btnVolver = new Button();
            btnActualizar = new Button();
            btnDesechar = new Button();
            dgEstados = new DataGridView();
            btnProduccion = new Button();
            btnEnvasado = new Button();
            btnStock = new Button();
            btnDesechado = new Button();
            btnEntregado = new Button();
            btnDevuelto = new Button();
            ((System.ComponentModel.ISupportInitialize)dgEstados).BeginInit();
            SuspendLayout();
            // 
            // btnVerConsulta
            // 
            btnVerConsulta.Location = new Point(182, 427);
            btnVerConsulta.Name = "btnVerConsulta";
            btnVerConsulta.Size = new Size(244, 37);
            btnVerConsulta.TabIndex = 75;
            btnVerConsulta.Text = "Modificar consulta seleccionada";
            btnVerConsulta.UseVisualStyleBackColor = true;
            btnVerConsulta.Click += btnAlterarEstado_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(0, 37);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(301, 54);
            lblTitulo.TabIndex = 71;
            lblTitulo.Text = " ESTADOS CAJA";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 11);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 76;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button4_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(536, 12);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 78;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnDesechar
            // 
            btnDesechar.Location = new Point(506, 555);
            btnDesechar.Name = "btnDesechar";
            btnDesechar.Size = new Size(105, 32);
            btnDesechar.TabIndex = 79;
            btnDesechar.Text = "DESECHAR";
            btnDesechar.UseVisualStyleBackColor = true;
            btnDesechar.Click += btnRechazar_Click;
            // 
            // dgEstados
            // 
            dgEstados.AllowUserToAddRows = false;
            dgEstados.AllowUserToDeleteRows = false;
            dgEstados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEstados.Location = new Point(12, 115);
            dgEstados.Name = "dgEstados";
            dgEstados.ReadOnly = true;
            dgEstados.RowTemplate.Height = 25;
            dgEstados.Size = new Size(599, 293);
            dgEstados.TabIndex = 80;
            dgEstados.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnProduccion
            // 
            btnProduccion.ForeColor = SystemColors.ButtonHighlight;
            btnProduccion.Location = new Point(246, 481);
            btnProduccion.Name = "btnProduccion";
            btnProduccion.Size = new Size(108, 38);
            btnProduccion.TabIndex = 81;
            btnProduccion.Text = "En Producción";
            btnProduccion.UseVisualStyleBackColor = true;
            btnProduccion.Click += btnProduccion_Click;
            // 
            // btnEnvasado
            // 
            btnEnvasado.ForeColor = SystemColors.ButtonHighlight;
            btnEnvasado.Location = new Point(360, 481);
            btnEnvasado.Name = "btnEnvasado";
            btnEnvasado.Size = new Size(108, 38);
            btnEnvasado.TabIndex = 82;
            btnEnvasado.Text = "Envasado";
            btnEnvasado.UseVisualStyleBackColor = true;
            btnEnvasado.Click += btnEnvasado_Click;
            // 
            // btnStock
            // 
            btnStock.ForeColor = SystemColors.ButtonHighlight;
            btnStock.Location = new Point(132, 481);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(108, 38);
            btnStock.TabIndex = 84;
            btnStock.Text = "En Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += button4_Click_1;
            // 
            // btnDesechado
            // 
            btnDesechado.ForeColor = SystemColors.ButtonFace;
            btnDesechado.Location = new Point(133, 560);
            btnDesechado.Name = "btnDesechado";
            btnDesechado.Size = new Size(108, 23);
            btnDesechado.TabIndex = 85;
            btnDesechado.Text = "Desechado";
            btnDesechado.UseVisualStyleBackColor = true;
            btnDesechado.Click += btnDesechado_Click;
            // 
            // btnEntregado
            // 
            btnEntregado.ForeColor = SystemColors.ButtonFace;
            btnEntregado.Location = new Point(247, 560);
            btnEntregado.Name = "btnEntregado";
            btnEntregado.Size = new Size(108, 23);
            btnEntregado.TabIndex = 86;
            btnEntregado.Text = "Entregado";
            btnEntregado.UseVisualStyleBackColor = true;
            // 
            // btnDevuelto
            // 
            btnDevuelto.ForeColor = SystemColors.ButtonFace;
            btnDevuelto.Location = new Point(360, 560);
            btnDevuelto.Name = "btnDevuelto";
            btnDevuelto.Size = new Size(108, 23);
            btnDevuelto.TabIndex = 87;
            btnDevuelto.Text = "Devuelto";
            btnDevuelto.UseVisualStyleBackColor = true;
            btnDevuelto.Click += btnDevuelto_Click;
            // 
            // ModEstados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 595);
            ControlBox = false;
            Controls.Add(btnDevuelto);
            Controls.Add(btnEntregado);
            Controls.Add(btnDesechado);
            Controls.Add(btnStock);
            Controls.Add(btnEnvasado);
            Controls.Add(btnProduccion);
            Controls.Add(dgEstados);
            Controls.Add(btnDesechar);
            Controls.Add(btnActualizar);
            Controls.Add(btnVolver);
            Controls.Add(btnVerConsulta);
            Controls.Add(lblTitulo);
            Name = "ModEstados";
            Text = "Modificación de envíos";
            Load += ModEstados_Load;
            ((System.ComponentModel.ISupportInitialize)dgEstados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerConsulta;
        private Label lblTitulo;
        private Button btnVolver;
        private Button btnActualizar;
        private Button btnDesechar;
        private DataGridView dgEstados;
        private Button btnProduccion;
        private Button btnEnvasado;
        private Button btnEntregado;
        private Button btnStock;
        private Button btnDesechado;
        private Button button2;
        private Button btnDevuelto;
    }
}