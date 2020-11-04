using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ProgramozasiTetelekForm
{
    public partial class frmKezdo : Form
    {
        private List<int> szamok = new List<int>();
        public frmKezdo()
        {
            InitializeComponent();
            try
            {
                StreamReader be = new StreamReader("adatok.txt");
                while (!be.EndOfStream)
                {
                    szamok.Add(int.Parse(be.ReadLine()));
                }
                be.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba volt a fájlban, de hibás adatot figyelmen kívül hagytam.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnkiiras_Click(object sender, EventArgs e)
        {
            lbText.Items.Clear();
            foreach (var i in szamok)
            {
                lbText.Items.Add(i);
            }
            
        }

        private void btnosszeg_Click(object sender, EventArgs e)
        {
            lbText.Items.Clear();
            double szum = 0;
            for (int i = 0; i < szamok.Count; i++)
            {
                szum = szum + szamok[i];
            }
            szum = szum / szamok.Count();
            lbText.Items.Add(szum);
        }

        private void btnmegszamol_Click(object sender, EventArgs e)
        {
            lbText.Items.Clear();
            int s = 0;
            for (int i = 0; i < szamok.Count; i++)
            {
                if (szamok[i] % 3 == 1)
                {
                    s += 1;
                }
            }
            lbText.Items.Add(s + " db van");
        }

        private void btneldontes_Click(object sender, EventArgs e)
        {
            lbText.Items.Clear();
            int i = 1;
            while (i < szamok.Count && szamok[i] != 8876)
            {
                i += 1;
            }
            if (i < szamok.Count)
            {
                lbText.Items.Add("Volt 8876-es szám.");
            }
            else
            {
                lbText.Items.Add("Nem volt 8876-es szám");
            }
        }

        private void btnkivalaszt_Click(object sender, EventArgs e)
        {
            lbText.Items.Clear();
            int i = 1;
            while (i < szamok.Count && szamok[i] != 7143)
            {
                i++;
            }
            lbText.Items.Add($"A 7143 a {i + 1}. helyen van");
        }

        private void btnkeres_Click(object sender, EventArgs e)
        {
            lbText.Items.Clear();
            int x = 0;
            foreach (var i in szamok)
            {
                if (i == 1170)
                {
                    x++;
                }
            }
            lbText.Items.Add($"Az 1170 {x}-szer fordul elő");
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            lbText.Items.Clear();
            int m = 0;
            for (int i = 1; i < szamok.Count; i++)
            {
                if (szamok[i] < szamok[m])
                {
                    m = i;
                }
            }
            lbText.Items.Add(szamok[m] + " a legkisebb elem");
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            lbText.Items.Clear();
            int m = 1;
            for (int i = 2; i < szamok.Count; i++)
            {
                if (szamok[i] > szamok[m])
                {
                    m = i;
                }
            }
            lbText.Items.Add(szamok[m] + " a legnagyobb elem");
        }
    }
}
