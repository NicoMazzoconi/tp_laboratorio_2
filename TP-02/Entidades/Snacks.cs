using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Snacks	:Producto
    {
		/// <summary>
		/// Constructor que recibe 3 parametros de la clase base Producto
		/// </summary>
		/// <param name="marca"></param>
		/// <param name="patente"></param>
		/// <param name="color"></param>
		public Snacks(EMarca marca, string patente, ConsoleColor color) : base(patente, marca, color)
        {
        }

        /// <summary>
        /// Los snacks tienen 104 calorías, propiedad abstracta CantidadCalorias de la clase Producto
        /// </summary>
        public override short CantidadCalorias
        {
            get
            {
                return 104;
            }
        }

		/// <summary>
		/// Muestra los datos de la clase base agregando los datos de la clase Snack
		/// </summary>
		/// <returns></returns>
		public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SNACKS");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("CALORIAS : " + this.CantidadCalorias);
			sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
