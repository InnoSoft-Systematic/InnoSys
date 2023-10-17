namespace InnoSys
{
    partial class IngresoEnvío
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
            lblIngresarEnvio = new Label();
            lstEnvios = new ListBox();
            lblInfo = new Label();
            btnDespachar = new Button();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(21, 14);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 38;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button4_Click;
            // 
            // lblIngresarEnvio
            // 
            lblIngresarEnvio.AutoSize = true;
            lblIngresarEnvio.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblIngresarEnvio.Location = new Point(12, 40);
            lblIngresarEnvio.Name = "lblIngresarEnvio";
            lblIngresarEnvio.Size = new Size(333, 54);
            lblIngresarEnvio.TabIndex = 37;
            lblIngresarEnvio.Text = "INGRESAR ENVÍO";
            // 
            // lstEnvios
            // 
            lstEnvios.FormattingEnabled = true;
            lstEnvios.ItemHeight = 15;
            lstEnvios.Location = new Point(21, 113);
            lstEnvios.Name = "lstEnvios";
            lstEnvios.Size = new Size(308, 289);
            lstEnvios.TabIndex = 47;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(21, 94);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(282, 15);
            lblInfo.TabIndex = 48;
            lblInfo.Text = "*Se mostrará la lista de estados listos para despachar";
            // 
            // btnDespachar
            // 
            btnDespachar.Location = new Point(357, 196);
            btnDespachar.Name = "btnDespachar";
            btnDespachar.Size = new Size(144, 66);
            btnDespachar.TabIndex = 49;
            btnDespachar.Text = "DESPACHAR";
            btnDespachar.UseVisualStyleBackColor = true;
            // 
            // IngresoEnvío
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 450);
            ControlBox = false;
            Controls.Add(btnDespachar);
            Controls.Add(lblInfo);
            Controls.Add(lstEnvios);
            Controls.Add(btnVolver);
            Controls.Add(lblIngresarEnvio);
            Name = "IngresoEnvío";
            Text = "IngresoEnvío";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblIngresarEnvio;
        private ListBox lstEnvios;
        private Label lblInfo;
        private Button btnDespachar;
    }
}