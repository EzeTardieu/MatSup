using System;
using System.Collections.Generic;
using System.Linq;



namespace MatSup
{
    public interface Metodo
	{
		Polinomio aplicar(Dictionary<float, float> tablaValores);
		List<String> obtenerPasos();
	}

	public class Lagrange : Metodo
	{
        public static List<Polinomio> ls;
		List<String> pasos = new List<string>();
        List<float> xs;
        List<float> ys;
        public Polinomio aplicar(Dictionary<float, float> tablaValores)
		{
            reset();
            int grado = tablaValores.Count() - 1;
            xs = tablaValores.Keys.ToList();
            ys = tablaValores.Values.ToList();
            ls = new List<Polinomio>();

            int n = tablaValores.Count();
            
            int a = 0;
			pasos.Add("Calcular los Li(Xi)");
			foreach (var raiz in xs)
            {
                var xsNew = xs.Where(x => x != raiz).ToList();

                var pol = new Polinomio();
                pol.coeficientes.Add(1);
                foreach (var raizNew in xsNew)
                {
                    List<float> coefAux = new List<float>();
                    coefAux.Add(-raizNew);
                    coefAux.Add(1);
                    pol = pol.Multiplicar(new Polinomio(coefAux));
                }
                float denominador = 1;
                foreach (var raizNew in xsNew)
                {
                    denominador *= (xs.First(x => x == raiz) - raizNew);
                }
                pol = pol.DividirEscalar(denominador);
                a++;
                ls.Add(pol);
				pasos.Add("L"+ a + "(" + raiz + ") = " + pol.Formatear());
            }
            int y = 0;

            Polinomio polInterpolante = new Polinomio();

			pasos.Add("Calcular el polinomio interpolante");
            
            foreach (var imagen in ys)
            {
                Polinomio polAux = ls[y].MultiplicarEscalar(imagen);
                polInterpolante = polInterpolante.Sumar(polAux);
                y++;
            }
            
            for(int b = 0; b < polInterpolante.coeficientes.Count; b++)
            {
                polInterpolante.coeficientes[b] = (float) Math.Truncate(polInterpolante.coeficientes[b] * 10000) / 10000;
            }
            
			pasos.Add("P(X)=" + polInterpolante.Formatear());
            return polInterpolante;
        }
        public List<String> obtenerPasos()
        {
            return pasos;
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
		List<String> pasos = new List<string>();
		List<float> xs;
        List<float> ys;
        List<List<float>>fs; 
        public NewtonGregory(Formula _formula) {
			formula = _formula;
		}

		public Polinomio aplicar(Dictionary<float, float> tablaValores)
		{
            xs = tablaValores.Keys.ToList();
            ys = tablaValores.Values.ToList();
            fs = new List<List<float>>();
            int contadorf = 1;
            fs.Add(ys);
            calcularF(ys, contadorf);
            Polinomio polInter= formula.retornarPolinomio(fs,xs);
			pasos.Add("Armamos el polinomio interpolante: ");
			pasos.AddRange(formula.obtenerPasos());
            for (int b = 0; b < polInter.coeficientes.Count; b++)
            {
                polInter.coeficientes[b] = (float)Math.Truncate(polInter.coeficientes[b] * 10000) / 10000;
            }
            pasos.Add("P(x) = " + polInter.Formatear());
            return polInter;

		}
		public List<String> obtenerPasos()
		{
			return pasos;
		}
		public void reset()
        {
            fs = null;
            xs = null;
            ys = null;
        }
        private void calcularF(List<float> imagenes, int contadorF)
        {
            List<float> f = new List<float>();
			pasos.Add("Calculamos las diferencias progresivas de orden " + contadorF);
            for (int i = 0; i < imagenes.Count - 1; i++)
            {
                float aux = (imagenes[i + 1] - imagenes[i]) / (xs[i + contadorF] - xs[i]);
                f.Add(aux);
				pasos.Add("ΔF" + contadorF +"(" + imagenes[i] + ") = " + aux);
            }
            fs.Add(f);
            contadorF++;
            if (f.Count > 1)
                calcularF(f, contadorF);
            
        }
    }

}
