﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Rezeptewoche
{
    public partial class Form1 : Form
    {

        Dictionary<string, Rezept> Rezepte ;
        Dictionary<string, Zutat> Einkaufszettel = new Dictionary<string, Zutat>();
        public Form1()
        {
            InitializeComponent();            
            lvZutatenDesRezepts.View = View.Details;
            string[] row1 = { "s1", "s2"};
            cbMeasure.SelectedIndex = 0;
            Init();
        }


        void Init()
        {
            Rezepte = new Dictionary<string, Rezept>();
            Einkaufszettel = new Dictionary<string, Zutat>();
        }
        private void btRecipeSubmission_Click(object sender, EventArgs e)
        {
            Zutat NeueZutat = GetZutatByInput();
            ZutatDerRezeptListeHinzufügen(NeueZutat);
            cbRecipenameAktualisieren();
            AddZutatToListView(NeueZutat);
        }

        void AddZutatToListView(Zutat neueZutat)
        {
            ListViewItem item = new ListViewItem(new[]
            {
                neueZutat.Bezeichnung,
                neueZutat.Menge.ToString(),
                neueZutat.Maßeinheit.ToString()
            });
            lvZutatenDesRezepts.Items.Add(item);
        }

        Zutat GetZutatByInput()
        {
            Maßeinheitstyp maßeinheit;
            try
            {
                maßeinheit = (Maßeinheitstyp)Enum.Parse(typeof(Maßeinheitstyp), cbMeasure.Text);
            }
            catch (Exception)
            {
                throw;
            }
            return new Zutat(
                tbIngredientName.Text,
                Convert.ToInt32(nudAmount.Value),
                maßeinheit);
        }

        void RezeptHinzufügen(string rezeptname)
        {
            if (!Rezepte.ContainsKey(rezeptname))
            {
                Rezepte.Add(rezeptname, new Rezept(rezeptname));
            }
        }
        void ZutatDerRezeptListeHinzufügen(Zutat neueZutat)
        {
            string rezeptname = cbRecipename.Text;
            RezeptHinzufügen(rezeptname);
            Rezepte[rezeptname].ZutatHinzufuegen(neueZutat);
        }

        void ZutatenVomRezeptInEinkaufslisteHinzufügen(Rezept rezept)
        {
            foreach (Zutat zutat in rezept.Zutaten)
            {
                AddMerged(zutat);
            }
        }

        private void AddMerged(Zutat NeueZutat)
        {
            if (Einkaufszettel.Keys.Contains(NeueZutat.Bezeichnung))
            {
                Zutat BisherigeZutat = Einkaufszettel[NeueZutat.Bezeichnung];
                if (BisherigeZutat.Maßeinheit == NeueZutat.Maßeinheit)
                {
                    BisherigeZutat.Menge += NeueZutat.Menge;
                }
                else
                {
                    // todo: mg + g + kg möglich machen
                    string Errormessage = "Unterschiedliche Maßeinheiten vereinigt: Es wurde versucht " +
                        Zutat.GetMaßeinheit(BisherigeZutat.Maßeinheit) +
                        " mit " + Zutat.GetMaßeinheit(NeueZutat.Maßeinheit) + " zu vereinigen.";

                    throw new Exception(Errormessage);
                }
            }
            else
            {
                Einkaufszettel.Add(NeueZutat.Bezeichnung, new Zutat(NeueZutat));
            }
        }

        void SchreibeAlleZutatenInEinkaufszettelBox()
        {
            rtbSelectedRecipes.Clear();
            foreach (Zutat zutat in Einkaufszettel.Values)
            {
                rtbSelectedRecipes.AppendText(zutat.ToString()+"\n");
            }
        }

        private void RezeptZumEinkaufszettelHinzufügen(object sender, EventArgs e)
        {
            ZutatenVomRezeptInEinkaufslisteHinzufügen(Rezepte[cbRecipename.Text]);
            SchreibeAlleZutatenInEinkaufszettelBox();
        }

        private void btLaden_Click(object sender, EventArgs e)
        {
            Dateimanager dmg = new Dateimanager();
            this.Rezepte = dmg.LoadXML(Rezepte);
            cbRecipename.Items.Clear();
            cbRecipenameAktualisieren();
        }

        private void cbRecipenameAktualisieren()
        {
            cbRecipename.Items.Clear();
            foreach (string rezept in Rezepte.Keys)
            {
                cbRecipename.Items.Add(rezept);
            }
        }

        private void cbRecipename_TextChanged(object sender, EventArgs e)
        {
            if (cbRecipename.Items.Count > 0)
            {
                lvZutatenDesRezepts.Items.Clear();
                if (Rezepte.ContainsKey(cbRecipename.Text))
                {
                    foreach (Zutat zutat in Rezepte[cbRecipename.Text].Zutaten)
                    {
                        AddZutatToListView(zutat);
                    }
                }
            }
        }

        private void btspeichern_Click(object sender, EventArgs e)
        {
            Dateimanager dmg = new Dateimanager();
            dmg.writeXMl(Rezepte);
        }
    }
}
