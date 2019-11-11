using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatSup
{
	public interface Formula
	{
		Polinomio aplicar(Dictionary<float, float> tablaValores);
	}

	public class Regresivo : Formula
	{
		Polinomio Formula.aplicar(Dictionary<float, float> tablaValores)
		{
			return new Polinomio();
		}
	}

	public class Progresivo : Formula
	{
		public Polinomio aplicar(Dictionary<float, float> tablaValores)
		{
			return new Polinomio();
		}
	}


}
