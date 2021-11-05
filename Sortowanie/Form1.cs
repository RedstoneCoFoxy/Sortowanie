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
            int[] Table = new int[50];
            Random rnd = new Random();
            for (int i = 0; i < Table.Length; i++)
            {
                Table[i] = rnd.Next(1, 100);
            }


            Wynik.Text = "";
            for (int i = 0; i < Table.Length; i++)
            {
                Wynik.Text = Wynik.Text+" "+Table[i].ToString();
            }
        }
    }
}
