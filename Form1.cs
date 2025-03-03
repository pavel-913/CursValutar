using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CursValutar
{

    public partial class CursMAIB : Form
    {

        string rezult, rezultMDL;
        float valorificare, valoare;
        float EURto = 19.13f, EURfrom = 19.40f;
        float USDto = 17.70f, USDfrom = 17.93f;
        float RONto = 3.80f, RONfrom = 3.90f;
        float GBPto = 22.20f, GBPfrom = 22.60f;
        string defualtValut = "MDL", changedValut = "MDL";
        int check = 0, check1 = 0;

        public CursMAIB()
        {
            InitializeComponent();
        }

        private void mdlbtn_Click(object sender, EventArgs e)
        {
            defualtValut = "MDL";
        }

        private void usdbtn_Click(object sender, EventArgs e)
        {
            defualtValut = "USD";
        }

        private void eurbtn_Click(object sender, EventArgs e)
        {
            defualtValut = "EUR";
        }

        private void rontbn_Click(object sender, EventArgs e)
        {
            defualtValut = "RON";
        }

        private void gbpbtn_Click(object sender, EventArgs e)
        {
            defualtValut = "GBP";
        }

        private void mdl1btn_Click(object sender, EventArgs e)
        {
            changedValut = "MDL";
        }

        private void usd1btn_Click(object sender, EventArgs e)
        {
            changedValut = "USD";
        }

        private void eur1btn_Click(object sender, EventArgs e)
        {
            changedValut = "EUR";
        }

        private void ron1btn_Click(object sender, EventArgs e)
        {
            changedValut = "RON";
        }

        private void gbp1btn_Click(object sender, EventArgs e)
        {
            changedValut = "GBP";
        }

        void schimb(float valoare, float curs)
        {
            float rez = (float)Math.Round((curs * valoare), 2);
            rezult = rez.ToString();
        }
        void schimbReverse(float valoare, float curs)
        {
            float rez = (float)Math.Round((valoare / curs), 2);
            rezultMDL = rez.ToString();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            /*using (StreamReader readtext = new StreamReader("valori.txt"))
            {
                USDto = float.Parse(readtext.ReadLine());
                USDfrom = float.Parse(readtext.ReadLine());
                EURto = float.Parse(readtext.ReadLine());
                EURfrom = float.Parse(readtext.ReadLine());
                RONto = float.Parse(readtext.ReadLine());
                RONfrom = float.Parse(readtext.ReadLine());
                GBPto = float.Parse(readtext.ReadLine());
                GBPfrom = float.Parse(readtext.ReadLine());
            }*/

            Form3 form3 = new Form3();
            schimbCurs form2 = new schimbCurs();

            mdlbtn.FlatStyle = FlatStyle.Flat;
            mdlbtn.FlatAppearance.BorderSize = 1;
            mdlbtn.FlatAppearance.BorderColor = Color.LightSlateGray;
            usdbtn.FlatStyle = FlatStyle.Flat;
            usdbtn.FlatAppearance.BorderSize = 1;
            usdbtn.FlatAppearance.BorderColor = Color.LightSlateGray;
            eurbtn.FlatStyle = FlatStyle.Flat;
            eurbtn.FlatAppearance.BorderSize = 1;
            eurbtn.FlatAppearance.BorderColor = Color.LightSlateGray;
            ronbtn.FlatStyle = FlatStyle.Flat;
            ronbtn.FlatAppearance.BorderSize = 1;
            ronbtn.FlatAppearance.BorderColor = Color.LightSlateGray;
            gbpbtn.FlatStyle = FlatStyle.Flat;
            gbpbtn.FlatAppearance.BorderSize = 1;
            gbpbtn.FlatAppearance.BorderColor = Color.LightSlateGray;

            mdl1btn.FlatStyle = FlatStyle.Flat;
            mdl1btn.FlatAppearance.BorderSize = 1;
            mdl1btn.FlatAppearance.BorderColor = Color.LightSlateGray;
            usd1btn.FlatStyle = FlatStyle.Flat;
            usd1btn.FlatAppearance.BorderSize = 1;
            usd1btn.FlatAppearance.BorderColor = Color.LightSlateGray;
            eur1btn.FlatStyle = FlatStyle.Flat;
            eur1btn.FlatAppearance.BorderSize = 1;
            eur1btn.FlatAppearance.BorderColor = Color.LightSlateGray;
            ron1btn.FlatStyle = FlatStyle.Flat;
            ron1btn.FlatAppearance.BorderSize = 1;
            ron1btn.FlatAppearance.BorderColor = Color.LightSlateGray;
            gbp1btn.FlatStyle = FlatStyle.Flat;
            gbp1btn.FlatAppearance.BorderSize = 1;
            gbp1btn.FlatAppearance.BorderColor = Color.LightSlateGray;

            USDbuy.Text = USDto.ToString();
            EURbuy.Text = EURto.ToString();
            RONbuy.Text = RONto.ToString();
            GBPbuy.Text = GBPto.ToString();

            USDsell.Text = USDfrom.ToString();
            EURsell.Text = EURfrom.ToString();
            RONsell.Text = RONfrom.ToString();
            GBPsell.Text = GBPfrom.ToString();

            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.LightGray;
            button1.ForeColor = Color.Gray;
            button1.FlatAppearance.BorderSize = 0;

            button2.FlatStyle = FlatStyle.Flat;
            button2.BackColor = Color.LightGray;
            button2.ForeColor = Color.Gray;
            button2.FlatAppearance.BorderSize = 0;

            mdlbtn.Click += btnSettings;
            usdbtn.Click += btnSettings;
            eurbtn.Click += btnSettings;
            ronbtn.Click += btnSettings;
            gbpbtn.Click += btnSettings;
            mdl1btn.Click += btn1Settings;
            usd1btn.Click += btn1Settings;
            eur1btn.Click += btn1Settings;
            ron1btn.Click += btn1Settings;
            gbp1btn.Click += btn1Settings;


        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {
            if (check == 1)
            {
                if (txtBox1.Text == "")
                    valorificare = 0;
                else valorificare = float.Parse(txtBox1.Text);
                switch (defualtValut)
                {
                    case "MDL":
                        switch (changedValut)
                        {
                            case "MDL":
                                txtBox2.Text = valorificare.ToString();
                                break;
                            case "USD":
                                schimbReverse(valorificare, USDfrom);
                                txtBox2.Text = rezultMDL;
                                break;
                            case "EUR":
                                schimbReverse(valorificare, EURfrom);
                                txtBox2.Text = rezultMDL;
                                break;
                            case "RON":
                                schimbReverse(valorificare, RONfrom);
                                txtBox2.Text = rezultMDL;
                                break;
                            case "GBP":
                                schimbReverse(valorificare, GBPfrom);
                                txtBox2.Text = rezultMDL;
                                break;
                        }
                        break;
                    case "USD":
                        switch (changedValut)
                        {
                            case "MDL":
                                schimb(valorificare, USDto);
                                txtBox2.Text = rezult;
                                break;
                            case "USD":
                                schimb(valorificare, USDto);
                                schimbReverse(float.Parse(rezult), USDfrom);
                                txtBox2.Text = rezultMDL;
                                break;
                            case "EUR":
                                schimb(valorificare, USDto);
                                schimbReverse(float.Parse(rezult), EURfrom);
                                txtBox2.Text = rezultMDL;
                                break;
                            case "RON":
                                schimb(valorificare, USDto);
                                schimbReverse(float.Parse(rezult), RONfrom);
                                txtBox2.Text = rezultMDL;
                                break;
                            case "GBP":
                                schimb(valorificare, USDto);
                                schimbReverse(float.Parse(rezult), GBPfrom);
                                txtBox2.Text = rezultMDL;
                                break;
                        }
                        break;
                    case "EUR":
                        switch (changedValut)
                        {
                            case "MDL":
                                schimb(valorificare, EURto);
                                txtBox2.Text = rezult;
                                break;
                            case "USD":
                                schimb(valorificare, EURto);
                                schimbReverse(float.Parse(rezult), USDfrom);
                                txtBox2.Text = rezultMDL;
                                break;
                            case "EUR":
                                schimb(valorificare, EURto);
                                schimbReverse(float.Parse(rezult), EURfrom);
                                txtBox2.Text = rezultMDL;
                                break;
                            case "RON":
                                schimb(valorificare, EURto);
                                schimbReverse(float.Parse(rezult), RONfrom);
                                txtBox2.Text = rezultMDL;
                                break;
                            case "GBP":
                                schimb(valorificare, EURto);
                                schimbReverse(float.Parse(rezult), GBPfrom);
                                txtBox2.Text = rezultMDL;
                                break;
                        }
                        break;
                    case "RON":
                        switch (changedValut)
                        {
                            case "MDL":
                                schimb(valorificare, RONto);
                                txtBox2.Text = rezult;
                                break;
                            case "USD":
                                schimb(valorificare, RONto);
                                schimbReverse(float.Parse(rezult), USDfrom);
                                txtBox2.Text = rezultMDL;
                                break;
                            case "EUR":
                                schimb(valorificare, RONto);
                                schimbReverse(float.Parse(rezult), EURfrom);
                                txtBox2.Text = rezultMDL;
                                break;
                            case "RON":
                                schimb(valorificare, RONto);
                                schimbReverse(float.Parse(rezult), RONfrom);
                                txtBox2.Text = rezultMDL;
                                break;
                            case "GBP":
                                schimb(valorificare, RONto);
                                schimbReverse(float.Parse(rezult), GBPfrom);
                                txtBox2.Text = rezultMDL;
                                break;
                        }
                        break;
                    case "GBP":
                        switch (changedValut)
                        {
                            case "MDL":
                                schimb(valorificare, GBPto);
                                txtBox2.Text = rezult;
                                break;
                            case "USD":
                                schimb(valorificare, GBPto);
                                schimbReverse(float.Parse(rezult), USDfrom);
                                txtBox2.Text = rezultMDL;
                                break;
                            case "EUR":
                                schimb(valorificare, GBPto);
                                schimbReverse(float.Parse(rezult), EURfrom);
                                txtBox2.Text = rezultMDL;
                                break;
                            case "RON":
                                schimb(valorificare, GBPto);
                                schimbReverse(float.Parse(rezult), RONfrom);
                                txtBox2.Text = rezultMDL;
                                break;
                            case "GBP":
                                schimb(valorificare, GBPto);
                                schimbReverse(float.Parse(rezult), GBPfrom);
                                txtBox2.Text = rezultMDL;
                                break;
                        }
                        break;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new schimbCurs().Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3().Visible = true;
        }

        private void txtBox2_TextChanged(object sender, EventArgs e)
        {
            if (check1 == 1)
            {
                if (txtBox2.Text == "")
                    valoare = 0;
                else valoare = float.Parse(txtBox2.Text);
                switch (changedValut)
                {
                    case "MDL":
                        switch (defualtValut)
                        {
                            case "MDL":
                                txtBox1.Text = valoare.ToString();
                                break;
                            case "USD":
                                schimbReverse(valoare, USDto);
                                txtBox1.Text = rezultMDL;
                                break;
                            case "EUR":
                                schimbReverse(valoare, EURto);
                                txtBox1.Text = rezultMDL;
                                break;
                            case "RON":
                                schimbReverse(valoare, RONto);
                                txtBox1.Text = rezultMDL;
                                break;
                            case "GBP":
                                schimbReverse(valoare, GBPto);
                                txtBox1.Text = rezultMDL;
                                break;
                        }
                        break;
                    case "USD":
                        switch (defualtValut)
                        {
                            case "MDL":
                                schimb(valoare, USDfrom);
                                txtBox1.Text = rezult.ToString();
                                break;
                            case "USD":
                                schimb(valoare, USDfrom);
                                schimbReverse(float.Parse(rezult), USDto);
                                txtBox1.Text = rezultMDL;
                                break;
                            case "EUR":
                                schimb(valoare, USDfrom);
                                schimbReverse(float.Parse(rezult), EURto);
                                txtBox1.Text = rezultMDL;
                                break;
                            case "RON":
                                schimb(valoare, USDfrom);
                                schimbReverse(float.Parse(rezult), RONto);
                                txtBox1.Text = rezultMDL;
                                break;
                            case "GBP":
                                schimb(valoare, USDfrom);
                                schimbReverse(float.Parse(rezult), GBPto);
                                txtBox1.Text = rezultMDL;
                                break;
                        }
                        break;
                    case "EUR":
                        switch (defualtValut)
                        {
                            case "MDL":
                                schimb(valoare, EURfrom);
                                txtBox1.Text = rezult.ToString();
                                break;
                            case "USD":
                                schimb(valoare, EURfrom);
                                schimbReverse(float.Parse(rezult), USDto);
                                txtBox1.Text = rezultMDL;
                                break;
                            case "EUR":
                                schimb(valoare, EURfrom);
                                schimbReverse(float.Parse(rezult), EURto);
                                txtBox1.Text = rezultMDL;
                                break;
                            case "RON":
                                schimb(valoare, EURfrom);
                                schimbReverse(float.Parse(rezult), RONto);
                                txtBox1.Text = rezultMDL;
                                break;
                            case "GBP":
                                schimb(valoare, EURfrom);
                                schimbReverse(float.Parse(rezult), GBPto);
                                txtBox1.Text = rezultMDL;
                                break;
                        }
                        break;
                    case "RON":
                        switch (defualtValut)
                        {
                            case "MDL":
                                schimb(valoare, RONfrom);
                                txtBox1.Text = rezult.ToString();
                                break;
                            case "USD":
                                schimb(valoare, RONfrom);
                                schimbReverse(float.Parse(rezult), USDto);
                                txtBox1.Text = rezultMDL;
                                break;
                            case "EUR":
                                schimb(valoare, RONfrom);
                                schimbReverse(float.Parse(rezult), EURto);
                                txtBox1.Text = rezultMDL;
                                break;
                            case "RON":
                                schimb(valoare, RONfrom);
                                schimbReverse(float.Parse(rezult), RONto);
                                txtBox1.Text = rezultMDL;
                                break;
                            case "GBP":
                                schimb(valoare, RONfrom);
                                schimbReverse(float.Parse(rezult), GBPto);
                                txtBox1.Text = rezultMDL;
                                break;
                        }
                        break;
                    case "GBP":
                        switch (defualtValut)
                        {
                            case "MDL":
                                schimb(valoare, GBPfrom);
                                txtBox1.Text = rezult.ToString();
                                break;
                            case "USD":
                                schimb(valoare, GBPfrom);
                                schimbReverse(float.Parse(rezult), USDto);
                                txtBox1.Text = rezultMDL;
                                break;
                            case "EUR":
                                schimb(valoare, GBPfrom);
                                schimbReverse(float.Parse(rezult), EURto);
                                txtBox1.Text = rezultMDL;
                                break;
                            case "RON":
                                schimb(valoare, GBPfrom);
                                schimbReverse(float.Parse(rezult), RONto);
                                txtBox1.Text = rezultMDL;
                                break;
                            case "GBP":
                                schimb(valoare, GBPfrom);
                                schimbReverse(float.Parse(rezult), GBPto);
                                txtBox1.Text = rezultMDL;
                                break;
                        }
                        break;
                }
            }
        }

        private void txtBox1_Enter(object sender, EventArgs e)
        {
            txtBox1.Text = "";
            check = 1;
        }

        private void txtBox1_Leave(object sender, EventArgs e)
        {
            check = 0;
        }

        private void txtBox2_Enter(object sender, EventArgs e)
        {
            txtBox2.Text = "";
            check1 = 1;
        }

        private void txtBox2_Leave(object sender, EventArgs e)
        {
            check1 = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void btnSettings(object sender, EventArgs e)
        {
            foreach (Control c in panel2.Controls)
            {
                c.BackColor = Color.White;
                c.ForeColor = Color.Black;
            }
            Control click = (Control)sender;
            click.BackColor = Color.LightSeaGreen;
            click.ForeColor = Color.White;
        }

        public void btn1Settings(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                c.BackColor = Color.White;
                c.ForeColor = Color.Black;
            }
            Control click = (Control)sender;
            click.BackColor = Color.LightSeaGreen;
            click.ForeColor = Color.White;
        }

    }
}
