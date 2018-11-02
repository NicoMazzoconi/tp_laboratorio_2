using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        #region Atributos
        private string apellido;
        private string nombre;
        private int dni;
        private ENacionalidad nacionalidad;
        #endregion

        #region Enum
		/// <summary>
		/// Enumerado Nacionalidades
		/// </summary>
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
        #endregion

        #region Constructores
		/// <summary>
		/// Constructor por defecto
		/// </summary>
        public Persona()
        {

        }

		/// <summary>
		/// Constructor que recibe 3 parametros y los setea
		/// </summary>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

		/// <summary>
		/// Constructor que recibe 4 parametros y re utiliza el constructor de 3 y setea el atributo que queda
		/// </summary>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <param name="dni"></param>
		/// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) :this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }

		/// <summary>
		/// Constructor que recibe 4 parametros y re utiliza el constructor de 3 y setea el atributo que queda
		/// </summary>
		/// <param name="nombre"></param>
		/// <param name="apellido"></param>
		/// <param name="dni"></param>
		/// <param name="nacionalidad"></param>
		public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)  :this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion

        #region Propiedades

		/// <summary>
		/// Propiedad de lectura y escritura Nombre, get retorna nombre y set valida nombre y setea
		/// </summary>
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (!(ValidarNombreApellido(value) is null))
                    nombre = value;
            }
        }

		/// <summary>
		/// Propiedad de lectura y escritura Apellido, get retorna nombre y set valida apellido y setea
		/// </summary>
		public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                if (!(ValidarNombreApellido(value) is null))
                    apellido = value;
            }
        }

		/// <summary>
		/// Propiedad de lectura y escritura Nacionalidad, get retorna nacionalidad y setea nacionalidad
		/// </summary>
		public ENacionalidad Nacionalidad
        {
            get
            {
                return nacionalidad;
            }
            set
            {
                nacionalidad = value;
            }
        }

		/// <summary>
 		/// Propiedad de lectura y escritura Dni, get retorna dni y set valida dni y setea
		/// </summary>
        public int DNI
        {
            get
            {
                return dni;
            }
            set
            {
                 dni = ValidarDni(nacionalidad, value);            
            }
        }

		/// <summary>
		/// Propiedad solo escritura Dni, valida y setea
		/// </summary>
        public string StringToDNI
        {
            set
            {
                this.DNI = ValidarDni(nacionalidad, value);
            }
        }
        #endregion

        #region Metodos

		/// <summary>
		/// Metodo ValidarDni, recibe nacionalidad y dni, y valida que sea un dni valido y que concuerde con la nacionalidad
		/// </summary>
		/// <param name="nacionalidad"></param>
		/// <param name="dato"></param>
		/// <returns>dni si es valido, NacionalidadInvalidaException si no concuerda la nacionalidad y 
		/// DniInvalidoException si el dni no es valido</returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (dato < 1 || dato > 99999999)
                throw new DniInvalidoException("Dni invalido");
            else
            {
                if (dato > 0 && dato < 90000000 && nacionalidad == ENacionalidad.Argentino)
                    return dato;
                else
                {
					if (dato > 89999999 && dato < 100000000 && nacionalidad == ENacionalidad.Extranjero)
						return dato;
					else
						throw new NacionalidadInvalidaException("Nacionalidad invalida");
                }            
            }
        }

		/// <summary>
		/// Metodo ValidarDni, recibe nacionalidad y dni como string, y valida que sea un dni valido y que concuerde con la nacionalidad
		/// </summary>
		/// <param name="nacionalidad"></param>
		/// <param name="dato"></param>
		/// <returns>dni si es validom Dni, InvalidoException si es invalido 
		/// y NacionalidadInvalidaException si no concuerda la nacionalidad</returns>
		private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dni;
            if (int.TryParse(dato, out dni))
            {
                return ValidarDni(nacionalidad, dni);
            }
            else
                throw new DniInvalidoException("Dni invalido");
        }

		/// <summary>
		/// Metodo ValidarNombreApellido valida una cadena de string y valida que no tenga caracteres especiales
		/// </summary>
		/// <param name="dato"></param>
		/// <returns>el dato si es valido, null si es invalido</returns>
        private string ValidarNombreApellido(string dato)
        {
            foreach(char a in dato)
            {
                if (!((a >= 'a' && a <= 'z') || (a >= 'A' && a <= 'Z') || (a == ' ')))
                    return null;
            }
            return dato;
        }

		/// <summary>
		/// Metodo sobreescrito ToString, prepara una string con todos los datos de la persona
		/// </summary>
		/// <returns>retorna la string creada</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre completo: {0} {1}, Dni: {2}, Nacionalidad: {3}", Nombre, Apellido, DNI, Nacionalidad.ToString());
            return sb.ToString();
        }
        #endregion
    }
}
