using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;
using Patentes;
using Entidades;
using Archivos;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Queue<Patente> cola = new Queue<Patente>();
            Queue<Patente> colaDos = new Queue<Patente>();
            cola.Enqueue(new Patente("FUT952", Patente.Tipo.Vieja));
            cola.Enqueue(new Patente("FUT772", Patente.Tipo.Vieja));
            Texto rxr = new Texto();
            rxr.Guardar("PruebaUnitaria.txt", cola);

            rxr.Leer("PruebaUnitaria.txt", out colaDos);

            if (cola.Dequeue().CodigoPatente == colaDos.Dequeue().CodigoPatente)
                Assert.IsTrue(true);
            else
                Assert.IsTrue(false);
            
        }
    }
}
