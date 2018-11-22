using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paquete	:IMostrar<Paquete>
    {
		public delegate void DelegadoEstado();
		public event DelegadoEstado InformarEstado;

		public delegate void DelegadoErrorSql(string mensaje);
		public event DelegadoErrorSql ErrorSql;

		private string direccionEntrega;
		private EEstado estado;
		private string trackingID;

		/// <summary>
		/// Enumerado EEstado, estado del paquete
		/// </summary>
		public enum EEstado
		{
			Ingresado,
			EnViaje,
			Entregado
		}

		/// <summary>
		/// Constructor de Paquete, recibe direccion y un ID, y los asigna
		/// </summary>
		/// <param name="direccionEntrega"></param>
		/// <param name="trackingID"></param>
		public Paquete(string direccionEntrega, string trackingID)
		{
			this.direccionEntrega = direccionEntrega;
			this.trackingID = trackingID;
		}

		/// <summary>
		/// Propiedad de escritura y lectura, de la direccionEntrega
		/// </summary>
		public string DireccionEntrega
		{
			get
			{
				return direccionEntrega;
			}
			set
			{
				direccionEntrega = value;
			}
		}

		/// <summary>
		/// Propiedad de escritura y lectura, del estado
		/// </summary>
		public EEstado Estado
		{
			get
			{
				return estado;
			}
			set
			{
				estado = value;
			}
		}

		/// <summary>
		/// Propiedad de escritura y lectura, del trackingID
		/// </summary>
		public string TrackingID
		{
			get
			{
				return trackingID;
			}
			set
			{
				trackingID = value;
			}
		}

		/// <summary>
		/// Sobreescritura del operator ==, recibe dos paquetes y compara su trackingID
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>true si son iguales, false si son diferentes</returns>
		public static bool operator ==(Paquete a, Paquete b)
		{
			if (a.TrackingID == b.TrackingID)
				return true;
			return false;
		}

		/// <summary>
		/// Sobreescritura del operator !=, recibe dos paquetes y compara su trackingID
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>true si son diferentes, false si son iguales</returns>
		public static bool operator !=(Paquete a, Paquete b)
		{
			return !(a == b);
		}

		/// <summary>
		/// Metodo que cambia el estado del paquete cada 2 segudos y por ultimo lo inserta en la base de datos
		/// </summary>
		public void MockCicloDeVida()
		{
			while (estado != EEstado.Entregado)
			{
				System.Threading.Thread.Sleep(4000);
				if (estado == EEstado.Ingresado)
				{
					estado = EEstado.EnViaje;
				}
				else
				{
					estado = EEstado.Entregado;
				}
				InformarEstado.Invoke();
			}
			try
			{
				PaqueteDAO.Insertar(this);
			}
			catch(Exception ex)
			{
				ErrorSql.Invoke(ex.Message);
			}
		}

		/// <summary>
		/// Metodo MostrarDatos, retorna una string con el trackingID y la direccion de entrega del paquetes
		/// </summary>
		/// <returns>La string</returns>
		public string MostrarDatos()
		{
			return string.Format("{0} ({1})", this.ToString(), this.Estado);
		}

		/// <summary>
		/// Sobreescritura del metodo ToString, crea una string con el MostrarDatos y el estado del paquete
		/// </summary>
		/// <returns>La string</returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("{0} para {1}", this.TrackingID, this.DireccionEntrega);
			return sb.ToString();
		}
	}
}
