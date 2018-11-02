using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Excepciones;
using Archivos;

namespace Clases_Instanciables
{
    public class Universidad
    {
        #region Atributos
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        #endregion

        #region Enum

		/// <summary>
		/// Enumerado EClases, todas las clases que hay en la universidad
		/// </summary>
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
		#endregion

		#region Constructores

		/// <summary>
		/// Constructor por defecto, inicializa las listas
		/// </summary>
		public Universidad()
		{
			alumnos = new List<Alumno>();
			jornada = new List<Jornada>();
			profesores = new List<Profesor>();
		}
		#endregion

		#region Propiedades

		/// <summary>
		/// Propiedad escritura lectura de List<Alumno>, get retorna la lista, set la asigna 
		/// </summary>
		public List<Alumno> Alumnos
		{
			get
			{
				return alumnos;
			}
			set
			{
				alumnos = value;
			}
		}

		/// <summary>
		/// Propiedad escritura lectura de List<Jornada>, get retorna la lista, set la asigna 
		/// </summary>
		public List<Jornada> Jornadas
		{
			get
			{
				return jornada;
			}
			set
			{
				jornada = value;
			}
		}

		/// <summary>
		/// Propiedad escritura lectura de List<Profesor>, get retorna la lista, set la asigna 
		/// </summary>
		public List<Profesor> Profesores
		{
			get
			{
				return profesores;
			}
			set
			{
				profesores = value;
			}
		}

		/// <summary>
		/// Propiedad escritura lectura de Jornada[i], get retorna la jornada en i, set la asigna 
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		public Jornada this[int i]
		{
			get
			{
				return jornada[i];
			}
			set
			{
				jornada[i] = value;
			}
		}
		#endregion

		#region Metodos

		/// <summary>
		/// Metodo static MostrarDatos, recibe una universidad y crea una string con toda la informacion de la universidad
		/// </summary>
		/// <param name="uni"></param>
		/// <returns>retorna la string</returns>
		private static string MostrarDatos(Universidad uni)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("<---------------------------------------------------------------------->");
			sb.AppendLine("Jornadas:\n");
			foreach (Jornada j in uni.Jornadas)
			{
				sb.AppendLine(j.ToString());
			}
			sb.AppendLine("<---------------------------------------------------------------------->");
			sb.AppendFormat("Alumnos:\n");
			foreach (Alumno a in uni.Alumnos)
			{
				sb.AppendLine(a.ToString());
			}
			sb.AppendLine("<---------------------------------------------------------------------->");
			sb.AppendLine("Profesores:\n");
			foreach (Profesor p in uni.Profesores)
			{
				sb.AppendLine(p.ToString());
			}
			sb.AppendLine("<---------------------------------------------------------------------->");
			return sb.ToString();
		}

		/// <summary>
		/// Sobreescritura ToString, llama al MostrarDatos
		/// </summary>
		/// <returns>retorna lo recibido por MostrarDatos</returns>
		public override string ToString()
		{
			return MostrarDatos(this);
		}

		/// <summary>
		/// Sobreescritura del operator ==, recibe una universidad y un alumno, valida que el alumno este en la lista de alumnos de la universidad
		/// </summary>
		/// <param name="uni"></param>
		/// <param name="alu"></param>
		/// <returns>true si esta, false si no esta</returns>
		public static bool operator ==(Universidad uni, Alumno alu)
		{
			foreach (Alumno a in uni.Alumnos)
				if (alu == a)
					return true;
			return false;
		}

		/// <summary>
		/// Sobreescritura del operator !=, recibe una universidad y un alumno, valida que el alumno no este en la lista de alumnos de la universidad
		/// </summary>
		/// <param name="uni"></param>
		/// <param name="alu"></param>
		/// <returns>true si no esta, false si esta</returns>
		public static bool operator !=(Universidad uni, Alumno alu)
		{
			return !(uni == alu);
		}

