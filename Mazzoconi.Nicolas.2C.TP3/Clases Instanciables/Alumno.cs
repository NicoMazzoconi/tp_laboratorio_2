using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Excepciones;

namespace Clases_Instanciables
{
    public sealed class Alumno : Universitario
    {
        #region Atributos
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        #endregion

        #region Constructores

		/// <summary>
		/// Constructor por defecto
		/// </summary>
        public Alumno()
        {

        }

		/// <summary>
		/// Constructor que recibe 6 parametros de los cuales 5 manda a la base y el que queda lo setea
		/// </summary>
		/// <param name="id"></param>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <param name="dni"></param>
		/// <param name="nacionalidad"></param>
		/// <param name="claseQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)    :base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

		/// <summary>
		/// Constructor que recibe 7 paramentros, reutiliza el constructor de 6 paramentros y el que queda lo setea
		/// </summary>
		/// <param name="id"></param>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <param name="dni"></param>
		/// <param name="nacionalidad"></param>
		/// <param name="clasesQueToma"></param>
		/// <param name="estadoCuenta"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases clasesQueToma, EEstadoCuenta estadoCuenta)    :this(id, nombre, apellido, dni, nacionalidad, clasesQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        #endregion

        #region Enumerado

		/// <summary>
		/// Enumerado EEstadoCuenta, los estado en que puede estar la cuenta de un alumno
		/// </summary>
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
        #endregion

        #region Metodos

		/// <summary>
		/// Sobreescritura del metodo ParticiparEnClase, prepara una string con las clases que toma el alumno
		/// </summary>
		/// <returns>retorna la string</returns>
        protected override string ParticiparEnClase()
        {
            return "TOMA CLASE DE " + claseQueToma.ToString();
        }

		/// <summary>
		/// Sobreescritura del metodo MostrarDatos protegido, prepara una string con los datos de la base y de la misma clase
		/// </summary>
		/// <returns>retorna la string</returns>
        protected override string MostrarDatos()
        {
            return base.MostrarDatos() + " " + ParticiparEnClase() + ", su estado es: " + estadoCuenta.ToString();
        }

		/// <summary>
		/// Sobreescritura del metodo ToString, devuelve los datos del alumno
		/// </summary>
		/// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos();
        }

		/// <summary>
		/// Sobreescritura del operator ==, recibe un alumno y una clase, valida que el alumno tenga esa clase
		/// </summary>
		/// <param name="alumno"></param>
		/// <param name="clase"></param>
		/// <returns>true si la tiene, false sino</returns>
        public static bool operator ==(Alumno alumno, Universidad.EClases clase)
        {
            if (alumno.claseQueToma == clase && alumno.estadoCuenta != EEstadoCuenta.Deudor)
                return true;
            return false;
        }

		/// <summary>
		/// Sobreescritura del operator !=, recibe un alumno y una clase, valida reutilizando codigo del ==
		/// </summary>
		/// <param name="alumno"></param>
		/// <param name="clase"></param>
		/// <returns>true sino la tiene, false si la tiene</returns>
        public static bool operator !=(Alumno alumno, Universidad.EClases clase)
        {
            return !(alumno == clase);
        }
        #endregion
    }
}
