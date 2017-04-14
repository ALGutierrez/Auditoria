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
    public partial class Plan : Form
    {
        string cadena_conexion = Properties.Settings.Default.conexion;
        LLenaCombos c = new LLenaCombos();
        LlenaDataGrid dg = new LlenaDataGrid();

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;



      
        public Plan()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGeneraCódigoPlan_Click(object sender, EventArgs e)
        {
            txtCodigoPlan.Text = "REG-AUD-PL-FECHA("+txtFechaEfectivaAuditoriaPlan.Text+")-V "+txtVersionPlan.Text;
        }

        private void Plan_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'data.filtraFechasPlanes' Puede moverla o quitarla según sea necesario.
            //this.filtraFechasPlanesTableAdapter.Fill(this.data.filtraFechasPlanes);
            //// TODO: esta línea de código carga datos en la tabla 'data.filtraPlan' Puede moverla o quitarla según sea necesario.
            //this.filtraPlanTableAdapter.Fill(this.data.filtraPlan);
            //// TODO: esta línea de código carga datos en la tabla 'data.filtraVerifPlan' Puede moverla o quitarla según sea necesario.
            //this.filtraVerifPlanTableAdapter.Fill(this.data.filtraVerifPlan);
            //// TODO: esta línea de código carga datos en la tabla 'data.filtraAudiPlan' Puede moverla o quitarla según sea necesario.
            //this.filtraAudiPlanTableAdapter.Fill(this.data.filtraAudiPlan);
            //// TODO: esta línea de código carga datos en la tabla 'data.filtraProPlan' Puede moverla o quitarla según sea necesario.
            //this.filtraProPlanTableAdapter.Fill(this.data.filtraProPlan);
            txtFechaPlanificadaAuditoriaPlan.Enabled = false;
            txtFechaEfectivaAuditoriaPlan.Enabled = false;
            c.LlenaCombosPrograma(cmbAñoProgramaPlan);
            c.LlenaCombosPlan(cmbBuscarPlanDetallePlan);
            txtFechaEmisionPlan.Text =DateTime.Now.ToString("d");


            this.reportViewer1.RefreshReport();
        }

        private void cmbAñoProgramaPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            txtIDProgramaPlan.Text = Convert.ToString(cmbAñoProgramaPlan.SelectedValue);
        }

        private void cmbTituloAuditoriaPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDAuditoriaPlan.Text = Convert.ToString(cmbTituloAuditoriaPlan.SelectedValue);
        }

        private void OKPrograma_CheckedChanged(object sender, EventArgs e)
        {
            if (OKPrograma.Checked== true)
            {
                c.LlenaCombosAuditoriaPrograma(cmbTituloAuditoriaPlan, Convert.ToInt32(txtIDProgramaPlan.Text));
            }
        }

        private void btnMostrarInformacionPlan_Click(object sender, EventArgs e)
        {
            string cadena = "SELECT fecha_prevista,fecha_efectiva FROM Auditoria WHERE idauditoria='" + txtIDAuditoriaPlan.Text + "' AND idprograma='" + txtIDProgramaPlan.Text + "'";


            SqlConnection con = new SqlConnection(cadena_conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtFechaPlanificadaAuditoriaPlan.Text = Convert.ToString(rd["fecha_prevista"]);
                txtFechaEfectivaAuditoriaPlan.Text = Convert.ToString(rd["fecha_efectiva"]);
            }
            rd.Close();
          

            try
            {
                da = new SqlDataAdapter("SELECT p.descripcion FROM Proceso_Auditoria pa, Proceso p WHERE pa.proceso = p.idproceso AND pa.auditoria ='"+txtIDAuditoriaPlan.Text+"'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgvAlcanceAuditoriaPlan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay registros para mostrar" + ex.ToString());
            }

            try
            {
                da = new SqlDataAdapter("SELECT a.apellido +' '+a.nombre As Nombre FROM Proceso_Auditoria pa, Auditor a WHERE pa.auditor = a.idauditor AND pa.auditoria ='" + txtIDAuditoriaPlan.Text + "'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgvEquipoAuditoriaPlan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay registros para mostrar" + ex.ToString());
            }

            con.Close();
        }

        private void btnGuardarDetallePlan_Click(object sender, EventArgs e)
        {
            if (rbIngresaPlan.Checked == true)
            {
                txtIDAuditoriaActualPlan.Text = txtIDAuditoriaPlan.Text;
                string cadena = "INSERT INTO Planes(idauditoria,version,fecha_emision,objetivos,lugar,criterio,codigo)"
                   + "VALUES ('" + txtIDAuditoriaPlan.Text + "','" + txtVersionPlan.Text + "','"
                   + txtFechaEmisionPlan.Text + "','"
                   + txtObjetivosPlan.Text + "','"
                   + txtLugarPlan.Text + "','"
                   + txtCriterioPlan.Text + "','"
                   + txtCodigoPlan.Text + "')";

                SqlConnection con = new SqlConnection(cadena_conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand(cadena, con);

                cmd.CommandType = CommandType.Text;


                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro almacenado correctamente !");
                    c.LlenaCombosPlan(cmbBuscarPlanDetallePlan);
                    txtObjetivosPlan.Text = "";
                    txtLugarPlan.Text = "";
                    txtCriterioPlan.Text = "";
                    txtVersionPlan.Text = "";
                    txtCodigoPlan.Text = "";

                    string cadena2 = "SELECT MAX(idplanes) AS ultimo FROM Planes";


                    SqlCommand cmd2 = new SqlCommand(cadena2, con);
                    cmd2.CommandType = CommandType.Text;
                    SqlDataReader rd2 = cmd2.ExecuteReader();
                    if (rd2.Read())
                    {
                        txtIDPlanActual.Text = Convert.ToString(rd2["ultimo"]);

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
            if(rbModificarPlan.Checked == true)
            {
                string cadena = "UPDATE Planes SET  version='" + txtVersionPlan.Text +
                   "',fecha_emision= '" + txtFechaEmisionPlan.Text +
                   "',objetivos='"+txtObjetivosPlan.Text+
                   "',lugar='"+txtLugarPlan.Text+
                   "',criterio='"+txtCriterioPlan.Text+
                   "',codigo='"+txtCodigoPlan.Text+
                   "' WHERE idplanes= '" + txtIDPlan.Text + "'";


                SqlConnection con = new SqlConnection(cadena_conexion);
                SqlCommand cmd = new SqlCommand(cadena, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro actualizado correctamente !");

                    c.LlenaCombosPlan(cmbBuscarPlanDetallePlan);
                    txtObjetivosPlan.Text = "";
                    txtLugarPlan.Text = "";
                    txtCriterioPlan.Text = "";
                    txtVersionPlan.Text = "";
                    txtCodigoPlan.Text = "";

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
            if(rbEliminarPlan.Checked == true)
            {
                string cadena = "DELETE FROM Planes  WHERE idplanes= '" + txtIDPlan.Text + "'";

                SqlConnection con = new SqlConnection(cadena_conexion);
                SqlCommand cmd = new SqlCommand(cadena, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro eliminado correctamente !");
                    c.LlenaCombosPlan(cmbBuscarPlanDetallePlan);
                    txtObjetivosPlan.Text = "";
                    txtLugarPlan.Text = "";
                    txtCriterioPlan.Text = "";
                    txtVersionPlan.Text = "";
                    txtCodigoPlan.Text = "";
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
        }

        private void btnBuscarPlan_Click(object sender, EventArgs e)
        {
            txtIDPlanActual.Text = txtIDPlan.Text;
            string cadena = "SELECT version,fecha_emision,objetivos,lugar,criterio,codigo,idauditoria FROM Planes WHERE idplanes='" + txtIDPlanActual.Text + "'";
            string cadena2="SELECT idprograma FROM Auditoria WHERE idauditoria='"+txtIDAuditoriaActualPlan.Text+"'";

            SqlConnection con = new SqlConnection(cadena_conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtVersionPlan.Text = Convert.ToString(rd["version"]);
                txtFechaEmisionPlan.Text= Convert.ToString(rd["fecha_emision"]);
                txtObjetivosPlan.Text= Convert.ToString(rd["objetivos"]);
                txtLugarPlan.Text= Convert.ToString(rd["lugar"]);
                txtCriterioPlan.Text= Convert.ToString(rd["criterio"]);
                txtCodigoPlan.Text= Convert.ToString(rd["codigo"]);
                txtIDAuditoriaActualPlan.Text= Convert.ToString(rd["idauditoria"]);
            }
            rd.Close();

            SqlCommand cmd2 = new SqlCommand(cadena2, con);
            cmd2.CommandType = CommandType.Text;
            SqlDataReader rd2 = cmd2.ExecuteReader();
            if (rd2.Read())
            {
                txtIDProgramaActualPlan.Text = Convert.ToString(rd2["idprograma"]);
            }
            rd2.Close();
            con.Close();
        }

        private void cmbBuscarPlanDetallePlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDPlan.Text = Convert.ToString(cmbBuscarPlanDetallePlan.SelectedValue);
        }

        private void btnSiguientePlan_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            txtIDPlanActual.Text = txtIDPlan.Text;
            txtIDProgramaActualPlan.Text = txtIDProgramaPlan.Text;
        }

        private void btnSiguienteDetallePlan_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            int au = Convert.ToInt32(txtIDAuditoriaActualPlan.Text);
            int pro = Convert.ToInt32(txtIDProgramaActualPlan.Text);
            int plan = Convert.ToInt32(txtIDPlanActual.Text);
            this.reportViewer1.Clear();
           this.filtraPlanTableAdapter.Fill(this.data.filtraPlan, plan, au);
            this.filtraFechasPlanesTableAdapter.Fill(this.data.filtraFechasPlanes, plan, au);
            this.filtraAudiPlanTableAdapter.Fill(this.data.filtraAudiPlan, pro, au);
            this.filtraProPlanTableAdapter.Fill(this.data.filtraProPlan, pro, au);
            this.filtraVerifPlanTableAdapter.Fill(this.data.filtraVerifPlan, plan);
            
            this.reportViewer1.RefreshReport();
        }

        private void btnGuardarVerificaciones_Click(object sender, EventArgs e)
        {
            if (rbIngresaPlan.Checked == true)
            {
                string cadena = "INSERT INTO Verificacion(mejora_continua,quejas,idplanes)"
                   + "VALUES ('" + txtMejoraContinuaPlan.Text + "','" + txtQuejasPlan.Text + "','"
                   + txtIDPlanActual.Text + "')";

                SqlConnection con = new SqlConnection(cadena_conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand(cadena, con);

                cmd.CommandType = CommandType.Text;


                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro almacenado correctamente !");
                    txtMejoraContinuaPlan.Text = "";
                    txtQuejasPlan.Text = "";
                    


                    string cadena2 = "SELECT MAX(idplanes) AS ultimo FROM Planes";


                    SqlCommand cmd2 = new SqlCommand(cadena2, con);
                    cmd2.CommandType = CommandType.Text;
                    SqlDataReader rd2 = cmd2.ExecuteReader();
                    if (rd2.Read())
                    {
                        txtIDPlanActual.Text = Convert.ToString(rd2["ultimo"]);

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
            if (rbModificarPlan.Checked==true)
            {
                MessageBox.Show("Esta sección no permite la edición de contenido");
            }
            if (rbEliminarPlan.Checked==true)
            {
                string cadena = "DELETE FROM Verificacion  WHERE idplanes= '" + txtIDPlanActual.Text + "'";

                SqlConnection con = new SqlConnection(cadena_conexion);
                SqlCommand cmd = new SqlCommand(cadena, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro eliminado correctamente !");
              
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
        }

        private void rbModificarPlan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbModificarPlan.Checked == true)
            {
                tabControl1.TabIndex = 1;
                lblBuscarPlan.Visible = true;
                cmbBuscarPlanDetallePlan.Visible = true;
                btnBuscarPlan.Visible = true;
                btnGeneraCódigoPlan.Visible = true;
            }
        }

        private void rbIngresaPlan_CheckedChanged(object sender, EventArgs e)
        {
           
            lblBuscarPlan.Visible = false;
            cmbBuscarPlanDetallePlan.Visible = false;
            btnBuscarPlan.Visible = false;
            btnGeneraCódigoPlan.Visible = true;
        }

        private void rbEliminarPlan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEliminarPlan.Checked == true)
            {
                tabControl1.TabIndex = 1;
                lblBuscarPlan.Visible = true;
                cmbBuscarPlanDetallePlan.Visible = true;
                btnBuscarPlan.Visible = true;
                btnGeneraCódigoPlan.Visible = false;
            }
        }
    }
}
