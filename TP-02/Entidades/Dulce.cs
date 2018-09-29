using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Dulce : Producto
    {
		/// <summary>
		/// Constructor de Dulce que le pasa los datos a la base
		/// </summary>
		/// <param name="marca"></param>
		/// <param name="patente"></param>
		/// <param name="color"></param>
		public Dulce(EMarca marca, string patente, ConsoleColor color)	:base(patente, marca, color)
        {
        }

		/// <summary>
		/// Los dulces tienen 80 calorías, get del metodo abstracto CantidadCalorias de la clase Prodcuto
		/// </summary>
		public override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }

		/// <summary>
		/// Muestra los datos de la base producto mas los de la clase Dulce
		/// </summary>
		/// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("CALORIAS : " + this.CantidadCalorias);
			sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
