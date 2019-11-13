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
    public partial class Form1 : Form
    {
        int indiceTablaPuntos = 1;
        Interpolador interpolador = new Interpolador();
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            float x, y;
            bool agregable = true; 


            if(puntoX.Text.Any(c => !char.IsNumber(c) && c != '.'))
            {
                MessageBox.Show("Error: X tiene caracter inválido", "Error al agregar punto", MessageBoxButtons.OK);
                agregable = false;
            }
            if (puntoY.Text.Any(c => !char.IsNumber(c) && c != '.'))
            {
                MessageBox.Show("Error: Y tiene caracter inválido", "Error al agregar punto", MessageBoxButtons.OK);
                agregable = false;
            }
            if (puntoX.Text == "" || puntoY.Text == "")
            {
                MessageBox.Show("Error: Falta completar alguna coordenada del punto", "Error al agregar punto", MessageBoxButtons.OK);
                agregable = false;
            }
            if (agregable)
            {

                x = float.Parse(puntoX.Text);
                y = float.Parse(puntoY.Text);
                tablaPuntos.Controls.Add(new Label { Text = puntoX.Text, Anchor = AnchorStyles.Left, AutoSize = true }, 0, indiceTablaPuntos);
                tablaPuntos.Controls.Add(new Label { Text = puntoY.Text, Anchor = AnchorStyles.Left, AutoSize = true }, 1, indiceTablaPuntos);
                indiceTablaPuntos++;
                puntoX.Text = "";
                puntoY.Text = "";
                interpolador.agregarPunto(x,y);
            }


        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void PuntoX_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void PuntoY_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(metodos.Text)
            {
                case "Lagrange":
                    interpolador.setMetodo(new Lagrange());        
                    break;

                case "Newton Gregory progresivo":
                    interpolador.setMetodo(new NewtonGregory(new Progresivo()));
                    break;
                case "Newton Gregory regresivo":
                    interpolador.setMetodo(new NewtonGregory(new Regresivo()));
                    break;


            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (!mostrarPasosBox.Checked)
            {
				Polinomio polInterpolante = interpolador.obtenerPolinomioInterpolador();
                PolinomioView polView = new PolinomioView(polInterpolante);
                polView.Show();

            }
        }
    }
}
