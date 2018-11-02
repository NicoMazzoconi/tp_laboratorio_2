using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
	public class Texto : IArchivo<string>
	{
		/// <summary>
		/// Metodo guardar, reciebe un path y datos, y los escribe en el archivo del path
		/// </summary>
		/// <param name="archivo"></param>
		/// <param name="datos"></param>
		/// <returns>true si logro guardar, ArchivosException sino</returns>
		public bool Guardar(string archivo, string datos)
		{
			try
			{
				StreamWriter sw = new StreamWriter(archivo);
				sw.WriteLine(datos);
				sw.Close();
				return true;
			}
			catch(ArchivosException ex)
			{
				throw new ArchivosException(ex);
			}
		}

		/// <summary>
		/// Metodo leer, recibe un path y un string por referencia donde guarda los datos leidos
		/// </summary>
		/// <param name="archivo"></param>
		/// <param name="datos"></param>
		/// <returns>true si logro leer, ArchivosException sino</returns>
		public bool Leer(string archivo, out string datos)
		{
			try
			{
				StreamReader sr = new StreamReader(archivo);
				datos = sr.ReadToEnd();
				sr.Close();
				return true;
			}
			catch(ArchivosException ex)
			{
				throw new ArchivosException(ex);
			}
		}
	}
}
