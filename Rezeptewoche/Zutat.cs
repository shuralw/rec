using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Rezeptewoche
{
    enum Maßeinheitstyp { mg ,g,kg,ml,l,TL,EL,Prise,Tropfen, Stk}
    [SerializableAttribute]
    [ComVisibleAttribute(true)]
    class Zutat
    {
        public string Bezeichnung { get; set; }
        public int Menge { get; set; }
        public Maßeinheitstyp Maßeinheit  { get; set; }
        
        public Zutat()
        {

        }
        public Zutat(Zutat zutat)
        {
            this.Bezeichnung = zutat.Bezeichnung;
            this.Menge = zutat.Menge;
            this.Maßeinheit = zutat.Maßeinheit;
        }
        public Zutat(string bezeichnung, int menge, Maßeinheitstyp maßeinheit)
        {
            this.Bezeichnung = bezeichnung;
            this.Menge = menge;
            this.Maßeinheit = maßeinheit;
        }
        public static string GetMaßeinheit(Maßeinheitstyp maßeinheit)
        {
            string result = String.Empty;
            switch (maßeinheit)
            {
                case Maßeinheitstyp.Stk:
                    result = "Stück";
                    break;
                default:
                    result = maßeinheit.ToString();
                    break;
            }
            return result;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Menge);
            sb.Append(GetMaßeinheit(Maßeinheit)+" ");
            sb.Append(Bezeichnung);
            return sb.ToString();
        }
    }
}
