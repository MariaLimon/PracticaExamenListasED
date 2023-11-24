using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamenListasED.Modelo
{
	public class Persona
	{
		private string _nombre;
		private int _edad;

		public Persona(string nombre, int edad )
		{
			_nombre = nombre;
			_edad = edad;
		}

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		public int Edad
		{
			get { return _edad; }
			set { _edad = value; }
		}
	}
}
