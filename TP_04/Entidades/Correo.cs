using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
	public class Correo	:IMostrar<List<Paquete>>
	{
		List<Thread> mockPaquetes;
		List<Paquete> paquetes;

		/// <summary>
		/// Constructor por defecto que inicializa las listas
		/// </summary>
		public Correo()
		{
			mockPaquetes = new List<Thread>();
			paquetes = new List<Paquete>();
		}

		/// <summary>
		/// Propiedad escritura y lectura de la lista de paquetes
		/// </summary>
		public List<Paquete> Paquetes
		{
			get
			{
				return paquetes;
			}
			set
			{
				paquetes = value;
			}
		}

		/// <summary>
		/// Metodo que aborta todos los hilos vivos
		/// </summary>
		public void FinEntregas()
		{
			foreach(Thread t in mockPaquetes)
			{
				if (t.IsAlive)
					t.Abort();
			}
		}

		/// <summary>
		/// Metodo que construye una string con la informacion de los paquetes de la lista
		/// </summary>
		/// <returns>La string construida</returns>
		public string MostrarDatos()
		{
			StringBuilder sb = new StringBuilder();
			foreach (Paquete p in paquetes)
			{
				sb.AppendLine(p.ToString());
			}
			return sb.ToString();
		}

		/// <summary>
		/// Sobreescritura del operator +, recibe un correo y un paquete, verifica que el paquete no pertenezca al correo para agregarlo
		/// una vez agregado crea un hilo y con el puntero del metodo MockCicloDeVida del paquete y lo inicia
		/// </summary>
		/// <param name="c"></param>
		/// <param name="p"></param>
		/// <returns>Retorna el correo con el paquete agregado</returns>
		public static Correo operator +(Correo c, Paquete p)
		{
			foreach (Paquete a in c.Paquetes)
			{
				if (a == p)
					throw new TrackingIdRepetidaException("TrackingID repetido");
			}
			c.Paquetes.Add(p);
			Thread t = new Thread(p.MockCicloDeVida);
			c.mockPaquetes.Add(t);
			t.Start();
			return c;
		}
	}
}
