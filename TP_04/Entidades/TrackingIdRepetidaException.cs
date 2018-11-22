using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class TrackingIdRepetidaException	:Exception
	{
		/// <summary>
		/// Constructor de la Exception recibe un mensaje y lo manda al constructor que recibe 2 variables
		/// </summary>
		/// <param name="mensaje"></param>
		public TrackingIdRepetidaException(string mensaje) : this(mensaje, null) { }

		/// <summary>
		/// Constructor de la Exception que recibe 2 variables, un mensaje y un inner, lo manda a la base
		/// </summary>
		/// <param name="mensaje"></param>
		/// <param name="inner"></param>
		public TrackingIdRepetidaException(string mensaje, Exception inner)	:base(mensaje, inner) { }
	}
}
