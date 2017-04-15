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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal(string tipoUsuario)
        {
            InitializeComponent();
            if (tipoUsuario.Equals("Administrador"))
            {
                usuariosToolStripMenuItem.Enabled = true;
                auditoresToolStripMenuItem.Enabled = true;
                procesToolStripMenuItem.Enabled = true;
            }
            else if (tipoUsuario.Equals("Usuario"))
            {
                usuariosToolStripMenuItem.Enabled = false;
                auditoresToolStripMenuItem.Enabled = false;
                procesToolStripMenuItem.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void irToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Auditores ir = new Auditores();
            ir.Show();
        }

        private void irToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios ir = new Usuarios();
            ir.Show();
        }

        private void tipoDeProcesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void irToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Procesos ir = new Procesos();
            ir.Show();
        }

        private void irToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Programa ir = new Programa();
            ir.Show();
        }

        private void irToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Plan ir = new Plan();
            ir.Show();
        }

        private void irToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Informe ir = new Informe();
            ir.Show();
        }

        private void aCercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformaciónAdicional ir = new InformaciónAdicional();
            ir.Show();
        }

        private void sugerenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otros.Sugerencias ir = new Otros.Sugerencias();
            ir.Show();
        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prueba_datos ir = new Prueba_datos();
            ir.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InicioSesion ir = new InicioSesion();
            ir.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
