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
    public partial class FormConsulta : Form
    {
        SqlConnection conn;
        String tipo;

        public FormConsulta(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private String generarID()
        {
            try
            {
                String sql_index = "SELECT cta_codigo FROM consulta ORDER BY cta_codigo";
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
                String cod = i != 0 ? array_cod[i - 1] : "C001";
                cod = cod.Replace('C', '0');
                int nuevo_cod = Convert.ToInt32(cod) + 1;
                String cod_final = "";
                if (nuevo_cod <= 9)
                {
                    cod_final = "C00" + nuevo_cod;
                }
                else if (nuevo_cod <= 99)
                {
                    cod_final = "C0" + nuevo_cod;
                }
                else
                {
                    cod_final = "C" + nuevo_cod;
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

        private void btnConsultorio_Click(object sender, EventArgs e)
        {
            tipo = "C";
            FormListado frmList = new FormListado(conn, tipo);
            frmList.Show();

        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            tipo = "M";
            FormListado frmList = new FormListado(conn, tipo);
            frmList.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                String consultorio = Datos.cod_c;
                String medico = Datos.cod_m;
                String codigo = generarID();
                String triaje = Datos.cod_t;
                //String fecha = dtpFecha.Text;

                if (consultorio.Length > 0 && medico.Length > 0)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "paInsertarConsulta";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlParameter paramCodigo = new SqlParameter();
                    paramCodigo.ParameterName = "@cta_codigo";
                    paramCodigo.SqlDbType = SqlDbType.NChar;
                    paramCodigo.Value = codigo;

                    SqlParameter paramConsultorio = new SqlParameter();
                    paramConsultorio.ParameterName = "@cta_consultorio";
                    paramConsultorio.SqlDbType = SqlDbType.NChar;
                    paramConsultorio.Value = consultorio;

                    SqlParameter paramMedico = new SqlParameter();
                    paramMedico.ParameterName = "@cta_medico";
                    paramMedico.SqlDbType = SqlDbType.NChar;
                    paramMedico.Value = medico;

                    SqlParameter paramTriaje = new SqlParameter();
                    paramTriaje.ParameterName = "@cta_triaje";
                    paramTriaje.SqlDbType = SqlDbType.NChar;
                    paramTriaje.Value = triaje;

                    cmd.Parameters.Add(paramCodigo);
                    cmd.Parameters.Add(paramConsultorio);
                    cmd.Parameters.Add(paramMedico);
                    cmd.Parameters.Add(paramTriaje);

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Consulta registrada");
                        this.Close();

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
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtConsultorio.Text = Datos.cod_c;
            txtMedico.Text = Datos.nom_m;
        }
    }
}
