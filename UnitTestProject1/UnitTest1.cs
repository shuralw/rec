using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rezeptewoche
{
    //public enum Maßeinheitstyp { mg, g, kg, ml, l, TL, EL, Prise, Tropfen, Stk }
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestZutat()
        {
            // Arrange
            int Menge = 300;
            Maßeinheitstyp Maßeinheit = Maßeinheitstyp.g;
            string Bezeichnung = "Kartoffeln";

            // Act
            Zutat zutat = new Zutat("Kartoffeln", 300, Maßeinheitstyp.g);

            // Assert
            Assert.AreEqual(Menge, zutat.Menge);
            Assert.AreEqual(Maßeinheit, zutat.Maßeinheit);
            Assert.AreEqual(Bezeichnung, zutat.Bezeichnung);
        }
        [TestMethod]
        public void TestRezept()
        {
            // Arrange
            List<Zutat> zutaten = new List<Zutat>();
            zutaten.Add(new Zutat());

            // Act
            Rezept rezept = new Rezept("Kartoffelpürree", zutaten);

            // Assert
            Assert.AreEqual(new Rezept("Kartoffelpürree", new List<Zutat> { new Zutat() }),rezept);
        }
    }
}
