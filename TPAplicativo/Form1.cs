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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercício11AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ex11 = new Form2();
            ex11.Show();
        }

        private void exercício13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 ex13 = new Form4();
            ex13.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exercíciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 ex12 = new Form3();
            ex12.Show();
        }
    }
}
