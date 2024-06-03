using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Reflection;

namespace Sol_Alamcen.Presentacion
{
    public class D_Articulos
    {
        public DataTable Listado_ar(String cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                String sql_tarea = "SELECT a.codigo_ar," +
                        " a.descripcion_ar," +
                        " a.marca_ar," +
                        " b.descripcion_um," +
                        " c.descripcion_ca," +
                        " a.stock_actual," +
                        " a.codigo_um," +
                        " a.codigo_ca" +
                        " FROM tb_articulos a " +
                        " INNER JOIN tb_unidades_medidas b ON a.codigo_um = b.codigo_um" +
                        " INNER JOIN tb_categorias c ON a.codigo_ca = c.codigo_ca " +
                        " WHERE a.descripcion_ar LIKE '" + cTexto + "' " +          
                        " ORDER BY a.codigo_ar";


                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon);
                Comando.CommandTimeout = 60;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }
        }
        public string guardar_ar(int nOpicion, P_Articulos Oar)
        {

            string rpta = "";
            string sqlTarea = "";
            MySqlConnection sqlCon = null;

            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();
                if (nOpicion == 1) // nuevo registro
                {
                    sqlTarea = "INSERT INTO tb_articulos (Descripcion_ar, Marca_ar, Codigo_um, Codigo_ca, Stock_actual, Fecha_crea, Fecha_Modifica) " +
                               "VALUES (@Descripcion_ar, @Marca_ar, @Codigo_um, @Codigo_ca, @Stock_actual, @Fecha_crea, @Fecha_Modifica)";
                }
                else
                {
                    sqlTarea = "UPDATE tb_articulos SET " +
                          "descripcion_ar = '" + Oar.descripcion_ar + "', " +
                          "marca_ar = '" + Oar.marca_ar + "', " +
                         "Codigo_um = '" + Oar.codigo_um + "', " +
                          "Codigo_ca = '" + Oar.codigo_ca + "', " +
                         "Stock_actual = '" + Oar.stock_Actual + "', " +
                        "Fecha_Modifica = '" + Oar.fecha_modifica + "' " +
                         "WHERE codigo_ar = '" + Oar.codigo_ar + "'";

                }

                MySqlCommand comando = new MySqlCommand(sqlTarea, sqlCon);
                comando.Parameters.AddWithValue("@Descripcion_ar", Oar.descripcion_ar);
                comando.Parameters.AddWithValue("@Marca_ar", Oar.marca_ar);
                comando.Parameters.AddWithValue("@Codigo_um", Oar.codigo_um);
                comando.Parameters.AddWithValue("@Codigo_ca", Oar.codigo_ca);
                comando.Parameters.AddWithValue("@Stock_actual", Oar.stock_Actual);
                comando.Parameters.AddWithValue("@Fecha_crea", Oar.fecha_crea);
                comando.Parameters.AddWithValue("@Fecha_Modifica", Oar.fecha_modifica) ;
                sqlCon.Open();
                rpta = comando.ExecuteNonQuery() >= 1 ? "ok" : "No puedes ingresar el registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == System.Data.ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return rpta;
        }

        public string Eliminar_ar(int Codigo_ar)
        {
            string Rpta = "";
            MySqlConnection sqlCon = null;

            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();
                string sqlTarea = "DELETE FROM tb_articulos WHERE Codigo_ar = @Codigo_ar";

                MySqlCommand comando = new MySqlCommand(sqlTarea, sqlCon);
                comando.Parameters.AddWithValue("@Codigo_ar", Codigo_ar);

                sqlCon.Open();
                Rpta = comando.ExecuteNonQuery() >= 1 ? "OK" : "No se puede eliminar el registro";
            }
            catch (Exception ex)
            {
                Rpta = "Error al intentar eliminar el registro: " + ex.Message;
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close(); // Cierra la conexión solo si está abierta
                }
            }
            return Rpta;

        }

    }
}


