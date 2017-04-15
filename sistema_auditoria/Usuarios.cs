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
using sistema_auditoria.Controladores;

namespace sistema_auditoria
{
    public partial class Usuarios : Form
    {
        ControladorUsuarios controlador = new ControladorUsuarios();
        string cadena_conexion=Properties.Settings.Default.conexion;
        LLenaCombos c = new LLenaCombos();
        LlenaDataGrid dg = new LlenaDataGrid();
        DataTable tablaUsuarios;
        public Usuarios()
        {
            InitializeComponent();
        }

        private void llenarTablaUsuarios()
        {
            DataTable tablaUsuarios = new DataTable("Usuarios");
            tablaUsuarios.Columns.Add("Id");
            tablaUsuarios.Columns.Add("Usuario");
            tablaUsuarios.Columns.Add("Tipo");
            foreach (Modelo.Usuario usu in controlador.obtenerUsuarios())
            {
                DataRow row = tablaUsuarios.NewRow();
                row["Id"] = usu.Idusuario;
                row["Usuario"] = usu.Nombreusuario;
                row["Tipo"] = usu.Tipo;
            }
            dgvUsuarios.DataSource = tablaUsuarios;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            cmbBuscarUsuario.DataSource = controlador.obtenerUsuarios(); ;
            cmbBuscarUsuario.ValueMember = "idusuario";
            cmbBuscarUsuario.DisplayMember = "usuario";

            cmbSeleccionarAuditor.DataSource = controlador.obtenerAuditores();
            cmbSeleccionarAuditor.ValueMember = "idauditor";
            cmbSeleccionarAuditor.DisplayMember = "nombreCompleto";

            txtAliasUsuario.Text = "";
            txtContraseñaUsuario.Text = "";

            cmbTipoUsuario.Items.Add("Administrador");
            cmbTipoUsuario.Items.Add("Usuario");
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            string cadena = "SELECT usuario,contraseña,tipo,idauditor FROM Usuario WHERE idusuario= '" + txtIDUsuario.Text + "'";
            string cadena2 = "SELECT apellido+' '+ nombre AS apellido FROM Auditor WHERE idauditor='"+txtIDAuditorUsuarios.Text+"'";
            SqlConnection con = new SqlConnection(cadena_conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand(cadena, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtAliasUsuario.Text = Convert.ToString(rd["usuario"]);
                txtContraseñaUsuario.Text = Convert.ToString(rd["contraseña"]);
                txtIDAuditorUsuarios.Text = Convert.ToString(rd["idauditor"]);
                cmbTipoUsuario.Text = Convert.ToString(rd["tipo"]);
              
            }
            rd.Close();
            SqlConnection con2 = new SqlConnection(cadena_conexion);
            //con.Open();
            SqlCommand cmd2 = new SqlCommand(cadena2, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd2 = cmd2.ExecuteReader();
            if (rd2.Read())
            {

                cmbSeleccionarAuditor.Text = Convert.ToString(rd2["apellido"]);

            }
            rd2.Close();
            con.Close();
        }

        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTipoUsuario.Items.Add("Administrador");
            cmbTipoUsuario.Items.Add("Usuario");

        }

        private void btnAceptarUsuario_Click(object sender, EventArgs e)
        {
            if (rbIngresaUsuario.Checked==true )
            {
                string cadena_consulta = "SELECT contraseña, idauditor FROM Usuario WHERE usuario='" + txtAliasUsuario.Text + "'";

                string cadena = "INSERT INTO Usuario(usuario, contraseña, idauditor, tipo)"
               + "VALUES ('" + txtAliasUsuario.Text + "','" + txtContraseñaUsuario.Text + "','" + txtIDAuditorUsuarios.Text + "','" + cmbTipoUsuario.Text + "')";

                SqlConnection con = new SqlConnection(cadena_conexion);
                SqlCommand cmd = new SqlCommand(cadena, con);
                con.Open();
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
                        c.LlenaCombosUsuario(cmbBuscarUsuario);
                        c.LlenaCombosAuditor(cmbSeleccionarAuditor);
                        dg.llenaDataGridUsuario(dgvUsuarios);
                        txtAliasUsuario.Text = "";
                        txtContraseñaUsuario.Text = "";
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
            if (rbModificarUsuario.Checked==true )
            {
                string cadena = "UPDATE Usuario SET  usuario='" + txtAliasUsuario.Text + "', contraseña= '" + txtContraseñaUsuario.Text + "', idauditor='" + txtIDAuditorUsuarios.Text + "', tipo='" + cmbTipoUsuario.Text + "' WHERE idusuario= '" + txtIDUsuario.Text + "'";


                SqlConnection con = new SqlConnection(cadena_conexion);
                SqlCommand cmd = new SqlCommand(cadena, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro actualizado correctamente !");
                    c.LlenaCombosUsuario(cmbBuscarUsuario);
                    c.LlenaCombosAuditor(cmbSeleccionarAuditor);
                    dg.llenaDataGridUsuario(dgvUsuarios);
                    txtAliasUsuario.Text = "";
                    txtContraseñaUsuario.Text = "";
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
            if(rbEliminarUsuario.Checked==true )
            {
                string cadena = "DELETE FROM Usuario  WHERE idusuario= '" + txtIDUsuario.Text + "'";


                SqlConnection con = new SqlConnection(cadena_conexion);
                SqlCommand cmd = new SqlCommand(cadena, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro eliminado correctamente !");

                    c.LlenaCombosUsuario(cmbBuscarUsuario);
                    c.LlenaCombosAuditor(cmbSeleccionarAuditor);
                    dg.llenaDataGridUsuario(dgvUsuarios);
                    txtAliasUsuario.Text = "";
                    txtContraseñaUsuario.Text = "";
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

        private void rbIngresaUsuario_CheckedChanged(object sender, EventArgs e)
        {
            c.LlenaCombosUsuario(cmbBuscarUsuario);
            c.LlenaCombosAuditor(cmbSeleccionarAuditor);
            dg.llenaDataGridUsuario(dgvUsuarios);
            lblBuscarUsuario.Visible = false;
            cmbBuscarUsuario.Visible = false;
            btnBuscarUsuario.Visible = false;
            txtAliasUsuario.Enabled = true;
            txtContraseñaUsuario.Enabled = true;
            cmbBuscarUsuario.Text = "";
       
            txtAliasUsuario.Text = "";
            txtContraseñaUsuario.Text = "";

        }

        private void rbModificarUsuario_CheckedChanged(object sender, EventArgs e)
        {
            c.LlenaCombosUsuario(cmbBuscarUsuario);
            c.LlenaCombosAuditor(cmbSeleccionarAuditor);
            dg.llenaDataGridUsuario(dgvUsuarios);
            lblBuscarUsuario.Visible = true ;
            cmbBuscarUsuario.Visible = true;
            btnBuscarUsuario.Visible = true;
            txtAliasUsuario.Enabled = true;
            txtContraseñaUsuario.Enabled = true;
            cmbBuscarUsuario.Text = "";

            txtAliasUsuario.Text = "";
            txtContraseñaUsuario.Text = "";
        }

        private void rbEliminarUsuario_CheckedChanged(object sender, EventArgs e)
        {
            c.LlenaCombosUsuario(cmbBuscarUsuario);
            c.LlenaCombosAuditor(cmbSeleccionarAuditor);
            dg.llenaDataGridUsuario(dgvUsuarios);
            lblBuscarUsuario.Visible = true;
            cmbBuscarUsuario.Visible = true;
            btnBuscarUsuario.Visible = true;
            txtAliasUsuario.Enabled = false;
            txtContraseñaUsuario.Enabled = false;
            cmbSeleccionarAuditor.Enabled = false;
            cmbTipoUsuario.Enabled = false;
            cmbBuscarUsuario.Text = "";

            txtAliasUsuario.Text = "";
            txtContraseñaUsuario.Text = "";
        }

        private void btnCancelarUsuario_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

