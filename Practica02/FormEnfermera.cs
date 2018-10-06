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
    public partial class FormEnfermera : Form
    {
        SqlConnection conn;
        Boolean estado;
        String[] arrayHospitales;

        public FormEnfermera(SqlConnection conn)
        {
            try
            {
                this.conn = conn;
                InitializeComponent();
                btnCancelar.Visible = false;
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
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema: " + ex);
            }
        }

        private String generarID()
        {
            try
            {
                String sql_index = "SELECT enf_codigo FROM enfermera ORDER BY enf_codigo";
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
                String cod = array_cod[i - 1];
                cod = cod.Replace('E', '0');
                int nuevo_cod = Convert.ToInt32(cod) + 1;
                String cod_final = "";
                if (nuevo_cod <= 9)
                {
                    cod_final = "E00" + nuevo_cod;
                }
                else if (nuevo_cod <= 99)
                {
                    cod_final = "E0" + nuevo_cod;
                }
                else
                {
                    cod_final = "E" + nuevo_cod;
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

        private void ListarEnfermeras(SqlConnection conn, String codigo)
        {
            try
            {
                String sql_select = "SELECT enf_codigo as 'CODIGO', enf_hospital as 'HOSPITAL', enf_dni as 'DNI', enf_nomape as 'NOMBRE', enf_fecnac as 'FECHA NACIMIENTO', enf_sueldo as 'SUELDO', enf_fecini as 'FECHA INICIO', enf_direc as 'DIRECCION' FROM enfermera WHERE enf_hospital = '" + codigo + "'";
                SqlCommand cmd = new SqlCommand(sql_select, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListadoE.DataSource = dt;
                dgvListadoE.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema: " + ex);
            }
            
        }

        private void cbxHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = cbxHospital.SelectedIndex;
                ListarEnfermeras(conn, arrayHospitales[id]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema: " + ex);
            }
            
        }

        private void dgvListadoE_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvListadoE.SelectedRows.Count > 0)
                {
                    txtCodigo.Text = dgvListadoE.SelectedRows[0].Cells[0].Value.ToString();
                    txtDNI.Text = dgvListadoE.SelectedRows[0].Cells[2].Value.ToString();
                    txtNombre.Text = dgvListadoE.SelectedRows[0].Cells[3].Value.ToString();
                    dtpFechaNac.Text = dgvListadoE.SelectedRows[0].Cells[4].Value.ToString();
                    txtSueldo.Text = dgvListadoE.SelectedRows[0].Cells[5].Value.ToString();
                    //txtEspecialidad.Text = dgvListadoE.SelectedRows[0].Cells[6].Value.ToString();
                    dtpFechaInicio.Text = dgvListadoE.SelectedRows[0].Cells[6].Value.ToString();
                    txtDireccion.Text = dgvListadoE.SelectedRows[0].Cells[7].Value.ToString();

                    String cod_hospital = dgvListadoE.SelectedRows[0].Cells[1].Value.ToString();

                    for (int i = 0; i <= arrayHospitales.Count() - 1; i++)
                    {
                        if (cod_hospital == arrayHospitales[i])
                        {
                            cbxHospital.SelectedIndex = i;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema: " + ex);
            }
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = cbxHospital.SelectedIndex;
                ListarEnfermeras(conn, arrayHospitales[id]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema: " + ex);
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                String nombre = txtNombre.Text;
                String sql_buscar = "SELECT enf_codigo as 'CODIGO', enf_hospital as 'HOSPITAL', enf_dni as 'DNI', enf_nomape as 'NOMBRE', enf_fecnac as 'FECHA NACIMIENTO', enf_sueldo as 'SUELDO', enf_fecini as 'FECHA INICIO', enf_direc as 'DIRECCION' FROM enfermera WHERE enf_nomape LIKE '%" + nombre + "%'";
                SqlCommand cmd = new SqlCommand(sql_buscar, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListadoE.DataSource = dt;
                dgvListadoE.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema: " + ex);
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                estado = !estado;
                if (estado)
                {
                    txtCodigo.Text = generarID();
                    txtDireccion.Text = "";
                    txtDNI.Text = "";
                    txtNombre.Text = "";
                    txtSueldo.Text = "";
                    dtpFechaInicio.Text = "";
                    dtpFechaNac.Text = "";
                    btnNuevo.Text = "Guardar";
                    btnCancelar.Visible = true;
                }
                else if (!estado)
                {
                    btnNuevo.Text = "Nuevo";
                    String codigo = txtCodigo.Text;
                    String nombre = txtNombre.Text;
                    String DNI = txtDNI.Text;
                    String direccion = txtDireccion.Text;
                    //String especialidad = txtEspecialidad.Text;
                    String sueldo = txtSueldo.Text;
                    String fec_nac = dtpFechaNac.Text;
                    String fec_ini = dtpFechaInicio.Text;
                    String hospital = arrayHospitales[cbxHospital.SelectedIndex];

                    if (codigo.Length > 0 && nombre.Length > 0 && DNI.Length > 0 && direccion.Length > 0 && sueldo.Length > 0 && fec_nac.Length > 0 && fec_ini.Length > 0 && hospital.Length > 0)
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "paInsertarEnfermera";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;

                        SqlParameter paramCodigo = new SqlParameter();
                        paramCodigo.ParameterName = "@enf_codigo";
                        paramCodigo.SqlDbType = SqlDbType.NChar;
                        paramCodigo.Value = codigo;

                        SqlParameter paramHospital = new SqlParameter();
                        paramHospital.ParameterName = "@enf_hospital";
                        paramHospital.SqlDbType = SqlDbType.NChar;
                        paramHospital.Value = hospital;

                        SqlParameter paramNombre = new SqlParameter();
                        paramNombre.ParameterName = "@enf_nomape";
                        paramNombre.SqlDbType = SqlDbType.NVarChar;
                        paramNombre.Value = nombre;

                        SqlParameter paramDNI = new SqlParameter();
                        paramDNI.ParameterName = "@enf_dni";
                        paramDNI.SqlDbType = SqlDbType.NVarChar;
                        paramDNI.Value = DNI;

                        SqlParameter paramDireccion = new SqlParameter();
                        paramDireccion.ParameterName = "@enf_direc";
                        paramDireccion.SqlDbType = SqlDbType.NVarChar;
                        paramDireccion.Value = direccion;

                        SqlParameter paramSueldo = new SqlParameter();
                        paramSueldo.ParameterName = "@enf_sueldo";
                        paramSueldo.SqlDbType = SqlDbType.Money;
                        paramSueldo.Value = sueldo;

                        SqlParameter paramFecNac = new SqlParameter();
                        paramFecNac.ParameterName = "@enf_fecnac";
                        paramFecNac.SqlDbType = SqlDbType.Date;
                        paramFecNac.Value = fec_nac;

                        SqlParameter paramFecIni = new SqlParameter();
                        paramFecIni.ParameterName = "@enf_fecini";
                        paramFecIni.SqlDbType = SqlDbType.Date;
                        paramFecIni.Value = fec_ini;

                        cmd.Parameters.Add(paramCodigo);
                        cmd.Parameters.Add(paramNombre);
                        cmd.Parameters.Add(paramDNI);
                        cmd.Parameters.Add(paramDireccion);
                        //cmd.Parameters.Add(paramEspecialidad);
                        cmd.Parameters.Add(paramSueldo);
                        cmd.Parameters.Add(paramFecNac);
                        cmd.Parameters.Add(paramFecIni);
                        cmd.Parameters.Add(paramHospital);

                        int resultado = cmd.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Enfermera insertada");
                            ListarEnfermeras(conn, hospital);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema: " + ex);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo = txtCodigo.Text;
                String nombre = txtNombre.Text;
                String DNI = txtDNI.Text;
                String direccion = txtDireccion.Text;
                //String especialidad = txtEspecialidad.Text;
                String sueldo = txtSueldo.Text;
                String fec_nac = dtpFechaNac.Text;
                String fec_ini = dtpFechaInicio.Text;
                String hospital = arrayHospitales[cbxHospital.SelectedIndex];

                if (codigo.Length > 0 && nombre.Length > 0 && DNI.Length > 0 && direccion.Length > 0 && sueldo.Length > 0 && fec_nac.Length > 0 && fec_ini.Length > 0 && hospital.Length > 0)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "paActualizarEnfermera";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlParameter paramCodigo = new SqlParameter();
                    paramCodigo.ParameterName = "@enf_codigo";
                    paramCodigo.SqlDbType = SqlDbType.NChar;
                    paramCodigo.Value = codigo;

                    SqlParameter paramHospital = new SqlParameter();
                    paramHospital.ParameterName = "@enf_hospital";
                    paramHospital.SqlDbType = SqlDbType.NChar;
                    paramHospital.Value = hospital;

                    SqlParameter paramNombre = new SqlParameter();
                    paramNombre.ParameterName = "@enf_nomape";
                    paramNombre.SqlDbType = SqlDbType.NVarChar;
                    paramNombre.Value = nombre;

                    SqlParameter paramDNI = new SqlParameter();
                    paramDNI.ParameterName = "@enf_dni";
                    paramDNI.SqlDbType = SqlDbType.NVarChar;
                    paramDNI.Value = DNI;

                    SqlParameter paramDireccion = new SqlParameter();
                    paramDireccion.ParameterName = "@enf_direc";
                    paramDireccion.SqlDbType = SqlDbType.NVarChar;
                    paramDireccion.Value = direccion;

                    SqlParameter paramSueldo = new SqlParameter();
                    paramSueldo.ParameterName = "@enf_sueldo";
                    paramSueldo.SqlDbType = SqlDbType.Money;
                    paramSueldo.Value = sueldo;

                    SqlParameter paramFecNac = new SqlParameter();
                    paramFecNac.ParameterName = "@enf_fecnac";
                    paramFecNac.SqlDbType = SqlDbType.Date;
                    paramFecNac.Value = fec_nac;

                    SqlParameter paramFecIni = new SqlParameter();
                    paramFecIni.ParameterName = "@enf_fecini";
                    paramFecIni.SqlDbType = SqlDbType.Date;
                    paramFecIni.Value = fec_ini;

                    cmd.Parameters.Add(paramCodigo);
                    cmd.Parameters.Add(paramNombre);
                    cmd.Parameters.Add(paramDNI);
                    cmd.Parameters.Add(paramDireccion);
                    //cmd.Parameters.Add(paramEspecialidad);
                    cmd.Parameters.Add(paramSueldo);
                    cmd.Parameters.Add(paramFecNac);
                    cmd.Parameters.Add(paramFecIni);
                    cmd.Parameters.Add(paramHospital);

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Enfermera actualizada");
                        ListarEnfermeras(conn, hospital);
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
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema: " + ex);
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvListadoE.SelectedRows.Count > 0)
                {
                    String codigo = dgvListadoE.SelectedRows[0].Cells[0].Value.ToString();
                    String hospital = arrayHospitales[cbxHospital.SelectedIndex];

                    String sql_eliminar = "DELETE enfermera WHERE enf_codigo = '" + codigo + "'";
                    SqlCommand cmd = new SqlCommand(sql_eliminar, conn);
                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Enfermera eliminada");
                        ListarEnfermeras(conn, hospital);
                    }
                    else
                    {
                        MessageBox.Show("Algo salio mal. Vuelve a intentar :/");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema: " + ex);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estado = false;
            btnCancelar.Visible = false;
            btnNuevo.Text = "Nuevo";
        }
    }
}
