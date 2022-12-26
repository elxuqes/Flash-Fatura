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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public static string internet1 = "";
        public static string internet2 = "";
        public static string elektrik1 = "";
        public static string elektrik2 = "";
        public static string su1 = "";
        public static string su2 = "";
        public static string dogalgaz1 = "";
        public static string dogalgaz2 = "";
        private void button1_Click(object sender, EventArgs e)
        {
            internet1 = textBox1.Text + " (Kullanıcı tarafından eklendi)";
            internet2 = textBox2.Text + " (Kullanıcı tarafından eklendi)";

            if (textBox1.Text == "")
            {
                MessageBox.Show("Kurum eklenmedi, lütfen isim veya web sitesi girdiğinizi kontrol edin.", "Flash Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form6 form6sec = new Form6();
                form6sec.Show();
                this.Hide();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Kurum eklenmedi, lütfen isim veya web sitesi girdiğinizi kontrol edin.", "Flash Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form6 form6sec = new Form6();
                form6sec.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kurum eklendi.", "Flash Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form3 form3sec = new Form3();
                form3sec.Show();
            }

        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form3 form3sec = new Form3();
            form3sec.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            elektrik1 = textBox6.Text + " (Kullanıcı tarafından eklendi)";
            elektrik2 = textBox5.Text + " (Kullanıcı tarafından eklendi)";

            if (textBox6.Text == "")
            {
                MessageBox.Show("Kurum eklenmedi, lütfen isim veya web sitesi girdiğinizi kontrol edin.", "Flash Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form6 form6sec = new Form6();
                form6sec.Show();
                this.Hide();
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Kurum eklenmedi, lütfen isim veya web sitesi girdiğinizi kontrol edin.", "Flash Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form6 form6sec = new Form6();
                form6sec.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kurum eklendi.", "Flash Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form3 form3sec = new Form3();
                form3sec.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            su1 = textBox4.Text + " (Kullanıcı tarafından eklendi)";
            su2 = textBox3.Text + " (Kullanıcı tarafından eklendi)";

            if (textBox4.Text == "")
            {
                MessageBox.Show("Kurum eklenmedi, lütfen isim veya web sitesi girdiğinizi kontrol edin.", "Flash Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form6 form6sec = new Form6();
                form6sec.Show();
                this.Hide();
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Kurum eklenmedi, lütfen isim veya web sitesi girdiğinizi kontrol edin.", "Flash Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form6 form6sec = new Form6();
                form6sec.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kurum eklendi.", "Flash Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form3 form3sec = new Form3();
                form3sec.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dogalgaz1 = textBox8.Text + " (Kullanıcı tarafından eklendi)";
            dogalgaz2 = textBox7.Text + " (Kullanıcı tarafından eklendi)";

            if (textBox8.Text == "")
            {
                MessageBox.Show("Kurum eklenmedi, lütfen isim veya web sitesi girdiğinizi kontrol edin.", "Flash Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form6 form6sec = new Form6();
                form6sec.Show();
                this.Hide();
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show("Kurum eklenmedi, lütfen isim veya web sitesi girdiğinizi kontrol edin.", "Flash Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form6 form6sec = new Form6();
                form6sec.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kurum eklendi.", "Flash Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form3 form3sec = new Form3();
                form3sec.Show();
            }
        }

   

    }
}

