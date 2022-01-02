﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortowanie
{
    public partial class f : Form
    {
        int[] Table = new int[0];
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
                Table[i] = rnd.Next(1, 10);
            }
            Liczby.Text = "";
            for (int y = 0; y < Table.Length; y++)
            {
                if (y % 25 == 0) { Liczby.Text = Liczby.Text + "\n "; }
                Liczby.Text = Liczby.Text + " " + Table[y].ToString();
            }
            Czas.Text = "Wygenerowano";
            var CzasStart = DateTime.Now;

            int[] Quick(int[] Tabela)
            {
                if (Tabela.Length == 2)
                {
                    if (Tabela[0] > Tabela[1])
                    {
                        int x = Tabela[1];
                        Tabela[1] = Tabela[0];
                        Tabela[0] = x;
                    }
                    return Tabela;
                }
                if (Tabela.Length == 1)
                {
                    return Tabela;
                }
                if (Tabela.Length == 0)
                {
                    return Tabela;
                }
                bool PrawaIstnieje = true;
                bool LewaIstnieje = true;

                int pivot = Tabela[Tabela.Length - 1];
                int IPivot = Tabela.Length - 1;
                int WiekszeOdPivota = 0;
                for (int y = 0; y < Tabela.Length; y++)
                {
                    if (Tabela[y] >= pivot && Tabela[y] != Tabela[IPivot]) { WiekszeOdPivota++; }
                }
                int[] Prawy = new int[WiekszeOdPivota];
                int[] Lewy = new int[Tabela.Length - WiekszeOdPivota];
             
                int l = 0;
                int r = 0;
                for (int y = 0; y < Tabela.Length; y++)
                {
                    if (Tabela[y] >= pivot)
                    {
                        if (PrawaIstnieje) { if (Tabela[y] != Tabela[IPivot]) { Prawy[r] = Tabela[y]; } }
                        r++;
                    }
                    else
                    {
                        if (LewaIstnieje) { if (Tabela[y] != Tabela[IPivot]) { Lewy[l] = Tabela[y]; } }
                        l++;
                    }
                }
                if (Prawy[0]==0) { PrawaIstnieje = false; }
                if (Lewy[0]==0) { LewaIstnieje = false; }
                xd.Text = xd.Text + "========\n";
                xd.Text = xd.Text + "Left: " + Lewy.Length.ToString() + "\n";
                xd.Text = xd.Text + "Right: " + Prawy.Length.ToString() + "\n";

                if (Lewy.Length != 1 && LewaIstnieje) { Lewy = Quick(Lewy); }
                if (Prawy.Length != 1 && PrawaIstnieje) { Prawy = Quick(Prawy); }

                xd.Text = xd.Text + "\n";
                if (PrawaIstnieje) {xd.Text = xd.Text + "Left: " + Lewy.Length.ToString() + "\n";}
                    if (PrawaIstnieje) { xd.Text = xd.Text + "Right: " + Prawy.Length.ToString() + "\n"; }

                    int[] TPivot = new int[1];
                    TPivot[0] = pivot;
                    int[] Temp = new int[0];

                    xd.Text = xd.Text + "TT: " + Temp.Length.ToString();

                    Temp = Temp.Concat(TPivot).ToArray();
                    if (LewaIstnieje) { Temp = Lewy.Concat(TPivot).ToArray(); }
                    if (PrawaIstnieje) { Temp = Temp.Concat(Prawy).ToArray(); }

                    xd.Text = xd.Text+ "Temp: " + Temp.Length.ToString();

                    return Temp;               
            }
            xd.Text = "";
            Table =Quick(Table);


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
                Table[i] = rnd.Next(1, 10);
            }
            Liczby.Text = "";
            for (int y = 0; y < Table.Length; y++)
            {
                if (y % 25 == 0) { Liczby.Text = Liczby.Text + "\n "; }
                Liczby.Text = Liczby.Text + " " + Table[y].ToString();
            }
            Czas.Text = "Wygenerowano";
            var CzasStart = DateTime.Now;
            xd.Text = "";
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
                            int o = Tabela[0];
                            Tabela[0] = Tabela[1];
                            Tabela[1] = o;
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
                Tabela = Left.Concat(Right).ToArray();
                int[] Temp = new int[Tabela.Length];
                for (int m = 0; m < Temp.Length; m++)
                {
                    int z = 0;
                    for (int mm = 0; mm < Tabela.Length; mm++)
                    {
                        if (Tabela[mm] > Tabela[z]) { z = mm; }
                    }
                    Temp[m] = Tabela[z];
                    Tabela[z] = 0;
                }
                Temp = Temp.Reverse().ToArray();
                return Temp;
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

        private void ButtonZapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog Zapis = new SaveFileDialog();

            Zapis.Filter = "Plik (*.txt)|*.txt";
            Zapis.FilterIndex = 2;
            Zapis.RestoreDirectory = true;
            if (Zapis.ShowDialog() == DialogResult.OK)
            {
                int generujliczby = Decimal.ToInt32(NumericUpDownLiczby.Value);
                string[] Table = new string[generujliczby];
                Random rnd = new Random();
                for (int i = 0; i < Table.Length; i++)
                {
                    Table[i] = rnd.Next(1, 100).ToString();
                }

                File.WriteAllLinesAsync(Zapis.FileName, Table);
            }
        }

        private void ButtonOtworz_Click(object sender, EventArgs e)
        {
            OpenFileDialog Otworz = new OpenFileDialog();

            Otworz.Filter = "Plik (*.txt)|*.txt";
            Otworz.FilterIndex = 2;
            Otworz.RestoreDirectory = true;
            if (Otworz.ShowDialog() == DialogResult.OK)
            {
                var fileStream = Otworz.OpenFile();

                using (StreamReader reader = new StreamReader(Otworz.FileName))
                {
                    while (reader.Peek() >= 0)
                    {
                        int linia = Int32.Parse(reader.ReadLine().ToString());
                        int[] Temp = new int[1];
                        Temp[0] = linia;
                        Table = Table.Concat(Temp).ToArray();
                    }
                }
                Liczby.Text = "";
                for (int y = 0; y < Table.Length; y++)
                {
                    if (y % 25 == 0) { Liczby.Text = Liczby.Text + "\n "; }
                    Liczby.Text = Liczby.Text + " " + Table[y].ToString();
                }
                Czas.Text = "Zaladowano";
            }
        }
    }
}
