
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
        public void sacarPunto(float x)
        {
            tablaPuntos.Remove(x);
        }
        public bool tienePunto(float x)
        {
            return tablaPuntos.ContainsKey(x);
        }
        public bool tablaPuntosVacia()
        {
            return tablaPuntos.Count<1;
        }
        public bool necesitaRecalcular(Polinomio polInterpolante){
            bool respuesta = false;
            if (polInterpolante.getGrado() >= tablaPuntos.Count)
            {
                return true;
            }
            
            foreach(var par in tablaPuntos){
                float key = par.Key;
                float value = par.Value;
                respuesta = polInterpolante.Evaluar(key) != value;
                if (respuesta == true) return respuesta;
            }
            return respuesta;
        }

		public Polinomio obtenerPolinomioInterpolador() {
            return metodo.aplicar(tablaPuntos);
		}
        public string Equiespaciados()
        {
            String respuesta = "Si";
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
