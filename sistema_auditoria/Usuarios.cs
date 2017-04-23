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
        string cadena_conexion = Properties.Settings.Default.conexion;
        public Usuarios()
        {
            InitializeComponent();
            llenarTablaUsuarios();
        }

        private void llenarComboUsuarios()
        {
            cmbBuscarUsuario.DataSource = controlador.obtenerUsuarios();
            cmbBuscarUsuario.ValueMember = "idusuario";
            cmbBuscarUsuario.DisplayMember = "nombreusuario";
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
                tablaUsuarios.Rows.Add(row);
            }
            dgvUsuarios.DataSource = tablaUsuarios;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            llenarComboUsuarios();

            cmbSeleccionarAuditor.DataSource = controlador.obtenerAuditores();
            cmbSeleccionarAuditor.ValueMember = "idauditor";
            cmbSeleccionarAuditor.DisplayMember = "nombreCompleto";

            txtAliasUsuario.Text = "";
            txtContraseñaUsuario.Text = "";

            cmbTipoUsuario.Items.Add("Administrador");
            cmbTipoUsuario.Items.Add("Usuario");
            cmbTipoUsuario.SelectedIndex = 0;

            dgvUsuarios.ClearSelection();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            Modelo.Usuario usuario = controlador.buscarUsuario((int)cmbBuscarUsuario.SelectedValue);
            txtAliasUsuario.Text = usuario.Nombreusuario;
            txtContraseñaUsuario.Text = usuario.Contraseña;
            cmbTipoUsuario.Text = usuario.Tipo;
            cmbSeleccionarAuditor.Text = usuario.Auditor.NombreCompleto;
        }

        private void btnAceptarUsuario_Click(object sender, EventArgs e)
        {
            if (rbIngresaUsuario.Checked)
            {
                string result = controlador.nuevoUsuario(txtAliasUsuario.Text, txtContraseñaUsuario.Text,
                    cmbTipoUsuario.Text, (int)cmbSeleccionarAuditor.SelectedValue);
                if (result != "")
                {
                    MessageBox.Show(result);
                }
                llenarComboUsuarios();
                llenarTablaUsuarios();
                txtAliasUsuario.Text = "";
                txtContraseñaUsuario.Text = "";
            }
            if (rbModificarUsuario.Checked)
            {
                controlador.modificarUsuario((int)cmbBuscarUsuario.SelectedValue,txtAliasUsuario.Text,
                    txtContraseñaUsuario.Text,cmbTipoUsuario.Text,(int)cmbSeleccionarAuditor.SelectedValue);
                llenarComboUsuarios();
                llenarTablaUsuarios();
                txtAliasUsuario.Text = "";
                txtContraseñaUsuario.Text = "";
            }
            if (rbEliminarUsuario.Checked)
            {
                controlador.eliminarUsuario((int)cmbBuscarUsuario.SelectedValue);
                llenarComboUsuarios();
                llenarTablaUsuarios();
                txtAliasUsuario.Text = "";
                txtContraseñaUsuario.Text = "";
            }
        }

        private void rbIngresaUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIngresaUsuario.Checked)
            {
                lblBuscarUsuario.Visible = false;
                cmbBuscarUsuario.Visible = false;
                btnBuscarUsuario.Visible = false;
                txtAliasUsuario.Enabled = true;
                txtContraseñaUsuario.Enabled = true;
                cmbSeleccionarAuditor.Enabled = true;
                cmbTipoUsuario.Enabled = true;
                cmbBuscarUsuario.Text = "";
                txtAliasUsuario.Text = "";
                txtContraseñaUsuario.Text = "";
            }
        }

        private void rbModificarUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbModificarUsuario.Checked)
            {
                lblBuscarUsuario.Visible = true;
                cmbBuscarUsuario.Visible = true;
                btnBuscarUsuario.Visible = true;
                txtAliasUsuario.Enabled = true;
                txtContraseñaUsuario.Enabled = true;
                cmbSeleccionarAuditor.Enabled = true;
                cmbTipoUsuario.Enabled = true;
                cmbBuscarUsuario.Text = "";
                txtAliasUsuario.Text = "";
                txtContraseñaUsuario.Text = "";
            }
        }

        private void rbEliminarUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEliminarUsuario.Checked)
            {
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
        }

        private void btnCancelarUsuario_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

