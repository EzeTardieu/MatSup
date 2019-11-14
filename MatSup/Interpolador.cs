
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatSup
{
	public class Interpolador
	{
		public static Dictionary<float, float> tablaPuntos = new Dictionary<float, float>();
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
        public string Equiespaciados()
        {
            String respuesta = "No";
            List<float> listaOrdenada = tablaPuntos.Keys.ToList().OrderBy(i => i).ToList();
            for(int i = 0; i < tablaPuntos.Count()-2; i++)
            {
				if (listaOrdenada[i + 1] - listaOrdenada[i] == listaOrdenada[i + 2] - listaOrdenada[i + 1])
					respuesta = "Si";
				else
					return "No";
            }
            return respuesta;
        }
	}
}
