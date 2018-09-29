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

		public Numero()
		{
			this.numero = 0;
		}
		public Numero(double num)
		{
			this.numero = num;
		}
		public Numero(string strNum) 
		{
			this.SetNumero = strNum;
		}
		private static double ValidarNumero(string strNumero)
		{
			if (!(strNumero is null))
			{
				if (strNumero.Length > 0)
					for (int i = 0; i < strNumero.Length; i++)
					{
						if (strNumero[i] < '0' || strNumero[i] > '9')
							return 0;
					}
				else
					return 0;

				return double.Parse(strNumero);
			}
			return 0;
		}

		private string SetNumero
		{
			set
			{
				if (ValidarNumero(value) != 0)
					numero = double.Parse(value);
			}
		}

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

		public static string DecimalBinario(string strDecim)
		{
			double d;
			if(double.TryParse(strDecim, out d))
				return DecimalBinario(d);
			return "0";
		}

		public static double operator +(Numero n1, Numero n2)
		{
			if (!(n1 is null) || !(n2 is null))
				return n1.numero + n2.numero;
			return 0;
		}

		public static double operator -(Numero n1, Numero n2)
		{
			if (!(n1 is null) || !(n2 is null))
				return n1.numero - n2.numero;
			return 0;
		}

		public static double operator *(Numero n1, Numero n2)
		{
			if (!(n1 is null) || !(n2 is null))
				return n1.numero * n2.numero;
			return 0;
		}

		public static double operator /(Numero n1, Numero n2)
		{
			if (!(n1 is null) || !(n2 is null))
				if (n2.numero != 0)
					return n1.numero / n2.numero;
			return 0;
		}
	}
}
