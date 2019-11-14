using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatSup {
	public interface Formula {
		Polinomio retornarPolinomio (List<List<float>> fs, List<float> xs);
		List<String> obtenerPasos();
	}

	public class Regresivo : Formula {

		List<String> pasos = new List<String>();
        public Polinomio retornarPolinomio(List<List<float>> fs, List<float> xs)
        {
			foreach(var f in fs) f.Reverse();
            xs.Reverse();
			String polinomioSinResolver = "P(x)=";
            Polinomio polInterpolante = new Polinomio();
            for (int j = 0; j < fs.Count - 1; j++)
            {
                Polinomio termino = new Polinomio();
                termino.AgregarCoeficiente(1);
				polinomioSinResolver += fs[j].First().ToString();
                for (int i = 0; i < j; i++)
                {
                    Polinomio aux = new Polinomio();
                    aux.AgregarCoeficiente(-xs[i]);
                    aux.AgregarCoeficiente(1);
					polinomioSinResolver += "(x-" + xs[i] + ")";
					termino = termino.Multiplicar(aux);
                }
				if(j!=fs.Count - 1) polinomioSinResolver += "+";
				termino = termino.MultiplicarEscalar(fs[j].First());
                polInterpolante = polInterpolante.Sumar(termino);
				pasos.Add(polinomioSinResolver);
            }
            return polInterpolante;
        }
		public List<String> obtenerPasos()
		{
			return pasos;
		}
	}

	public class Progresivo : Formula {

		List<String> pasos = new List<String>();
		public Polinomio retornarPolinomio (List<List<float>> fs, List<float> xs) {
			String polinomioSinResolver = "P(x)=";
			Polinomio polInterpolante = new Polinomio();
			for (int j = 0; j < fs.Count - 1; j++)
			{
				Polinomio termino = new Polinomio();
				termino.AgregarCoeficiente(1);
				polinomioSinResolver += fs[j].First().ToString();
				for (int i = 0; i < j; i++)
				{
					Polinomio aux = new Polinomio();
					aux.AgregarCoeficiente(-xs[i]);
					aux.AgregarCoeficiente(1);
					polinomioSinResolver += "(x-" + xs[i] + ")";
					termino = termino.Multiplicar(aux);
				}
				if (j != fs.Count - 1 ) polinomioSinResolver += "+";
				termino = termino.MultiplicarEscalar(fs[j].First());
				polInterpolante = polInterpolante.Sumar(termino);
				pasos.Add(polinomioSinResolver);
			}
			return polInterpolante;
		}
		public List<String> obtenerPasos()
		{
			return pasos;
		}
	}

}