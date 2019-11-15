using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatSup
{
	public class Polinomio
	{
		public List<float> coeficientes = new List<float>();

		public Polinomio()
        {
            
        }

		public Polinomio(List<float> valores) {
			for (int i = 0; i < valores.Count; i++)
			{
				this.AgregarCoeficiente(valores[i]);
			}
		}

		public Polinomio Multiplicar(Polinomio polinomio){
			List<float> coeficientes1 = coeficientes;
			List<float> coeficientes2 = polinomio.GetCoeficientes();

			List<float> coeficientesProducto = new List<float>();

			for (int i = 0; i < Grado() + polinomio.Grado() - 1; i++)
				coeficientesProducto.Add(0);

			for (int i = 0; i < Grado(); i++)
			{
				for (int j = 0; j < polinomio.Grado(); j++)
					coeficientesProducto[i + j] += coeficientes1[i] * coeficientes2[j];
			}

			for (int i = 0; i < Grado() + polinomio.Grado() - 1; i++)
				Console.WriteLine(coeficientesProducto[i]);

			return new Polinomio(coeficientesProducto);
		}

		public Polinomio DividirEscalar(float denominador) {
			return new Polinomio(coeficientes.ConvertAll(numerador => numerador / denominador));
		}

		public Polinomio MultiplicarEscalar(float escalar)
		{
			return new Polinomio(coeficientes.ConvertAll(numerador => numerador * escalar));
		}

		public Polinomio Sumar(Polinomio polinomio)
		{
            Polinomio resultado = new Polinomio();
            for (int i = 0; i < Grado() ; i++)
            {
                resultado.AgregarCoeficiente(coeficientes[i]);
            }

            for (int i = 0; i < polinomio.Grado() ; i++)
            {
                if (i < resultado.GetCoeficientes().Count)
                    resultado.GetCoeficientes()[i] += polinomio.GetCoeficientes()[i];
                else
                    resultado.AgregarCoeficiente(polinomio.GetCoeficientes()[i]);
            }
            return resultado;
        }

        public List<float> GetCoeficientes(){
			return coeficientes;
		}

		public string Formatear(){
			String formateado = "";
			for (int i=0; i<coeficientes.Count; i++) {
				if (coeficientes[i] != 0)
                {
                    formateado += coeficientes[i];
                    if (i != 0)
                        formateado += "X^" + i;

                    if (i != coeficientes.Count - 1 && coeficientes[i+1]!=0)
						formateado += (coeficientes[i+1] >= 0) ? "+" : "";
                        
                }
					
			}
			return formateado;
		}

        public void AgregarCoeficiente(float nuevoCoeficiente) {
            coeficientes.Add(nuevoCoeficiente);

		}


		public int Grado() {// cuenta los cero, no funciona
			return coeficientes.Count;
		}
        public int getGrado()
        {
            int grado;
            for(int i = coeficientes.Count-1; i > 0; i--)
            {
                if(coeficientes[i]!=0)
                return i;
            }
            return 0;
        }
        public float Evaluar(float k)
        {
            float resultado = 0;
            for(int i = 0; i < coeficientes.Count; i++)
            {
                resultado += coeficientes[i] * ((float)Math.Pow(k, i));
                
            }
            return resultado;
        }
	}
}
