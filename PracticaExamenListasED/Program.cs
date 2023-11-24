using PracticaExamenListasED.Clases;
using PracticaExamenListasED.Modelo;

namespace PracticaExamenListasED
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			Persona persona = new Persona("lllll",27);

			ListaPersonas listaPersonas = new ListaPersonas();

			listaPersonas.InsertarFrenteLista(persona);
			listaPersonas.ImprimirLista();

			Persona persona2 = new Persona("lllll", 12);
			listaPersonas.InsertarFrenteLista(persona2);
			listaPersonas.ImprimirLista();

			Persona persona3 = new Persona("llll", 5985555 );
			listaPersonas.InsertarFrenteLista(persona3);

			Persona persona4 = new Persona("llll", 59844444);
			listaPersonas.InsertarFrenteLista(persona4);

			Persona persona5 = new Persona("ññññ", 0);
			listaPersonas.InsertarMedioLista(persona5);
			listaPersonas.ImprimirLista();
		}
	}
}