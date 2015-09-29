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
            string peselTest = numericUpDown1.Value.ToString();

            Pesel pe = new Pesel(numericUpDown1.Value.ToString());
            pe.check();

            //warunek czy ilsc cyfr sie zgadzace
            MessageBox.Show("cos tam cos tam " + peselTest + " wynik= " + pe.Result);
        }
    }
}
