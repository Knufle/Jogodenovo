using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogodenovo
{
    public partial class Tinicial : Form
    {
        public Tinicial()
        {
            InitializeComponent();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(tBmostrar1.Text);
            b = Convert.ToInt32(tBmostrar2.Text);
            lblNome.Text = (a + b).ToString();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
