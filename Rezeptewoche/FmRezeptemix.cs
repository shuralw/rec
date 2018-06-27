using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezeptewoche
{
    public partial class FmRezeptemix : Form
    {
        Dictionary<string, string> dicLabels = new Dictionary<string, string>();
        public FmRezeptemix()
        {
            InitializeComponent();
            Generate();
            //initDicLabels();
            //setDicLabels();
        }
        
        public void Generate()
        {
            Random random = new Random();
            int AnzahlRezepte = Variables.Rezepte.Count;
            List<string> usedBezeichnungen = new List<string>();

            var labels = gbMix.Controls.OfType<Label>();

            if (Variables.Rezepte.Count>7)
            {
                foreach (Label lb in labels)
                {
                    string neuesRezept;
                    do
                    {
                        neuesRezept = getRezepte()[random.Next(0, AnzahlRezepte)].Bezeichnung;
                    }
                    while (usedBezeichnungen.Contains(neuesRezept));

                    lb.Text = neuesRezept;
                    usedBezeichnungen.Add(neuesRezept);
                }
            }
            else
            {
                MessageBox.Show("Zu wenige Rezepte für\neine ganze Woche vorhanden..");
            }
        }

        public List<Rezept> getRezepte()
        {
            List<Rezept> tempList = new List<Rezept>();
            foreach (Rezept rezept in Variables.Rezepte.Values)
            {
                tempList.Add(rezept);
            }
            return tempList;
        }

        public Dictionary<string,string> initDicLabels()
        {
            
            var labels = gbMix.Controls.OfType<Label>();
            foreach (Label lb in labels)
            {
                dicLabels.Add(lb.Name, lb.Text);
            }
            return dicLabels;
        }

        public void setDicLabels()
        {
            var labels = gbMix.Controls.OfType<Label>();
            foreach (string key in dicLabels.Keys)
            {
                gbMix.Controls.Find(key, false).FirstOrDefault().Text = dicLabels[key];
            }
        }

        private void btZurueck_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FmRezeptemix_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
