using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatSup {
	public interface Formula {
		Polinomio retornarPolinomio (List<List<double>> fs, List<double> xs);
	}

	public class Regresivo : Formula {
        public Polinomio retornarPolinomio(List<List<double>> fs, List<double> xs)
        {
			foreach(var f in fs) f.Reverse();
            xs.Reverse();

            Polinomio polInterpolante = new Polinomio();
            for (int j = 0; j < fs.Count - 1; j++)
            {
                Polinomio termino = new Polinomio();
                termino.AgregarCoeficiente(1);
                for (int i = 0; i < j; i++)
                {
                    Polinomio aux = new Polinomio();
                    aux.AgregarCoeficiente(-xs[i]);
                    aux.AgregarCoeficiente(1);
                    termino = termino.Multiplicar(aux);
                }
                termino = termino.MultiplicarEscalar(fs[j].First());
                polInterpolante = polInterpolante.Sumar(termino);
            }
            return polInterpolante;
        }

    }

	public class Progresivo : Formula {
		public Polinomio retornarPolinomio (List<List<double>> fs, List<double> xs) {
			Polinomio polInterpolante = new Polinomio ();
			for(int j = 0; j < fs.Count-1; j++) {
				Polinomio termino = new Polinomio ();
				termino.AgregarCoeficiente(1);
				for (int i = 0; i < j; i++) {
					Polinomio aux = new Polinomio();
					aux.AgregarCoeficiente(-xs[i]);
					aux.AgregarCoeficiente(1);
					termino = termino.Multiplicar(aux);
				}
				termino = termino.MultiplicarEscalar(fs[j].First());
				polInterpolante = polInterpolante.Sumar(termino);
			}
			return polInterpolante;
		}
	}

}