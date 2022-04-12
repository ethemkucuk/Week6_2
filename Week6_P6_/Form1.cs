using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6_P6_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color a;
        private void Ust(object sender, EventArgs e)
        {
            a = (sender as Control).BackColor;
            (sender as Control).BackColor = Color.Turquoise;
        }

        private void Git(object sender, EventArgs e)
        {
            (sender as Control).BackColor = a;
        }

        private void Bekle(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.Red;
        }
    }
}
