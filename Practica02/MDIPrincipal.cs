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
    public partial class MDIPrincipal : Form
    {
        SqlConnection conn;

        public MDIPrincipal(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void manUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios frmU = new FormUsuarios(conn);
            frmU.MdiParent = this;
            frmU.Show();
        }

        private void sisSalir_Click(object sender, EventArgs e)
        {
            conn.Close();
            FormLogin frmLogin = new FormLogin();
            frmLogin.Show();
            this.Close();
        }

        private void manHospitales_Click(object sender, EventArgs e)
        {
            FormHospital frmH = new FormHospital(conn);
            frmH.MdiParent = this;
            frmH.Show();
        }

        private void manConsultorios_Click(object sender, EventArgs e)
        {
            FormConsultorio frmC = new FormConsultorio(conn);
            frmC.MdiParent = this;
            frmC.Show();
        }

        private void doctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMedico frmM = new FormMedico(conn);
            frmM.MdiParent = this;
            frmM.Show();
        }

        private void enfermerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEnfermera frmE = new FormEnfermera(conn);
            frmE.MdiParent = this;
            frmE.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPaciente frmP = new FormPaciente(conn);
            frmP.MdiParent = this;
            frmP.Show();
        }

        private void manProveedores_Click(object sender, EventArgs e)
        {
            FormProveedor frmPrv = new FormProveedor(conn);
            frmPrv.MdiParent = this;
            frmPrv.Show();
        }

        private void medicinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMedicina frmMdc = new FormMedicina(conn);
            frmMdc.MdiParent = this;
            frmMdc.Show();
        }

        private void procTriaje_Click(object sender, EventArgs e)
        {
            FormTriaje frmTrj = new FormTriaje(conn);
            frmTrj.MdiParent = this;
            frmTrj.Show();
        }

        private void procConsulta_Click(object sender, EventArgs e)
        {
            String tipo = "T";
            FormListado frmList = new FormListado(conn, tipo);
            frmList.MdiParent = this;
            frmList.Show();
        }
    }
}
