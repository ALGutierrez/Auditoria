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

namespace sistema_auditoria
{
    public partial class Auditores : Form
    {
        string cadena_conexion = Properties.Settings.Default.conexion;
        LLenaCombos c = new LLenaCombos();
        LlenaDataGrid dg = new LlenaDataGrid();
        public Auditores()
        {
            InitializeComponent();
        }

        private void Auditores_Load(object sender, EventArgs e)
        {
            c.LlenaCombosAuditor(cmbBuscarAuditor);
            dg.llenaDataGridAuditor(dataGridView1);
            txtApellidoAuditor.Text = "";
            txtNombreAuditor.Text = "";
            txtMailAuditor.Text = "";
           
            txtCompetenciasAuditor.Text = "";
        }
        private void cmbBuscarAuditor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDAuditor.Text = Convert.ToString(cmbBuscarAuditor.SelectedValue);
        }

        private void btnBuscarAuditor_Click(object sender, EventArgs e)
        {
            string cadena = "SELECT apellido,nombre,mail,competencias FROM Auditor WHERE idauditor= '" + txtIDAuditor.Text + "'";
            SqlConnection con = new SqlConnection(cadena_conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtApellidoAuditor.Text = Convert.ToString(rd["apellido"]);
                txtNombreAuditor.Text = Convert.ToString(rd["nombre"]);
                
                txtMailAuditor.Text = Convert.ToString(rd["mail"]);
                txtCompetenciasAuditor.Text = Convert.ToString(rd["competencias"]);
             
            }
            rd.Close();
            con.Close();
            }

        private void btnAceptarAuditor_Click(object sender, EventArgs e)
        {
            if (rbIngresaAuditor.Checked==true)
            {
               
                string cadena = "INSERT INTO Auditor(apellido,nombre,mail,competencias)"
                   + "VALUES ('" + txtApellidoAuditor.Text + "','" + txtNombreAuditor.Text + "','" + txtMailAuditor.Text + "','"+txtCompetenciasAuditor.Text+"')";

                SqlConnection con = new SqlConnection(cadena_conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand(cadena, con);

                cmd.CommandType = CommandType.Text;
                try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            MessageBox.Show("Registro almacenado correctamente !");
                    c.LlenaCombosAuditor(cmbBuscarAuditor);
                    dg.llenaDataGridAuditor(dataGridView1);
                    txtApellidoAuditor.Text = "";
                    txtNombreAuditor.Text = "";
                    txtMailAuditor.Text = "";
           
                    txtCompetenciasAuditor.Text = "";

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
            if(rbModificarAuditor.Checked==true)
            {
                string cadena = "UPDATE Auditor SET  nombre='" + txtNombreAuditor.Text +
                    "',apellido='"+txtApellidoAuditor.Text+
                    
                     "',mail= '" + txtMailAuditor.Text +
                     "',competencias= '" + txtCompetenciasAuditor.Text +
                     "' WHERE idauditor= '" + txtIDAuditor.Text + "'";


                SqlConnection con = new SqlConnection(cadena_conexion);
                SqlCommand cmd = new SqlCommand(cadena, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro actualizado correctamente !");
                    c.LlenaCombosAuditor(cmbBuscarAuditor);
                    dg.llenaDataGridAuditor(dataGridView1);
                    txtApellidoAuditor.Text = "";
                    txtNombreAuditor.Text = "";
                    txtMailAuditor.Text = "";
                 
                    txtCompetenciasAuditor.Text = "";


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
            if (rbEliminarAuditor.Checked==true)
            {
                string cadena = "DELETE FROM Auditor  WHERE idauditor= '" + txtIDAuditor.Text + "'";


                SqlConnection con = new SqlConnection(cadena_conexion);
                SqlCommand cmd = new SqlCommand(cadena, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro eliminado correctamente !");
                    c.LlenaCombosAuditor(cmbBuscarAuditor);
                    dg.llenaDataGridAuditor(dataGridView1);
                    txtApellidoAuditor.Text = "";
                    txtNombreAuditor.Text = "";
                    txtMailAuditor.Text = "";
                  
                    txtCompetenciasAuditor.Text = "";

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

        private void rbIngresaAuditor_CheckedChanged(object sender, EventArgs e)
        {
            lblBuscarAuditor.Visible = false;
            cmbBuscarAuditor.Visible = false;
            btnBuscarAuditor.Visible = false;
            txtApellidoAuditor.Enabled = true;
            txtNombreAuditor.Enabled = true;
            txtMailAuditor.Enabled = true;
     
            txtCompetenciasAuditor.Enabled = true;
            c.LlenaCombosAuditor(cmbBuscarAuditor);
            dg.llenaDataGridAuditor(dataGridView1);
            txtApellidoAuditor.Text = "";
            txtNombreAuditor.Text = "";
            txtMailAuditor.Text = "";
           
            txtCompetenciasAuditor.Text = "";
        }

        private void rbModificarAuditor_CheckedChanged(object sender, EventArgs e)
        {
            lblBuscarAuditor.Visible = true;
            cmbBuscarAuditor.Visible = true ;
            btnBuscarAuditor.Visible = true ;
            txtApellidoAuditor.Enabled = true;
            txtNombreAuditor.Enabled = true;
            txtMailAuditor.Enabled = true;
        
            txtCompetenciasAuditor.Enabled = true;
            c.LlenaCombosAuditor(cmbBuscarAuditor);
            dg.llenaDataGridAuditor(dataGridView1);
        }

        private void rbEliminarAuditor_CheckedChanged(object sender, EventArgs e)
        {
            lblBuscarAuditor.Visible = true;
            cmbBuscarAuditor.Visible = true;
            btnBuscarAuditor.Visible = true;
            txtApellidoAuditor.Enabled = false ;
            txtNombreAuditor.Enabled = false ;
            txtMailAuditor.Enabled =false ;
          
            txtCompetenciasAuditor.Enabled = false ;
            c.LlenaCombosAuditor(cmbBuscarAuditor);
            dg.llenaDataGridAuditor(dataGridView1);
        }

        private void btnCancelarAuditor_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
