using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql    :IArchivo<Queue<Patente>>
    {
        #region Atributos
        private SqlCommand comando;
        private SqlConnection conexion;
        #endregion

        #region Construcores
        /// <summary>
        /// Constructor publico Sql, inicializa los atributos
        /// </summary>
        public Sql()
        {
            conexion = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = patentes-sp-2018; Integrated Security = True");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo Guardar, recibe una tabla y los datos a guardar en la base de datos
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="datos"></param>
        public void Guardar(string tabla, Queue<Patente> datos)
        {
            try
            {
                foreach (Patente p in datos)
                {
                    comando.CommandText = "INSERT INTO " + tabla + " (patente, tipo) VALUES ('" + p.CodigoPatente + "', '" + p.TipoCodigo + "')";
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Metodo Leer , recibe una tabla y una cola de datos como out para poder cargarle los datos leidos
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="datos"></param>
        public void Leer(string tabla, out Queue<Patente> datos)
        {
            try
            {
                comando.CommandText = "SELECT patente,tipo FROM " + tabla;
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();
                Queue<Patente> patenesAux = new Queue<Patente>();
                while (oDr.Read())
                {
                    if (oDr["tipo"].ToString() == Patente.Tipo.Mercosur.ToString())
                    {
                        patenesAux.Enqueue(new Patente(oDr["patente"].ToString(), Patente.Tipo.Mercosur));
                    }
                    else
                    {
                        patenesAux.Enqueue(new Patente(oDr["patente"].ToString(), Patente.Tipo.Vieja));
                    }
                }
                conexion.Close();
                datos = patenesAux;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
        #endregion
    }
}