		/// <summary>
		/// Sobreescritura del operator ==, recibe una universidad y un profesor, valida que el profesor este en la lista de profesores de la universidad
		/// </summary>
		/// <param name="uni"></param>
		/// <param name="profe"></param>
		/// <returns>true si esta, false sino</returns>
		public static bool operator ==(Universidad uni, Profesor profe)
		{
			foreach (Profesor p in uni.Profesores)
				if (p == profe)
					return true;
			return false;
		}

		/// <summary>
		/// Sobreescritura del operator !=, recibe una universidad y un profesor, valida que el profesor no este en la lista de profesores de la universidad
		/// </summary>
		/// <param name="uni"></param>
		/// <param name="profe"></param>
		/// <returns>true si no esta, false si esta</returns>
		public static bool operator !=(Universidad uni, Profesor profe)
		{
			return !(uni == profe);
		}

		/// <summary>
 		/// Sobreescritura del operator ==, recibe una universidad y una clase, busca el primer profesor de la lista de profesores que pueda dar la clase
		/// </summary>
		/// <param name="uni"></param>
		/// <param name="clase"></param>
		/// <returns>retorna el prodesor, sino hay SinProfesorException</returns>
		public static Profesor operator ==(Universidad uni, EClases clase)
		{
			foreach (Profesor p in uni.Profesores)
				if (p == clase)
					return p;
			throw new SinProfesorException();
		}

		/// <summary>
		/// Sobreescritura del operator !=, recibe una universidad y una clase, busca el primer profesor de la lista de profesores que no pueda dar la clase
		/// </summary>
		/// <param name="uni"></param>
		/// <param name="clase"></param>
		/// <returns>retorna el primer profesor en no poder dar la clase, sino null</returns>
		public static Profesor operator !=(Universidad uni, EClases clase)
		{
			foreach (Profesor p in uni.Profesores)
				if (p != clase)
					return p;
			return null;
		}

		/// <summary>
		/// Sobreescritura del operator +, recibe una universidad y un alumno, agrega el alumno a la lista de la universidad, si el no pertence a ella
		/// </summary>
		/// <param name="uni"></param>
		/// <param name="alu"></param>
		/// <returns>Universidad con el alumno agregado, AlumnoRepetidoException</returns>
		public static Universidad operator +(Universidad uni, Alumno alu)
		{
			if (uni != alu)
			{
				uni.alumnos.Add(alu);
				return uni;
			}
			else
				throw new AlumnoRepetidoException();
		}

		/// <summary>
		/// Sobreescritura del operator +, recibue una universidad y un profesor, valida que el profesor no pertenezca a la universidad y lo asigna 
		/// </summary>
		/// <param name="uni"></param>
		/// <param name="profe"></param>
		/// <returns>retorna la universidad con o sin el profesor agregado</returns>
		public static Universidad operator +(Universidad uni, Profesor profe)
		{
			if (uni != profe)
				uni.profesores.Add(profe);
			return uni;
		}

		/// <summary>
		/// Sobreescritura del operator +, recibe una universidad y una clase, crea una jornada para la clase y le asigna un profesor 
		/// y la agrega a la universidad
		/// </summary>
		/// <param name="uni"></param>
		/// <param name="clase"></param>
		/// <returns>retorna la universidad con la jornada agregada en caso de que halla profesor, sino retorna la misma universidad</returns>
		public static Universidad operator +(Universidad uni, EClases clase)
		{
			Profesor auxProfe = (uni == clase);
			if (auxProfe != null)
			{
				Jornada auxJor = new Jornada(clase, auxProfe);
				foreach(Alumno a in uni.Alumnos)
				{
					if (a == clase)
						auxJor += a;
				}
				uni.jornada.Add(auxJor);
			}
			return uni;
		}

		/// <summary>
		/// Metodo estatico guardar, recibe una universidad y la serializa y la guarda en un archivo
		/// </summary>
		/// <param name="uni"></param>
		/// <returns>true si logra guardar, ArchivoException si no pudo guardar</returns>
		public static bool Guardar(Universidad uni)
		{
			Xml<Universidad> xml = new Xml<Universidad>();
			return xml.Guardar("universidad.xml", uni);
		}
		#endregion
	}
}
