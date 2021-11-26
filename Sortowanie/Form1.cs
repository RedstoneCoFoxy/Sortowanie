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
    public partial class f : Form
    {
        public f()
        {
            InitializeComponent();
            
        }

        public void Begin()
        {
            
        }
        public void End()
        {

        }

        public void GenerujZestawLiczb()
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

            int[] Bubble(int[] Tabela)
            {
                    if (Tabela.Length == 2)
                    {
                        if (Tabela[0] > Tabela[1])
                        {
                            int x = Tabela[1];
                            Tabela[1] = Tabela[0];
                            Tabela[0] = x;
                        }
                    xd.Text = "dupa";
                        return Tabela;
                    }

                    int pivot = Tabela[Tabela.Length - 1];
                    int WiekszeOdPivota = 0;
                    for (int y = 0; y < Tabela.Length; y++)
                    {
                        if (Tabela[y] >= pivot) { WiekszeOdPivota++; }
                    }
                    int[] Prawy = new int[WiekszeOdPivota]; 
                    int[] Lewy = new int[Tabela.Length - WiekszeOdPivota]; 
                    int l = 0;
                    int p = 0;

                    for (int y = 0; y < Tabela.Length; y++)
                    {
                        if (Tabela[y] >= pivot) 
                        { 
                        if (Lewy.Length != 0){ Lewy[l] = Tabela[y];
                            l++;
                            if (l >= Lewy.Length) { l = Lewy.Length - 1; }
                            } 
                        }
                        else 
                        {
                        if (Prawy.Length!=0) { Prawy[p] = Tabela[y]; 
                            p++;
                            if (p >= Prawy.Length) { p = Prawy.Length - 1; }
                            } 
                        }
                    }

                    xd.Text = "";
                    xd.Text = xd.Text+ (Tabela.Length - WiekszeOdPivota).ToString() + " " + WiekszeOdPivota.ToString() + "\n ";
                    xd.Text = xd.Text+ Lewy.Length.ToString()+ " "+ Prawy.Length.ToString() + "\n";
                    for (int y = 0; y < Lewy.Length; y++)
                    {
                        xd.Text = xd.Text + "L " + Lewy[y].ToString();
                    }
                    xd.Text = xd.Text+"\n ";
                    for (int y = 0; y < Prawy.Length; y++)
                    {
                        xd.Text = xd.Text + "P " + Prawy[y].ToString();
                    }

                    if (Lewy.Length > 1) { Lewy=Bubble(Lewy); }
                    if (Prawy.Length > 1) { Prawy = Bubble(Prawy); }
                /*
                for (int y = 0; y < Lewy.Length; y++)
                {
                    xd.Text = xd.Text + "L " + Lewy[y].ToString();
                }
                xd.Text = "\n";
                for (int y = 0; y < Prawy.Length; y++)
                {
                    xd.Text = xd.Text + "P " + Prawy[y].ToString();
                }*/
                if (Lewy.Length == 0) { Tabela = Prawy; }
                    if (Prawy.Length == 0) { Tabela = Lewy; }
                    if (Lewy.Length != 0 && Prawy.Length != 0) { Tabela = Lewy.Concat(Prawy).ToArray(); }

                    return Tabela;               
            }

            Table=Bubble(Table);


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

        private void Generuj_Click(object sender, EventArgs e)
        {
            GenerujZestawLiczb();
        }

        private void ButtonInsertSort_Click(object sender, EventArgs e)
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
            int B = 1;
            while ( B < Table.Length)
                {
                    Sortuj = true;
                    int ii = B;
                    while (Sortuj)
                    {

                        int xx = 0;
                        
                        if (Table[ii-1] > Table[ii] )
                        {
                            xx = Table[ii];
                            Table[ii ] = Table[ii - 1];
                            Table[ii- 1] = xx;
                            ii--;
                            if (ii == 0) { Sortuj = false; }
                        }
                        else
                        {
                            Sortuj = false;
                        }
                        
                    }
                    B++;
            }
            //Table=Table.Reverse().ToArray();
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

        private void ButtonMergeSort_Click(object sender, EventArgs e)
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
               int[] MergeSort(int[] Tabela)
                {
                    if (Tabela.Length == 1)
                    {
                        return Tabela;
                    }
                    if (Tabela.Length == 2)
                    {
                        if (Tabela[0]> Tabela[1])
                        {
                            int x = Tabela[0];
                            Tabela[0] = Tabela[1];
                            Tabela[1] = x;
                        xd.Text = xd.Text + "P ";
                        }
                        return Tabela;
                    }
                    int n = Tabela.Length / 2;
                    int[] Left = new int[n];
                    int[] Right = new int[Tabela.Length- n];
                    int xx = 0;
                    int yy = 0;
                    for(int y = 0; y < Tabela.Length; y++)
                {
                    if (y < n) { Left[xx] = Tabela[y];xx++; } else { Right[yy] = Tabela[y];yy++; }
                }
                Left = MergeSort(Left);
                Right = MergeSort(Right);
                Tabela = Right.Concat(Left).ToArray();
                return Tabela;
                }
            Table=MergeSort(Table);
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
