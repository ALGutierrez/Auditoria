using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;

namespace sistema_auditoria
{
    public partial class Informe : Form
    {
        string cadena_conexion = Properties.Settings.Default.conexion;
        LLenaCombos c = new LLenaCombos();
        LlenaDataGrid dg = new LlenaDataGrid();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public Informe()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {}
        private void tabPage3_Click(object sender, EventArgs e)
        {}

        private void btnGeneraCódigoInforme_Click(object sender, EventArgs e)
        {
            txtCodigoInforme.Text = "REG-INF-FINAL-FECHA(" + txtFechaEmisionInforme.Text + ")-V" + txtVersionInforme.Text;
        }

        private void Informe_Load(object sender, EventArgs e)
        {
            txtFechaEmisionInforme.Text = DateTime.Now.ToString("d");
            c.LlenaCombosPlanInforme(cmbBuscarPlanInforme);
            if (cmbTipoHallazgo.Text=="")
            {
                cmbTipoHallazgo.Items.Add("Fortalezas");
                cmbTipoHallazgo.Items.Add("Oportunidades de Mejora");
                cmbTipoHallazgo.Items.Add("Observaciones");
                cmbTipoHallazgo.Items.Add("Conformidades");
                cmbTipoHallazgo.Items.Add("No Conformidades");
                
            }
            this.reportViewer1.RefreshReport();
        }

        private void cmbBuscarPlanInforme_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDPlan.Text = Convert.ToString(cmbBuscarPlanInforme.SelectedValue);
        }

        private void OKPlanInforme_CheckedChanged(object sender, EventArgs e)
        {
            string cadena = "SELECT idauditoria,criterio FROM Planes WHERE idplanes='" + txtIDPlan.Text + "'";


            SqlConnection con = new SqlConnection(cadena_conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtIDAuditoria.Text = Convert.ToString(rd["idauditoria"]);
                txtCriterioAuditoriaHalalzgo.Text = Convert.ToString(rd["criterio"]);
               
            }
            rd.Close();
            con.Close();

        }

        private void btnMostrarInformación_Click(object sender, EventArgs e)
        {
            string cadena = "SELECT tipo,fecha_efectiva FROM Auditoria WHERE idauditoria='" + txtIDAuditoria.Text + "'";
           
            SqlConnection con = new SqlConnection(cadena_conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtTipoAuditoriaHallazgo.Text = Convert.ToString(rd["tipo"]);
                txtFechaAuditoriaInforme.Text = Convert.ToString(rd["fecha_efectiva"]);

            }
            rd.Close();


            try
            {
                da = new SqlDataAdapter("SELECT p.descripcion FROM Proceso_Auditoria pa, Proceso p WHERE pa.proceso = p.idproceso AND pa.auditoria ='" + txtIDAuditoria.Text + "'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgvAlcanceAuditoriaHallazgo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay registros para mostrar" + ex.ToString());
            }

            try
            {
                da = new SqlDataAdapter("SELECT a.apellido +' '+a.nombre As Nombre FROM Proceso_Auditoria pa, Auditor a WHERE pa.auditor = a.idauditor AND pa.auditoria ='" + txtIDAuditoria.Text + "'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgvEquipoAuditorHallazgo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay registros para mostrar" + ex.ToString());
            }








            con.Close();
        }

