﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patentes;
using Entidades;
using Archivos;
using System.Threading;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        Queue<Patente> cola;
        List<Thread> hilos;
        public FrmPpal()
        {
            InitializeComponent();

            this.cola = new Queue<Patente>();
            this.hilos = new List<Thread>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            vistaPatente3.FinExposicion += ProximaPatente;
            vistaPatente4.FinExposicion += ProximaPatente;
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            Xml<List<Patente>> a = new Xml<List<Patente>>();
            List<Patente> auxLs = new List<Patente>();
            
            try
            {
                a.Leer("patentes.xml", out auxLs);
                foreach (Patente p in auxLs)
                {
                    cola.Enqueue(p);
                }
                IniciarSimulacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            Texto txt = new Texto();
            txt.Leer("patentes.txt", out cola);
            IniciarSimulacion();
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            Sql sql = new Sql();
            try
            {
                sql.Leer("Patentes", out cola);
                IniciarSimulacion();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FinalizarSimulacion()
        {
            foreach(Thread t in hilos)
            {
                if (t.IsAlive)
                    t.Abort();
            }
        }

        public void ProximaPatente(VistaPatente vp)
        {
            if (cola.Count > 0 && cola != null)
            {
                Thread t = new Thread(new ParameterizedThreadStart(vp.MostrarPatente));
                t.Start(cola.Dequeue());
                hilos.Add(t);
            }
        }

        public void IniciarSimulacion()
        {
            foreach(Thread t in hilos)
            {
                if (t.IsAlive)
                    t.Abort();
            }

            ProximaPatente(vistaPatente3);
            ProximaPatente(vistaPatente4);
        }
    }

}
