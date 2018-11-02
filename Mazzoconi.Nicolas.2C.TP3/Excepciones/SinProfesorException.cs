using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
	public class SinProfesorException	:Exception
	{
		/// <summary>
		/// Constructor por defecto que llama a la base y le envia un mensaje predeterminado
		/// </summary>
		public SinProfesorException() : base("No hay Profesor para la clase.")
		{}
	}
}
