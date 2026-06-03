using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entregable_franciso_Serafin
{
	public class Vehiculo
	{
		public string Marca { get; set; }

		public Vehiculo(string marca)
		{
			Marca = marca;
		}
	}

	public class Auto : Vehiculo
	{
		public int Puertas { get; set; }
		public Auto(string marca, int puertas) : base(marca)
		{
			Puertas = puertas;
		}
	}
    



    
}
