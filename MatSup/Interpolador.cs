using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatSup
{
	public class Interpolador
	{
		private Dictionary<float, float> tablaPuntos = new Dictionary<float, float>();
		private Metodo metodo;

		public Interpolador() { }

		public void setMetodo(Metodo nuevo_metodo) {
			metodo = nuevo_metodo;
		}

		public void agregarPunto(float x, float y) {
			tablaPuntos.Add(x, y);
		}

		public Polinomio obtenerPolinomioInterpolador() {
			return metodo.aplicar(tablaPuntos);
		}

	}
}
