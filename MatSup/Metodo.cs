using System.Collections.Generic;
using System.Linq;

namespace MatSup
{
    public interface Metodo
	{
		Polinomio aplicar(Dictionary<float, float> tablaValores);
	}

	public class Lagrange : Metodo
	{
        
        public Polinomio aplicar(Dictionary<float, float> tablaValores)
		{
            int grado = tablaValores.Count()-1;
            float[] xs = tablaValores.Keys.ToArray();
            float[] ys = tablaValores.Values.ToArray();
            int i = 0;
            int n = tablaValores.Count();
            float[][] L;


            return new Polinomio();
		}


	}

	public class NewtonGregory : Metodo
	{
		Formula formula;

		public NewtonGregory(Formula _formula) {
			formula = _formula;
		}

		public Polinomio aplicar(Dictionary<float, float> tablaValores)
		{
			Polinomio polinomio = new Polinomio();
			Polinomio polinomio2 = new Polinomio();
			polinomio.AgregarCoeficiente(1);
			polinomio.AgregarCoeficiente(1);
			polinomio2.AgregarCoeficiente(1);
			polinomio2.AgregarCoeficiente(1);
			return polinomio.Multiplicar(polinomio2);
			//return formula.aplicar(tablaValores);
		}
	}

}
