using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
	public class DniInvalidoException	:Exception
	{
		private const string mensajeBase = "Dni invalido";

		/// <summary>
		/// Constructor por defecto que manda al constructor que recibe un parametro el mensajeBase
		/// </summary>
		public DniInvalidoException()	:this(mensajeBase)
		{}

		/// <summary>
		/// Constructor que recibe un parametro Exception y manda al constructor que recibe 2 parametros el mensaje base y la excepcion como inner
		/// </summary>
		/// <param name="ex"></param>
		public DniInvalidoException(Exception ex)	:this(mensajeBase, ex)
		{}

		/// <summary>
		/// Constructor que recibe un mensaje y manda al constructor que recibe dos paramentros el mensaje y un null como inner
		/// </summary>
		/// <param name="mensaje"></param>
		public DniInvalidoException(string mensaje)	:this(mensaje, null)
		{}

		/// <summary>
		/// Constructor que recibe un mensaje y una excpecion, y manda a la base el mensaje y la excepcion como inner
		/// </summary>
		/// <param name="mensaje"></param>
		/// <param name="ex"></param>
		public DniInvalidoException(string mensaje, Exception ex)	:base(mensaje, ex)
		{}
	}
}
