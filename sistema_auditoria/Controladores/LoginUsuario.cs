using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace sistema_auditoria.Controladores
{
    class LoginUsuario
    {
        string cadena_conexion = Properties.Settings.Default.conexion;

        public string ingresarUsuario(string user, string password)
        {
            string tipo = "";
            using (SqlConnection connection = new SqlConnection(cadena_conexion))
            {
                string cadena = "SELECT tipo FROM Usuario WHERE usuario = '" + user + "' AND contraseña= '" + password + "'";
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(cadena, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tipo = reader.GetString(0);
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return tipo;
        }
    }
}
