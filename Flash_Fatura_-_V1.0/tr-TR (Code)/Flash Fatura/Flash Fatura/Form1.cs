using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Flash_Fatura;

namespace FlashFatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form_2 = new Form2();
            form_2.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Flash Fatura kapatılıyor.", "Flash Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Environment.Exit(0);                       
        }

    }
}
