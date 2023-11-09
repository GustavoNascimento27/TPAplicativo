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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void opçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frmprincipal = new Form1();
            frmprincipal.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnc1_Click(object sender, EventArgs e)
        {
            txtr.Clear();
            double x, n, i;
            n = Convert.ToDouble(txtn.Text);
            i = 1;
            while (i < 11)
            {
                x= n* i;
                txtr.Text += ($"{n} x {i} = {x}\r\n");
                i++;
            }
        }

        private void txtn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double x, n, i;
                n = Convert.ToDouble(txtn.Text);
                Random botao = new Random(4);
                 
                
            }
        }

        private void btnc2_Click(object sender, EventArgs e)
        {
            txtr.Clear();
            double x, n, i;
           n = Convert.ToDouble(txtn.Text);
            i = 1;
            {
                do
                {
                    x = n * i;
                    txtr.Text += ($"{n} x {i} = {x}\r\n");
                    i++;
                }
                while (i < 11);
            }
            
        }

        private void btnc3_Click(object sender, EventArgs e)
        {
            txtr.Clear();
            double x, n, i;
            n = Convert.ToDouble(txtn.Text);
            for (i = 1; i < 11; i++) 
                {
                    x = n * i;
                    txtr.Text += ($"{n} x {i} = {x}\r\n");
                }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtr.Clear();
            txtn.Clear();
            txtn.Focus();
        }
    }
}
