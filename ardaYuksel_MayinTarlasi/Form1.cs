using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ardaYuksel_MayinTarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> mayinlar = new List<int>();
            for (int i = 1; mayinlar.Count < 2; i++)
            {
                int sayi = rnd.Next(1, 65);
                if (!mayinlar.Contains(sayi))
                {
                    mayinlar.Add(sayi);
                }
            }
            for (int i = 1; i <= 64; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                if (mayinlar.Contains(i))
                {
                    btn.Tag = true;
                }
                else
                {
                    btn.Tag = false; 
                }
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button basilanbuton = (Button)sender;
            bool mayin = (bool)basilanbuton.Tag;
            if (mayin)
            {
                basilanbuton.BackColor = Color.Red;
            }
            else
            {
                basilanbuton.BackColor = Color.Green;
            }
        }
    }
}
