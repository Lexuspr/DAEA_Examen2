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
    public partial class FormConsultorio : Form
    {
        SqlConnection conn;
        String[] arrayHospitales;


        public FormConsultorio(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            arrayHospitales = new string[100];
            String sql_select_hospitales = "SELECT hos_codigo, hos_nombre FROM hospital";
            int i = 0;
            SqlCommand cmd = new SqlCommand(sql_select_hospitales, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            cbxHospital.Items.Clear();

            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString());
                arrayHospitales[i] = reader[0].ToString();
                cbxHospital.Items.Add(reader[1].ToString());
                i += 1;
            }
            reader.Close();
        }

        private void ListarConsultorios(SqlConnection conn, String codigo)
        {
            String sql_select = "SELECT cto_codigo as 'CODIGO', cto_hospital as 'HOSPITAL', cto_piso as 'PISO', cto_numero as 'NUMERO' FROM consultorio WHERE cto_hospital = '" + codigo + "'";
            SqlCommand cmd = new SqlCommand(sql_select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvListadoC.DataSource = dt;
            dgvListadoC.Refresh();
        }

        private void FormConsultorio_Load(object sender, EventArgs e)
        {

        }

        private void dgvListadoC_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListadoC.SelectedRows.Count > 0)
            {
                txtCodigo.Text = dgvListadoC.SelectedRows[0].Cells[0].Value.ToString();
                numPiso.Text = dgvListadoC.SelectedRows[0].Cells[2].Value.ToString();
                numNumero.Text = dgvListadoC.SelectedRows[0].Cells[3].Value.ToString();
                String cod_hospital = dgvListadoC.SelectedRows[0].Cells[1].Value.ToString();
                for (int i = 0; i <= arrayHospitales.Count() - 1; i++)
                {
                    if (cod_hospital == arrayHospitales[i])
                    {
                        cbxHospital.SelectedIndex = i;
                    }
                }
            }
        }

        private void cbxHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = cbxHospital.SelectedIndex;
            ListarConsultorios(conn, arrayHospitales[id]);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            int id = cbxHospital.SelectedIndex;
            ListarConsultorios(conn, arrayHospitales[id]);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;

            String sql_buscar = "SELECT cto_codigo as 'CODIGO', cto_hospital as 'HOSPITAL', cto_piso as 'PISO', cto_numero as 'NUMERO' FROM consultorio WHERE cto_codigo = '" + codigo + "'";
            SqlCommand cmd = new SqlCommand(sql_buscar, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvListadoC.DataSource = dt;
            dgvListadoC.Refresh();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;
            String hospital = arrayHospitales[cbxHospital.SelectedIndex];
            String piso = numPiso.Text;
            String numero = numNumero.Text;

            if (codigo.Length > 0 && hospital.Length > 0 && piso.Length > 0 && numero.Length > 0)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "paInsertarConsultorio";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter paramCodigo = new SqlParameter();
                paramCodigo.ParameterName = "@cto_codigo";
                paramCodigo.SqlDbType = SqlDbType.NChar;
                paramCodigo.Value = codigo;

                SqlParameter paramHospital = new SqlParameter();
                paramHospital.ParameterName = "@cto_hospital";
                paramHospital.SqlDbType = SqlDbType.NChar;
                paramHospital.Value = hospital;

                SqlParameter paramPiso = new SqlParameter();
                paramPiso.ParameterName = "@cto_piso";
                paramPiso.SqlDbType = SqlDbType.Int;
                paramPiso.Value = Convert.ToInt16(piso);

                SqlParameter paramNumero = new SqlParameter();
                paramNumero.ParameterName = "@cto_numero";
                paramNumero.SqlDbType = SqlDbType.Int;
                paramNumero.Value = Convert.ToInt16(numero);

                cmd.Parameters.Add(paramCodigo);
                cmd.Parameters.Add(paramHospital);
                cmd.Parameters.Add(paramPiso);
                cmd.Parameters.Add(paramNumero);

                int resultado = cmd.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Consultorio insertado");
                    ListarConsultorios(conn, hospital);
                }
                else
                {
                    MessageBox.Show("Algo salio mal. Vuelve a intentar :/");
                }

            }
            else
            {
                MessageBox.Show("No se permiten campos vacios!!!");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListadoC.SelectedRows.Count > 0)
            {
                String codigo = txtCodigo.Text;
                String hospital = arrayHospitales[cbxHospital.SelectedIndex];
                String piso = numPiso.Text;
                String numero = numNumero.Text;

                if (codigo.Length > 0 && piso.Length > 0 && numero.Length > 0)
                {
                    String sql_actualizar = "UPDATE consultorio SET cto_piso = " + piso + ", cto_numero = " + numero + " WHERE cto_codigo = '" + codigo + "'";
                    SqlCommand cmd = new SqlCommand(sql_actualizar, conn);
                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Consultorio actualizado");
                        ListarConsultorios(conn, hospital);
                    }
                    else
                    {
                        MessageBox.Show("Algo salio mal. Vuelve a intentar :/");
                    }
                }
                else
                {
                    MessageBox.Show("No se permite campos vacios");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListadoC.SelectedRows.Count > 0)
            {
                String codigo = dgvListadoC.SelectedRows[0].Cells[0].Value.ToString();
                String hospital = arrayHospitales[cbxHospital.SelectedIndex];

                String sql_eliminar = "DELETE consultorio WHERE cto_codigo = '" + codigo + "'";
                SqlCommand cmd = new SqlCommand(sql_eliminar, conn);
                int resultado = cmd.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Consultorio eliminado");
                    ListarConsultorios(conn, hospital);
                }
                else
                {
                    MessageBox.Show("Algo salio mal. Vuelve a intentar :/");
                }
            }
        }
    }
}
