using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_banhcuuchuong
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtso1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnkq1_Click(object sender, EventArgs e)
        {
            lbsketqua.Items.Clear();
            int cc = Convert.ToInt32(txtso1.Text);
            for (int i=1;i<=10;i++)
            {
                //LBSKETQUA.iTEM.Add(txtso.Text+"x"+ convert.tostring(i)+"+"+ convert.tostring(cc*i));
                lbsketqua.Items.Add(string.Format("{0}*{1}={2}", txtso1.Text, i.ToString(), Convert.ToString(cc * i)));
            }

        }
    }
}
