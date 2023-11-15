namespace InnoSys
{
    partial class Vehículos
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
            lstVehiculos = new ListBox();
            txtMatricula = new TextBox();
            lblMatricula = new Label();
            txtCapacidad = new TextBox();
            lblCapacidad = new Label();
            btnAñadirVehiculo = new Button();
            gbBuscar = new GroupBox();
            btnBuscar = new Button();
            btnModificar = new Button();
            gbIngresar = new GroupBox();
            btnActualizarCapacidad = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            gbBuscar.SuspendLayout();
            gbIngresar.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 8);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 38;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button4_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(12, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(228, 54);
            lblTitulo.TabIndex = 37;
            lblTitulo.Text = "VEHÍCULOS";
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(12, 95);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(139, 199);
            lstVehiculos.TabIndex = 47;
            lstVehiculos.SelectedIndexChanged += lstVehiculos_SelectedIndexChanged;
            // 
            // txtMatricula
            // 
            txtMatricula.Cursor = Cursors.IBeam;
            txtMatricula.Location = new Point(77, 27);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(97, 23);
            txtMatricula.TabIndex = 50;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(6, 30);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(65, 15);
            lblMatricula.TabIndex = 49;
            lblMatricula.Text = "Matrícula *";
            // 
            // txtCapacidad
            // 
            txtCapacidad.Cursor = Cursors.IBeam;
            txtCapacidad.Location = new Point(83, 37);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(32, 23);
            txtCapacidad.TabIndex = 52;
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Location = new Point(6, 40);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(71, 15);
            lblCapacidad.TabIndex = 51;
            lblCapacidad.Text = "Capacidad *";
            // 
            // btnAñadirVehiculo
            // 
            btnAñadirVehiculo.Location = new Point(6, 70);
            btnAñadirVehiculo.Name = "btnAñadirVehiculo";
            btnAñadirVehiculo.Size = new Size(94, 23);
            btnAñadirVehiculo.TabIndex = 53;
            btnAñadirVehiculo.Text = "INGRESAR";
            btnAñadirVehiculo.UseVisualStyleBackColor = true;
            btnAñadirVehiculo.Click += btnAñadirVehiculo_Click;
            // 
            // gbBuscar
            // 
            gbBuscar.Controls.Add(btnBuscar);
            gbBuscar.Controls.Add(btnModificar);
            gbBuscar.Controls.Add(txtMatricula);
            gbBuscar.Controls.Add(lblMatricula);
            gbBuscar.Location = new Point(157, 95);
            gbBuscar.Name = "gbBuscar";
            gbBuscar.Size = new Size(200, 94);
            gbBuscar.TabIndex = 54;
            gbBuscar.TabStop = false;
            gbBuscar.Text = "Buscar";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(83, 65);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 55;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(6, 65);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 56;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // gbIngresar
            // 
            gbIngresar.Controls.Add(btnActualizarCapacidad);
            gbIngresar.Controls.Add(txtCapacidad);
            gbIngresar.Controls.Add(lblCapacidad);
            gbIngresar.Controls.Add(btnAñadirVehiculo);
            gbIngresar.Location = new Point(157, 195);
            gbIngresar.Name = "gbIngresar";
            gbIngresar.Size = new Size(200, 99);
            gbIngresar.TabIndex = 55;
            gbIngresar.TabStop = false;
            gbIngresar.Text = "Ingresar capacidad del vehículo";
            // 
            // btnActualizarCapacidad
            // 
            btnActualizarCapacidad.Location = new Point(106, 70);
            btnActualizarCapacidad.Name = "btnActualizarCapacidad";
            btnActualizarCapacidad.Size = new Size(75, 23);
            btnActualizarCapacidad.TabIndex = 57;
            btnActualizarCapacidad.Text = "Actualizar";
            btnActualizarCapacidad.UseVisualStyleBackColor = true;
            btnActualizarCapacidad.Click += btnActualizarCapacidad_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(367, 12);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 56;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(372, 265);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 57;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Vehículos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 307);
            ControlBox = false;
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(gbIngresar);
            Controls.Add(gbBuscar);
            Controls.Add(lstVehiculos);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Name = "Vehículos";
            Text = "Vehículos";
            Load += Vehículos_Load;
            gbBuscar.ResumeLayout(false);
            gbBuscar.PerformLayout();
            gbIngresar.ResumeLayout(false);
            gbIngresar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblTitulo;
        private ListBox lstVehiculos;
        private TextBox txtMatricula;
        private Label lblMatricula;
        private TextBox txtCapacidad;
        private Label lblCapacidad;
        private Button btnAñadirVehiculo;
        private GroupBox gbBuscar;
        private Button btnBuscar;
        private GroupBox gbIngresar;
        private Button btnActualizar;
        private Button btnModificar;
        private Button btnActualizarCapacidad;
        private Button btnEliminar;
    }
}