using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatSup
{
	public class Polinomio
	{
		public List<double> coeficientes = new List<double>();

		public Polinomio()
        {
            
        }

		public Polinomio(List<double> valores) {
			for (int i = 0; i < valores.Count; i++)
			{
				coeficientes.Add(valores[i]);
			}
		}

		public Polinomio Multiplicar(Polinomio polinomio){
			List<double> coeficientes1 = coeficientes;
			List<double> coeficientes2 = polinomio.GetCoeficientes();

			List<double> coeficientesProducto = new List<double>();

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

		public Polinomio DividirEscalar(double denominador) {
			return new Polinomio(coeficientes.ConvertAll(numerador => numerador / denominador));
		}

		public Polinomio MultiplicarEscalar(double escalar)
		{
			return new Polinomio(coeficientes.ConvertAll(numerador => numerador * escalar));
		}

		public Polinomio Sumar(Polinomio polinomio)
		{
			
            List<double> coefRes = new List<double>();
            if (this.coeficientes.Count != polinomio.coeficientes.Count)
                return polinomio;

            int pos = 0;
    		foreach(var coef in polinomio.coeficientes)
            {
                coefRes.Add(coef + this.coeficientes.ElementAt(pos));
                pos++;
            }
            Polinomio resultado = new Polinomio(coefRes);
            return resultado;
		}

		public List<double> GetCoeficientes(){
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
                    if (i != coeficientes.Count - 1)
                        formateado += " + ";
                }
					
			}
			return formateado;
		}

		public void AgregarCoeficiente(double nuevoCoeficiente) {
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
        public double Evaluar(double k)
        {
            double resultado = 0;
            for(int i = 0; i < coeficientes.Count; i++)
            {
                resultado += coeficientes[i] * (Math.Pow(k, i));
                
            }
            return resultado;
        }
	}
}
