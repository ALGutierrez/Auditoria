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
using sistema_auditoria.Controladores;

namespace sistema_auditoria
{
    public partial class InicioSesion : Form
    {
        string cadena_conexion = Properties.Settings.Default.conexion;
        LoginUsuario controlador;
        public InicioSesion()
        {
            controlador = new LoginUsuario();
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
                string tipo = controlador.ingresarUsuario(txtUsuarioInicioSesion.Text,txtContraseñaIncioSesion.Text);
                if (!tipo.Equals(""))
                {
                    MenuPrincipal mp = new MenuPrincipal(tipo);
                    this.Hide();
                    mp.Show();
                }
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

