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
    public partial class FormMedicina : Form
    {
        SqlConnection conn;
        Boolean estado;
        String[] arrayProveedores;

        public FormMedicina(SqlConnection conn)
        {
            try
            {
                this.conn = conn;
                InitializeComponent();
                btnCancelar.Visible = false;
                arrayProveedores = new string[100];

                String sql_select_proveedores = "SELECT prv_codigo, prv_nombre FROM proveedor";
                int i = 0;
                SqlCommand cmd = new SqlCommand(sql_select_proveedores, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                cbxProveedor.Items.Clear();

                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString());
                    arrayProveedores[i] = reader[0].ToString();
                    cbxProveedor.Items.Add(reader[1].ToString());
                    i += 1;
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un problema: " + ex);
            }
        }

        private String generarID()
        {
            try
            {
                String sql_index = "SELECT mdc_codigo FROM medicina ORDER BY mdc_codigo";
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
                cod = cod.Replace('I', '0');
                int nuevo_cod = Convert.ToInt32(cod) + 1;
                String cod_final = "";
                if (nuevo_cod <= 9)
                {
                    cod_final = "I00" + nuevo_cod;
                }
                else if (nuevo_cod <= 99)
                {
                    cod_final = "I0" + nuevo_cod;
                }
                else
                {
                    cod_final = "I" + nuevo_cod;
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

        private void ListarMedicinas(SqlConnection conn, String codigo)
        {
            try
            {
                String sql_select = "SELECT mdc_codigo as 'CODIGO', mdc_proveedor as 'Proveedor', mdc_nomcom as 'NOMBRE COMERCIAL', mdc_nomgen as 'NOMBRE GENERICO', mdc_presentacion as 'PRESENTACION', mdc_cantidad as 'CANTIDAD', mdc_precio as 'PRECIO' FROM medicina WHERE mdc_proveedor = '" + codigo + "'";
                SqlCommand cmd = new SqlCommand(sql_select, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListadoMd.DataSource = dt;
                dgvListadoMd.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema: " + ex);
            }
            
        }

        private void cbxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = cbxProveedor.SelectedIndex;
                ListarMedicinas(conn, arrayProveedores[id]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema: " + ex);
            }
            
        }

        private void dgvListadoMd_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvListadoMd.SelectedRows.Count > 0)
                {
                    txtCodigo.Text = dgvListadoMd.SelectedRows[0].Cells[0].Value.ToString();
                    txtNombreC.Text = dgvListadoMd.SelectedRows[0].Cells[2].Value.ToString();
                    txtNombreG.Text = dgvListadoMd.SelectedRows[0].Cells[3].Value.ToString();
                    txtPresentacion.Text = dgvListadoMd.SelectedRows[0].Cells[4].Value.ToString();
                    txtCantidad.Text = dgvListadoMd.SelectedRows[0].Cells[5].Value.ToString();
                    txtPrecio.Text = dgvListadoMd.SelectedRows[0].Cells[6].Value.ToString();

                    String cod_proveedor = dgvListadoMd.SelectedRows[0].Cells[1].Value.ToString();

                    for (int i = 0; i <= arrayProveedores.Count() - 1; i++)
                    {
                        if (cod_proveedor == arrayProveedores[i])
                        {
                            cbxProveedor.SelectedIndex = i;
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
                int id = cbxProveedor.SelectedIndex;
                ListarMedicinas(conn, arrayProveedores[id]);
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
                String nombreG = txtNombreG.Text;
                String sql_buscar = "SELECT mdc_codigo as 'CODIGO', mdc_proveedor as 'Proveedor', mdc_nomcom as 'NOMBRE COMERCIAL', mdc_nomgen as 'NOMBRE GENERICO', mdc_presentacion as 'PRESENTACION', mdc_cantidad as 'CANTIDAD', mdc_precio as 'PRECIO' FROM medicina WHERE mdc_nomgen LIKE '%" + nombreG + "%'";
                SqlCommand cmd = new SqlCommand(sql_buscar, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListadoMd.DataSource = dt;
                dgvListadoMd.Refresh();
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
                    txtNombreC.Text = "";
                    txtNombreG.Text = "";
                    txtPresentacion.Text = "";
                    txtCantidad.Text = "";
                    txtPrecio.Text = "";
                    btnNuevo.Text = "Guardar";
                    btnCancelar.Visible = true;
                }
                else if (!estado)
                {
                    btnNuevo.Text = "Nuevo";
                    String codigo = txtCodigo.Text;
                    String nombreC = txtNombreC.Text;
                    String nombreG = txtNombreG.Text;
                    String presentacion = txtPresentacion.Text;
                    String cantidad = txtCantidad.Text;
                    String precio = txtPrecio.Text;

                    String proveedor = arrayProveedores[cbxProveedor.SelectedIndex];

                    if (codigo.Length > 0 && nombreC.Length > 0 && nombreG.Length > 0 && presentacion.Length > 0 && cantidad.Length > 0 && precio.Length > 0)
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "paInsertarMedicina";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;

                        SqlParameter paramCodigo = new SqlParameter();
                        paramCodigo.ParameterName = "@mdc_codigo";
                        paramCodigo.SqlDbType = SqlDbType.NChar;
                        paramCodigo.Value = codigo;

                        SqlParameter paramProveedor = new SqlParameter();
                        paramProveedor.ParameterName = "@mdc_proveedor";
                        paramProveedor.SqlDbType = SqlDbType.NChar;
                        paramProveedor.Value = proveedor;

                        SqlParameter paramNombreC = new SqlParameter();
                        paramNombreC.ParameterName = "@mdc_nomcom";
                        paramNombreC.SqlDbType = SqlDbType.NVarChar;
                        paramNombreC.Value = nombreC;

                        SqlParameter paramNombreG = new SqlParameter();
                        paramNombreG.ParameterName = "@mdc_nomgen";
                        paramNombreG.SqlDbType = SqlDbType.NVarChar;
                        paramNombreG.Value = nombreG;

                        SqlParameter paramPresentacion = new SqlParameter();
                        paramPresentacion.ParameterName = "@mdc_presentacion";
                        paramPresentacion.SqlDbType = SqlDbType.NVarChar;
                        paramPresentacion.Value = presentacion;

                        SqlParameter paramCantidad = new SqlParameter();
                        paramCantidad.ParameterName = "@mdc_cantidad";
                        paramCantidad.SqlDbType = SqlDbType.Int;
                        paramCantidad.Value = Convert.ToInt16(cantidad);

                        SqlParameter paramPrecio = new SqlParameter();
                        paramPrecio.ParameterName = "@mdc_precio";
                        paramPrecio.SqlDbType = SqlDbType.Money;
                        paramPrecio.Value = precio;

                        cmd.Parameters.Add(paramCodigo);
                        cmd.Parameters.Add(paramProveedor);
                        cmd.Parameters.Add(paramNombreC);
                        cmd.Parameters.Add(paramNombreG);
                        cmd.Parameters.Add(paramPresentacion);
                        cmd.Parameters.Add(paramCantidad);
                        cmd.Parameters.Add(paramPrecio);

                        int resultado = cmd.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Medicina insertado");
                            ListarMedicinas(conn, proveedor);
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
                if (dgvListadoMd.SelectedRows.Count > 0)
                {
                    String codigo = txtCodigo.Text;
                    String nombreC = txtNombreC.Text;
                    String nombreG = txtNombreG.Text;
                    String presentacion = txtPresentacion.Text;
                    String cantidad = txtCantidad.Text;
                    String precio = txtPrecio.Text;

                    String proveedor = arrayProveedores[cbxProveedor.SelectedIndex];

                    if (codigo.Length > 0 && nombreC.Length > 0 && nombreG.Length > 0 && presentacion.Length > 0 && cantidad.Length > 0 && precio.Length > 0)
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "paActualizarMedicina";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;

                        SqlParameter paramCodigo = new SqlParameter();
                        paramCodigo.ParameterName = "@mdc_codigo";
                        paramCodigo.SqlDbType = SqlDbType.NChar;
                        paramCodigo.Value = codigo;

                        SqlParameter paramProveedor = new SqlParameter();
                        paramProveedor.ParameterName = "@mdc_proveedor";
                        paramProveedor.SqlDbType = SqlDbType.NChar;
                        paramProveedor.Value = proveedor;

                        SqlParameter paramNombreC = new SqlParameter();
                        paramNombreC.ParameterName = "@mdc_nomcom";
                        paramNombreC.SqlDbType = SqlDbType.NVarChar;
                        paramNombreC.Value = nombreC;

                        SqlParameter paramNombreG = new SqlParameter();
                        paramNombreG.ParameterName = "@mdc_nomgen";
                        paramNombreG.SqlDbType = SqlDbType.NVarChar;
                        paramNombreG.Value = nombreG;

                        SqlParameter paramPresentacion = new SqlParameter();
                        paramPresentacion.ParameterName = "@mdc_presentacion";
                        paramPresentacion.SqlDbType = SqlDbType.NVarChar;
                        paramPresentacion.Value = presentacion;

                        SqlParameter paramCantidad = new SqlParameter();
                        paramCantidad.ParameterName = "@mdc_cantidad";
                        paramCantidad.SqlDbType = SqlDbType.Int;
                        paramCantidad.Value = Convert.ToInt16(cantidad);

                        SqlParameter paramPrecio = new SqlParameter();
                        paramPrecio.ParameterName = "@mdc_precio";
                        paramPrecio.SqlDbType = SqlDbType.Money;
                        paramPrecio.Value = precio;

                        cmd.Parameters.Add(paramCodigo);
                        cmd.Parameters.Add(paramProveedor);
                        cmd.Parameters.Add(paramNombreC);
                        cmd.Parameters.Add(paramNombreG);
                        cmd.Parameters.Add(paramPresentacion);
                        cmd.Parameters.Add(paramCantidad);
                        cmd.Parameters.Add(paramPrecio);

                        int resultado = cmd.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Medicina modificada");
                            ListarMedicinas(conn, proveedor);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvListadoMd.SelectedRows.Count > 0)
                {
                    String codigo = dgvListadoMd.SelectedRows[0].Cells[0].Value.ToString();
                    String proveedor = arrayProveedores[cbxProveedor.SelectedIndex];

                    String sql_eliminar = "DELETE medicina WHERE mdc_codigo = '" + codigo + "'";
                    SqlCommand cmd = new SqlCommand(sql_eliminar, conn);
                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Medicina eliminada");
                        ListarMedicinas(conn, proveedor);
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
            btnNuevo.Text = "Nuevo";
            btnCancelar.Visible = false;
        }
    }
}
