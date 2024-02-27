using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KS_PD_V9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ediens_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void kopejas_kalorijas_Click(object sender, EventArgs e)
        {
            int ediens = Convert.ToInt32(kalorijas.Value);

            int ediens2 = Convert.ToInt32(kalorijas2.Value);

            int ediens3 = Convert.ToInt32(kalorijas3.Value);

            int kopejas_kalorijas = ediens + ediens2 + ediens3;

            textBox1.Text = kopejas_kalorijas.ToString();
        }
    }
}
