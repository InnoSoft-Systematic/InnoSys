﻿namespace InnoSys.Transporte
{
    partial class Transporte
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
            btnZonas = new Button();
            btnEstEnvios = new Button();
            btnSucursales = new Button();
            btnVehiculos = new Button();
            SuspendLayout();
            // 
            // btnZonas
            // 
            btnZonas.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnZonas.Location = new Point(336, 155);
            btnZonas.Name = "btnZonas";
            btnZonas.Size = new Size(290, 123);
            btnZonas.TabIndex = 16;
            btnZonas.Text = "Zonas";
            btnZonas.UseVisualStyleBackColor = true;
            btnZonas.Click += button3_Click;
            // 
            // btnEstEnvios
            // 
            btnEstEnvios.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnEstEnvios.Location = new Point(22, 12);
            btnEstEnvios.Name = "btnEstEnvios";
            btnEstEnvios.Size = new Size(290, 123);
            btnEstEnvios.TabIndex = 18;
            btnEstEnvios.Text = "Estado de envíos";
            btnEstEnvios.UseVisualStyleBackColor = true;
            btnEstEnvios.Click += button2_Click;
            // 
            // btnSucursales
            // 
            btnSucursales.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnSucursales.Location = new Point(22, 155);
            btnSucursales.Name = "btnSucursales";
            btnSucursales.Size = new Size(290, 123);
            btnSucursales.TabIndex = 19;
            btnSucursales.Text = "Sucursales";
            btnSucursales.UseVisualStyleBackColor = true;
            btnSucursales.Click += button4_Click;
            // 
            // btnVehiculos
            // 
            btnVehiculos.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnVehiculos.Location = new Point(336, 12);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Size = new Size(290, 123);
            btnVehiculos.TabIndex = 21;
            btnVehiculos.Text = "Vehículos";
            btnVehiculos.UseVisualStyleBackColor = true;
            btnVehiculos.Click += button6_Click;
            // 
            // Transporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(647, 290);
            Controls.Add(btnVehiculos);
            Controls.Add(btnSucursales);
            Controls.Add(btnEstEnvios);
            Controls.Add(btnZonas);
            Name = "Transporte";
            Text = "Transporte";
            Load += Transporte_Load;
            Disposed += Login_Disposed;
            ResumeLayout(false);
        }

        #endregion

        private Button btnZonas;
        private Button btnEstEnvios;
        private Button btnSucursales;
        private Button btnVehiculos;
    }
}