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
    public partial class FormTriaje : Form
    {
        SqlConnection conn;
        String tipo;
        public FormTriaje(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            tipo = "P";
            FormListado frmListado = new FormListado(conn, tipo);
            frmListado.Show();
        }

        private void btnEnfermera_Click(object sender, EventArgs e)
        {
            tipo = "E";
            FormListado frmListado = new FormListado(conn, tipo);
            frmListado.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEnfermera.Text = "";
            txtPaciente.Text = "";
            txtPeso.Text = "";
            txtPresion.Text = "";
            txtTalla.Text = "";
            txtTemperatura.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String codigo = generarID();
            String cod_paciente = Datos.cod_p;
            String cod_enfermera = Datos.cod_e;
            String peso = txtPeso.Text;
            String presion = txtPresion.Text;
            String talla = txtTalla.Text;
            String temperatura = txtTemperatura.Text;
            String fecha = dtpFecha.Text;
            
            if (cod_enfermera.Length > 0 && cod_paciente.Length > 0 && peso.Length > 0 && presion.Length > 0 && talla.Length > 0 && temperatura.Length > 0 && fecha.Length > 0)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "paInsertarTriaje";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter paramCodigo = new SqlParameter();
                paramCodigo.ParameterName = "@trj_codigo";
                paramCodigo.SqlDbType = SqlDbType.NChar;
                paramCodigo.Value = codigo;

                SqlParameter paramPaciente = new SqlParameter();
                paramPaciente.ParameterName = "@trj_paciente";
                paramPaciente.SqlDbType = SqlDbType.NChar;
                paramPaciente.Value = cod_paciente;

                SqlParameter paramEnfermera = new SqlParameter();
                paramEnfermera.ParameterName = "@trj_enfermera";
                paramEnfermera.SqlDbType = SqlDbType.NChar;
                paramEnfermera.Value = cod_enfermera;

                SqlParameter paramPeso = new SqlParameter();
                paramPeso.ParameterName = "@trj_peso";
                paramPeso.SqlDbType = SqlDbType.Decimal;
                paramPeso.Precision = 5;
                paramPeso.Scale = 2;
                paramPeso.Value = Convert.ToDecimal(peso);

                SqlParameter paramPresion = new SqlParameter();
                paramPresion.ParameterName = "@trj_presion";
                paramPresion.SqlDbType = SqlDbType.Decimal;
                paramPresion.Precision = 5;
                paramPresion.Scale = 2;
                paramPresion.Value = Convert.ToDecimal(presion);

                SqlParameter paramTalla = new SqlParameter();
                paramTalla.ParameterName = "@trj_talla";
                paramTalla.SqlDbType = SqlDbType.Decimal;
                paramTalla.Precision = 5;
                paramTalla.Scale = 2;
                paramTalla.Value = Convert.ToDecimal(talla);

                SqlParameter paramTemperatura = new SqlParameter();
                paramTemperatura.ParameterName = "@trj_temp";
                paramTemperatura.SqlDbType = SqlDbType.Decimal;
                paramTemperatura.Precision = 5;
                paramTemperatura.Scale = 2;
                paramTemperatura.Value = Convert.ToDecimal(temperatura);

                cmd.Parameters.Add(paramCodigo);
                cmd.Parameters.Add(paramPaciente);
                cmd.Parameters.Add(paramEnfermera);
                cmd.Parameters.Add(paramPeso);
                cmd.Parameters.Add(paramPresion);
                cmd.Parameters.Add(paramTalla);
                cmd.Parameters.Add(paramTemperatura);

                int resultado = cmd.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Triaje registrado");
                }
                else
                {
                    MessageBox.Show("Algo salio mal. Vuelve a intentar :/");
                }
            }
            else
            {
                MessageBox.Show("Llene todos los campos");
            }
        }

        private String generarID()
        {
            try
            {
                String sql_index = "SELECT trj_codigo FROM triaje ORDER BY trj_codigo";
                SqlCommand cmd = new SqlCommand(sql_index, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                String[] array_cod = new string[1000];
                int i = 0;
                while (reader.Read())
                {
                    array_cod[i] = reader[0].ToString();
                    i += 1;
                }
                reader.Close();
                String cod = i != 0 ? array_cod[i - 1] : "J001";
                cod = cod.Replace('J', '0');
                int nuevo_cod = Convert.ToInt32(cod) + 1;
                String cod_final = "";
                if (nuevo_cod <= 9)
                {
                    cod_final = "J00" + nuevo_cod;
                }
                else if (nuevo_cod <= 99)
                {
                    cod_final = "J0" + nuevo_cod;
                }
                else
                {
                    cod_final = "J" + nuevo_cod;
                }
                //Console.WriteLine(cod);
                return cod_final;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al generar el id: " + ex);
                return "";
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtPaciente.Text = Datos.nom_p != null ? Datos.nom_p : "";
            txtEnfermera.Text = Datos.nom_e != null ? Datos.nom_e : "";
        }
    }
}
