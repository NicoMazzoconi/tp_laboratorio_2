using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
	public class NacionalidadInvalidaException	:Exception
	{
		/// <summary>
		/// Constructor por defecto, que llama al constructor por defecto de la base
		/// </summary>
		public NacionalidadInvalidaException()	:base()
		{ }

		/// <summary>
		/// Constructor que recibe un mensaje, y lo envia a la base
		/// </summary>
		/// <param name="mensaje"></param>
		public NacionalidadInvalidaException(string mensaje)	:base(mensaje)
		{ }
	}
}
