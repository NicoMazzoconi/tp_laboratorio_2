using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Numero
	{
		private double numero;

		/// <summary>
		/// Constructor por defecto asigna 0
		/// </summary>
		public Numero()
		{
			this.numero = 0;
		}

		/// <summary>
		/// Constructor publico que recibe un double y lo envia como string al constructor que recibe string
		/// </summary>
		/// <param name="num"></param>
		public Numero(double num)	:this(num.ToString())
		{

		}

		/// <summary>
		/// Constrcutor publico que recibe una string y la setea
		/// </summary>
		/// <param name="strNum"></param>
		public Numero(string strNum)
		{
			SetNumero = strNum;
		}

		/// <summary>
		/// Metodo privado ValidarNumero, valida que el string sea todo numero
		/// </summary>
		/// <param name="strNumero"></param>
		/// <returns>Retorna el numero si es, sino un 0</returns>
		private static double ValidarNumero(string strNumero)
		{
			if (double.TryParse(strNumero, out double auxiliar))
				return auxiliar;
			return 0;
		}

		/// <summary>
		/// Propiedad de escritura SetNumero, utiliza el metodo validarnumero para setear el value
		/// </summary>
		private string SetNumero
		{
			set
			{
				numero = ValidarNumero(value);
			}
		}

		/// <summary>
		/// Metodo statico BinarioDecimal recibe una string con un numero binario y lo transforma a decimal
		/// </summary>
		/// <param name="binario"></param>
		/// <returns>Si es un binario valido lo convierte y lo retonra sino retorna 0</returns>
		public static string BinarioDecimal(string binario)
		{
			char[] charArray = binario.ToCharArray();
			Array.Reverse(charArray);
			double decim = 0;
			int tam = binario.Length;
			int i;
			for (i = 0; i < tam; i++)
			{
				if (charArray[i] != '0' && charArray[i] != '1')
					return "0";
			}
			for (i = 0; i < tam; i++)
			{
				if (charArray[i] == '1')
				{
					decim = decim + Math.Pow(2, i);
				}
			}
			return string.Format("{0}", decim);
		}

		/// <summary>
		/// Metodo statico DecimalBinario, recibe un double y lo transforma a binario
		/// </summary>
		/// <param name="decim"></param>
		/// <returns>Retorna una string con el numero binario, si el numero es negativo retorna null</returns>
		public static string DecimalBinario(double decim)
		{
			string binario = "";
			if (decim >= 0)
			{
				while (decim > 0)
				{
					if (decim % 2 == 0)
					{
						binario = "0" + binario;
					}
					else
					{
						binario = "1" + binario;
					}
					decim = (int)decim / 2;
				}
			}
			else
			{
				return null;
			}
			return binario;
		}

		/// <summary>
		/// Metodo statico DecimalBinario, recibe una string y lo transforma a binario si es valida
		/// </summary>
		/// <param name="strDecim"></param>
		/// <returns>Retorna el numero en binario si se pudo convertir sino 0</returns>
		public static string DecimalBinario(string strDecim)
		{
			double d;
			if(double.TryParse(strDecim, out d))
				return DecimalBinario(d);
			return "0";
		}

		/// <summary>
		/// Sobrecarga operador +, recibe dos obj Numero y los suma
		/// </summary>
		/// <param name="n1"></param>
		/// <param name="n2"></param>
		/// <returns>La suma si son los dos valido, 0 si alguno es null</returns>
		public static double operator +(Numero n1, Numero n2)
		{
			if (!(n1 is null) || !(n2 is null))
				return n1.numero + n2.numero;
			return 0;
		}

		/// <summary>
		/// Sobrecarga operador -, recibe dos obj Numero y los resta
		/// </summary>
		/// <param name="n1"></param>
		/// <param name="n2"></param>
		/// <returns>La resta si los dos son valido, 0 si alguno es null</returns>
		public static double operator -(Numero n1, Numero n2)
		{
			if (!(n1 is null) || !(n2 is null))
				return n1.numero - n2.numero;
			return 0;
		}

		/// <summary>
		/// Sobrecarga operador *, recibe dos obj Numero y los multiplica
		/// </summary>
		/// <param name="n1"></param>
		/// <param name="n2"></param>
		/// <returns>La multiplicacion si son los dos validos, 0 si alguno es null</returns>
		public static double operator *(Numero n1, Numero n2)
		{
			if (!(n1 is null) || !(n2 is null))
				return n1.numero * n2.numero;
			return 0;
		}

		/// <summary>
		/// Sobrecarga operador /, recibe dos Obj Numero y los divide, comparandoque obj2 no sea 0
		/// </summary>
		/// <param name="n1"></param>
		/// <param name="n2"></param>
		/// <returns>Si alguno es null o obj 2 es 0 entonces retorna 0, sino retorna la division</returns>
		public static double operator /(Numero n1, Numero n2)
		{
			if (!(n1 is null) || !(n2 is null))
				if (n2.numero != 0)
					return n1.numero / n2.numero;
			return 0;
		}
	}
}
