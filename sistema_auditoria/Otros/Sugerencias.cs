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

namespace sistema_auditoria.Otros
{
    public partial class Sugerencias : Form
    {
        string cadena_conexion = Properties.Settings.Default.conexion;
        LLenaCombos c = new LLenaCombos();
        LlenaDataGrid dg = new LlenaDataGrid();
        DateTime fec;
        public Sugerencias()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void Sugerencias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'data.Suger' Puede moverla o quitarla según sea necesario.
            this.sugerTableAdapter.Fill(this.data.Suger);


            c.LlenaCombosSugerencias(cmbBuscarSugerencia);
            dg.llenaDataGridSugerencia(dgvSugerencias);
            txtFecha.Text = DateTime.Now.ToString("d");
            if (cmbTipo.Text=="")
            {
                cmbTipo.Items.Add("Error");
                cmbTipo.Items.Add("Sugerencia de Mejora");
            }
            this.reportViewer1.RefreshReport();
        }

        private void cmbBuscarSugerencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIDSugerencia.Text = Convert.ToString(cmbBuscarSugerencia.SelectedValue);
        }

        private void btnMostrarInformacion_Click(object sender, EventArgs e)
        {
            string cadena = "SELECT tipo,descripcion FROM Sugerencia WHERE idsugerencia='" + txtIDSugerencia.Text + "'";


            SqlConnection con = new SqlConnection(cadena_conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtDescripcion.Text = Convert.ToString(rd["descripcion"]);
                cmbTipo.Text = Convert.ToString(rd["tipo"]);
                
            }
            rd.Close();
            con.Close();
        }

        private void btnGuardarSugerencias_Click(object sender, EventArgs e)
        {
            
            if(rbIngresaSugerencia.Checked==true)
            {
                string cadena = "INSERT INTO Sugerencia(tipo,descripcion,fecha)"
                   + "VALUES ('" + cmbTipo.Text + "','" + txtDescripcion.Text + "','"
                   + txtFecha.Text+ "')";

                SqlConnection con = new SqlConnection(cadena_conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand(cadena, con);

                cmd.CommandType = CommandType.Text;


                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro almacenado correctamente !");
                    c.LlenaCombosSugerencias(cmbBuscarSugerencia);
                    dg.llenaDataGridSugerencia(dgvSugerencias);
                    txtDescripcion.Text = "";
                    
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
           
            if (rbEliminarSugerencia.Checked==true )
            {
                string cadena = "DELETE FROM Sugerencia  WHERE idsugerencia= '" + txtIDSugerencia.Text + "'";

                SqlConnection con = new SqlConnection(cadena_conexion);
                SqlCommand cmd = new SqlCommand(cadena, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro eliminado correctamente !");
                    c.LlenaCombosSugerencias(cmbBuscarSugerencia);
                    dg.llenaDataGridSugerencia(dgvSugerencias);
                    txtDescripcion.Text = "";
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

        private void rbEliminarSugerencia_CheckedChanged(object sender, EventArgs e)
        {
          
            lblBuscarSugerencia.Visible = true;
            cmbBuscarSugerencia.Visible = true;
            btnMostrarInformacion.Visible = true;
            txtDescripcion.Enabled = false;
            cmbTipo.Enabled = false;

        }

        private void rbIngresaSugerencia_CheckedChanged(object sender, EventArgs e)
        {
            lblBuscarSugerencia.Visible = false;
            cmbBuscarSugerencia.Visible = false;
            btnMostrarInformacion.Visible = false;
            txtDescripcion.Enabled = true;
            cmbTipo.Enabled = true;
            
        }
       
        private void btnEmitirReportesSugerencias_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            //PruebaRepo p = new PruebaRepo();
            //p.Show();
           reportViewer1.Refresh();
        }
    }
}
