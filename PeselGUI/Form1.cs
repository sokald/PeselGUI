using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PeselGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pesel pe = new Pesel(numericUpDown1.Value.ToString());
            pe.check();

            MessageBox.Show("pesel: " + pe.Pesel1 + " wynik= " + pe.Result);
            label2.Text = "pesel: " + pe.Pesel1 + " wynik= " + pe.Result;
        }
    }
}
