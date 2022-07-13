using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Generator
{
    public partial class Form1 : Form
    {
        public Random r = new Random(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string SylGen()
        {
            string syl = "";
            string vow = "EYUIOA";
            string con = "QWRTPSDFGHJKLZXCVBNM";
            int wf;
            int lc = r.Next(1, 4);
            switch (lc)
            {
                case 1:
                    syl += vow[r.Next(0, vow.Length)];
                    break;
                case 2:
                    wf = r.Next(1, 2);
                    if (wf == 1) 
                    {
                        syl += con[r.Next(0, con.Length)];
                        syl += vow[r.Next(0, vow.Length)];
                    }
                    else
                    {
                        syl += vow[r.Next(0, vow.Length)];
                        syl += con[r.Next(0, con.Length)];
                    }
                    break;
                case 3:
                    syl += con[r.Next(0, con.Length)];
                    syl += vow[r.Next(0, vow.Length)];
                    syl += con[r.Next(0, con.Length)];
                    break;
                case 4:
                    syl += con[r.Next(0, con.Length)];
                    wf = r.Next(1, 2);
                    if (wf == 1)
                    {
                        syl += con[r.Next(0, con.Length)];
                        syl += vow[r.Next(0, vow.Length)];
                    }
                    syl += con[r.Next(0, con.Length)];
                    break;
            }
            return syl;
        }

        public string StrGen(int sylc)
        {
            string s = "";
            for (int i=0; i<sylc; i++) { s = s+SylGen(); }
            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = StrGen(Convert.ToInt32(numericUpDown1.Value));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
