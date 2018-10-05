namespace Practica02
{
    partial class MDIPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manHospitales = new System.Windows.Forms.ToolStripMenuItem();
            this.manConsultorios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.doctoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enfermerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sisSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manUsuarios,
            this.hospitalesToolStripMenuItem,
            this.médicosToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // manUsuarios
            // 
            this.manUsuarios.Name = "manUsuarios";
            this.manUsuarios.Size = new System.Drawing.Size(216, 26);
            this.manUsuarios.Text = "Usuarios";
            this.manUsuarios.Click += new System.EventHandler(this.manUsuarios_Click);
            // 
            // hospitalesToolStripMenuItem
            // 
            this.hospitalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manHospitales,
            this.manConsultorios,
            this.toolStripSeparator1,
            this.doctoresToolStripMenuItem,
            this.enfermerasToolStripMenuItem,
            this.pacientesToolStripMenuItem});
            this.hospitalesToolStripMenuItem.Name = "hospitalesToolStripMenuItem";
            this.hospitalesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.hospitalesToolStripMenuItem.Text = "Establecimientos";
            // 
            // manHospitales
            // 
            this.manHospitales.Name = "manHospitales";
            this.manHospitales.Size = new System.Drawing.Size(216, 26);
            this.manHospitales.Text = "Hospitales";
            this.manHospitales.Click += new System.EventHandler(this.manHospitales_Click);
            // 
            // manConsultorios
            // 
            this.manConsultorios.Name = "manConsultorios";
            this.manConsultorios.Size = new System.Drawing.Size(216, 26);
            this.manConsultorios.Text = "Consultorios";
            this.manConsultorios.Click += new System.EventHandler(this.manConsultorios_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // doctoresToolStripMenuItem
            // 
            this.doctoresToolStripMenuItem.Name = "doctoresToolStripMenuItem";
            this.doctoresToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.doctoresToolStripMenuItem.Text = "Médicos";
            this.doctoresToolStripMenuItem.Click += new System.EventHandler(this.doctoresToolStripMenuItem_Click);
            // 
            // enfermerasToolStripMenuItem
            // 
            this.enfermerasToolStripMenuItem.Name = "enfermerasToolStripMenuItem";
            this.enfermerasToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.enfermerasToolStripMenuItem.Text = "Enfermeras";
            this.enfermerasToolStripMenuItem.Click += new System.EventHandler(this.enfermerasToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // médicosToolStripMenuItem
            // 
            this.médicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicinasToolStripMenuItem,
            this.manProveedores});
            this.médicosToolStripMenuItem.Name = "médicosToolStripMenuItem";
            this.médicosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.médicosToolStripMenuItem.Text = "Depósito";
            // 
            // medicinasToolStripMenuItem
            // 
            this.medicinasToolStripMenuItem.Name = "medicinasToolStripMenuItem";
            this.medicinasToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.medicinasToolStripMenuItem.Text = "Medicinas";
            this.medicinasToolStripMenuItem.Click += new System.EventHandler(this.medicinasToolStripMenuItem_Click);
            // 
            // manProveedores
            // 
            this.manProveedores.Name = "manProveedores";
            this.manProveedores.Size = new System.Drawing.Size(216, 26);
            this.manProveedores.Text = "Proveedores";
            this.manProveedores.Click += new System.EventHandler(this.manProveedores_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sisSalir});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // sisSalir
            // 
            this.sisSalir.Name = "sisSalir";
            this.sisSalir.Size = new System.Drawing.Size(113, 26);
            this.sisSalir.Text = "Salir";
            this.sisSalir.Click += new System.EventHandler(this.sisSalir_Click);
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDIPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manUsuarios;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospitalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manHospitales;
        private System.Windows.Forms.ToolStripMenuItem manConsultorios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem doctoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enfermerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manProveedores;
        private System.Windows.Forms.ToolStripMenuItem sisSalir;
    }
}