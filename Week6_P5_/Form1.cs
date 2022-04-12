using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6_P5_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum mevsim { ilkbahar, yaz, sonbahar, kış };
        mevsim deneme = 0;

        public enum Plakalar
        {
            Ankara = 06, İstanbul=34, İzmir=35,Hatay=31,Adana=01,Samsun=55
        }

        int i;
        private void button1_Click(object sender, EventArgs e)
        {
           // textBox1.Text = deneme.ToString();
            //deneme++;

            i = Convert.ToInt32(Plakalar.İstanbul);
            textBox1.Text = i.ToString();

        }
    }
}
