using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public void Begin()
        {
            
        }
        public void End()
        {

        }

        public void ButtonBubbleSort_Click(object sender, EventArgs e)
        {
            int generujliczby = Decimal.ToInt32(NumericUpDownLiczby.Value);
            int[] Table = new int[generujliczby];
            Random rnd = new Random();
            for (int i = 0; i < Table.Length; i++)
            {
                Table[i] = rnd.Next(1, 100);
            }
            Liczby.Text = "";
            for (int y = 0; y < Table.Length; y++)
            {
                if (y % 25 == 0) { Liczby.Text = Liczby.Text + "\n "; }
                Liczby.Text = Liczby.Text + " " + Table[y].ToString();
            }
            Czas.Text = "Wygenerowano";
            var CzasStart = DateTime.Now;

            bool Sortuj = true;
            int x = 0;
            int p = 1;
            while (Sortuj)
            {
                for (int i = 0; i < Table.Length-p; i++)
                {
                    if (Table[i]> Table[i+1]) 
                    {
                        x = Table[i + 1];
                        Table[i + 1] = Table[i];
                        Table[i] = x;
                        x = 0;
                    }
                }
                p = p + 1;
                if (p == Table.Length) { Sortuj = false; }
            }
            var CzasKoniec = DateTime.Now;
            var CzasTrwania = CzasKoniec - CzasStart;
            Czas.Text = "Czas sortowania: "+CzasTrwania.ToString();

            Wynik.Text = "";
            for (int y = 0; y < Table.Length; y++)
            {
                if (y % 25 == 0) { Wynik.Text = Wynik.Text + "\n "; }
                Wynik.Text = Wynik.Text + " " + Table[y].ToString();
            }

        }

        private void Liczby_Click(object sender, EventArgs e)
        {

        }

        private void GenerujLiczby_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int generujliczby = Decimal.ToInt32(NumericUpDownLiczby.Value);
            int[] Table = new int[generujliczby];
            Random rnd = new Random();
            for (int i = 0; i < Table.Length; i++)
            {
                Table[i] = rnd.Next(1, 100);
            }
            Liczby.Text = "";
            for (int y = 0; y < Table.Length; y++)
            {
                if (y % 25 == 0) { Liczby.Text = Liczby.Text + "\n "; }
                Liczby.Text = Liczby.Text + " " + Table[y].ToString();
            }
            Czas.Text = "Wygenerowano";
            var CzasStart = DateTime.Now;

            int Bubble(int[] Tabela)
            {
                if (Tabela.Length == 1) { return 0; }
                int RozmiarTabeli = Tabela.Length;
                int[] Table = new int[generujliczby];
            }

            bool Sortuj = true;

            while (Sortuj)
            {
                    Bubble(Table);
            }

            var CzasKoniec = DateTime.Now;
            var CzasTrwania = CzasKoniec - CzasStart;
            Czas.Text = "Czas sortowania: " + CzasTrwania.ToString();

            Wynik.Text = "";
            for (int y = 0; y < Table.Length; y++)
            {
                if (y % 25 == 0) { Wynik.Text = Wynik.Text + "\n "; }
                Wynik.Text = Wynik.Text + " " + Table[y].ToString();
            }
        }
    }
}
