namespace Practica02
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtClave = new System.Windows.Forms.MaskedTextBox();
            this.rbtnUser = new System.Windows.Forms.RadioButton();
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(119, 78);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(137, 22);
            this.txtClave.TabIndex = 16;
            // 
            // rbtnUser
            // 
            this.rbtnUser.AutoSize = true;
            this.rbtnUser.Location = new System.Drawing.Point(197, 149);
            this.rbtnUser.Name = "rbtnUser";
            this.rbtnUser.Size = new System.Drawing.Size(59, 21);
            this.rbtnUser.TabIndex = 15;
            this.rbtnUser.Text = "User";
            this.rbtnUser.UseVisualStyleBackColor = true;
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.Location = new System.Drawing.Point(118, 149);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(68, 21);
            this.rbtnAdmin.TabIndex = 14;
            this.rbtnAdmin.Text = "Admin";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(115, 109);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(120, 17);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Olvidó su clave?";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(298, 149);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(92, 26);
            this.btnIngresar.TabIndex = 12;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Clave:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(118, 47);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(138, 22);
            this.txtUsuario.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuario:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(20, 180);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 26);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 218);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.rbtnUser);
            this.Controls.Add(this.rbtnAdmin);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtClave;
        private System.Windows.Forms.RadioButton rbtnUser;
        private System.Windows.Forms.RadioButton rbtnAdmin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
    }
}

