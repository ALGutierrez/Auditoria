using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using sistema_auditoria.Modelo;

namespace sistema_auditoria.Controladores
{
    class ControladorUsuarios
    {
        string cadena_conexion = Properties.Settings.Default.conexion;

        public List<Usuario> obtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (SqlConnection connection = new SqlConnection(cadena_conexion))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT idusuario,usuario,tipo FROM Usuario", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Usuario usu = new Usuario();
                        usu.Idusuario = reader.GetInt32(0);
                        usu.Nombreusuario = reader.GetString(1);
                        usu.Tipo = reader.GetString(2);
                        usuarios.Add(usu);
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error en la conexion: " + ex.ToString());
                }
            }
            return usuarios;
        }

        public List<Auditor> obtenerAuditores()
        {
            List<Auditor> auditores = new List<Auditor>();
            using (SqlConnection connection = new SqlConnection(cadena_conexion))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT idauditor,nombre,apellido FROM Auditor", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Auditor aud = new Auditor();
                        aud.Idauditor = reader.GetInt32(0);
                        aud.Nombre = reader.GetString(1);
                        aud.Apellido = reader.GetString(2);
                        auditores.Add(aud);
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("No pueden mostrarse los elementos " + ex.ToString());
                }
            }
            return auditores;
        }

        public Usuario buscarUsuario(int idUsuario)
        {
            Usuario usu = new Usuario();
            using (SqlConnection connection = new SqlConnection(cadena_conexion))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT usuario,contraseña,tipo,Usuario.idauditor,apellido,nombre FROM Usuario INNER JOIN "
                        + "Auditor ON Usuario.idauditor = Auditor.idauditor WHERE idusuario = " + idUsuario;
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Auditor audi = new Auditor();
                        usu.Idusuario = idUsuario;
                        usu.Nombreusuario = reader.GetString(0);
                        usu.Contraseña = reader.GetString(1);
                        usu.Tipo = reader.GetString(2);
                        audi.Idauditor = reader.GetInt32(3);
                        audi.Apellido = reader.GetString(4);
                        audi.Nombre = reader.GetString(5);
                        usu.Auditor = audi;
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error en la conexion: " + ex.ToString());
                }
            }
            return usu;
        }

        public string nuevoUsuario(string nombreUsuario, string password, string tipoUsuario, int idAuditor)
        {
            using (SqlConnection connection = new SqlConnection(cadena_conexion))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario WHERE usuario = '" + nombreUsuario + "'", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return "El usuario ingresado ya existe";
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error en la conexion: " + ex.ToString());
                }
            }

            using (SqlConnection connection = new SqlConnection(cadena_conexion))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Usuario(usuario,contraseña,tipo,idauditor) VALUES('" + nombreUsuario
                        + "','" + password + "','" + tipoUsuario + "'," + idAuditor + ")";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error al ingresar usuario: " + ex.ToString());
                }
            }
            return "";
        }

        public void modificarUsuario(int idUsuario, string nombreUsuario, string password, string tipoUsuario,
            int idAuditor)
        {
            using (SqlConnection connection = new SqlConnection(cadena_conexion))
            {
                try
                {
                    string query = "UPDATE Usuario SET usuario='" + nombreUsuario + "', contraseña= '" + password + "', idauditor='" + idAuditor + "', tipo='" + tipoUsuario + "' WHERE idusuario = " + idUsuario;
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error al modificar usuario: " + ex.ToString());
                }
            }
        }

        public void eliminarUsuario(int idUsuario)
        {
            using (SqlConnection connection = new SqlConnection(cadena_conexion))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE idusuario = " + idUsuario, connection);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error al modificar usuario: " + ex.ToString());
                }
            }
        }
    }
}
