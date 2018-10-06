namespace Practica02
{
    partial class FormTriaje
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
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtPresion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtEnfermera = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEnfermera = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(172, 182);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(146, 22);
            this.txtTemperatura.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(173, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 89;
            this.label9.Text = "Temperatura";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy HH:MM";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(11, 228);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(165, 22);
            this.dtpFecha.TabIndex = 82;
            this.dtpFecha.Value = new System.DateTime(2018, 10, 5, 20, 5, 16, 0);
            // 
            // txtPresion
            // 
            this.txtPresion.Location = new System.Drawing.Point(172, 137);
            this.txtPresion.Name = "txtPresion";
            this.txtPresion.Size = new System.Drawing.Size(146, 22);
            this.txtPresion.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 80;
            this.label2.Text = "Presion";
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(11, 182);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(144, 22);
            this.txtTalla.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 77;
            this.label5.Text = "Paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 76;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Talla";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(11, 137);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(144, 22);
            this.txtPeso.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "Peso";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(12, 29);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(478, 22);
            this.txtPaciente.TabIndex = 91;
            // 
            // btnPaciente
            // 
            this.btnPaciente.Location = new System.Drawing.Point(519, 23);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(149, 34);
            this.btnPaciente.TabIndex = 92;
            this.btnPaciente.Text = "Escoger Paciente";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(342, 224);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(148, 34);
            this.btnLimpiar.TabIndex = 93;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(519, 224);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 34);
            this.btnGuardar.TabIndex = 94;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtEnfermera
            // 
            this.txtEnfermera.Location = new System.Drawing.Point(12, 83);
            this.txtEnfermera.Name = "txtEnfermera";
            this.txtEnfermera.Size = new System.Drawing.Size(478, 22);
            this.txtEnfermera.TabIndex = 96;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 95;
            this.label10.Text = "Enfermera";
            // 
            // btnEnfermera
            // 
            this.btnEnfermera.Location = new System.Drawing.Point(519, 77);
            this.btnEnfermera.Name = "btnEnfermera";
            this.btnEnfermera.Size = new System.Drawing.Size(149, 34);
            this.btnEnfermera.TabIndex = 97;
            this.btnEnfermera.Text = "Escoger Enfermera";
            this.btnEnfermera.UseVisualStyleBackColor = true;
            this.btnEnfermera.Click += new System.EventHandler(this.btnEnfermera_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(519, 131);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(148, 34);
            this.btnActualizar.TabIndex = 98;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FormTriaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 266);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEnfermera);
            this.Controls.Add(this.txtEnfermera);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtPresion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTalla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label1);
            this.Name = "FormTriaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Llenar Triaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtPresion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEnfermera;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.TextBox txtEnfermera;
    }
}