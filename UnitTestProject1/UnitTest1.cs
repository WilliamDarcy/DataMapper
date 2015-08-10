using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Adherent2_DataLayer;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestReductionTarif()
        {
            TypeAdhesion t = new TypeAdhesion(1, "loisir", 100);
            //On applique une réduction de 20% au tarif.
            t.ReductionTarif(20);

            //le tarif doit maintenant être égal à 80 en arrondissant.
            Assert.AreEqual(t.Tarif, 80);
        }
        
        [TestMethod]
        public void TestReductionTarif1()
        {
            TypeAdhesion t = new TypeAdhesion(1, "loisir", 12);
            //On applique une réduction de 20% au tarif.
            t.ReductionTarif(20);

            //le tarif doit maintenant être égal à 10 en arrondissant.
            Assert.AreEqual(t.Tarif, 10);
        }

       
    }
}
