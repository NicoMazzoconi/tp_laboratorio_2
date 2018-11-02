using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    public sealed class Profesor : Universitario
    {
        #region Atributos
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;
        #endregion

        #region Constructores
        static Profesor()
        {
            random = new Random();
        }

        public Profesor()
        {
            
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) :base(id, nombre, apellido, dni, nacionalidad)
        {
            clasesDelDia = new Queue<Universidad.EClases>();
            _randomClases();
        }
        #endregion

        #region Metodos
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

        private void _randomClases()
        {
            for (int i = 0; i < 2; i++)
            {
                this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 3));
                System.Threading.Thread.Sleep(250);
            }
        }

        protected override string MostrarDatos()
        {
            return base.MostrarDatos() + " " + ParticiparEnClase();
        }

        public override string ToString()
        {
            return MostrarDatos();
        }

        public static bool operator ==(Profesor profe, Universidad.EClases clase)
        {
            foreach(Universidad.EClases a in profe.clasesDelDia)
            {
                if (a == clase)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Profesor profe, Universidad.EClases clase)
        {
            return !(profe == clase);
        }
        #endregion
    }
}
