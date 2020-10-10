using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ev evim = new Ev();
            evim.evtipi = "Daire";
            evim.evyasi = 5;
            evim.kat = 3;
            evim.odasayisi = 3;
            evim.m2 = 100;

            string evtipi = evim.evtipigetir();
            label6.Text = evim.evtipi.ToString();
            label7.Text = evim.evyasi.ToString();
            label8.Text = evim.kat.ToString();
            label9.Text = evim.odasayisi.ToString();
            label10.Text = evim.m2.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
