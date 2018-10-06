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
    public partial class FormHospital : Form
    {
        SqlConnection conn;
        Boolean estado;

        public FormHospital(SqlConnection conn)
        {
            this.conn = conn;
            estado = false;
            InitializeComponent();
            btnCancelar.Visible = false;
            ListarHospitales(conn);
        }

        private void ListarHospitales(SqlConnection conn)
        {
            try
            {
                String sql_select = "SELECT * FROM hospital";
                SqlCommand cmd = new SqlCommand(sql_select, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListadoH.DataSource = dt;
                dgvListadoH.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un problema al listar los hospitales: " + ex);
            }
            
        }

        private String generarID()
        {
            try
            {
                int filas = dgvListadoH.RowCount - 2;
                String cod = dgvListadoH.Rows[filas].Cells[0].Value.ToString();
                cod = cod.Replace('H', '0');
                int nuevo_cod = Convert.ToInt32(cod) + 1;
                String cod_final = "";
                if (nuevo_cod <= 9)
                {
                    cod_final = "H00" + nuevo_cod;
                }
                else if (nuevo_cod <= 99)
                {
                    cod_final = "H0" + nuevo_cod;
                }
                else
                {
                    cod_final = "H" + nuevo_cod;
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

        private void dgvListadoH_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvListadoH.SelectedRows.Count > 0)
                {
                    txtCodigo.Text = dgvListadoH.SelectedRows[0].Cells[0].Value.ToString();
                    txtNombre.Text = dgvListadoH.SelectedRows[0].Cells[1].Value.ToString();
                    txtDireccion.Text = dgvListadoH.SelectedRows[0].Cells[2].Value.ToString();
                    txtTelefono.Text = dgvListadoH.SelectedRows[0].Cells[3].Value.ToString();
                    numAmbulancias.Text = dgvListadoH.SelectedRows[0].Cells[4].Value.ToString();
                    txtAdministrador.Text = dgvListadoH.SelectedRows[0].Cells[5].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error con la tabla: " + ex);
            }
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarHospitales(conn);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                String nombre = txtNombre.Text;

                String sql_buscar = "SELECT * FROM hospital WHERE hos_nombre LIKE '%" + nombre + "%'";
                SqlCommand cmd = new SqlCommand(sql_buscar, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListadoH.DataSource = dt;
                dgvListadoH.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un problema al buscar un hospital: " + ex);
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estado = !estado;
            try
            {
                if (estado)
                {
                    txtCodigo.Text = generarID();
                    txtDireccion.Text = "";
                    txtNombre.Text = "";
                    txtTelefono.Text = "";
                    txtAdministrador.Text = "";
                    btnNuevo.Text = "Guardar";
                    btnCancelar.Visible = true;
                }
                else if (!estado)
                {
                    btnNuevo.Text = "Nuevo";

                    String codigo = txtCodigo.Text;
                    String nombre = txtNombre.Text;
                    String direccion = txtDireccion.Text;
                    String telefono = txtTelefono.Text;
                    String ambulancias = numAmbulancias.Text;
                    String admin = txtAdministrador.Text;

                    if (codigo.Length > 0 && nombre.Length > 0 && direccion.Length > 0 && telefono.Length > 0 && admin.Length > 0)
                    {

                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "paInsertarHospital";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;

                        SqlParameter paramCodigo = new SqlParameter();
                        paramCodigo.ParameterName = "@hos_codigo";
                        paramCodigo.SqlDbType = SqlDbType.NChar;
                        paramCodigo.Value = codigo;

                        SqlParameter paramNombre = new SqlParameter();
                        paramNombre.ParameterName = "@hos_nombre";
                        paramNombre.SqlDbType = SqlDbType.NVarChar;
                        paramNombre.Value = nombre;

                        SqlParameter paramDireccion = new SqlParameter();
                        paramDireccion.ParameterName = "@hos_direc";
                        paramDireccion.SqlDbType = SqlDbType.NVarChar;
                        paramDireccion.Value = direccion;

                        SqlParameter paramTelefono = new SqlParameter();
                        paramTelefono.ParameterName = "@hos_fono";
                        paramTelefono.SqlDbType = SqlDbType.NVarChar;
                        paramTelefono.Value = telefono;

                        SqlParameter paramAmbulancia = new SqlParameter();
                        paramAmbulancia.ParameterName = "@hos_ambul";
                        paramAmbulancia.SqlDbType = SqlDbType.Int;
                        paramAmbulancia.Value = Convert.ToInt16(ambulancias);

                        SqlParameter paramAdmin = new SqlParameter();
                        paramAdmin.ParameterName = "@hos_admin";
                        paramAdmin.SqlDbType = SqlDbType.NVarChar;
                        paramAdmin.Value = admin;

                        cmd.Parameters.Add(paramCodigo);
                        cmd.Parameters.Add(paramNombre);
                        cmd.Parameters.Add(paramDireccion);
                        cmd.Parameters.Add(paramTelefono);
                        cmd.Parameters.Add(paramAmbulancia);
                        cmd.Parameters.Add(paramAdmin);


                        int resultado = cmd.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Hospital insertado");
                            ListarHospitales(conn);
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
                MessageBox.Show("Ocurrio un problema al crear un hospital: " + ex);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvListadoH.SelectedRows.Count > 0)
                {
                    String codigo = txtCodigo.Text;
                    String nombre = txtNombre.Text;
                    String direccion = txtDireccion.Text;
                    String telefono = txtTelefono.Text;
                    String ambulancias = numAmbulancias.Text;
                    String admin = txtAdministrador.Text;

                    if (codigo.Length > 0 && nombre.Length > 0 && direccion.Length > 0 && telefono.Length > 0 && admin.Length > 0)
                    {
                        String sql_actualizar = "UPDATE hospital SET hos_nombre = '" + nombre + "', hos_direc = '" + direccion + "', hos_fono = '" + telefono + "', hos_ambul = " + ambulancias + ", hos_admin = '" + admin + "' WHERE hos_codigo = '" + codigo + "'";
                        SqlCommand cmd = new SqlCommand(sql_actualizar, conn);
                        int resultado = cmd.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Hospital actualizado");
                            ListarHospitales(conn);
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
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema al editar un hospital: " + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvListadoH.SelectedRows.Count > 0)
                {
                    String codigo = dgvListadoH.SelectedRows[0].Cells[0].Value.ToString();

                    String sql_eliminar = "DELETE hospital WHERE hos_codigo = '" + codigo + "'";
                    SqlCommand cmd = new SqlCommand(sql_eliminar, conn);
                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Hospital eliminado");
                        ListarHospitales(conn);
                    }
                    else
                    {
                        MessageBox.Show("Algo salio mal. Vuelve a intentar :/");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema al eliminar un hospital: " + ex);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estado = false;
            btnNuevo.Text = "Nuevo";
            btnCancelar.Visible = false;
        }
    }
}
