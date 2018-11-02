using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Clases_Instanciables
{
    public class Jornada
    {
        #region Atribuos
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        #endregion

        #region Constructores

		/// <summary>
		/// Constructor por defecto que inicializa la lista alumnos
		/// </summary>
        private Jornada()
        {
            alumnos = new List<Alumno>();
        }

		/// <summary>
		/// Constructor que recibe 2 parametros y los setea, llama al constructor por defecto para inicializar la lista
		/// </summary>
		/// <param name="clase"></param>
		/// <param name="instructor"></param>
        public Jornada(Universidad.EClases clase, Profesor instructor)  :this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }
		#endregion

		#region Metodos

		/// <summary>
		/// Sobreescritura del metodo ToString, crea una string con todos los datos de la jornada
		/// </summary>
		/// <returns>retorna el string creado</returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("Clase: " + clase.ToString() + ".\nProfesor: \n\t" + instructor.ToString() + "\nAlumnos:\n");
			foreach(Alumno a in alumnos)
			{
				sb.AppendLine("\t" + a.ToString());
			}
			return sb.ToString();
		}

		/// <summary>
		/// Sobreescritura del operator ==, recibe una jornada y un alumno, valida que el alumno este en la misma clase que la jornada
		/// </summary>
		/// <param name="jornada"></param>
		/// <param name="alumno"></param>
		/// <returns>true si esta, false sino</returns>
		public static bool operator ==(Jornada jornada, Alumno alumno)
		{
			return alumno == jornada.clase;
		}

		/// <summary>
		/// Sobreescritura del operator !=, recibe una jornada y un alumno, valida que el alumno no este en la misma clase que la jornada
		/// </summary>
		/// <param name="jornada"></param>
		/// <param name="alumno"></param>
		/// <returns>true sino esta, false si esta</returns>
		public static bool operator !=(Jornada jornada, Alumno alumno)
		{
			return !(jornada == alumno);
		}

		/// <summary>
		/// Sobreescritura del operator +, recibe una jornada y un alumno, valida que el alumno no este en la lista de alumnos de la jornada
		/// y si no esta lo agrega
		/// </summary>
		/// <param name="jornada"></param>
		/// <param name="alumno"></param>
		/// <returns>retorna la jornada con o sin el alumno agregado</returns>
		public static Jornada operator +(Jornada jornada, Alumno alumno)
		{
			foreach(Alumno alJor in jornada.alumnos)
			{
				if (alumno == alJor)
					return jornada;
			}
			jornada.alumnos.Add(alumno);
			return jornada;
		}

		/// <summary>
		/// Metodo statico Guardar, recibe una jornada y guarda todos sus datos en un txt
		/// </summary>
		/// <param name="jor"></param>
		/// <returns>true si pudo guardarlo, false sino, ArchivosException si hay un error con el path</returns>
		public static bool Guardar(Jornada jor)
		{
			Texto archivoTxt = new Texto();
			return archivoTxt.Guardar("Jornada.txt", jor.ToString());
		}

		/// <summary>
		/// Metodo Leer, crea una string con los datos leidos de un archivo
		/// </summary>
		/// <returns>string con los datos</returns>
		public string Leer()
		{
			Texto archivoTxt = new Texto();
			string datos;
			archivoTxt.Leer("Jornada.txt", out datos);
			return datos;
		}
		#endregion
	}
}
