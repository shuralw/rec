using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Rezeptewoche
{
    class Rezept
    {
        public List<Zutat> Zutaten = new List<Zutat>();
        public string Bezeichnung { get; set; }
      
        public Rezept()
        {

        }
        public Rezept(string Bezeichnung)
        {
            this.Bezeichnung = Bezeichnung;   
        }
        public Rezept(string Bezeichnung,List<Zutat> zutaten)
        {
            this.Bezeichnung = Bezeichnung;
            Zutaten = zutaten;
        }
        public void ZutatHinzufuegen(Zutat zutat)
        {
            Zutaten.Add(zutat);
        }
        
        public List<Zutat> GetZutaten()
        {
            List<Zutat> result = new List<Zutat>();
            result = Zutaten;
            return result;
        }

        public override string ToString()
        {
            return Bezeichnung;
        }

    }
}
