using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursValutar
{
    public partial class schimbCurs : Form
    {
        string EUR1, EUR2, USD1, USD2, RON1, RON2, GBP1, GBP2;

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
                RON1 = textBox3.Text;
      
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
                GBP1 = textBox4.Text;
          
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
                USD2 = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
                EUR2 = textBox6.Text;

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
                RON2 = textBox7.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
                GBP2 = textBox8.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                EUR1 = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                USD1 = textBox1.Text;
        }

        CursMAIB maibForm = new CursMAIB();
        public schimbCurs()
        {
            InitializeComponent();
        }


        public void Form2_Load(object sender, EventArgs e)
        {
            using (StreamReader readtext = new StreamReader("valori.txt"))
            {
                USDbuy.Text = readtext.ReadLine();
                USDsell.Text = readtext.ReadLine();
                EURbuy.Text = readtext.ReadLine();
                EURsell.Text = readtext.ReadLine();
                RONbuy.Text = readtext.ReadLine();
                RONsell.Text = readtext.ReadLine();
                GBPbuy.Text = readtext.ReadLine();
                GBPsell.Text = readtext.ReadLine();
            }
        }

        private void changeCurs_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("valori.txt"))
            {
                writetext.WriteLine(USD1);
                writetext.WriteLine(USD2);
                writetext.WriteLine(EUR1);
                writetext.WriteLine(EUR2);
                writetext.WriteLine(RON1);
                writetext.WriteLine(RON2);
                writetext.WriteLine(GBP1);
                writetext.WriteLine(GBP2);

            }
            this.Visible = false;
            maibForm.Visible = true;

        }
    }
}
