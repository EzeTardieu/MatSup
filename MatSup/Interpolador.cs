using CenterSpace.NMath.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatSup
{
	public class Interpolador
	{
		private Dictionary<double, double> tablaPuntos = new Dictionary<double, double>();
		private Metodo metodo;

		public Interpolador() { }

		public void setMetodo(Metodo nuevo_metodo) {
			metodo = nuevo_metodo;
		}

		public void agregarPunto(float x, float y) {
			tablaPuntos.Add(x, y);
		}

		public Polinomio obtenerPolinomioInterpolador() {
			Polinomio pol1 = new Polinomio();
			Polinomio pol2 = new Polinomio();
			pol1.AgregarCoeficiente(3);
			pol1.AgregarCoeficiente(0);
			pol1.AgregarCoeficiente(1);
			pol2.AgregarCoeficiente(1);
			pol2.AgregarCoeficiente(1);
			return pol1.Multiplicar(pol2);
		}

	}
}
