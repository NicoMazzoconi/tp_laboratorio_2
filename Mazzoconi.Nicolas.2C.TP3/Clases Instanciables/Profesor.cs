using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace Clases_Instanciables
{
    public sealed class Profesor : Universitario
    {
        #region Atributos
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;
        #endregion

        #region Constructores

		/// <summary>
		/// Constructor statico, inicializa el atributo static random
		/// </summary>
        static Profesor()
        {
            random = new Random();
        }

		/// <summary>
		/// Constructor por defecto
		/// </summary>
        public Profesor()
        {
            
        }

		/// <summary>
		/// Constructor que recibe 5 parametros, y los asigna en la base, inicializa el atributo clasesDelDia y le asigna dos clases random
		/// </summary>
		/// <param name="id"></param>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <param name="dni"></param>
		/// <param name="nacionalidad"></param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) :base(id, nombre, apellido, dni, nacionalidad)
        {
            clasesDelDia = new Queue<Universidad.EClases>();
            _randomClases();
        }
        #endregion

        #region Metodos

		/// <summary>
		/// Sobreescritura ParticiparEnClase protegido, crea una string con las clases que tiene el profesor
		/// </summary>
		/// <returns>retorna la string</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CLASES DEL DIA ");
            foreach(Universidad.EClases a in clasesDelDia)
            {
                sb.AppendFormat(a.ToString() + " ");
            }
            return sb.ToString();
        }

		/// <summary>
		/// Metodo _randomClases, asigna aleatoriamente dos clases al profesor
		/// </summary>
        private void _randomClases()
        {
            for (int i = 0; i < 2; i++)
            {
                this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 3));
                System.Threading.Thread.Sleep(250);
            }
        }

		/// <summary>
		/// Sobreescritura del metodo MostrarDatos protegido, crea una string con todos los datos del profesor y su base
		/// </summary>
		/// <returns>retorna la string</returns>
        protected override string MostrarDatos()
        {
            return base.MostrarDatos() + " " + ParticiparEnClase();
        }

		/// <summary>
		/// Sobreescritura del metodo ToString, llama al MostrarDatos
		/// </summary>
		/// <returns>la string recibida por MostrarDatos</returns>
        public override string ToString()
        {
            return MostrarDatos();
        }

		/// <summary>
		/// Sobreescritura del operator ==, recibe un profesor y una clase, valida que el profesor de esa clase
		/// </summary>
		/// <param name="profe"></param>
		/// <param name="clase"></param>
		/// <returns>true si la da, false sino</returns>
        public static bool operator ==(Profesor profe, Universidad.EClases clase)
        {
            foreach(Universidad.EClases a in profe.clasesDelDia)
            {
                if (a == clase)
                    return true;
            }
            return false;
        }

		/// <summary>
		/// Sobreescritura del operator !=, recibe un profesor y una clase, valida que el profesor no de esa clase
		/// </summary>
		/// <param name="profe"></param>
		/// <param name="clase"></param>
		/// <returns>true si no la da, false si la da</returns>
		public static bool operator !=(Profesor profe, Universidad.EClases clase)
        {
            return !(profe == clase);
        }
        #endregion
    }
}
