namespace Practica02
{
    partial class FormMedico
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
            this.cbxHospital = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvListadoM = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoM)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxHospital
            // 
            this.cbxHospital.FormattingEnabled = true;
            this.cbxHospital.Location = new System.Drawing.Point(13, 30);
            this.cbxHospital.Name = "cbxHospital";
            this.cbxHospital.Size = new System.Drawing.Size(305, 24);
            this.cbxHospital.TabIndex = 60;
            this.cbxHospital.SelectedIndexChanged += new System.EventHandler(this.cbxHospital_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(519, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 34);
            this.btnBuscar.TabIndex = 57;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(518, 338);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 34);
            this.btnEliminar.TabIndex = 56;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(518, 298);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 34);
            this.btnEditar.TabIndex = 55;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(518, 258);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(84, 34);
            this.btnNuevo.TabIndex = 54;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(519, 23);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(84, 34);
            this.btnListar.TabIndex = 53;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvListadoM
            // 
            this.dgvListadoM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoM.Location = new System.Drawing.Point(11, 258);
            this.dgvListadoM.Name = "dgvListadoM";
            this.dgvListadoM.RowTemplate.Height = 24;
            this.dgvListadoM.Size = new System.Drawing.Size(479, 317);
            this.dgvListadoM.TabIndex = 52;
            this.dgvListadoM.SelectionChanged += new System.EventHandler(this.dgvListadoM_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Hospital";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "DNI";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(11, 92);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(144, 22);
            this.txtCodigo.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Código";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(11, 137);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(144, 22);
            this.txtDNI.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(172, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(318, 22);
            this.txtNombre.TabIndex = 63;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(11, 228);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(146, 22);
            this.dtpFechaNac.TabIndex = 64;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(172, 182);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(144, 22);
            this.txtSueldo.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "Sueldo";
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(11, 182);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(144, 22);
            this.txtEspecialidad.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 67;
            this.label7.Text = "Especialidad";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(172, 228);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(146, 22);
            this.dtpFechaInicio.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 69;
            this.label8.Text = "Fecha Inicio";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(172, 137);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(318, 22);
            this.txtDireccion.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(173, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 71;
            this.label9.Text = "Direccion";
            // 
            // FormMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 590);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.cbxHospital);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvListadoM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxHospital;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvListadoM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label9;
    }
}