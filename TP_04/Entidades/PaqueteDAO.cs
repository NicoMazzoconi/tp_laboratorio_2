using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
	public static class PaqueteDAO
	{
		static SqlCommand comando;
		static SqlConnection conexion;

		/// <summary>
		/// Constructor por defecto, inicializa SqlCommand y SqlConnection
		/// </summary>
		static PaqueteDAO()
		{
			conexion = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = correo-sp-2017; Integrated Security = True");
			comando = new SqlCommand();
			comando.CommandType = System.Data.CommandType.Text;
			comando.Connection = conexion;
		}

		/// <summary>
		/// Metodo estatico Insertar, recibe un paquete y lo inserta en la base de datos
		/// </summary>
		/// <param name="p"></param>
		/// <returns>True si lo logro</returns>
		public static bool Insertar(Paquete p)
		{
			try
			{
				comando.CommandText = "INSERT INTO correo-sp-2017 (direccionEntrega, trackingID, alumno) VALUES ('" + p.DireccionEntrega + "', '" + p.TrackingID + "', Nicolas.Mazzoconi)";
				conexion.Open();
				comando.ExecuteNonQuery();
				conexion.Close();
				return true;
			}
			catch
			{
				throw new Exception("Error al insertar paquete");
			}
			finally
			{
				conexion.Close();
			}
		}
	}
}
