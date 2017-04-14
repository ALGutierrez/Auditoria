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

namespace sistema_auditoria
{
    public partial class Programa : Form
    {
        string cadena_conexion = Properties.Settings.Default.conexion;
        LLenaCombos c = new LLenaCombos();
        LlenaDataGrid dg = new LlenaDataGrid();
        float version_programa;
        public Programa()
        {
            InitializeComponent();
        }

       

        private void Programa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Data.filtraPrograma' Puede moverla o quitarla según sea necesario.
            //this.filtraProgramaTableAdapter.Fill(this.Data.filtraPrograma);
            cmbRolAuditorEquipo.Items.Add("Líder");
            cmbRolAuditorEquipo.Items.Add("Colaborador");
            txtFechaEmisionPrograma.Text = DateTime.Now.ToString("d");
            c.LlenaCombosPrograma(cmbBuscarPrograma);
            c.LlenaCombosAuditor(cmbAuditorEquipo);
     
            c.LlenaCombosAudi(cmbBuscarAuditoria);
            c.LlenaCombosTipoPro(cmbTipoProceso);



            //dg.llenaDataGridAuditores(dataGridView1, Convert.ToInt32(txtIDProgramaActual.Text));
            this.reportViewer1.RefreshReport();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void cmbBuscarPrograma_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDPrograma.Text = Convert.ToString(cmbBuscarPrograma.SelectedValue);
        }

        private void btnBuscarPrograma_Click(object sender, EventArgs e)
        {
            txtIDProgramaActual.Text = txtIDPrograma.Text;
            string cadena = "SELECT año,version,codigo,objetivos,criterio,recursos,fecha_emision,fecha_aprobacion,aprobado_por FROM Programa WHERE idprograma='" + txtIDPrograma.Text + "'";
             SqlConnection con = new SqlConnection(cadena_conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtAñoPrograma.Text = Convert.ToString(rd["año"]);
                txtVersionPrograma.Text= Convert.ToString(rd["version"]);
                txtCodigoPrograma.Text= Convert.ToString(rd["codigo"]);
                txtObjetivosPrograma.Text= Convert.ToString(rd["objetivos"]);
                txtCriteriosPrograma.Text= Convert.ToString(rd["criterio"]);
                txtRecursosPrograma.Text= Convert.ToString(rd["recursos"]);
                txtFechaEmisionPrograma.Text= Convert.ToString(rd["fecha_emision"]);
                dtFechaAprobacionPrograma.Text= Convert.ToString(rd["fecha_aprobacion"]);
                txtAprobadoPorPrograma.Text= Convert.ToString(rd["aprobado_por"]);




            }
            rd.Close();
            con.Close();
            }

        private void btnGeneraCódigo_Click(object sender, EventArgs e)
        {
            txtCodigoPrograma.Text = "REG-AIN-PR-" + txtAñoPrograma.Text + "V" + txtVersionPrograma.Text;
        }

