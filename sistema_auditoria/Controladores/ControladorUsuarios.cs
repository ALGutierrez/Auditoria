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
            using(SqlConnection connection = new SqlConnection(cadena_conexion))
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
    }
}
