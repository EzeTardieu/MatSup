﻿using System;
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
        bool polinomioCalculado = false;

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
                    if (!interpolador.tienePunto(x))
                    {
                        Button boton = new Button { Name = indiceTablaPuntos.ToString(), Text = "x", Anchor = AnchorStyles.Top, Height = 25, AutoSize = true, BackColor = Color.Red };


                        boton.Click += (senderxd, args) =>
                        {
                            int i;
                            interpolador.sacarPunto(int.Parse(tablaPuntos.GetControlFromPosition(0, int.Parse((senderxd as Button).Name)).Text));
                            for (i = 0; i < tablaPuntos.ColumnCount; i++)
                            {
                                Control c = tablaPuntos.GetControlFromPosition(i, int.Parse((senderxd as Button).Name));
                                tablaPuntos.Controls.Remove(c);
                            }
                            tablaPuntos.RowStyles.RemoveAt(int.Parse((senderxd as Button).Name));



                        };
                        tablaPuntos.Controls.Add(new Label { Text = puntoX.Text, Anchor = AnchorStyles.Left, AutoSize = true }, 0, indiceTablaPuntos);
                        tablaPuntos.Controls.Add(new Label { Text = puntoY.Text, Anchor = AnchorStyles.Left, AutoSize = true }, 1, indiceTablaPuntos);
                        tablaPuntos.Controls.Add(boton, 2, indiceTablaPuntos);
                        indiceTablaPuntos++;
                        puntoX.Text = "";
                        puntoY.Text = "";
                        interpolador.agregarPunto(x, y);
                    }
                    else
                    {
                        MessageBox.Show("Error: Punto x ya existe en la tabla", "Error al agregar punto", MessageBoxButtons.OK);
                    }
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
            polinomioCalculado = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (interpolador.tablaPuntosVacia())
            {
              
               
                MessageBox.Show("Error: Debe agregar al menos un punto para continuar", "Error al calcular polinomio interpolante", MessageBoxButtons.OK);
            }
            else
            {
                if (!polinomioCalculado)
                {
                   
                    if (metodos.Text == "")
                        MessageBox.Show("Error: Debe seleccionar un método para continuar", "Error al calcular polinomio interpolante", MessageBoxButtons.OK);
                    else
                    {
                        polInterpolante = interpolador.obtenerPolinomioInterpolador();
                        ContainerPolinomioInterpolante.Text = polInterpolante.Formatear();
                        if (mostrarPasosBox.Checked) CargarPasos();
                        ContainerGrado.Text = polInterpolante.getGrado().ToString();
                        ContainerEquiespaciados.Text = interpolador.Equiespaciados();
                        polinomioCalculado = true;
                    }
                }
                else
                {
                    if (interpolador.necesitaRecalcular(polInterpolante))
                    {
                        ContainerPasos.Text += "El polinomio interpolante no es el mismo calculado anteriormente, se va a recalcultar..." + Environment.NewLine;
                        polinomioCalculado = false;
                        Button1_Click(sender, e);
                    }
                    else
                    {
                        
                        
                       
                        ContainerPasos.Text += "El polinomio interpolante se mantiene igual con los nuevos puntos, no se necesita recalcular" + Environment.NewLine;
                    }
                }
            }
            
            
          
        }
		public void CargarPasos()
		{
            ContainerPasos.Text = "";
            foreach (var paso in interpolador.metodo.obtenerPasos())
				ContainerPasos.Text += paso + Environment.NewLine;
		}

		private void ValorAEspecializar_TextChanged(object sender, KeyEventArgs e)
		{
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (polInterpolante != null)
                    {
                        PolinomioEspecializado.Text = "P(" + ValorAEspecializar.Text + ") =" +
                        polInterpolante.Evaluar(float.Parse(ValorAEspecializar.Text)).ToString();

                    }
                    else
                    {
                        MessageBox.Show("Error: Polinomio interpolante debe ser calculado previamente", "Error al especializar", MessageBoxButtons.OK);
                    }
                }



                catch
                {
                    MessageBox.Show("Error: entrada inválida", "Error al especializar", MessageBoxButtons.OK);

                }


            }
        }
			

		
	}
}
