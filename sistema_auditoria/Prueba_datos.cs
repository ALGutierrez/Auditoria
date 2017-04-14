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
    public partial class Prueba_datos : Form
    {
        string cadena_conexion = Properties.Settings.Default.conexion;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        public Prueba_datos()
        {
            InitializeComponent();
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {

           string cadena = "INSERT INTO TipoProceso (descripcion)"
                +"VALUES ('Estratégico'),('Clave'),('Soporte Interno'),('Soporte Externo')";
           
            
            //string cadena = "INSERT INTO Capitulo_Norma (descripcion)"
            //    + "VALUES ('4. Sistema de Gestión de la Calidad')"
            //    + ",('5. Responsabilidad de la Dirección')"
            //    + ",('6. Gestión de los Recursos')"
            //    + ",('7. Realización del Producto')"
            //    + ",('8. Medición, Análisis y Mejoras')";


            //string cadena = "INSERT INTO Apartado_Norma(descripcion,idcapitulo)"
            //+ "VALUES ('4.1 Requisitos Generales/Identificación de la Vinculación (secuencia e interrelación), con otros procesos','1')"
            //+ ",('4.2 Requisitos de la Documentación/Disponibilidad de Registros', '1')"
            //+ ",('5.1 Compromiso de la Dirección','2')"
            //+ ",('5.2 Enfoque al Cliente','2')"
            //+ ",('5.3 Política de la Calidad','2')"
            //+ ",('5.4 Planificación (Objetivos de la calidad, Planificación del Sistema de Gestión)','2')"
            //+ ",('5.5 Responsabilidad, Autoridad y Comunicación Interna','2')"
            //+ ",('6.1 Provisión de Recursos','3')"
            //+ ",('6.2 Recursos Humanos/Competencia del Personal','3')"
            //+ ",('6.3 Infraestructura','3')"
            //+ ",('6.4 Ambiente de Trabajo','3')"
            //+ ",('7.1 Planificación de la Realización del Trabajo/ Identificación de los Objetivos del Proceso','4')"
            //+ ",('7.2 Procesos Relacionados con el Cliente','4')"
            //+ ",('7.3 Diseño y Desarrollo','4')"
            //+ ",('7.4 Compras','4')"
            //+ ",('7.5 Producción y Prestación del Servicio','4')"
            //+ ",('7.6 Control de los Equipos de Medición y de Seguimiento','4')"
            //+ ",('8.1 Generalidades','5')"
            //+ ",('8.2 Medición y Seguimiento/Satisfacción del Cliente','5')"
            //+ ",('8.3 Producto no Conforme','5')"
            //+ ",('8.4 Análisis de Datos/Seguimiento del Desempeño del Proceso y Contro de no Conformidades','5')"
            //+ ",('8.5 Mejora','5')"
            //+ ",('8.5.1 Mejora Continua','5')"
            //+ ",('8.5.2 Acción Correctiva','5')";

            SqlConnection con = new SqlConnection(cadena_conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand(cadena, con);
           
            cmd.CommandType = CommandType.Text;
          
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro almacenado correctamente !");
               


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

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("SELECT au.apellido +' '+au.nombre As Nombre, p.descripcion "
                                         +"FROM Auditoria a, Auditor au, Proceso_Auditoria pa, Proceso p "
                                         +"WHERE pa.auditoria = a.idauditoria AND pa.proceso=p.idproceso AND pa.auditor=au.idauditor AND a.idprograma='3'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgvDatos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay registros para mostrar" + ex.ToString());
            }
        }

        private void Prueba_datos_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(Properties.Settings.Default.conexion);
                con.Open();
                // MessageBox.Show("Conexión exitosa!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("La conexión  no pudo realizarse" + ex.ToString());
            }

        }
    }
    }

