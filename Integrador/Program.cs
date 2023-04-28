using System;

namespace Integrador
{
	class Program
	{
		public static void Main(string[] args)
		{
			bool continuar = true;
			int opcion;
			while(continuar)
			{
				menu();
				opcion = int.Parse(Console.ReadLine());
				switch(opcion)
				{
					case 1 :
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 1 - Crear empresa");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
//						agregarAbog(estudio1);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 2 :
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 2 - Agregar nueva obra");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
//						eliminarAbogado(estudio1);
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 3 :
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 3 - Modificar estado de avance de obra");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
//						mostrarAbog(estudio1);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 4 :
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 4 - Listado de obras");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
//						agregarExpediente(estudio1);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 5 :
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 5 - Contratar nuevo obrero");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
//						mostrarExpediente(estudio1);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 6 :
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 6 - Eliminar obrero");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
//						modificarEstadoExpediente(estudio1);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 7 :
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 7 - Lista de obreros");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
//						eliminarExpediente(estudio1);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 8 :
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 8 - Lista de obras finalizadas");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
//						listadoExpedientePorMes(estudio1);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 0 :
						continuar = false;
						break;
					default:
						Console.WriteLine("Opción incorrecta");
						Console.ReadKey();
						Console.Clear();
						break;
				}
			}
		}
		public static void menu()
		{
			Console.WriteLine("------------------------------------");
			Console.WriteLine(" Menu ");
			Console.WriteLine("------------------------------------");
			Console.WriteLine("");
			Console.WriteLine(" 1 - Crear empresa");
			Console.WriteLine(" 2 - Agregar nueva obra");
			Console.WriteLine(" 3 - Modificar estado de avance de obra");
			Console.WriteLine(" 4 - Listado de obras");
			Console.WriteLine(" 5 - Contratar nuevo obrero");
			Console.WriteLine(" 6 - Eliminar obrero");
			Console.WriteLine(" 7 - Lista de obreros");
			Console.WriteLine(" 8 - Lista de obras finalizadas");
			Console.WriteLine("");
			Console.WriteLine(" 0 - Salir");
			Console.WriteLine("------------------------------------");
			Console.WriteLine("Ingrese una opcion: ");
		}
	}
}