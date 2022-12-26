using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Flash_Fatura
{
    public partial class Form4 : Form
    {
        bool optDurum = false;
        double sonuc = 0;
        string opt = "";
        public Form4()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 0;
        }

        private void RakamOlay(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" || optDurum)
                textBox2.Clear();
            optDurum = false;
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;

            this.ActiveControl = null;
        }

        private void OptHesap(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniOPT = btn.Text;

            label1.Text = label1.Text + " " + textBox2.Text + " " + yeniOPT;
            switch (opt)
            {
                case "+": textBox2.Text = (sonuc + Double.Parse(textBox2.Text)).ToString(); break;
                case "-": textBox2.Text = (sonuc - Double.Parse(textBox2.Text)).ToString(); break;
                case "*": textBox2.Text = (sonuc * Double.Parse(textBox2.Text)).ToString(); break;
                case "/": textBox2.Text = (sonuc / Double.Parse(textBox2.Text)).ToString(); break;
            }
            sonuc = Double.Parse(textBox2.Text);
            textBox2.Text = sonuc.ToString();
            opt = yeniOPT;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            label1.Text = "";
            opt = "";
            sonuc = 0;
            optDurum = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            optDurum = true;
            switch (opt)
            {
                case "+": textBox2.Text = (sonuc + Double.Parse(textBox2.Text)).ToString(); break;
                case "-": textBox2.Text = (sonuc - Double.Parse(textBox2.Text)).ToString(); break;
                case "*": textBox2.Text = (sonuc * Double.Parse(textBox2.Text)).ToString(); break;
                case "/": textBox2.Text = (sonuc / Double.Parse(textBox2.Text)).ToString(); break;
            }
            sonuc = Double.Parse(textBox2.Text);
            textBox2.Text = sonuc.ToString();
            opt = yeniOPT;
        }

        public string yeniOPT { get; set; }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form3 form3sec = new Form3();
            form3sec.Show();
            this.Hide();
            
        }


    

    }
}
