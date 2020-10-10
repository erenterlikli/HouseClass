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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ev evim = new Ev();
            evim.evtipi = "Müstakil";
            evim.evyasi = 20;
            evim.kat = 1;
            evim.odasayisi = 3;
            evim.m2 = 120;

            string evtipi = evim.evtipigetir();
            label15.Text = evim.evtipi.ToString();
            label14.Text = evim.evyasi.ToString();
            label13.Text = evim.kat.ToString();
            label12.Text = evim.odasayisi.ToString();
            label11.Text = evim.m2.ToString();
        }
    }
}
