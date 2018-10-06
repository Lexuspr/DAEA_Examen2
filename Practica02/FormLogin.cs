using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practica02
{
    public partial class FormLogin : Form
    {
        SqlConnection conn;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String str = "Server=localhost\\SQLSERVER2017;Database=sistema_9;Integrated Security=true";
            String nombre = txtUsuario.Text;
            String clave = txtClave.Text;
            try
            {
                conn = new SqlConnection(str);
                conn.Open();

                if (validarDatos(nombre, clave, conn))
                {
                    MDIPrincipal principal = new MDIPrincipal(conn);
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales invalidas");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un problema al conectar al servidor: " + ex);
            }
        }

        private Boolean validarDatos(String nombre, String clave, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "paValidar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            SqlParameter paramNombre = new SqlParameter();
            paramNombre.ParameterName = "@usuario";
            paramNombre.SqlDbType = SqlDbType.NVarChar;
            paramNombre.Value = nombre;

            SqlParameter paramClave = new SqlParameter();
            paramClave.ParameterName = "@passwd";
            paramClave.SqlDbType = SqlDbType.NVarChar;
            paramClave.Value = clave;

            cmd.Parameters.Add(paramNombre);
            cmd.Parameters.Add(paramClave);
           
            Object resultado = cmd.ExecuteScalar();

            if (resultado.ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
