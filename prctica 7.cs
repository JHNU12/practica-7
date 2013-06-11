using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int puntos = 0;
            if (this.udg.Checked)
            {
                puntos++;
            }
            if (this.cuatro.Checked)
            {
                puntos++;
            }
            if (this.mexico.Checked)
            {
                puntos++;
            }
            if (this.peru.Checked)
            {
                puntos++;
            }
        }
    }
}
