using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace TP_04
{
	public partial class FrmPpal : Form
	{
		private Correo correo;
		public FrmPpal()
		{
			InitializeComponent();
			correo = new Correo();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnMostrarTodos_Click(object sender, EventArgs e)
		{
			this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
		}

		private void MostrarInformacion<T>(IMostrar<T> elemento)
		{
			if(elemento != null)
			{
				rtbMostrar.Text = elemento.MostrarDatos();

				try
				{
					GuardarString.Guardar(elemento.MostrarDatos(), "salida.txt");
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			Paquete p = new Paquete(txtDireccion.Text, mtxtTrackingID.Text);
			try
			{
				p.ErrorSql += ErrorSql;
				correo += p;
				p.InformarEstado += ActualizarEstados;
				ActualizarEstados();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void ActualizarEstados()
		{
			if (!(lstEstadoEntregado.InvokeRequired && lstEstadoEnViaje.InvokeRequired && lstEstadoIngresado.InvokeRequired))
			{
				lstEstadoEntregado.Items.Clear();
				lstEstadoEnViaje.Items.Clear();
				lstEstadoIngresado.Items.Clear();

				foreach (Paquete p in correo.Paquetes)
				{
					switch (p.Estado)
					{
						case Paquete.EEstado.Entregado:
							lstEstadoEntregado.Items.Add(p);
							break;
						case Paquete.EEstado.EnViaje:
							lstEstadoEnViaje.Items.Add(p);
							break;
						case Paquete.EEstado.Ingresado:
							lstEstadoIngresado.Items.Add(p);
							break;
					}
				}
			}
			else
			{
				Paquete.DelegadoEstado recall = new Paquete.DelegadoEstado(this.ActualizarEstados);
				this.Invoke(recall, new object[] {});
			}
		}

		private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
		{
			correo.FinEntregas();
		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{

		}

		private void ErrorSql(string mensaje)
		{
			MessageBox.Show(mensaje);
		}

		private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
		}
	}
}
