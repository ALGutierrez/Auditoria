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
using System.Threading;

namespace sistema_auditoria
{
    public partial class InicioSesion : Form
    {
        string cadena_conexion = Properties.Settings.Default.conexion;
        public InicioSesion()
        {

            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();
                t.Abort();
        }

        private void btnIngresarInicioSesion_Click(object sender, EventArgs e)
        {
            if (txtContraseñaIncioSesion.Text != "" && txtUsuarioInicioSesion.Text != "")
            {
                //int usuario;
                string cadena = "SELECT tipo FROM Usuario WHERE usuario = '" + txtUsuarioInicioSesion.Text + "' AND contraseña= '" + txtContraseñaIncioSesion.Text + "'";

                SqlConnection con = new SqlConnection(cadena_conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand(cadena, con);
                cmd.CommandType = CommandType.Text;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    //usuario = Convert.ToInt32(rd["idusuario"]);
                    string aux = Convert.ToString(rd["tipo"]);
                    Form1 ir = new Form1();

                    if (aux == "Administrador")
                    {
                        ir.Show();
                        this.Hide();
                        ir.usuariosToolStripMenuItem.Enabled = true;
                        ir.auditoresToolStripMenuItem.Enabled = true;
                        ir.procesToolStripMenuItem.Enabled = true;
                    }
                    if (aux == "Usuario")
                    {
                        ir.Show();
                        this.Hide();
                        ir.usuariosToolStripMenuItem.Enabled = false;
                        ir.auditoresToolStripMenuItem.Enabled = false;
                        ir.procesToolStripMenuItem.Enabled = false;
                    }

                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos!");
                }
                rd.Close();
                // string cadena2 = "SELECT apellido +' '+ nombre FROM Empleado WHERE idempleado='" + usuario + "'";
                con.Close();
                // Close();
            }
            else
            { MessageBox.Show("No puede haber campos en blanco!"); }
        }

       public void StartForm()
        {
            Application.Run(new Splash());
        }
    }
    }

