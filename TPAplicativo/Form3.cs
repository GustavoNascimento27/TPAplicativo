using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPAplicativo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        double t, i, x;

        private void btnc1_Click(object sender, EventArgs e)
        {
            txtr.Clear();
            t = Convert.ToDouble(txtc.Text);
            t = t * 1.8 + 32;
            i = 0;
            while(i<101)
            {
                x = t + i * 10;
                i++;
                txtr.Text += ($"{x}ºf \r\n");
            }
        }

        private void btnc2_Click(object sender, EventArgs e)
        {
            txtr.Clear();



            t = Convert.ToDouble(txtc.Text);
            t = t * 1.8 + 32;
            i = 0;
            do
            {
                x = t + i * 10;
                i++;
                txtr.Text += ($"{x}ºf \r\n");
            }
            while (i < 101);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtr.Clear();
            txtc.Clear();
            txtc.Focus();
        }

        private void btnc3_Click(object sender, EventArgs e)
        {
            txtr.Clear();
            t = Convert.ToDouble(txtc.Text);
            t = t * 1.8 + 32;
            for (i = 0; i < 101; i++)
            {
                x = t + i * 10;
                txtr.Text += ($"{x}ºf \r\n");
            }
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frmprincipal = new Form1();
            frmprincipal.Show();
        }
    }
}
