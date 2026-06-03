using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entregable_franciso_Serafin
{
	public class Motor
	{
		public void Encender() { Console.WriteLine("Encendido!"); }
	}

	public class Coche
	{
		public Motor MotorDelCoche { get; set; }

		public Coche()
		{
			MotorDelCoche = new Motor();
		}

		public void Arrancar()
		{
			MotorDelCoche.Encender(); 
		}
	}
}
