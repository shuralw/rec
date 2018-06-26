using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Threading.Tasks;

namespace Rezeptewoche
{
    class Dateimanager
    {
        public string RezeptToString(Rezept rezept)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(rezept.ToString()+"|");
            foreach (Zutat zutat in rezept.Zutaten)
            {
                sb.Append(ZutatToString(zutat)+"|");
            }
            return sb.ToString();
        }

        public Rezept StringToRezept(string rezeptstring)
        {
            string[] RezeptEigenschaften = rezeptstring.Split('/');
            return new Rezept
            (
                RezeptEigenschaften[0],
                GetZutatenList(RezeptEigenschaften.Skip(1).ToArray())  
            );
        }

        private List<Zutat> GetZutatenList(string[] stringzutaten)
        {
            List<Zutat> result = new List<Zutat>();
            foreach (string szutat in stringzutaten)
            {
                result.Add(StringToZutat(szutat));
            }
            return result;
        }

        string ZutatToString(Zutat zutat)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(zutat.Bezeichnung + "/");
            sb.Append(zutat.Menge + "/");
            sb.Append(zutat.Maßeinheit);
            return sb.ToString();
        }

        Zutat StringToZutat(string zutatstring)
        {
            string[] ZutatEigenschaften = zutatstring.Split('/');
            return new Zutat
            (
                ZutatEigenschaften[0],
                Convert.ToInt32(ZutatEigenschaften[1]),
                (Maßeinheitstyp)Enum.Parse(typeof(Maßeinheitstyp), ZutatEigenschaften[2])
            );
        }

        public void writeXMl(Dictionary<string, Rezept> Rezepte)
        {
            FileStream stream = new FileStream(@".\Rezepte.xml", FileMode.Create);
            XmlWriter writer = XmlWriter.Create(stream);
            writer.WriteStartElement("Rezepte");

            foreach (Rezept rezept in Rezepte.Values)
            {
                writer.WriteStartElement("Rezept");
                writer.WriteStartElement("Bezeichnung");
                writer.WriteString(rezept.ToString());
                writer.WriteEndElement();

                foreach (Zutat zutat in rezept.Zutaten)
                {
                    writer.WriteStartElement("Zutat");

                    writer.WriteStartElement("Bezeichnung");
                    writer.WriteString(zutat.Bezeichnung);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Maßeinheit");
                    writer.WriteString(zutat.Maßeinheit.ToString());
                    writer.WriteEndElement();

                    writer.WriteStartElement("Menge");
                    writer.WriteString(zutat.Menge.ToString());
                    writer.WriteEndElement();

                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                //(dmg.RezeptToString(rezept));
            }
            writer.WriteEndElement();
            writer.Close();
            stream.Close();
        }

        public Dictionary<string, Rezept> LoadXML()
        {
            Dictionary<string, Rezept> result = new Dictionary<string, Rezept>();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(@".\Rezepte.xml");
            foreach (XmlNode RezepteNode in xmlDocument.SelectNodes("Rezepte"))
            {
                foreach (XmlNode Rezept in RezepteNode.ChildNodes) // SubRezeptNode: Erster Node ist die Bezeichnung, alle weiteren sind Zutaten
                {
                    Rezept rezept = new Rezept();
                    rezept.Bezeichnung = Rezept.FirstChild.InnerText;
                    foreach (XmlNode ZutatNode in Rezept.SelectNodes("Zutat"))
                    {
                        Zutat zutat = new Zutat();
                        zutat.Bezeichnung = ZutatNode["Bezeichnung"].InnerText;
                        zutat.Menge = Convert.ToInt32(ZutatNode["Menge"].InnerText);
                        zutat.Maßeinheit = (Maßeinheitstyp)Enum.Parse(typeof(Maßeinheitstyp), (ZutatNode["Maßeinheit"].InnerText));
                        rezept.ZutatHinzufuegen(zutat);
                    }
                    result.Add(rezept.Bezeichnung, rezept);
                } 
            }
            return result;
        }
        public Dictionary<string, Rezept> LoadXML(Dictionary<string, Rezept> bestehendeRezepte)
        {
            Dictionary<string, Rezept> neueRezepte = LoadXML();
            foreach (var item in bestehendeRezepte)
            {
                neueRezepte.Add(item.Key,item.Value);
            }
            return neueRezepte;
        }

    }
}
