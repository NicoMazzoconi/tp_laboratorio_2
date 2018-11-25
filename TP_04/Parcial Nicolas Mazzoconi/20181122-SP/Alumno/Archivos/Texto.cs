using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        /// <summary>
        /// Metodo guardar, recibe un nombre de archivo y una cola de datos, y los guarda como texto
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            StreamWriter sw = new StreamWriter(archivo);
            foreach(Patente p in datos)
            {
                sw.WriteLine(p.CodigoPatente);
            }
            sw.Close();
        }

        /// <summary>
        /// Metodo leer, recibe el nombre del archivo y una cola de datos como out para alojar lo leido
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        public void Leer(string archivo, out Queue<Patente> datos)
        {
            StreamReader sr = new StreamReader(archivo);
            string str = sr.ReadToEnd();
            Patente p;
            Queue<Patente> auxQueue = new Queue<Patente>();
            foreach(String s in str.Split('\n'))
            {
                string aux;
                aux = s.Replace('\r', ' ');
                aux = s.Trim();
                p = PatenteStringExtension.ValidarPatente(aux);
                if(p != null)
                    auxQueue.Enqueue(p);
            }
            datos = auxQueue;
            sr.Close();
        }
    }
}
