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
    public partial class FormListado : Form
    {
        String codigo;
        String tipo;
        SqlConnection conn;
        
        public FormListado(SqlConnection conn, String tipo)
        {
            try
            {
                this.conn = conn;
                InitializeComponent();
                this.tipo = tipo;
                Listar(conn, tipo);

            } catch(Exception ex)
            {
                MessageBox.Show("Algo salio mal. Cierra esta ventana y vuelve a intentarlo: " + ex);
            }
            
        }

        private void Listar(SqlConnection conn, String tipo)
        {
            try
            {
                String sql = "";
                if (tipo == "P")
                {
                    sql = "select pac_codigo as 'CODIGO', pac_nomape as 'NOMBRE' from paciente where pac_codigo not in (select trj_paciente from triaje)";
                    lblNombre.Text = "Paciente";
                }
                else if (tipo == "E")
                {
                    sql = "SELECT enf_codigo as 'CODIGO', enf_nomape as 'NOMBRE' FROM enfermera";
                    lblNombre.Text = "Enfermera";
                }
                else if (tipo == "T")
                {
                    sql = "select trj_codigo as 'TRIAJE', pac_nomape as 'PACIENTE', trj_paciente as 'HISTORIA CLINICA', trj_fechora as 'FECHA/HORA EN TRIAJE' from triaje inner join paciente on trj_paciente = pac_codigo where trj_estado = 'E' order by trj_fechora";
                    lblNombre.Text = "Pacientes en Triaje";
                }
                else if (tipo == "M")
                {
                    sql = "SELECT med_codigo as 'CODIGO', med_nomape as 'NOMBRE' FROM medico";
                    lblNombre.Text = "Medicos";
                }
                else if (tipo == "C")
                {
                    sql = "select cto_codigo as 'CODIGO', hos_nombre as 'HOSPITAL' from consultorio INNER JOIN hospital ON cto_hospital = hos_codigo";
                    lblNombre.Text = "Hospital donde se encuentra";
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListado.DataSource = dt;
                dgvListado.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salio mal. Cierra esta ventana y vuelve a intentarlo: " + ex);
            }
            
        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvListado.SelectedRows.Count > 0)
                {
                    codigo = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                    txtNombre.Text = dgvListado.SelectedRows[0].Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salio mal. Cierra esta ventana y vuelve a intentarlo: " + ex);
            }
            
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Length > 0 && codigo.Length > 0)
                {
                    if (tipo == "P")
                    {
                        Datos.nom_p = txtNombre.Text;
                        Datos.cod_p = this.codigo;
                        this.Close();
                    }
                    else if (tipo == "E")
                    {
                        Datos.nom_e = txtNombre.Text;
                        Datos.cod_e = this.codigo;
                        this.Close();
                    }
                    else if (tipo == "T")
                    {
                        Datos.cod_t = this.codigo;
                        FormConsulta frmCon = new FormConsulta(conn);
                        frmCon.Show();
                        this.Close();
                    }
                    else if (tipo == "M")
                    {
                        Datos.nom_m = txtNombre.Text;
                        Datos.cod_m = this.codigo;
                        this.Close();
                    }
                    else if (tipo == "C")
                    {
                        Datos.nom_c = txtNombre.Text;
                        Datos.cod_c = this.codigo;
                        this.Close();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Seleccione un registro antes de continuar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salio mal. Cierra esta ventana y vuelve a intentarlo: " + ex);
            }
                    
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
