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
    public partial class FormUsuarios : Form
    {
        SqlConnection conn;
        Boolean estado;
        public FormUsuarios(SqlConnection conn)
        {
            this.conn = conn;
            estado = false;
            InitializeComponent();
            ListarUsuarios(conn);
            btnCancelar.Visible = false;
        }

        private void ListarUsuarios(SqlConnection conn)
        {
            try
            {
                String sql_select = "SELECT * FROM usuario";
                SqlCommand cmd = new SqlCommand(sql_select, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListadoU.DataSource = dt;
                dgvListadoU.Refresh();
            }catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un problema con el servidor: " + ex);
            }           
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarUsuarios(conn);
        }

        private String generarID()
        {
            try
            {
                int filas = dgvListadoU.RowCount - 2;
                String cod = dgvListadoU.Rows[filas].Cells[0].Value.ToString();
                int nuevo_cod = Convert.ToInt16(cod) + 1;
                //Console.WriteLine(cod);
                return nuevo_cod.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error al generar el id: " + ex);
                return "";
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estado = !estado;
            if (estado)
            {
                txtCodigo.Text = generarID();
                txtLogin.Text = "";
                txtNomApe.Text = "";
                txtPasswd.Text = "";
                btnNuevo.Text = "Guardar";
                btnCancelar.Visible = true;
                //Console.WriteLine("Codigo: " + generarID());
            } else if (!estado)
            {
                btnNuevo.Text = "Nuevo";
                try
                {
                    String nombre = txtNomApe.Text;
                    String login = txtLogin.Text;
                    String passwd = txtPasswd.Text;

                    if (nombre.Length > 0 && login.Length > 0 && passwd.Length > 0)
                    {
                        String sql_insertar = "INSERT INTO usuario VALUES ('" + nombre + "','" + login + "','" + passwd + "')";
                        SqlCommand cmd = new SqlCommand(sql_insertar, conn);
                        int resultado = cmd.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Usuario insertado");
                            ListarUsuarios(conn);
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
                catch(Exception ex)
                {
                    MessageBox.Show("Ocurrio un problema al crear un usuario: " + ex);
                }
            }               
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                String nombre = txtNomApe.Text;
                String sql_buscar = "SELECT * FROM usuario WHERE usu_nomape LIKE '%" + nombre + "%'";
                SqlCommand cmd = new SqlCommand(sql_buscar, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListadoU.DataSource = dt;
                dgvListadoU.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un problema al buscar un usuario: " + ex);
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvListadoU.SelectedRows.Count > 0)
                {
                    String id = dgvListadoU.SelectedRows[0].Cells[0].Value.ToString();
                    String nombre = txtNomApe.Text;
                    String login = txtLogin.Text;
                    String passwd = txtPasswd.Text;

                    if (nombre.Length > 0 && login.Length > 0 && passwd.Length > 0)
                    {
                        String sql_actualizar = "UPDATE usuario SET usu_nomape = '" + nombre + "', usu_login = '" + login + "', usu_passwd = '" + passwd + "' WHERE usu_codigo = " + id + "";
                        SqlCommand cmd = new SqlCommand(sql_actualizar, conn);
                        int resultado = cmd.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Usuario actualizado");
                            ListarUsuarios(conn);
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
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un problema al modificar un usuario: " + ex);
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvListadoU.SelectedRows.Count > 0)
                {
                    String id = dgvListadoU.SelectedRows[0].Cells[0].Value.ToString();

                    String sql_eliminar = "DELETE usuario WHERE usu_codigo = " + id + "";
                    SqlCommand cmd = new SqlCommand(sql_eliminar, conn);
                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Usuario eliminado");
                        ListarUsuarios(conn);
                    }
                    else
                    {
                        MessageBox.Show("Algo salio mal. Vuelve a intentar :/");
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un problema al eliminar un usuario: " + ex);
            }
        }

        private void dgvListadoU_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvListadoU.SelectedRows.Count > 0)
                {
                    txtCodigo.Text = dgvListadoU.SelectedRows[0].Cells[0].Value.ToString();
                    txtNomApe.Text = dgvListadoU.SelectedRows[0].Cells[1].Value.ToString();
                    txtLogin.Text = dgvListadoU.SelectedRows[0].Cells[2].Value.ToString();
                    txtPasswd.Text = dgvListadoU.SelectedRows[0].Cells[3].Value.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un problema con la tabla: " + ex);
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