        private void btnGuardarPrograma_Click(object sender, EventArgs e)
        {
            //PROGRAMA
            if (rbIngresaPrograma.Checked==true)
            {
               // version_programa = Convert.ToSingle(txtVersionPrograma.Text);
                string cadena_consulta = "SELECT codigo,objetivos,criterio,recursos,fecha_emision,fecha_aprobacion,aprobado_por FROM Programa WHERE año='" + txtAñoPrograma.Text + "'AND version='" + txtVersionPrograma.Text + "'";
                string cadena = "INSERT INTO Programa(año,version,codigo,objetivos,criterio,recursos,fecha_emision,fecha_aprobacion,aprobado_por)"
                   + "VALUES ('"+ txtAñoPrograma.Text +"','"+ txtVersionPrograma.Text +"','" 
                   +txtCodigoPrograma.Text +"','"
                   +txtObjetivosPrograma.Text+ "','"
                   +txtCriteriosPrograma.Text+"','"
                   +txtRecursosPrograma.Text+"','"
                   +txtFechaEmisionPrograma.Text+"','"
                   +dtFechaAprobacionPrograma.Text+"','"
                   +txtAprobadoPorPrograma.Text+"')";
               
                SqlConnection con = new SqlConnection(cadena_conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlCommand cmd_consulta = new SqlCommand(cadena_consulta, con);

                cmd_consulta.CommandType = CommandType.Text;
                cmd.CommandType = CommandType.Text;
                SqlDataReader rd = cmd_consulta.ExecuteReader();

                if (rd.Read())
                {
                    MessageBox.Show("El registro ya existe");
                }
                else
                {
                    rd.Close();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            MessageBox.Show("Registro almacenado correctamente !");
                        c.LlenaCombosPrograma(cmbBuscarPrograma);
                        txtAñoPrograma.Text = "";
                        txtCriteriosPrograma.Text = "";
                        txtObjetivosPrograma.Text = "";
                        txtRecursosPrograma.Text = "";
                        txtAprobadoPorPrograma.Text = "";
                        txtVersionPrograma.Text = "";
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
            if(rbModificarPrograma.Checked==true)
            {
                string cadena = "UPDATE Programa SET  año='" + txtAñoPrograma.Text +
                    "',version= '" + txtVersionPrograma.Text +
                   "',codigo='"+txtCodigoPrograma.Text+
                   "',objetivos='"+txtObjetivosPrograma.Text+
                    "',criterio='"+txtCriteriosPrograma.Text+
                    "',recursos='"+txtRecursosPrograma.Text+
                    "',fecha_emision='"+txtFechaEmisionPrograma.Text+
                    "',fecha_aprobacion= '" + dtFechaAprobacionPrograma.Text +
                    "',aprobado_por= '" + txtAprobadoPorPrograma.Text +
                    "' WHERE idprograma= '" + txtIDPrograma.Text + "'";


                SqlConnection con = new SqlConnection(cadena_conexion);
                SqlCommand cmd = new SqlCommand(cadena, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro actualizado correctamente !");
                    c.LlenaCombosPrograma(cmbBuscarPrograma);
                    txtAñoPrograma.Text = "";
                    txtCriteriosPrograma.Text = "";
                    txtObjetivosPrograma.Text = "";
                    txtRecursosPrograma.Text = "";
                    txtAprobadoPorPrograma.Text = "";
                    txtVersionPrograma.Text = "";

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
            if(rbEliminarPrograma.Checked==true)
            {
                string cadena = "DELETE FROM Programa  WHERE idprograma= '" + txtIDPrograma.Text + "'";

                SqlConnection con = new SqlConnection(cadena_conexion);
                SqlCommand cmd = new SqlCommand(cadena, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro eliminado correctamente !");
                    c.LlenaCombosPrograma(cmbBuscarPrograma);
                    txtAñoPrograma.Text = "";
                    txtCriteriosPrograma.Text = "";
                    txtObjetivosPrograma.Text = "";
                    txtRecursosPrograma.Text = "";
                    txtAprobadoPorPrograma.Text = "";
                    txtVersionPrograma.Text = "";
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

        private void btnAuditoriaPrograma_Click(object sender, EventArgs e)
        {
          
            tabControl1.SelectedIndex = 1;
            string cadena = "SELECT MAX(idprograma) AS ultimo FROM Programa";

            SqlConnection con = new SqlConnection(cadena_conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtIDProgramaActual.Text = Convert.ToString(rd["ultimo"]);

            }
            rd.Close();
            con.Close();

            c.LlenaCombosEquipoPrograma(cmbBuscarAuditoresEquipo, Convert.ToInt32(txtIDProgramaActual.Text));
            dg.llenaDataGridAuditores(dataGridView1, Convert.ToInt32(txtIDProgramaActual.Text));
        }

        private void cmbRolAuditorEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbRolAuditorEquipo.Text == "")
            {
                cmbRolAuditorEquipo.Items.Add("Líder");
                cmbRolAuditorEquipo.Items.Add("Colaborador");
            }
         
        
            
        }

        private void cmbAuditorEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDAuditorEquipo.Text = Convert.ToString(cmbAuditorEquipo.SelectedValue);
        }

        private void cmbBuscarAuditoresEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDBuscarAuditorEquipo.Text = Convert.ToString(cmbBuscarAuditoresEquipo.SelectedValue);
        }

        private void btnBuscarAuditoresEquipo_Click(object sender, EventArgs e)
        {
            string cadena = "SELECT a.apellido +' '+ a.nombre AS apellido, e.rol AS rol  FROM Equipo e, Auditor a WHERE e.auditor='" + txtIDBuscarAuditorEquipo.Text + "' AND e.programa='"+txtIDProgramaActual.Text+"'";


            SqlConnection con = new SqlConnection(cadena_conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                cmbAuditorEquipo.Text = Convert.ToString(rd["apellido"]);
                cmbRolAuditorEquipo.Text = Convert.ToString(rd["rol"]);
            }
            rd.Close();
            con.Close();
        }

        private void btnGuardarEquipo_Click(object sender, EventArgs e)
        {
            if (rbIngresaPrograma.Checked == true)
            {
                string cadena_consulta = "SELECT programa,rol,auditor FROM Equipo WHERE auditor='" + txtIDAuditorEquipo.Text + "'AND rol='" + cmbRolAuditorEquipo.Text + "' AND programa='" + txtIDProgramaActual.Text + "'";
                string cadena = "INSERT INTO Equipo(programa,rol,auditor)"
                   + "VALUES ('" + txtIDProgramaActual.Text + "','" + cmbRolAuditorEquipo.Text + "','" + txtIDAuditorEquipo.Text + "')";

                SqlConnection con = new SqlConnection(cadena_conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlCommand cmd_consulta = new SqlCommand(cadena_consulta, con);

                cmd_consulta.CommandType = CommandType.Text;
                cmd.CommandType = CommandType.Text;
                SqlDataReader rd = cmd_consulta.ExecuteReader();

                if (rd.Read())
                {
                    MessageBox.Show("El registro ya existe");
                }
                else
                {
                    rd.Close();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            MessageBox.Show("Registro almacenado correctamente !");
                        c.LlenaCombosAuditor(cmbAuditorEquipo);
                        dg.llenaDataGridAuditores(dataGridView1, Convert.ToInt32(txtIDProgramaActual.Text));

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
            if (rbModificarPrograma.Checked==true)
            {

                string cadena = "UPDATE Equipo SET  rol='" + cmbRolAuditorEquipo.Text +
                 
                 "' WHERE auditor= '" + txtIDBuscarAuditorEquipo.Text + "' AND programa='"+txtIDProgramaActual.Text+"'";


                SqlConnection con = new SqlConnection(cadena_conexion);
                SqlCommand cmd = new SqlCommand(cadena, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro actualizado correctamente !");
                    c.LlenaCombosAuditor(cmbAuditorEquipo);
                    dg.llenaDataGridAuditores(dataGridView1, Convert.ToInt32(txtIDProgramaActual.Text));

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
            if(rbEliminarPrograma.Checked==true)
            {
                    string cadena = "DELETE FROM Equipo  WHERE auditor= '" + txtIDBuscarAuditorEquipo.Text + "'AND programa='"+txtIDProgramaActual.Text+"'";

                    SqlConnection con = new SqlConnection(cadena_conexion);
                    SqlCommand cmd = new SqlCommand(cadena, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            MessageBox.Show("Registro eliminado correctamente !");
                    c.LlenaCombosAuditor(cmbAuditorEquipo);
                    dg.llenaDataGridAuditores(dataGridView1, Convert.ToInt32(txtIDProgramaActual.Text));

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

        private void btnSiguienteEquipo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;

            c.LlenaCombosAuditorResp(cmbAuditorResponsable, Convert.ToInt32(txtIDProgramaActual.Text));
        }

        private void btnBuscarAuditoria_Click(object sender, EventArgs e)
        {
           // c.LlenaCombosProcesoAudi(cmbBuscarProceso, Convert.ToInt32(txtIDAuditoriaActual.Text));

            txtIDAuditoriaActual.Text = txtIDBuscarAuditoria.Text;
            c.LlenaCombosProcesoAudi(cmbBuscarProceso, Convert.ToInt32(txtIDAuditoriaActual.Text));
            string cadena = "SELECT numero, fecha_prevista, fecha_efectiva, informe, tipo FROM Auditoria WHERE idauditoria='" + txtIDBuscarAuditoria.Text + "' AND idprograma='" + txtIDProgramaActual.Text + "'";


            SqlConnection con = new SqlConnection(cadena_conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
           
                txtNumeroAuditoria.Text= Convert.ToString(rd["numero"]);
                dtFechaPrevistaAuditoria.Text= Convert.ToString(rd["fecha_prevista"]);
                dtFechaEfectivaAuditoria.Text= Convert.ToString(rd["fecha_efectiva"]);
                txtInformeAuditoria.Text= Convert.ToString(rd["informe"]);
                txtTipoAuditoria.Text= Convert.ToString(rd["tipo"]);
              

            }
            rd.Close();
            con.Close();

           
        }

        private void btnGuardarAuditoria_Click(object sender, EventArgs e)
        {
            
            #region Ingresar Auditoria

            if (rbIngresaPrograma.Checked==true)
            {
                string cadena_consulta = "SELECT numero,fecha_prevista,fecha_efectiva,informe FROM Auditoria WHERE tipo='" + txtTipoAuditoria.Text + "' AND idprograma='" + txtIDProgramaActual.Text + "'";
                string cadena = "INSERT INTO Auditoria(numero,fecha_prevista,fecha_efectiva,idprograma,tipo,informe)"
                   + "VALUES ('" + txtNumeroAuditoria.Text + "','" 
                   + dtFechaPrevistaAuditoria.Text + "','"
                   + dtFechaEfectivaAuditoria.Text+ "','"
                   +txtIDProgramaActual.Text +"','"
                   +txtTipoAuditoria.Text +"','"
                  + txtInformeAuditoria.Text + "')";

                SqlConnection con = new SqlConnection(cadena_conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlCommand cmd_consulta = new SqlCommand(cadena_consulta, con);

                cmd_consulta.CommandType = CommandType.Text;
                cmd.CommandType = CommandType.Text;
                SqlDataReader rd = cmd_consulta.ExecuteReader();

                if (rd.Read())
                {
                    MessageBox.Show("El registro ya existe");
                }
                else
                {
                    rd.Close();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            MessageBox.Show("Registro almacenado correctamente !");
                        {
                            c.LlenaCombosAudi(cmbBuscarAuditoria);

                            string cadena2 = "SELECT MAX(idauditoria) AS ultimo FROM Auditoria";


                            SqlCommand cmd2 = new SqlCommand(cadena2, con);
                            cmd2.CommandType = CommandType.Text;
                            SqlDataReader rd2 = cmd2.ExecuteReader();
                            if (rd2.Read())
                            {
                                txtIDAuditoriaActual.Text = Convert.ToString(rd2["ultimo"]);

                            }
                            rd2.Close();
                        
                                                    }
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

            #endregion

            #region Modificar Auditoria
            if (rbModificarPrograma.Checked==true)
            {
                string cadena = "UPDATE Auditoria SET  numero='" + txtNumeroAuditoria.Text +
              "', fecha_prevista= '" + dtFechaPrevistaAuditoria.Text +
             "',fecha_efectiva='" + dtFechaEfectivaAuditoria.Text +
             "',idprograma='" + txtIDProgramaActual.Text +
              "',informe='" + txtInformeAuditoria.Text +
              "',tipo='" + txtTipoAuditoria.Text +
              "' WHERE idauditoria= '" + txtIDBuscarAuditoria.Text + "'";


                SqlConnection con = new SqlConnection(cadena_conexion);
                SqlCommand cmd = new SqlCommand(cadena, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro actualizado correctamente !");
                    c.LlenaCombosAudi(cmbBuscarAuditoria);

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
            #endregion
            #region Eliminar Auditoria 
            if (rbEliminarPrograma.Checked==true)
            {
                string cadena = "DELETE FROM Auditoria  WHERE idauditoria= '" + txtIDBuscarAuditoria.Text + "'AND programa='" + txtIDProgramaActual.Text + "'";

                SqlConnection con = new SqlConnection(cadena_conexion);
                SqlCommand cmd = new SqlCommand(cadena, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro eliminado correctamente !");
                    c.LlenaCombosAudi(cmbBuscarAuditoria);
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
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtInformeAuditoria.Text = openFileDialog1.FileName;
            }
    }

        private void cmbBuscarAuditoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDBuscarAuditoria.Text = Convert.ToString(cmbBuscarAuditoria.SelectedValue);
        }

     

        private void cmbBuscarProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDBuscarProceso.Text = Convert.ToString(cmbBuscarProceso.SelectedValue);
        }

        private void btnBuscarProceso_Click(object sender, EventArgs e)
        {
            //string cadena = "SELECT descripcion,idtipoproceso FROM Proceso WHERE idproceso='" + txtIDBuscarProceso.Text + "'";
            //string cadena2 = "SELECT descripcion FROM TipoProceso WHERE idtipoproceso='"+txtid+"'";

            //SqlConnection con = new SqlConnection(cadena_conexion);
            //con.Open();
            //SqlCommand cmd = new SqlCommand(cadena, con);
            //cmd.CommandType = CommandType.Text;
            //SqlDataReader rd = cmd.ExecuteReader();
            //if (rd.Read())
            //{

            //    txtNumeroAuditoria.Text = Convert.ToString(rd["numero"]);
            //    dtFechaPrevistaAuditoria.Text = Convert.ToString(rd["fecha_prevista"]);
            //    dtFechaEfectivaAuditoria.Text = Convert.ToString(rd["fecha_efectiva"]);
            //    txtInformeAuditoria.Text = Convert.ToString(rd["informe"]);
            //    txtTipoAuditoria.Text = Convert.ToString(rd["tipo"]);

            //}
            //rd.Close();
            //con.Close()
        }

        private void btnGuardarProceso_Click(object sender, EventArgs e)
        {
            #region Ingresar procesos
            if (rbIngresaPrograma.Checked==true)
            {
                string cadena_consulta = "SELECT auditoria,proceso,auditor FROM Proceso_Auditoria WHERE auditoria='" + txtIDAuditoriaActual.Text + "'AND proceso='" + txtIDProceso.Text + "'";
                string cadena = "INSERT INTO Proceso_Auditoria(auditoria,proceso,auditor)"
                   + "VALUES ('" + txtIDAuditoriaActual.Text + "','"
                   + txtIDProceso.Text + "','"
                   + txtIDAuditor.Text + "')";

                SqlConnection con = new SqlConnection(cadena_conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlCommand cmd_consulta = new SqlCommand(cadena_consulta, con);

                cmd_consulta.CommandType = CommandType.Text;
                cmd.CommandType = CommandType.Text;
                SqlDataReader rd = cmd_consulta.ExecuteReader();

                if (rd.Read())
                {
                    MessageBox.Show("El registro ya existe");
                }
                else
                {
                    rd.Close();
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

            }
            #endregion

            if (rbModificarPrograma.Checked==true)
            {
                string cadena = "UPDATE Proceso_Auditoria SET  proceso='" + txtIDProceso.Text +
                    "', auditor= '" + txtIDAuditor.Text +
                    "' WHERE auditoria= '" + txtIDAuditoriaActual.Text + "'";


                SqlConnection con = new SqlConnection(cadena_conexion);
                SqlCommand cmd = new SqlCommand(cadena, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro actualizado correctamente !");
                 
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
            if(rbEliminarPrograma.Checked==true)
            {
                string cadena = "DELETE FROM Proceso_Auditoria  WHERE auditoria= '" + txtIDAuditoriaActual.Text + "'";

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

        private void tabPage3_Click(object sender, EventArgs e)
        {
           

            //c.LlenaCombosTipoPro(cmbTipoProceso);
            //c.LlenaCombosProceso(cmbNombreProceso, Convert.ToInt32(txtIDTipoProceso.Text));
            //c.LlenaCombosAuditorResp(cmbAuditorEquipo, Convert.ToInt32(txtIDAuditoriaActual.Text), Convert.ToInt32(txtIDProgramaActual.Text));
        }

        private void cmbTipoProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDTipoProceso.Text = Convert.ToString(cmbTipoProceso.SelectedValue);
            c.LlenaCombosProceso(cmbNombreProceso, Convert.ToInt32(txtIDTipoProceso.Text));

        }

        private void cmbNombreProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDProceso.Text = Convert.ToString(cmbNombreProceso.SelectedValue);


            
        }

        private void cmbAuditorResponsable_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDAuditor.Text = Convert.ToString(cmbAuditorResponsable.SelectedValue);
        }

        private void btnGenerarReportePrograma_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;

            int pro = Convert.ToInt32(txtIDProgramaActual.Text);
            this.reportViewer1.Clear();
            this.filtraProgramaTableAdapter.Fill(this.data.filtraPrograma, pro);
            this.filtraProAuProgramaTableAdapter.Fill(this.data.filtraProAuPrograma, pro);
            this.filtraEquipoProgramaTableAdapter.Fill(this.data.filtraEquipoPrograma, pro);
           
            this.reportViewer1.RefreshReport();
        }

        private void rbIngresaPrograma_CheckedChanged(object sender, EventArgs e)
        {
            lblBuscarPrograma.Visible = false;
            cmbBuscarPrograma.Visible = false;
            btnBuscarPrograma.Visible = false;
            lblBuscarAuditoresEquipo.Visible = false;
            cmbBuscarAuditoresEquipo.Visible = false;
            btnBuscarAuditoresEquipo.Visible = false;
        }

        private void rbModificarPrograma_CheckedChanged(object sender, EventArgs e)
        {
            lblBuscarPrograma.Visible = true;
            cmbBuscarPrograma.Visible = true;
            btnBuscarPrograma.Visible = true;
            lblBuscarAuditoresEquipo.Visible = true;
            cmbBuscarAuditoresEquipo.Visible = true;
            btnBuscarAuditoresEquipo.Visible = true;
        }

        private void rbEliminarPrograma_CheckedChanged(object sender, EventArgs e)
        {
            lblBuscarPrograma.Visible = true;
            cmbBuscarPrograma.Visible = true;
            btnBuscarPrograma.Visible = true;
            lblBuscarAuditoresEquipo.Visible = true;
            cmbBuscarAuditoresEquipo.Visible = true;
            btnBuscarAuditoresEquipo.Visible = true;
        }
    }
    }

