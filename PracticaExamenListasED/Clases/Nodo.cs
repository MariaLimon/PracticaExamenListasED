using PracticaExamenListasED.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamenListasED.Clases
{
	internal class Nodo
	{
		private Persona _persona;
		private Nodo? _siguiente;

		//contructor si es el primer o ultimo nodo
		public Nodo(Persona persona)
		{
			_persona = persona;
			_siguiente = null;
		}

		//contructor si se pone frente a un nodo
		public Nodo(Persona persona, Nodo siguiente)
		{
			_persona = persona;
			_siguiente = siguiente;
		}
		public Persona Persona
		{
			get { return _persona; }
			set { _persona = value; }
		}

		public Nodo Siguiente
		{
			get { return _siguiente; }
			set { _siguiente = value; }
		}
	}
}
