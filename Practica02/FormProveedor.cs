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
    public partial class FormProveedor : Form
    {
        SqlConnection conn;

        public FormProveedor(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            listarProveedores(conn);
        }

        private void listarProveedores(SqlConnection conn)
        {
            String sql_select = "SELECT prv_codigo as 'CODIGO', prv_nombre as 'NOMBRE', prv_ubicacion as 'UBICACION' FROM proveedor";
            SqlCommand cmd = new SqlCommand(sql_select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvListadoProv.DataSource = dt;
            dgvListadoProv.Refresh();

        }

        private void dgvListadoProv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListadoProv.SelectedRows.Count > 0)
            {
                txtCodigo.Text = dgvListadoProv.SelectedRows[0].Cells[0].Value.ToString();
                txtNombre.Text = dgvListadoProv.SelectedRows[0].Cells[1].Value.ToString();
                txtUbicacion.Text = dgvListadoProv.SelectedRows[0].Cells[2].Value.ToString();

                //String cod_hospital = dgvListadoP.SelectedRows[0].Cells[1].Value.ToString();

            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listarProveedores(conn);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String sql_buscar = "SELECT prv_codigo as 'CODIGO', prv_nombre as 'NOMBRE', prv_ubicacion as 'UBICACION' FROM proveedor WHERE prv_nombre LIKE '%" + nombre + "%'";
            SqlCommand cmd = new SqlCommand(sql_buscar, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvListadoProv.DataSource = dt;
            dgvListadoProv.Refresh();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;
            String nombre = txtNombre.Text;
            String ubicacion = txtUbicacion.Text;

            if (codigo.Length > 0 && nombre.Length > 0 && ubicacion.Length > 0)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "paInsertarProveedor";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter paramCodigo = new SqlParameter();
                paramCodigo.ParameterName = "@prv_codigo";
                paramCodigo.SqlDbType = SqlDbType.NChar;
                paramCodigo.Value = codigo;

                SqlParameter paramNombre = new SqlParameter();
                paramNombre.ParameterName = "@prv_nombre";
                paramNombre.SqlDbType = SqlDbType.NVarChar;
                paramNombre.Value = nombre;

                SqlParameter paramUbicacion = new SqlParameter();
                paramUbicacion.ParameterName = "@prv_ubicacion";
                paramUbicacion.SqlDbType = SqlDbType.NVarChar;
                paramUbicacion.Value = ubicacion;

                cmd.Parameters.Add(paramCodigo);
                cmd.Parameters.Add(paramNombre);
                cmd.Parameters.Add(paramUbicacion);

                int resultado = cmd.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Proveedor insertado");
                    listarProveedores(conn);
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
            String codigo = txtCodigo.Text;
            String nombre = txtNombre.Text;
            String ubicacion = txtUbicacion.Text;

            if (codigo.Length > 0 && nombre.Length > 0 && ubicacion.Length > 0)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "paActualizarProveedor";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter paramCodigo = new SqlParameter();
                paramCodigo.ParameterName = "@prv_codigo";
                paramCodigo.SqlDbType = SqlDbType.NChar;
                paramCodigo.Value = codigo;

                SqlParameter paramNombre = new SqlParameter();
                paramNombre.ParameterName = "@prv_nombre";
                paramNombre.SqlDbType = SqlDbType.NVarChar;
                paramNombre.Value = nombre;

                SqlParameter paramUbicacion = new SqlParameter();
                paramUbicacion.ParameterName = "@prv_ubicacion";
                paramUbicacion.SqlDbType = SqlDbType.NVarChar;
                paramUbicacion.Value = ubicacion;

                cmd.Parameters.Add(paramCodigo);
                cmd.Parameters.Add(paramNombre);
                cmd.Parameters.Add(paramUbicacion);

                int resultado = cmd.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Proveedor actualizado");
                    listarProveedores(conn);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListadoProv.SelectedRows.Count > 0)
            {
                String codigo = dgvListadoProv.SelectedRows[0].Cells[0].Value.ToString();
                //String hospital = arrayHospitales[cbxHospital.SelectedIndex];

                String sql_eliminar = "DELETE proveedor WHERE prv_codigo = '" + codigo + "'";
                SqlCommand cmd = new SqlCommand(sql_eliminar, conn);
                int resultado = cmd.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Proveedor eliminado");
                    listarProveedores(conn);
                }
                else
                {
                    MessageBox.Show("Algo salio mal. Vuelve a intentar :/");
                }
            }
        }
    }
}
