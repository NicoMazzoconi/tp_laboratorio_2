using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Excepciones;

namespace Archivos
{
	public class Xml<T> : IArchivo<T>
	{
		/// <summary>
		/// Guarda un archivo serializado en UTF32
		/// </summary>
		/// <param name="archivo">path</param>
		/// <param name="datos">datos a guardar</param>
		/// <returns>true si pudo, ArchivosException sino</returns>
		public bool Guardar(string archivo, T datos)
		{
			try
			{
				XmlTextWriter escribir;
				XmlSerializer ser;
				escribir = new XmlTextWriter(archivo, Encoding.UTF32);
				ser = new XmlSerializer(typeof(T));
				ser.Serialize(escribir, datos);
				escribir.Close();
				return true;
			}
			catch(ArchivosException ex)
			{
				throw new ArchivosException(ex);
			}
		}

		/// <summary>
		/// Lee un path y lo guarda en objeto generico por referencia
		/// </summary>
		/// <param name="archivo"></param>
		/// <param name="datos">true si pudo leer, ArchivosException sino</param>
		/// <returns></returns>
		public bool Leer(string archivo, out T datos)
		{
			try
			{
				XmlTextReader leer;
				XmlSerializer ser;
				leer = new XmlTextReader(archivo);
				ser = new XmlSerializer(typeof(T));
				datos = (T)ser.Deserialize(leer);
				leer.Close();
				return true;
			}
			catch(ArchivosException ex)
			{
				throw new ArchivosException(ex);
			}
		}
	}
}
