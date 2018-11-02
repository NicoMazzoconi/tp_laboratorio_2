using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
	public class ArchivosException	:Exception
	{
		/// <summary>
		/// Constructor por defecto que recibe una excepcion y manda a la base un mensaje por defecto y la exceptcion como inner
		/// </summary>
		/// <param name="innerException"></param>
		public ArchivosException(Exception innerException)	:base("Error al guardar en el archivo", innerException)
		{}
	}
}
