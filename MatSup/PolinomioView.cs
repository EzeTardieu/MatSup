using CenterSpace.NMath.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatSup
{
    public partial class PolinomioView : Form
    {
        private Polynomial polinomioInterpolante;
        public PolinomioView(Polynomial polInterpolante)
        {
            polinomioInterpolante = polInterpolante;
            InitializeComponent();
            polinomioLbl.Text = polinomioInterpolante.ToString();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            polK.Text = polinomioInterpolante.Evaluate(double.Parse(valueBox.Text)).ToString();
        }
    }
}
