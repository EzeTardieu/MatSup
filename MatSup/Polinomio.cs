using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatSup
{
	public class Polinomio
	{
		List<float> coeficientes = new List<float>();

		public Polinomio() { }

		public Polinomio(List<float> valores) {
			for (int i = 0; i < valores.Count; i++)
			{
				coeficientes.Add(valores[i]);
			}
		}

		public Polinomio Multiplicar(Polinomio polinomio){
			float a;
			float b;
			float c = 0;
			Polinomio resultado = new Polinomio();
			List<float> coeficientes2 = polinomio.GetCoeficientes();
			for (int i=0; i < Grado() + polinomio.Grado(); i++){
			int j = 0;
			int k = i;
				while (k >=0 && j <= i){
					Console.WriteLine("El coeficiente a" + j +" es igual a ");
					a = (j < Grado() + 1) ? coeficientes[j] : 0f;
					Console.WriteLine(a);
					Console.WriteLine("El coeficiente b" + k +" es igual a ");
					b = (k < polinomio.Grado() + 1)? coeficientes2[k]: 0f;
                    Console.WriteLine(b);
					c += a*b;
					Console.WriteLine("El coeficiente c es la multiplicacion de a" + j + " y b" + k + " = " + c);
					j++;
					k--;
                }
				coeficientes.Add(c);
			}
			return resultado;
		}

		public List<float> GetCoeficientes(){
			return coeficientes;
		}



		public string Formatear(){
			String formateado = "";
			for (int i=0; i<coeficientes.Count; i++) {
				formateado = formateado + coeficientes[i] + "X^" + i + " + ";
			}
			formateado.Remove(formateado.Length - 2);
			return formateado;
		}

		public void AgregarCoeficiente(float nuevoCoeficiente) {
			coeficientes.Add(nuevoCoeficiente);
		}

		public int Grado() {
			return coeficientes.Count - 1;
		}
	}
}
