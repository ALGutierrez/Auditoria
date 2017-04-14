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
    class LLenaCombos
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public LLenaCombos()
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

        public void LlenaCombosAuditor(ComboBox cmbA)
        {
            try
            {
                cmd = new SqlCommand("SELECT idauditor,apellido+' '+nombre AS apellido FROM Auditor", con);
                dr = cmd.ExecuteReader();



                dr.Close();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbA.ValueMember = "idauditor";
                cmbA.DisplayMember = "apellido";
                cmbA.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No pueden mostrarse los elementos " + ex.ToString());
            }

        }
        public void LlenaCombosUsuario(ComboBox cmbU)
        {
            try
            {
                cmd = new SqlCommand("SELECT idusuario,usuario FROM Usuario", con);
                dr = cmd.ExecuteReader();



                dr.Close();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbU.ValueMember = "idusuario";
                cmbU.DisplayMember = "usuario";
                cmbU.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No pueden mostrarse los elementos " + ex.ToString());
            }

        }


        public void LlenaCombosProceso(ComboBox cmbP, int aux)
        {
            try
            {
                cmd = new SqlCommand("SELECT idproceso,descripcion FROM Proceso WHERE idtipoproceso='" + aux + "'", con);
                dr = cmd.ExecuteReader();



                dr.Close();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbP.ValueMember = "idproceso";
                cmbP.DisplayMember = "descripcion";
                cmbP.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No pueden mostrarse los elementos " + ex.ToString());
            }
        }

        public void LlenaCombosTipoPro(ComboBox cmbT)
        {
            try
            {
                cmd = new SqlCommand("SELECT idtipoproceso,descripcion FROM TipoProceso ", con);
                dr = cmd.ExecuteReader();



                dr.Close();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbT.ValueMember = "idtipoproceso";
                cmbT.DisplayMember = "descripcion";
                cmbT.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No pueden mostrarse los elementos " + ex.ToString());
            }
        }


        public void LlenaCombosPrograma(ComboBox cmbP)
        {
            try
            {
                cmd = new SqlCommand("SELECT idprograma,año FROM Programa", con);
                dr = cmd.ExecuteReader();
                dr.Close();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbP.ValueMember = "idprograma";
                cmbP.DisplayMember = "año";
                cmbP.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No pueden mostrarse los elementos " + ex.ToString());
            }

        }


        public void LlenaCombosEquipoPrograma(ComboBox cmbE, int aux)
        {
            try
            {
                cmd = new SqlCommand("select e.auditor,a.apellido +' '+ a.nombre AS apellido from Programa p,Equipo e, Auditor a where a.idauditor=e.auditor and p.idprograma='" + aux + "'", con);
                dr = cmd.ExecuteReader();



                dr.Close();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbE.ValueMember = "e.auditor";
                cmbE.DisplayMember = "apellido";
                cmbE.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No pueden mostrarse los elementos " + ex.ToString());
            }
        }






        public void LlenaCombosAudi(ComboBox cmbA)
        {
            try
            {
                cmd = new SqlCommand("SELECT idauditoria,tipo FROM Auditoria", con);
                dr = cmd.ExecuteReader();
                dr.Close();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbA.ValueMember = "idauditoria";
                cmbA.DisplayMember = "tipo";
                cmbA.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No pueden mostrarse los elementos " + ex.ToString());
            }

        }


        public void LlenaCombosProceso_Auditoria(ComboBox cmbP, int aux)
        {
            try
            {
                cmd = new SqlCommand("select pa.auditoria,p.descripcion from Proceso_Auditoria pa, Proceso p where p.idproceso=pa.proceso and pa.auditoria='" + aux + "'", con);
                dr = cmd.ExecuteReader();



                dr.Close();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbP.ValueMember = "pa.auditoria";
                cmbP.DisplayMember = "p.descripcion";
                cmbP.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No pueden mostrarse los elementos " + ex.ToString());
            }
        }

        public void LlenaCombosAuditorResp(ComboBox cmbP,int prog)
        {
            try
            {
                cmd = new SqlCommand("SELECT e.auditor, a.apellido+' '+ a.nombre+' ('+e.rol+')' AS apellido FROM auditor a, equipo e  WHERE a.idauditor=e.auditor and e.auditor= a.idauditor and e.programa='" + prog + "'", con);
                dr = cmd.ExecuteReader();



                dr.Close();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbP.ValueMember = "e.auditor";
                cmbP.DisplayMember = "apellido";
                cmbP.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No pueden mostrarse los elementos " + ex.ToString());
            }
        }


        public void LlenaCombosProcesoAudi(ComboBox cmbP, int prog)
        {
            try
            {
                cmd = new SqlCommand("SELECT pa.auditor, p.descripcion as descripcion FROM Proceso p, Proceso_Auditoria pa WHERE p.idproceso=pa.proceso and pa.auditoria='" + prog + "'", con);
                dr = cmd.ExecuteReader();



                dr.Close();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbP.ValueMember = "pa.auditor";
                cmbP.DisplayMember = "descripcion";
                cmbP.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No pueden mostrarse los elementos " + ex.ToString());
            }
        }





        public void LlenaCombosAuditoriaPrograma(ComboBox cmbA, int aux)
        {
            try
            {
                cmd = new SqlCommand("SELECT idauditoria,tipo, idprograma FROM Auditoria WHERE idprograma='"+aux+"'", con);
                dr = cmd.ExecuteReader();
                dr.Close();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbA.ValueMember = "idauditoria";
                cmbA.DisplayMember = "tipo";
                cmbA.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No pueden mostrarse los elementos " + ex.ToString());
            }

        }



        public void LlenaCombosPlan(ComboBox cmbP)
        {
            try
            {
                cmd = new SqlCommand("SELECT idplanes,fecha_emision FROM Planes", con);
                dr = cmd.ExecuteReader();

                dr.Close();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbP.ValueMember = "idplanes";
                cmbP.DisplayMember = "fecha_emision";
                cmbP.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No pueden mostrarse los elementos " + ex.ToString());
            }
        }

        public void LlenaCombosPlanInforme(ComboBox cmbP)
        {
            try
            {
                cmd = new SqlCommand("SELECT idplanes,codigo FROM Planes", con);
                dr = cmd.ExecuteReader();

                dr.Close();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbP.ValueMember = "idplanes";
                cmbP.DisplayMember = "codigo";
                cmbP.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No pueden mostrarse los elementos " + ex.ToString());
            }
        }

        public void LlenaCombosProcesoInforme(ComboBox cmbP,int aux)
        {
            try
            {
                cmd = new SqlCommand("SELECT p.descripcion AS descripcion FROM Proceso_Auditoria pa, Proceso p WHERE pa.proceso = p.idproceso AND pa.auditoria ='" + aux + "'", con);
                dr = cmd.ExecuteReader();

                dr.Close();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbP.ValueMember = "p.proceso";
                cmbP.DisplayMember = "descripcion";
                cmbP.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No pueden mostrarse los elementos " + ex.ToString());
            }
        }

        public void LlenaCombosCapituloNorma(ComboBox cmbC)
        {
            try
            {
                cmd = new SqlCommand("SELECT idcapitulo,descripcion FROM Capitulo_Norma", con);
                dr = cmd.ExecuteReader();

                dr.Close();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbC.ValueMember = "idcapitulo";
                cmbC.DisplayMember = "descripcion";
                cmbC.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No pueden mostrarse los elementos " + ex.ToString());
            }
        }
        public void LlenaCombosApartadoNorma(ComboBox cmbA,int aux)
        {
            try
            {
                cmd = new SqlCommand("SELECT idapartado,descripcion FROM Apartado_Norma WHERE idcapitulo='"+aux+"'", con);
                dr = cmd.ExecuteReader();

                dr.Close();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbA.ValueMember = "idapartado";
                cmbA.DisplayMember = "descripcion";
                cmbA.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No pueden mostrarse los elementos " + ex.ToString());
            }
        }

        public void LlenaCombosSugerencias(ComboBox cmbS)
        {
            try
            {
                cmd = new SqlCommand("SELECT idsugerencia,fecha FROM Sugerencia", con);
                dr = cmd.ExecuteReader();

                dr.Close();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbS.ValueMember = "idsugerencia";
                cmbS.DisplayMember = "fecha";
                cmbS.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No pueden mostrarse los elementos " + ex.ToString());
            }
        }



    }
}
