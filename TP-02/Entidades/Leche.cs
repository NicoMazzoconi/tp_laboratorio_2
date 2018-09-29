using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2018
{
    public class Leche : Producto
    {
		/// <summary>
		/// Tipo de leches
		/// </summary>
		public enum ETipo
		{
			Entera,
			Descremada
		}

        ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será ENTERA, constructor publico solo necesita los parametros de la base
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, string patente, ConsoleColor color) : base(patente, marca, color)
        {
            tipo = ETipo.Entera;
        }

		/// <summary>
		/// Constructor publico que pide los parametros de la base y ademas el tipo de leche
		/// </summary>
		/// <param name="marca"></param>
		/// <param name="patente"></param>
		/// <param name="color"></param>
		/// <param name="tipo"></param>
		public Leche(EMarca marca, string patente, ConsoleColor color, ETipo tipo)	:this(marca, patente, color)
		{
			this.tipo = tipo;
		}

        /// <summary>
        /// Las leches tienen 20 calorías, get de la propiedad abstracta CantidadCalorias de la clase Producto
        /// </summary>
        public override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }

		/// <summary>
		/// Muestra los datos de la clase base Producto y le agrega el dato de caloria y tipo de la clase Leche
		/// </summary>
		/// <returns></returns>
		public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("CALORIAS : " + this.CantidadCalorias);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
