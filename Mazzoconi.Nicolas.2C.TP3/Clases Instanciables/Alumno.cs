using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    public sealed class Alumno : Universitario
    {
        #region Atributos
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        #endregion

        #region Constructores
        public Alumno()
        {

        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)    :base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases clasesQueToma, EEstadoCuenta estadoCuenta)    :this(id, nombre, apellido, dni, nacionalidad, clasesQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        #endregion

        #region Enumerado
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
        #endregion

        #region Metodos
        protected override string ParticiparEnClase()
        {
            return "TOMA CLASE DE " + claseQueToma.ToString();
        }

        protected override string MostrarDatos()
        {
            return base.MostrarDatos() + " " + ParticiparEnClase() + ", su estado es: " + estadoCuenta.ToString();
        }

        public override string ToString()
        {
            return MostrarDatos();
        }

        public static bool operator ==(Alumno alumno, Universidad.EClases clase)
        {
            if (alumno.claseQueToma == clase && alumno.estadoCuenta != EEstadoCuenta.Deudor)
                return true;
            return false;
        }

        public static bool operator !=(Alumno alumno, Universidad.EClases clase)
        {
            return !(alumno == clase);
        }
        #endregion
    }
}
