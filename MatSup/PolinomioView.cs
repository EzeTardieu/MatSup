
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
        private Polinomio polinomioInterpolante;
        private bool pidePasos;
        
        public PolinomioView(Polinomio polInterpolante,bool pasos)
        {
            polinomioInterpolante = polInterpolante;
            InitializeComponent();
            polinomioLbl.Text = polinomioInterpolante.Formatear();
            pidePasos = pasos;
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
            polK.Text = polinomioInterpolante.Evaluar(double.Parse(valueBox.Text)).ToString();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void PolinomioView_Load(object sender, EventArgs e)
        {
            gradolblresultado.Text = polinomioInterpolante.getGrado().ToString();
            if (Interpolador.equiespaciados())
                equiespaciadoslblresultado.Text = "Sí";
            else
                equiespaciadoslblresultado.Text = "No";
            if (!pidePasos)//parte de los pasos pero aca porque es comun a todos, escondo si no pide pasos el grado y equiespaciados
            {
                gradolbl.Hide();
                gradolblresultado.Hide();
                equiespaciadoslbl.Hide();
                equiespaciadoslblresultado.Hide();
                pasosLagrange1.Hide();//Esto después moverlo a otro lado sería mejor
            }
        }

        private void PasosLagrangeUC1_Load(object sender, EventArgs e)
        {
            
        }

        private void PasosLagrange1_Load(object sender, EventArgs e)
        {
            pasosLagrange1.cargar();
        }
    }
}
