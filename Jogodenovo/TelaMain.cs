using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MePresidentaServidor;

namespace Jogodenovo
{
    public partial class TelaMain : Form
    {

        public string Versao { get; set; }
        public TelaMain()
        {
            InitializeComponent();
            Location = new Point(700, 700);
            string versao = "3.0";
            lblversao.Text = versao;
            // TelaMain f = new TelaMain(versao);
            // f.ShowDialog();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(tBmostrar1.Text);
            b = Convert.ToInt32(tBmostrar2.Text);
            lblversao.Text = (a + b).ToString();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tinicial_Load(object sender, EventArgs e)
        {

        }
    }
}
