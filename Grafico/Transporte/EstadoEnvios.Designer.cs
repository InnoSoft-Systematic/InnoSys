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
            btnVolver = new Button();
            lblTitulos = new Label();
            btnConfirmado = new Button();
            btnEntregado = new Button();
            btnEnviado = new Button();
            dgEstados = new DataGridView();
            btnRechazar = new Button();
            btnActualizar = new Button();
            btnVerConsulta = new Button();
            btnRechazado = new Button();
            lblEntregado = new Label();
            ((System.ComponentModel.ISupportInitialize)dgEstados).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 6);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 34;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btmVolver_Click;
            // 
            // lblTitulos
            // 
            lblTitulos.AutoSize = true;
            lblTitulos.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulos.Location = new Point(16, 51);
            lblTitulos.Name = "lblTitulos";
            lblTitulos.Size = new Size(314, 54);
            lblTitulos.TabIndex = 33;
            lblTitulos.Text = "ESTADO ENVÍOS";
            // 
            // btnConfirmado
            // 
            btnConfirmado.ForeColor = SystemColors.ButtonHighlight;
            btnConfirmado.Location = new Point(129, 491);
            btnConfirmado.Name = "btnConfirmado";
            btnConfirmado.Size = new Size(108, 38);
            btnConfirmado.TabIndex = 96;
            btnConfirmado.Text = "Confirmado";
            btnConfirmado.UseVisualStyleBackColor = true;
            // 
            // btnEntregado
            // 
            btnEntregado.ForeColor = SystemColors.ButtonHighlight;
            btnEntregado.Location = new Point(357, 491);
            btnEntregado.Name = "btnEntregado";
            btnEntregado.Size = new Size(108, 38);
            btnEntregado.TabIndex = 95;
            btnEntregado.Text = "Entregado";
            btnEntregado.UseVisualStyleBackColor = true;
            btnEntregado.Click += btnEntregado_Click;
            // 
            // btnEnviado
            // 
            btnEnviado.ForeColor = SystemColors.ButtonHighlight;
            btnEnviado.Location = new Point(243, 491);
            btnEnviado.Name = "btnEnviado";
            btnEnviado.Size = new Size(108, 38);
            btnEnviado.TabIndex = 94;
            btnEnviado.Text = "Enviado";
            btnEnviado.UseVisualStyleBackColor = true;
            btnEnviado.Click += btnEnviado_Click;
            // 
            // dgEstados
            // 
            dgEstados.AllowUserToAddRows = false;
            dgEstados.AllowUserToDeleteRows = false;
            dgEstados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEstados.Location = new Point(16, 117);
            dgEstados.Name = "dgEstados";
            dgEstados.ReadOnly = true;
            dgEstados.RowTemplate.Height = 25;
            dgEstados.Size = new Size(694, 293);
            dgEstados.TabIndex = 93;
            // 
            // btnRechazar
            // 
            btnRechazar.Location = new Point(605, 593);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(105, 32);
            btnRechazar.TabIndex = 92;
            btnRechazar.Text = "RECHAZAR";
            btnRechazar.UseVisualStyleBackColor = true;
            btnRechazar.Click += btnRechazar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(635, 6);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 91;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnVerConsulta
            // 
            btnVerConsulta.Location = new Point(240, 437);
            btnVerConsulta.Name = "btnVerConsulta";
            btnVerConsulta.Size = new Size(244, 37);
            btnVerConsulta.TabIndex = 89;
            btnVerConsulta.Text = "Modificar consulta seleccionada";
            btnVerConsulta.UseVisualStyleBackColor = true;
            btnVerConsulta.Click += btnVerConsulta_Click;
            // 
            // btnRechazado
            // 
            btnRechazado.ForeColor = SystemColors.ButtonHighlight;
            btnRechazado.Location = new Point(471, 491);
            btnRechazado.Name = "btnRechazado";
            btnRechazado.Size = new Size(108, 38);
            btnRechazado.TabIndex = 100;
            btnRechazado.Text = "Rechazado";
            btnRechazado.UseVisualStyleBackColor = true;
            btnRechazado.Click += btnRechazado_Click;
            // 
            // lblEntregado
            // 
            lblEntregado.AutoSize = true;
            lblEntregado.Location = new Point(277, 541);
            lblEntregado.Name = "lblEntregado";
            lblEntregado.Size = new Size(158, 15);
            lblEntregado.TabIndex = 101;
            lblEntregado.Text = "Este envío ha sido entregado";
            lblEntregado.Click += label1_Click;
            // 
            // EstadoEnvios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 637);
            ControlBox = false;
            Controls.Add(lblEntregado);
            Controls.Add(btnRechazado);
            Controls.Add(btnConfirmado);
            Controls.Add(btnEntregado);
            Controls.Add(btnEnviado);
            Controls.Add(dgEstados);
            Controls.Add(btnRechazar);
            Controls.Add(btnActualizar);
            Controls.Add(btnVerConsulta);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulos);
            Name = "EstadoEnvios";
            Text = "Estado Envios";
            Load += EstadoEnvios_Load;
            ((System.ComponentModel.ISupportInitialize)dgEstados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblTitulos;
        private Button btnEntregado;
        private Button btnConfirmado;
        private Button btnEnvasado;
        private Button btnEnviado;
        private DataGridView dgEstados;
        private Button btnRechazar;
        private Button btnActualizar;
        private Button btnVerConsulta;
        private Button btnRechazado;
        private Label lblEntregado;
    }
}