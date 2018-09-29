using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// La clase Producto no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    {
		private string codigoDeBarras;
		private ConsoleColor colorPrimarioEmpaque;
		private EMarca marca;

		/// <summary>
		/// Enum de marcas de productos
		/// </summary>
		public enum EMarca
        {
            Serenisima, Campagnola, Arcor, Ilolay, Sancor, Pepsico
        }

		/// <summary>
		/// Constructor recibe 3 parametros
		/// </summary>
		/// <param name="patente"></param>
		/// <param name="marca"></param>
		/// <param name="color"></param>
		public Producto(string patente, EMarca marca, ConsoleColor color)
		{
			this.codigoDeBarras = patente;
			this.marca = marca;
			this.colorPrimarioEmpaque = color;
		}

		/// <summary>
		/// Propiedad abstracta de Cantidad de Calorias
		/// </summary>
        public abstract short CantidadCalorias
		{
			get;
		}

        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
			return (string)this;
        }

		/// <summary>
		/// Casteo de string en producto, devuelve una string con los datos del producto
		/// </summary>
		/// <param name="p"></param>
        public static explicit operator string(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CODIGO DE BARRAS: " + p.codigoDeBarras + "\r\n");
            sb.AppendLine("MARCA          : " + p.marca.ToString() + "\r\n");
            sb.AppendLine("COLOR EMPAQUE  : " + p.colorPrimarioEmpaque.ToString() + "\r\n");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto v1, Producto v2)
        {
            return (v1.codigoDeBarras == v2.codigoDeBarras);
        }

        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto v1, Producto v2)
        {
            return !(v1.codigoDeBarras == v2.codigoDeBarras);
        }
    }
}
