using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entregable_franciso_Serafin
{

	public class Termometro
	{
		public double Temperatura { get; private set; }

		public Termometro()
		{
			Temperatura = 20.0;
		}

		public void Actualizar(double lecturaSensor)
		{
			if (lecturaSensor >= -50.0 && lecturaSensor <= 100.0)
			{
				Temperatura = lecturaSensor;
			}
			else
			{
				Console.WriteLine("Error: Lectura extrema ignorada.");
			}
		}
	}
}
