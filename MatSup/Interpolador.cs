
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatSup
{
	public class Interpolador
	{
		public static Dictionary<double, double> tablaPuntos = new Dictionary<double, double>();
		public Metodo metodo;

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
        public static bool equiespaciados()
        {
            bool respuesta = true;
            List<double> listaOrdenada = tablaPuntos.Keys.ToList().OrderBy(i => i).ToList();
            for(int i = 0; i < tablaPuntos.Count()-2; i++)
            {
                if (listaOrdenada[i + 1] - listaOrdenada[i] == listaOrdenada[i + 2] - listaOrdenada[i + 1])
                    respuesta = true;
                else
                    return false;
            }
            return respuesta;
        }
	}
}
