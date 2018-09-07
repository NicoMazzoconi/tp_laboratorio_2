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

namespace TP_01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void buttonLimpiar_Click(object sender, EventArgs e)
		{
			textNum1.Text = "";
			textNum2.Text = "";
			comboBoxOperator.Text = "";
			labelResult.Text = "";
		}

		private void buttonOperar_Click(object sender, EventArgs e)
		{
			Calculadora calc = new Calculadora();
			Numero num1 = new Numero(textNum1.Text);
			Numero num2 = new Numero(textNum2.Text);
			labelResult.Text = string.Format("{0}", calc.Operar(num1, num2, comboBoxOperator.Text));
		}

		private void buttonConvToBin_Click(object sender, EventArgs e)
		{
			labelResult.Text = Numero.DecimalBinario(textNum1.Text);
		}

		private void buttonConvToDecim_Click(object sender, EventArgs e)
		{
			labelResult.Text = Numero.BinarioDecimal(textNum1.Text);
		}
	}
}
