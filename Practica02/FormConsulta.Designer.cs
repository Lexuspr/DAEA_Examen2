namespace Practica02
{
    partial class FormConsulta
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
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtConsultorio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConsultorio = new System.Windows.Forms.Button();
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMedico
            // 
            this.txtMedico.Location = new System.Drawing.Point(12, 117);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(478, 22);
            this.txtMedico.TabIndex = 100;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 99;
            this.label10.Text = "Medico";
            // 
            // txtConsultorio
            // 
            this.txtConsultorio.Location = new System.Drawing.Point(12, 29);
            this.txtConsultorio.Name = "txtConsultorio";
            this.txtConsultorio.Size = new System.Drawing.Size(478, 22);
            this.txtConsultorio.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 97;
            this.label5.Text = "Consultorio";
            // 
            // btnConsultorio
            // 
            this.btnConsultorio.Location = new System.Drawing.Point(341, 67);
            this.btnConsultorio.Name = "btnConsultorio";
            this.btnConsultorio.Size = new System.Drawing.Size(149, 34);
            this.btnConsultorio.TabIndex = 101;
            this.btnConsultorio.Text = "Escoger Consultorio";
            this.btnConsultorio.UseVisualStyleBackColor = true;
            this.btnConsultorio.Click += new System.EventHandler(this.btnConsultorio_Click);
            // 
            // btnMedico
            // 
            this.btnMedico.Location = new System.Drawing.Point(341, 156);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(149, 34);
            this.btnMedico.TabIndex = 102;
            this.btnMedico.Text = "Escoger Medico";
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(372, 228);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 34);
            this.btnGuardar.TabIndex = 105;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(15, 228);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(122, 34);
            this.btnAtras.TabIndex = 106;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 34);
            this.button1.TabIndex = 107;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 272);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnMedico);
            this.Controls.Add(this.btnConsultorio);
            this.Controls.Add(this.txtMedico);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtConsultorio);
            this.Controls.Add(this.label5);
            this.Name = "FormConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtConsultorio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConsultorio;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button button1;
    }
}