using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace NiOP_Kolekcije
{
    public partial class Form1 : Form
    {
        ArrayList Podatci = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            Podatci.Add("Podatak1");
            Podatci.Add("Podatak2");
            Podatci.Add("Podatak3");
            Podatci.Add("Podatak4");
            Podatci.Add("Dodatak");
        }
        private void Unesi_Click(object sender, EventArgs e)
        {
            Podatci.Add(Podatak1.Text);
            Podatci.Add(Podatak2.Text);
            Podatci.Add(Podatak3.Text);
            Podatci.Add(Podatak4.Text);
            Podatci.Insert(Podatci.IndexOf("Ž") + 1, "nema brkove");
            Podatci.Insert(Podatci.IndexOf("M") + 1, "ima brkove");
        }

        private void Obradi_Click(object sender, EventArgs e)
        {

        }

        private void Ispisi_Click(object sender, EventArgs e)
        {
            TextKutija.Text = "";
            TextKutija.Text += "Podatak1 Podatak2 Podatak3 Podatak4 Dodatak";
            for (int i=0; i<Podatci.Count;i++)
            {
                TextKutija.Text += Podatci[i] + " ";
            }
        }
    }
}
