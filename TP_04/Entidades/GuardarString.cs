using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Entidades
{
	public static class GuardarString
	{
		/// <summary>
		/// Metodo statico Guardar, recibe una string y un path, guarda la string en el archivo del path
		/// </summary>
		/// <param name="texto"></param>
		/// <param name="archivo"></param>
		/// <returns>true si lo logro</returns>
		public static bool Guardar(this string texto, string archivo)
		{
			StreamWriter sw = null;
			try
			{
				sw = new StreamWriter(archivo);
				sw.Write(texto);
				sw.Close();
				return true;
			}
			catch(Exception ex)
			{
				throw ex;
			}
			finally
			{
				if(sw != null)
				{
					sw.Close();
				}
			}
		}
	}
}