        private void btnSiguienteInforme_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            c.LlenaCombosProcesoInforme(cmbProcesoInformeHallazgo, Convert.ToInt32(txtIDAuditoria.Text));
            c.LlenaCombosCapituloNorma(cmbCapituloHallazgo);
        }

        private void btnGuardarInforme_Click(object sender, EventArgs e)
        {
            string cadena = "INSERT INTO Informe(fecha_emision,idplanes,codigo,fecha_proxima_auditoria,version)"
                   + "VALUES ('" + txtFechaEmisionInforme.Text + "','" + txtIDPlan.Text + "','"
                   + txtCodigoInforme.Text + "','"
                   + txtFechaProximaAuditoriaInforme.Text + "','"
                   + txtVersionInforme.Text + "')";

            SqlConnection con = new SqlConnection(cadena_conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand(cadena, con);

            cmd.CommandType = CommandType.Text;


            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro almacenado correctamente !");

                string cadena2 = "SELECT MAX(idinforme) AS ultimo FROM Informe";


                SqlCommand cmd2 = new SqlCommand(cadena2, con);
                cmd2.CommandType = CommandType.Text;
                SqlDataReader rd2 = cmd2.ExecuteReader();
                if (rd2.Read())
                {
                    txtIDInformeActual.Text = Convert.ToString(rd2["ultimo"]);

                }
                rd2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                // Cierro la Conexión.
                con.Close();
            }
        }

        private void cmbCapituloHallazgo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDCapitulo.Text = Convert.ToString(cmbCapituloHallazgo.SelectedValue);
        }

        private void OKCapitulo_CheckedChanged(object sender, EventArgs e)
        {
            if(OKCapitulo.Checked==true)
            {
                c.LlenaCombosApartadoNorma(cmbApartadoHallazgo, Convert.ToInt32(txtIDCapitulo.Text));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = "INSERT INTO Hallazgo(tipo,descripcion,idcapitulo,idapartado,idinforme,proceso)"
                   + "VALUES ('" + cmbTipoHallazgo.Text + "','" + txtDescripcionHallazgo.Text + "','"
                   + txtIDCapitulo.Text + "','"
                   + txtIDApartadoHallazgo.Text + "','"
                   + txtIDInformeActual.Text + "','"
                   + cmbProcesoInformeHallazgo.Text + "')";

            SqlConnection con = new SqlConnection(cadena_conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand(cadena, con);

            cmd.CommandType = CommandType.Text;


            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro almacenado correctamente !");
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                // Cierro la Conexión.
                con.Close();
            }
        }

        private void btnGenerarReporteInforme_Click(object sender, EventArgs e)
        {
            int auditoria, plan, informe;
            tabControl1.SelectedIndex = 2;
            auditoria = Convert.ToInt32(txtIDAuditoria.Text);
            plan = Convert.ToInt32(txtIDPlan.Text);
            informe = Convert.ToInt32(txtIDInformeActual.Text);
            this.reportViewer1.Clear();
            this.filtraInformeTableAdapter.Fill(this.data.filtraInforme, informe);
            this.filtraConformidadesHallazgosTableAdapter.Fill(this.data.filtraConformidadesHallazgos, informe);
            this.filtraNoConformidadesHallazgosTableAdapter.Fill(this.data.filtraNoConformidadesHallazgos, informe);
            this.filtraObservacionesHallazgosTableAdapter.Fill(this.data.filtraObservacionesHallazgos, informe);
            this.filtraOportunidadesHallazgosTableAdapter.Fill(this.data.filtraOportunidadesHallazgos, informe);
            this.filtraFortalezasHallazgosTableAdapter.Fill(this.data.filtraFortalezasHallazgos,informe);
            this.filtraPlanInformeTableAdapter.Fill(this.data.filtraPlanInforme, informe, plan);
            this.filtraEquipoInformeTableAdapter.Fill(this.data.filtraEquipoInforme, informe, plan, auditoria);
            this.filtraAuditoriasInformeTableAdapter.Fill(this.data.filtraAuditoriasInforme, informe, plan, auditoria);
            this.filtraProcesosInformeTableAdapter.Fill(this.data.filtraProcesosInforme, informe, plan, auditoria);
             this.reportViewer1.RefreshReport();

        }

        private void cmbApartadoHallazgo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDApartadoHallazgo.Text = Convert.ToString(cmbApartadoHallazgo.SelectedValue);
        }

        private void cmbProcesoInformeHallazgo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
