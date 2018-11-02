using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario    :Persona
    {
        #region Atributos
        private int legajo;
        #endregion

        #region Constructores

		/// <summary>
		/// Constructor por defecto
		/// </summary>
        public Universitario()
        { }

		/// <summary>
		/// Constructor que recibe 5 parametros, de los cuales 4 los manda a la base y el que queda lo asigna
		/// </summary>
		/// <param name="legajo"></param>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <param name="dni"></param>
		/// <param name="nacionalidad"></param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)    :base(nombre, apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region Metodos

		/// <summary>
		/// Metodo abstracto no implementado
		/// </summary>
		/// <returns></returns>
        protected abstract string ParticiparEnClase();

		/// <summary>
		/// Metodo virtual MostrarDatos protegido, prepara una string con todos los datos del universitario
		/// </summary>
		/// <returns>retorna la string creada</returns>
        protected virtual string MostrarDatos()
        {
            return base.ToString() + ", Legajo: " + legajo;
        }

		/// <summary>
		/// Sobreescritura del metodo Equals, recibe un obejeto y verifica si es Universitario
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>true si es, false si no</returns>
        public override bool Equals(object obj)
        {
			if (obj is Universitario)
				return true;
			return false;
        }

		/// <summary>
		/// Sobreescritura del operator ==, compara dos universitarios por tipo, dni y legajo
		/// </summary>
		/// <param name="pg1"></param>
		/// <param name="pg2"></param>
		/// <returns>true si son iguales, false si son diferentes</returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if (pg1.Equals(pg2) && (pg1.DNI == pg2.DNI || pg1.legajo == pg2.legajo))
                return true;
            return false;
        }

		/// <summary>
		/// Sobreescritura del operator !=, compara dos universitarios por tipo, dni y legajo, reutiliza codigo ==
		/// </summary>
		/// <param name="pg1"></param>
		/// <param name="pg2"></param>
		/// <returns>true si son diferentes, false si son iguales</returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        #endregion
    }
}
