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
            initDicLabels();
            setDicLabels();
        }
        
        public void Generate()
        {
            Random random = new Random();
            int AnzahlRezepte = Variables.Rezepte.Count;

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
        
    }
}
