using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
		/// <summary>
		/// Metodo privador ValidarOperador, recibe una string y valida que sea, +, -, * o /
		/// </summary>
		/// <param name="operador"></param>
		/// <returns>Si es uno de los 4 lo retorna sino retorna +</returns>
		private static string ValidarOperador(string operador)
		{
			switch(operador)
			{
				case "-":
					return "-";
				case "*":
					return "*";
				case "/":
					return "/";
				default:
					return "+";
			}
		}

		/// <summary>
		/// Metodo publico Operar, recibe 2 obj Numero y una string operador, realiza el calculo recibido al usar
		/// ValidarOperar con la string
		/// </summary>
		/// <param name="num1"></param>
		/// <param name="num2"></param>
		/// <param name="operador"></param>
		/// <returns>Retorna el calculo</returns>
		public double Operar(Numero num1, Numero num2, string operador)
		{
			double resultado = 0;
			switch(ValidarOperador(operador))
			{
				case "-":
					resultado = num1 - num2;
					break;
				case "*":
					resultado = num1 * num2;
					break;
				case "/":
					resultado = num1 / num2;
					break;
				case "+":
					resultado = num1 + num2;
					break;
			}
			return resultado;
		}
    }
}
