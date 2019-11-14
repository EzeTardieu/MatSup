using System;
using System.Collections.Generic;
using System.Linq;



namespace MatSup
{
    public interface Metodo
	{
		Polinomio aplicar(Dictionary<double, double> tablaValores);
	}

	public class Lagrange : Metodo
	{
        public static List<Polinomio> ls;
        List<double> xs;
        List<double> ys;
        public Polinomio aplicar(Dictionary<double, double> tablaValores)
		{
            reset();
            int grado = tablaValores.Count() - 1;
            xs = tablaValores.Keys.ToList();
            ys = tablaValores.Values.ToList();
            ls = new List<Polinomio>();

            int n = tablaValores.Count();
            
            int a = 0;
            foreach (var raiz in xs)
            {
                var xsNew = xs.Where(x => x != raiz).ToList();
                
                var pol = new Polinomio();
                pol.coeficientes.Add(1);
                foreach (var raizNew in xsNew)
                {
                    List<double> coefAux = new List<double>();
                    coefAux.Add(-raizNew);
                    coefAux.Add(1);
                    pol = pol.Multiplicar(new Polinomio(coefAux));
                }
                double denominador = 1;
                foreach (var raizNew in xsNew)
                {
                    denominador *= (xs.First(x => x == raiz) - raizNew);
                }
                pol = pol.DividirEscalar(denominador);
                Console.WriteLine("Lsub" + a + "es: " + pol.ToString());
                a++;
                ls.Add(pol);
            }
            int y = 0;

            Polinomio polInterpolante = new Polinomio();
            
            foreach (var imagen in ys)
            {
                Polinomio polAux = ls[y].MultiplicarEscalar(imagen);
                polInterpolante = polInterpolante.Sumar(polAux);
                y++;
            }
            //Console.WriteLine("Polinomio interpolante: " + polInterpolante);
            return polInterpolante;
        }
        public List<Polinomio> getLs()
        {
            return ls;
        }
        public void reset()
        {
            ls = null;
            xs = null;
            ys = null;
        }

	}

	public class NewtonGregory : Metodo
	{
		Formula formula;
        List<double> xs;
        List<double> ys;
        List<List<double>>fs; 
        public NewtonGregory(Formula _formula) {
			formula = _formula;
		}

		public Polinomio aplicar(Dictionary<double, double> tablaValores)
		{
            xs = tablaValores.Keys.ToList();
            ys = tablaValores.Values.ToList();
            fs = new List<List<double>>();
            int contadorf = 1;
            fs.Add(ys);
            calcularF(ys, contadorf);
            Polinomio polInter= formula.retornarPolinomio(fs,xs);
            return polInter;

		}
        public void reset()
        {
            fs = null;
            xs = null;
            ys = null;
        }
        private void calcularF(List<double> imagenes, int contadorF)
        {
            List<double> f = new List<double>();
            for (int i = 0; i < imagenes.Count - 1; i++)
            {
                double aux = (imagenes[i + 1] - imagenes[i]) / (xs[i + contadorF] - xs[i]);
                f.Add(aux);

            }
            fs.Add(f);
            contadorF++;
            if (imagenes.Count > 1)
                calcularF(f, contadorF);
            
        }
    }

}
