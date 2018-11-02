using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas
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
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
        #endregion

        #region Constructores
        public Persona()
        {

        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) :this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)  :this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion

        #region Propiedades
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

        public string StringToDNI
        {
            set
            {
                this.DNI = ValidarDni(nacionalidad, value);
            }
        }
        #endregion

        #region Metodos
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (dato < 1 || dato > 99999999)
                throw new NotImplementedException();
            else
            {
                if (dato > 0 && dato < 90000000 && nacionalidad == ENacionalidad.Argentino)
                    return dato;
                else
                {
                    if (dato > 89999999 && dato < 100000000 && nacionalidad == ENacionalidad.Extranjero)
                        return dato;
                    else
                        throw new NotImplementedException();
                }            
            }
        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dni;
            if (int.TryParse(dato, out dni))
            {
                return ValidarDni(nacionalidad, dni);
            }
            else
                throw new NotImplementedException();
        }

        private string ValidarNombreApellido(string dato)
        {
            foreach(char a in dato)
            {
                if (!((a >= 'a' && a <= 'z') || (a >= 'A' && a <= 'Z')))
                    return null;
            }
            return dato;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre completo: {0} {1}, Dni: {2}, Nacionalidad: {3}", Nombre, Apellido, DNI, Nacionalidad.ToString());
            return sb.ToString();
        }
        #endregion
    }
}
