using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AlumnoRepetidoException	:Exception
    {
		/// <summary>
		/// Constructor por defecto, que manda a la base un mensaje predeterminado
		/// </summary>
		public AlumnoRepetidoException()	:base("Alumno repetido.")
		{}
    }
}
