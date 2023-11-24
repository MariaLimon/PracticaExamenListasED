using PracticaExamenListasED.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamenListasED.Clases
{
	internal class ListaPersonas
	{
		private Nodo primero;
		private Nodo ultimo;

		public ListaPersonas()
		{
			primero = ultimo = null;
		}

		public bool ListaVacia()
		{
			if (primero != null)
				return false;
			return true;
		}

		public int Longitud()
		{
			int contador = 0;
			if (ListaVacia())
				return contador;
			else
			{
				Nodo actual = primero;
				if(actual.Siguiente == null)
					return ++contador;
				else
				{
					while(actual.Siguiente != null)
					{
						contador++;
						actual = actual.Siguiente;
					}
					return contador;
				}
			}

		}

		public void ImprimirLista()
		{
			if (ListaVacia())
			{
				Console.WriteLine("la lista esta vacia");
			}
			else
			{
				Nodo actual = primero;
				while (actual != null)
				{
					Console.WriteLine($"{actual.Persona.Edad},{actual.Persona.Nombre}->");
					actual = actual.Siguiente;
				}
				Console.WriteLine("->null");
			}
		}

		public void InsertarFrenteLista(Persona personaAgregada)
		{
			if (ListaVacia())
			{
				primero = ultimo = new Nodo(personaAgregada);
				Console.WriteLine("pesona agregada");
			}
			else
			{
				primero = new Nodo(personaAgregada,primero);
				Console.WriteLine("persona agregada");
			}
		}

		public void InsertarMedioLista(Persona personaAgregada)
		{
			int longitud = Longitud();
			int medio = 0;
			medio = longitud / 2;
			int contador = 0;
			Nodo actual = primero;
			Nodo anterior = null;
			while (actual != null)
			{
				if (contador == medio)
				{
					actual.Siguiente = new Nodo(personaAgregada);
					new Nodo(personaAgregada).Siguiente = actual;

				}
				anterior = actual;
				actual = actual.Siguiente;
				contador++;

				//if (ListaVacia())
				//{
				//	Console.WriteLine("lista vacia");
				//	primero = ultimo = new Nodo(personaAgregada);
				//	Console.WriteLine("persona agregada a la lista");
				//}
				//else
				//{
				//	int longitud = Longitud();
				//	Nodo actual = primero;
				//	int iterador = -1;
				//	Nodo anterior = null;
				//	while (actual.Siguiente !=null && iterador < longitud)
				//	{
				//		iterador++;
				//		actual = actual.Siguiente;
				//	}
				//	anterior = actual;
				//	Nodo nuevaPersona = new Nodo(personaAgregada, actual.Siguiente);
				//	anterior.Siguiente = nuevaPersona;
				//}
			}
		}

			public object EliminarDelFrente()
			{
				if (ListaVacia())
				{
					object eliminarElemento = primero.Persona; // recupera los datos

					// restablece las referencias primerNodo y ultimoNodo
					if (primero == ultimo)
						primero = ultimo = null;
					else
					{
						primero = primero.Siguiente;
					}

					return eliminarElemento; // devuelve los datos eliminados
				}

				return null; // Return null or handle differently if the list is empty
			}



		public void BuscarElemento(Persona personaBuacar)
		{
			int centinela = -1;
			//Nodo elemento = elementoBuscado;
			if (ListaVacia())
			{
				Console.WriteLine("La lista esta vacia");
			}
			else
			{
				//Console.WriteLine("dame el numero que buscas");
				Nodo actual = primero;
				while (actual != null)
				{
					if (actual.Persona == personaBuacar)
					{
						centinela = 1;
						Console.WriteLine("la persona se encuentra en la lista");
						break;
					}
					else
					{
						actual = actual.Siguiente;
					}
				}
				if (centinela == -1)
				{
					Console.WriteLine("la persona NO encuentra en la lista");
				}

			}
		}
		
	}
}
