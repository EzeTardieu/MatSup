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
		Polinomio polInterpolante;

		public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            float x, y;
            bool agregable = true; 


            if(puntoX.Text.Any(c => !char.IsNumber(c) && c != ',' && c != '-'))
            {
                MessageBox.Show("Error: X tiene caracter inválido", "Error al agregar punto", MessageBoxButtons.OK);
                agregable = false;
            }
            if (puntoY.Text.Any(c => !char.IsNumber(c) && c != ',' && c != '-'))
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
                try
                {
                    x = float.Parse(puntoX.Text);
                    y = float.Parse(puntoY.Text);
                    tablaPuntos.Controls.Add(new Label { Text = puntoX.Text, Anchor = AnchorStyles.Left, AutoSize = true }, 0, indiceTablaPuntos);
                    tablaPuntos.Controls.Add(new Label { Text = puntoY.Text, Anchor = AnchorStyles.Left, AutoSize = true }, 1, indiceTablaPuntos);
                    indiceTablaPuntos++;
                    puntoX.Text = "";
                    puntoY.Text = "";
                    interpolador.agregarPunto(x, y);
                }
                catch
                {
                    MessageBox.Show("Error: Caracter inválido", "Error al agregar punto", MessageBoxButtons.OK);
                }
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
            if(metodos.Text=="")
                MessageBox.Show("Error: Debe seleccionar un método para continuar", "Error al calcular polinomio interpolante", MessageBoxButtons.OK);
            else
            {
                polInterpolante = interpolador.obtenerPolinomioInterpolador();
				ContainerPolinomioInterpolante.Text = polInterpolante.Formatear();
				if (mostrarPasosBox.Checked) CargarPasos();
				ContainerGrado.Text = polInterpolante.getGrado().ToString();
				ContainerEquiespaciados.Text = interpolador.Equiespaciados();
            }
          
        }
		public void CargarPasos()
		{
			ContainerPasos.Clear();
			foreach (var paso in interpolador.metodo.obtenerPasos())
				ContainerPasos.Text += paso + Environment.NewLine;
		}

		private void ValorAEspecializar_TextChanged(object sender, EventArgs e)
		{
			if (Entrada_valida(ValorAEspecializar.Text)) {
				PolinomioEspecializado.Text = "P(" + ValorAEspecializar.Text + ") =" +
				polInterpolante.Evaluar(double.Parse(ValorAEspecializar.Text)).ToString();
			}
		}

		public bool Entrada_valida(String text) {
			return text.Length > 0;
		}
	}
}
