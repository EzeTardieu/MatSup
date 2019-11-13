using System;
using System.Collections.Generic;
using System.Linq;
using CenterSpace.NMath.Core;


namespace MatSup
{
    public interface Metodo
	{
		Polinomio aplicar(Dictionary<double, double> tablaValores);
	}

	public class Lagrange : Metodo
	{
        
        public Polinomio aplicar(Dictionary<double, double> tablaValores)
		{
			/*
            int grado = tablaValores.Count()-1;
            double[] xs = tablaValores.Keys.ToArray();
            double[] ys = tablaValores.Values.ToArray();
            
            DoubleVector cerosMath = new DoubleVector(tablaValores.Count(),0);
            int n = tablaValores.Count();
            List<Polynomial> ls = new List<Polynomial>();
            int a = 0;
            foreach(var raiz in xs)
            {
                var xsNew = xs.Where(x => x != raiz).ToArray();
                var xsMath = new DoubleVector(xsNew);
                var pol = new Polynomial(new DoubleVector(new double[] { 1}));
                foreach(var raizNew in xsNew)
                {
                    pol *= new Polynomial(new DoubleVector(new double[] { -raizNew, 1 }));
                }
                double denominador = 1;
                foreach (var raizNew in xsNew)
                {
                    denominador *= (xs.First(x => x == raiz) - raizNew);
                }
                pol /= denominador;
                Console.WriteLine("Lsub" + a + "es: " + pol.ToString());
                a++;
                ls.Add(pol);   
            }
            int y = 0;
            Polynomial polInterpolante = new Polynomial();
            foreach(var imagen in ys)
            {
                polInterpolante += (imagen * ls[y]);
                y++;
            }
            Console.WriteLine("Polinomio interpolante: " + polInterpolante);
            return polInterpolante;
			*/
			return new Polinomio();
		}


	}

	public class NewtonGregory : Metodo
	{
		Formula formula;

		public NewtonGregory(Formula _formula) {
			formula = _formula;
		}

		public Polinomio aplicar(Dictionary<double, double> tablaValores)
		{
            Polynomial pol = new Polynomial(new DoubleVector(new double[] { -2 ,1}));
            Console.WriteLine("el polinomio es: " + pol.ToString());
            return null;
		}
	}

}
