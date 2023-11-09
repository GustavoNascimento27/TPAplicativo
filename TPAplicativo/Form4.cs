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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        double l, p, x, a;
        string comodo;

        private void txtr_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtcom.Clear();
            txtcomp.Clear();
            txtl.Clear();
            txtr.Clear();
            txtcom.Focus();
            lblc_r.Visible = false;
            txtr.Visible = false;
            x = 0;
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frmprincipal = new Form1();
            frmprincipal.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnc1_Click(object sender, EventArgs e)
        {
            l = Convert.ToDouble(txtl.Text);
            p = Convert.ToDouble(txtcomp.Text);
            comodo = txtcom.Text;
            lblc_r.Visible = true;
            txtr.Visible = true;
            x = x + l * p;
            a = l * p;
            lblc_r.Text = "A área do(a) "+ comodo + " é: ";
            txtr.Text = a.ToString();
            var result = MessageBox.Show("Deseja continuar?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtcom.Clear();
                txtcomp.Clear();
                txtl.Clear();
                txtr.Clear();
                txtcom.Focus();
                lblc_r.Visible = false;
                txtr.Visible = false;
            }
            else
            {
                txtcom.Clear();
                txtcomp.Clear();
                txtl.Clear();
                txtr.Clear();
                lblc_r.Text = "Resultado";
                txtr.Text = "A área total é: " + x;
            }

        }
    }
}
