using System;

namespace Integrador
{
	class Program
	{
		public static void Main(string[] args)
		{
			Empresa emp1 = new Empresa("Empresa Constructora", "alejo@mail", "Argentina");
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
						Console.WriteLine(" 1 - Agregar obra");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
						agregarObra(emp1);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 2 :
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 2 - Modificar estado de avance de la obra");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
						modificarEstado(emp1);
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 3 :
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 3 - Listado de obras");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
						mostrarObra(emp1);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 4 :
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 4 - Contratar nuevo obrero");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
						contratarObrero(emp1);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 5 :
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 5 - Lista de obreros");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
						listaObreros(emp1);
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
						eliminarObrero(emp1);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 7 :
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 7 - Lista de obras finalizadas");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
//						eliminarExpediente(estudio1);
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
			Console.WriteLine(" 1 - Agregar nueva obra");
			Console.WriteLine(" 2 - Modificar estado de avance de obra");
			Console.WriteLine(" 3 - Listado de obras");
			Console.WriteLine(" 4 - Contratar nuevo obrero");
			Console.WriteLine(" 5 - Lista de obreros");
			Console.WriteLine(" 6 - Eliminar obrero");
			Console.WriteLine(" 7 - Lista de obras finalizadas");
			Console.WriteLine("");
			Console.WriteLine(" 0 - Salir");
			Console.WriteLine("");
			Console.WriteLine("------------------------------------");
			Console.WriteLine("Ingrese una opcion: ");
		}
		public static void agregarObra(Empresa e1)
		{
			if(e1.cantidadObra() < 4)
			{
				Console.WriteLine("Ingrese el nombre del propietario: ");
				string nombrePropietario = Console.ReadLine();
				Console.WriteLine("Ingrese DNI del propietario: ");
				int dniPropietario = int.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese código de obra: ");
				int codigodeobra = int.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese tipo de obra: ");
				string tipodeobra = Console.ReadLine();
				Console.WriteLine("Ingrese cantidad de días estimados de ejecución: ");
				int diasdejecucion = int.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese costo de obra: ");
				double costo = double.Parse(Console.ReadLine());
				Console.WriteLine("Asignar N° de grupo de obreros: ");
				int nrodegrupo = int.Parse(Console.ReadLine());
				if(e1.cantidadGrupo() < 3)
				{
					Obra ob1 = new Obra(nombrePropietario, dniPropietario, codigodeobra, tipodeobra, diasdejecucion, costo, nrodegrupo);
					e1.agregarObra(ob1);
					Grupo g1 = new Grupo(codigodeobra, nrodegrupo);
					e1.agregarGrupo(g1);
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("\n- Has creado exitosamente la obra -");
					Console.ForegroundColor = ConsoleColor.White;
				}
				else
				{
					Console.WriteLine("- No hay más grupos para asignar la obra -");
				}
			}
			else
			{
				Console.WriteLine("- Cupo de obras completo -");
			}
		}
		public static void modificarEstado(Empresa e1)
		{
			bool existe = false;
			foreach(Obra elem in e1.ListaObras)
			{
				if(e1.existeObra(elem) != existe)
				{
					existe = true;
					Console.WriteLine("Ingrese el código de obra para modificar su estado de avance: ");
					int codigo = int.Parse(Console.ReadLine());
					Console.WriteLine();
					if(elem.Cod_obra == codigo)
					{
						Console.WriteLine("Modifique el estado en el que se encuentra la obra: ");
						int estado = int.Parse(Console.ReadLine());
						elem.Estado = estado;
						Console.WriteLine("\n- Estado de avance cambiado correctamente -\n");
					}
					else
					{
						Console.WriteLine("- Código incorrecto -\n");
					}
				}
			}
			if(!existe)
			{
				Console.WriteLine("- Debe agregar una obra primero -\n");
			}
		}
		public static void mostrarObra(Empresa e1)
		{
			bool existe = false;
			foreach(Obra elem in e1.ListaObras)
			{
				if(e1.existeObra(elem) != existe)
				{
					existe = true;
					Console.WriteLine("- Ingrese el código de obra a buscar -");
					int codigo = int.Parse(Console.ReadLine());
					Console.WriteLine();
					if(elem.Cod_obra == codigo)
					{
						elem.imprimirObra();
					}
					else
					{
						Console.WriteLine("- Código de obra erróneo -");
					}
				}
			}
			if(!existe)
			{
				Console.WriteLine("- No existen obras -");
			}
		}
		public static void contratarObrero(Empresa e1)
		{
			bool existe = false;
			foreach(Obra elem in e1.ListaObras)
			{
				if(e1.existeObra(elem) != existe)
				{
					existe = true;
					Console.WriteLine("Agregue los datos del obrero \n");
					Console.WriteLine("Ingrese el nombre: ");
					string nombreObrero = Console.ReadLine();
					Console.WriteLine("Ingrese el apellido: ");
					string apellidoObrero = Console.ReadLine();
					Console.WriteLine("Ingrese DNI: ");
					int dni = int.Parse(Console.ReadLine());
					Console.WriteLine("Ingrese legajo: ");
					int legajo = int.Parse(Console.ReadLine());
					Console.WriteLine("Ingrese el cargo: ");
					string cargo = Console.ReadLine();
					Console.WriteLine("Asigne un N° de grupo para el obrero: ");
					int n_grupo = int.Parse(Console.ReadLine());
					if(e1.cantidadGrupo() <= 1)
					{
						foreach(Grupo elem1 in e1.ListaGrupos)
						{
							if(n_grupo == elem1.Nro_grupo && elem1.cantidadObrero() <= 2)
							{
								Obrero ob1 = new Obrero(nombreObrero, apellidoObrero, dni, legajo, cargo, n_grupo);
								e1.agregarObrero(ob1);
								elem1.agregarObrero(ob1);
								Console.ForegroundColor = ConsoleColor.Green;
								Console.WriteLine("\n- Obrero contratado exitosamente -");
								Console.ForegroundColor = ConsoleColor.White;
							}
							else
							{
								Console.WriteLine("- Número de grupo erróneo o cantidad de obreros por grupo excedido -");
							}
						}
					}
					else
					{
						Console.WriteLine("- Cantidad de grupos excedido -");
					}
				}
			}
			if(!existe)
			{
				Console.WriteLine("- Primero debe crear una obra -");
			}
		}
		public static void listaObreros(Empresa e1)
		{
			if(e1.cantidadObrero() > 0)
			{
				Console.WriteLine("- Datos de los obreros - \n");
				foreach(Obrero elem in e1.ListaObreros)
				{
					elem.imprimirObrero();
				}
			}
			else
			{
				Console.WriteLine("- No hay obreros existentes -");
			}
		}
		public static void eliminarObrero(Empresa e1)
		{
			if(e1.cantidadObrero() > 0)
			{
				Console.WriteLine("- Ingrese legajo de obrero a eliminar - \n");
				int legajo = int.Parse(Console.ReadLine());
				foreach(Obrero elem in e1.ListaObreros)
				{
					foreach(Grupo elem1 in e1.ListaGrupos)
					{
						if(elem.Legajo == legajo)
						{
							e1.eliminarObrero(legajo);
							elem1.eliminarObrero(legajo);
							Console.WriteLine("\n- Eliminado correctamente -");
						}
						else
						{
							Console.WriteLine("- Legajo incorrecto -");
						}
					}
				}
			}
			else
			{
				Console.WriteLine("- No hay obreros existentes -");
			}
		}
		public static void listaObrasFin(){
			
		}

	}
}