using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entregable_franciso_Serafin
{
	public class Trabajador
	{
		public virtual void RealizarTarea()
		{
			Console.WriteLine("El trabajador hace tareas generales.");
		}
	}

	public class Programador : Trabajador
	{
		public override void RealizarTarea()
		{
			Console.WriteLine("El programador escribe código en C#.");
		}
	}
}
