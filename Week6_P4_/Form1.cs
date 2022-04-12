using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6_P4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int form_num = 0;
        private void Open_File(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.MdiParent = this;
            form_num++;
            frm2.Show();
            frm2.Text = form_num.ToString();


        }

        private void File_close(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild != null)
                ActiveMdiChild.Close();
                form_num--;
        }

        private void All_File(object sender, EventArgs e)
        {
            for(int i = 0; i < 2; i++)
            { 

                if(this.MdiChildren[i]!=null)

                    this.MdiChildren[i].Close();
            }
        }

        private void H_Tile(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void V_Tile(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void C_Tile(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}
