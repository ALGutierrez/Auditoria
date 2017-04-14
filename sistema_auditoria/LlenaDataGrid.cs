using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sistema_auditoria
{
    class LlenaDataGrid
    {


        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;



        public LlenaDataGrid()
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

        public void llenaDataGridAuditor(DataGridView dg)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Auditor", con);
                dt = new DataTable();
                da.Fill(dt);
                dg.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay registros para mostrar" + ex.ToString());
            }

        }

        public void llenaDataGridUsuario(DataGridView dg)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Usuario", con);
                dt = new DataTable();
                da.Fill(dt);
                dg.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay registros para mostrar" + ex.ToString());
            }

        }
        public void llenaDataGridProceso(DataGridView dg)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Proceso", con);
                dt = new DataTable();
                da.Fill(dt);
                dg.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay registros para mostrar" + ex.ToString());
            }

        }

        public void llenaDataGridAuditores(DataGridView dg, int aux)
        {
            try
            {
                da = new SqlDataAdapter("select a.apellido+' '+ a.nombre as apellido, e.rol from auditor a, equipo e where a.idauditor=e.auditor and e.programa='"+aux+"'", con);
                dt = new DataTable();
                da.Fill(dt);
                dg.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay registros para mostrar" + ex.ToString());
            }

        }

        public void llenaDataGridSugerencia(DataGridView dg)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Sugerencia", con);
                dt = new DataTable();
                da.Fill(dt);
                dg.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay registros para mostrar" + ex.ToString());
            }

        }


    }
}
