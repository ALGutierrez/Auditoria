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
    public partial class Procesos : Form
    {
        string cadena_conexion = Properties.Settings.Default.conexion;
        LLenaCombos c = new LLenaCombos();
        LlenaDataGrid dg = new LlenaDataGrid();
        public Procesos()
        {
            InitializeComponent();
        }

        private void lblBuscarProceso_Click(object sender, EventArgs e)
        {

        }

        private void Procesos_Load(object sender, EventArgs e)
        {

            c.LlenaCombosTipoPro(cmbBuscarTipo);
            c.LlenaCombosTipoPro(cmbTipoProceso);
            c.LlenaCombosProceso(cmbNombreProceso, Convert.ToInt32(txtIDTipo.Text));
            dg.llenaDataGridProceso(dataGridView1);
            txtNombreProceso.Text = "";
            txtResponsableProceso.Text = "";
            txtCodigoProceso.Text = "";

        }

        private void cmbBuscarTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDTipo.Text = Convert.ToString(cmbBuscarTipo.SelectedValue);

        
        }

        private void cmbTipoProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDTipo2.Text = Convert.ToString(cmbTipoProceso.SelectedValue);
          
           
        }

        private void cmbNombreProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDProceso.Text = Convert.ToString(cmbNombreProceso.SelectedValue);
        }

        private void btnMostrarInformacionProceso_Click(object sender, EventArgs e)
        {
            string cadena = "SELECT descripcion,idtipoproceso,responsable,codigo FROM Proceso WHERE idproceso='"+txtIDProceso.Text+"'";
            string cadena2 = "SELECT descripcion FROM TipoProceso WHERE idtipoproceso= '" + txtIDTipo.Text + "'";
            
            SqlConnection con = new SqlConnection(cadena_conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtNombreProceso.Text = Convert.ToString(rd["descripcion"]);
                txtResponsableProceso.Text = Convert.ToString(rd["responsable"]);
                txtCodigoProceso.Text = Convert.ToString(rd["codigo"]);
                txtIDTipo.Text = Convert.ToString(rd["idtipoproceso"]);


            }
            rd.Close();
            SqlCommand cmd2 = new SqlCommand(cadena2, con);
            cmd2.CommandType = CommandType.Text;
            SqlDataReader rd2 = cmd2.ExecuteReader();
            if (rd2.Read())
            {
                cmbTipoProceso.Text = Convert.ToString(rd2["descripcion"]);
             }
            rd2.Close();

            con.Close();
        }

        private void btnAceptarProceso_Click(object sender, EventArgs e)
        {
            if (rbIngresaProceso.Checked == true)
            {
                string cadena_consulta = "SELECT descripcion, idtipoproceso, responsable,codigo FROM Proceso WHERE descripcion='" + txtNombreProceso.Text + "'AND idtipoproceso='" + txtIDTipo2.Text + "'";
                string cadena = "INSERT INTO Proceso(descripcion,idtipoproceso,responsable,codigo)"
                   + "VALUES ('" + txtNombreProceso.Text + "','" + txtIDTipo2.Text + "','" + txtResponsableProceso.Text + "','" + txtCodigoProceso.Text + "')";

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
                        c.LlenaCombosTipoPro(cmbBuscarTipo);
                        c.LlenaCombosTipoPro(cmbTipoProceso);
                        c.LlenaCombosProceso(cmbNombreProceso, Convert.ToInt32(txtIDTipo.Text));
                        dg.llenaDataGridProceso(dataGridView1);
                        txtNombreProceso.Text = "";
                        txtResponsableProceso.Text = "";
                        txtCodigoProceso.Text = "";


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
            if (rbModificarProceso.Checked == true)
            {
                string cadena = "UPDATE Proceso SET  descripcion='" + txtNombreProceso.Text +
                     "', responsable= '" + txtResponsableProceso.Text +
                     "',idtipoproceso= '" + txtIDTipo2.Text +
                     "',codigo= '" + txtCodigoProceso.Text +
                     "' WHERE idproceso= '" + txtIDProceso.Text + "'";


                SqlConnection con = new SqlConnection(cadena_conexion);
                SqlCommand cmd = new SqlCommand(cadena, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro actualizado correctamente !");
                    c.LlenaCombosTipoPro(cmbBuscarTipo);
                    c.LlenaCombosTipoPro(cmbTipoProceso);
                    c.LlenaCombosProceso(cmbNombreProceso, Convert.ToInt32(txtIDTipo.Text));
                    dg.llenaDataGridProceso(dataGridView1);
                    txtNombreProceso.Text = "";
                    txtResponsableProceso.Text = "";
                    txtCodigoProceso.Text = "";

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
            if (rbEliminarProceso.Checked == true)
            {
                string cadena = "DELETE FROM Proceso  WHERE idproceso= '" + txtIDProceso.Text + "'";

                SqlConnection con = new SqlConnection(cadena_conexion);
                SqlCommand cmd = new SqlCommand(cadena, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro eliminado correctamente !");
                    c.LlenaCombosTipoPro(cmbBuscarTipo);
                    c.LlenaCombosTipoPro(cmbTipoProceso);
                    c.LlenaCombosProceso(cmbNombreProceso, Convert.ToInt32(txtIDTipo.Text));
                    dg.llenaDataGridProceso(dataGridView1);
                    txtNombreProceso.Text = "";
                    txtResponsableProceso.Text = "";
                    txtCodigoProceso.Text = "";
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

        private void rbIngresaProceso_CheckedChanged(object sender, EventArgs e)
        {

            c.LlenaCombosTipoPro(cmbBuscarTipo);
            c.LlenaCombosTipoPro(cmbTipoProceso);
            c.LlenaCombosProceso(cmbNombreProceso, Convert.ToInt32(txtIDTipo.Text));
            dg.llenaDataGridProceso(dataGridView1);
            lblBuscaNombre.Visible = false;
            lblBuscarProceso.Visible = false;
            lblBuscarTipo.Visible = false;
            cmbBuscarTipo.Visible = false;
            cmbNombreProceso.Visible = false;
            btnMostrarInformacionProceso.Visible = false;
            txtCodigoProceso.Enabled = true;
            txtNombreProceso.Enabled = true;
            txtResponsableProceso.Enabled = true;
            cmbTipoProceso.Enabled = true;
            txtNombreProceso.Text = "";
            txtResponsableProceso.Text = "";
            txtCodigoProceso.Text = "";


        }

        private void rbModificarProceso_CheckedChanged(object sender, EventArgs e)
        {
            c.LlenaCombosTipoPro(cmbBuscarTipo);
            c.LlenaCombosTipoPro(cmbTipoProceso);
            c.LlenaCombosProceso(cmbNombreProceso, Convert.ToInt32(txtIDTipo.Text));
            dg.llenaDataGridProceso(dataGridView1);
            lblBuscaNombre.Visible = true ;
            lblBuscarProceso.Visible = true ;
            lblBuscarTipo.Visible = true ;
            cmbBuscarTipo.Visible = true ;
            cmbNombreProceso.Visible = true ;
            btnMostrarInformacionProceso.Visible = true ;
            txtCodigoProceso.Enabled = true;
            txtNombreProceso.Enabled = true;
            txtResponsableProceso.Enabled = true;
            cmbTipoProceso.Enabled = true;
            txtNombreProceso.Text = "";
            txtResponsableProceso.Text = "";
            txtCodigoProceso.Text = "";
          
          
        }

        private void rbEliminarProceso_CheckedChanged(object sender, EventArgs e)
        {
            c.LlenaCombosTipoPro(cmbBuscarTipo);
            c.LlenaCombosTipoPro(cmbTipoProceso);
            c.LlenaCombosProceso(cmbNombreProceso, Convert.ToInt32(txtIDTipo.Text));
            dg.llenaDataGridProceso(dataGridView1);
            lblBuscaNombre.Visible = true;
            lblBuscarProceso.Visible = true;
            lblBuscarTipo.Visible = true;
            cmbBuscarTipo.Visible = true;
            cmbNombreProceso.Visible = true;
            btnMostrarInformacionProceso.Visible = true;
            txtCodigoProceso.Enabled = false;
            txtNombreProceso.Enabled = false ;
            txtResponsableProceso.Enabled = false ;
            cmbTipoProceso.Enabled = false ;
            txtNombreProceso.Text = "";
            txtResponsableProceso.Text = "";
            txtCodigoProceso.Text = "";
            //cmbTipoProceso.Text = "";
            //cmbBuscarTipo.Text = "";
           
        }

        private void OK_CheckedChanged(object sender, EventArgs e)
        {
            if (OK.Checked==true)
            {
                c.LlenaCombosProceso(cmbNombreProceso, Convert.ToInt32(txtIDTipo.Text));
            }
            else
            {
                cmbNombreProceso.Text = "";
            }
        }

        private void btnCancelarProceso_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
    

