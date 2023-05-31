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
						Console.WriteLine("--------------------------------------------------------");
						Console.WriteLine(" 1 - Agregar obra -");
						Console.WriteLine("--------------------------------------------------------\n");
						agregarObra(emp1);
						Console.WriteLine("\n--------------------------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 2 :
						Console.Clear();
						Console.WriteLine("--------------------------------------------------------");
						Console.WriteLine(" 2 - Modificar estado de avance de la obra -");
						Console.WriteLine("--------------------------------------------------------\n");
						modificarEstado(emp1);
						Console.WriteLine("\n--------------------------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 3 :
						Console.Clear();
						Console.WriteLine("--------------------------------------------------------");
						Console.WriteLine(" 3 - Listado de obras -");
						Console.WriteLine("--------------------------------------------------------\n");
						mostrarObra(emp1);
						Console.WriteLine("\n--------------------------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 4 :
						Console.Clear();
						Console.WriteLine("--------------------------------------------------------");
						Console.WriteLine(" 4 - Contratar nuevo obrero -");
						Console.WriteLine("--------------------------------------------------------\n");
						contratarObrero(emp1);
						Console.WriteLine("\n--------------------------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 5 :
						Console.Clear();
						Console.WriteLine("--------------------------------------------------------");
						Console.WriteLine(" 5 - Lista de obreros -");
						Console.WriteLine("--------------------------------------------------------\n");
						mostrarObreros(emp1);
						Console.WriteLine("\n--------------------------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 6 :
						Console.Clear();
						Console.WriteLine("--------------------------------------------------------");
						Console.WriteLine(" 6 - Eliminar obrero -");
						Console.WriteLine("--------------------------------------------------------\n");
						eliminarObrero(emp1);
						Console.WriteLine("\n--------------------------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 7 :
						Console.Clear();
						Console.WriteLine("--------------------------------------------------------");
						Console.WriteLine(" 7 - Lista de obras finalizadas -");
						Console.WriteLine("--------------------------------------------------------\n");
						listaObrasFin(emp1);
						Console.WriteLine("\n--------------------------------------------------------");
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
			Console.WriteLine("--------------------------------------------------------");
			Console.WriteLine(" Menu ");
			Console.WriteLine("--------------------------------------------------------\n");
			Console.WriteLine(" 1 - Agregar nueva obra");
			Console.WriteLine(" 2 - Modificar estado de avance de obra");
			Console.WriteLine(" 3 - Listado de obras");
			Console.WriteLine(" 4 - Contratar nuevo obrero");
			Console.WriteLine(" 5 - Lista de obreros");
			Console.WriteLine(" 6 - Eliminar obrero");
			Console.WriteLine(" 7 - Lista de obras finalizadas");
			Console.WriteLine("");
			Console.WriteLine(" 0 - Salir");
			Console.WriteLine("\n--------------------------------------------------------");
			Console.WriteLine("Ingrese una opción: ");
		}
		public static void agregarObra(Empresa e1)
		{
			if(e1.cantidadObra() < 2)
			{
				Console.WriteLine("Ingrese datos del propietario: \n");
				Console.WriteLine("Nombre: ");
				string nombrePropietario = Console.ReadLine();
				Console.WriteLine("DNI: ");
				int dniPropietario = int.Parse(Console.ReadLine());
				Console.WriteLine("Código de obra: ");
				int codigodeobra = int.Parse(Console.ReadLine());
				Console.WriteLine("Tipo de obra: ");
				string tipodeobra = Console.ReadLine();
				Console.WriteLine("Cantidad de días estimados de ejecución: ");
				int diasdejecucion = int.Parse(Console.ReadLine());
				Console.WriteLine("Costo de obra: ");
				double costo = double.Parse(Console.ReadLine());
				try
				{
					if(e1.cantidadGrupo() < 2)
					{
						Console.WriteLine("Asigne el N° de grupo de obreros: ");
						int nrodegrupo = int.Parse(Console.ReadLine());
						Obra ob1 = new Obra(nombrePropietario, dniPropietario, codigodeobra, tipodeobra, diasdejecucion, costo, nrodegrupo);
						e1.agregarObra(ob1);
						Grupo g1 = new Grupo(codigodeobra, nrodegrupo);
						e1.agregarGrupo(g1);
						Console.WriteLine("\n- Has creado exitosamente la obra -");
					}
					else
					{
						throw new Exception_Grupo();
					}
				}
				catch(Exception_Grupo)
				{
					Console.WriteLine("\n(Excepción)\n- No hay grupos disponibles para asignar -");
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
			foreach(Obra elem in e1.todasObras())
			{
				if(e1.existeObra(elem) != existe)
				{
					existe = true;
					Console.WriteLine("Ingrese el código de obra para modificar su estado de avance: ");
					int codigo = int.Parse(Console.ReadLine());
					if(elem.Cod_obra == codigo)
					{
						Console.WriteLine("\nModifique el estado en el que se encuentra la obra: ");
						int estado = int.Parse(Console.ReadLine());
						elem.Estado = estado;
						Console.WriteLine("\n- Estado de avance actualizado -");
						
					}
					else
					{
						Console.WriteLine("\n- Código incorrecto -");
					}
				}
			}
			if(!existe)
			{
				Console.WriteLine("- No existen obras -");
			}
		}
		public static void mostrarObra(Empresa e1)
		{
			bool existe = false;
			foreach(Obra elem in e1.todasObras())
			{
				Console.WriteLine("- Ingrese el código de obra a buscar -");
				int codigo = int.Parse(Console.ReadLine());
				Console.WriteLine();
				if(e1.existeObra(elem) != existe)
				{
					existe = true;
					if(elem.Cod_obra == codigo)
					{
						if(elem.Estado != 100)
						{
							elem.imprimirObra();
						}
						else
						{
							Console.WriteLine("- La obra se encuentra finalizada -");
						}
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
			foreach(Obra elem in e1.todasObras())
			{
				if(e1.existeObra(elem) != existe)
				{
					existe = true;
					Console.WriteLine("Agregue los datos del obrero: \n");
					Console.WriteLine("Nombre: ");
					string nombreObrero = Console.ReadLine();
					Console.WriteLine("Apellido: ");
					string apellidoObrero = Console.ReadLine();
					Console.WriteLine("DNI: ");
					int dni = int.Parse(Console.ReadLine());
					Console.WriteLine("Legajo: ");
					int legajo = int.Parse(Console.ReadLine());
					Console.WriteLine("Cargo: ");
					string cargo = Console.ReadLine();
					Console.WriteLine("Asigne un N° de grupo para el obrero: ");
					int n_grupo = int.Parse(Console.ReadLine());
					if(e1.cantidadGrupo() <= 1)
					{
						foreach(Grupo elem1 in e1.todosGrupos())
						{
							if(n_grupo == elem1.Nro_grupo && elem1.cantidadObrero() <= 2)
							{
								Obrero ob1 = new Obrero(nombreObrero, apellidoObrero, dni, legajo, cargo, n_grupo);
								e1.agregarObrero(ob1);
								elem1.agregarObrero(ob1);
								Console.WriteLine("\n- Obrero contratado exitosamente -");
							}
							else
							{
								Console.WriteLine("\n- Número de grupo erróneo o cantidad de obreros por grupo excedido -");
							}
						}
					}
				}
			}
			if(!existe)
			{
				Console.WriteLine("- Primero debe crear una obra -");
			}
		}
		public static void mostrarObreros(Empresa e1)
		{
			if(e1.cantidadObrero() > 0)
			{
				Console.WriteLine("- Datos de los obreros - \n");
				foreach(Obrero elem in e1.ListaObreros)
				{
					elem.imprimirObrero();
					Console.WriteLine();
				}
			}
			else
			{
				Console.WriteLine("- No hay obreros existentes -");
			}
		}
		public static void eliminarObrero(Empresa e1)
		{
			if (e1.cantidadObrero() > 0)
			{
				bool eliminado = false;
				Console.WriteLine("- Ingrese legajo del obrero a eliminar -");
				int legajo = int.Parse(Console.ReadLine());
				foreach(Obrero elem in e1.ListaObreros)
				{
					foreach(Grupo elem1 in e1.ListaGrupos)
					{
						if(elem.Legajo == legajo)
						{
							eliminado = true;
							e1.eliminarObrero(elem);
							elem1.eliminarObrero(elem);
							Console.WriteLine("\n- Eliminado correctamente -");
						}
						else
						{
							Console.WriteLine("\n- Legajo incorrecto -");
						}
					}
					if(eliminado)
					{
						break;
					}
				}
			}
			else
			{
				Console.WriteLine("- No hay obreros existentes -");
			}
		}
		public static void listaObrasFin(Empresa e1)
		{
			if(e1.cantidadObra() > 0)
			{
				bool existe = false;
				foreach(Obra elem in e1.ListaObras)
				{
					if(elem.Estado == 100)
					{
						if(e1.existeObra(elem) != existe)
						{
							existe = true;
							elem.imprimirObra();
						}
					}
				}
				if(!existe)
				{
					Console.WriteLine("- Aún no hay obras finalizadas -");
				}
			}
			else
			{
				Console.WriteLine("- No existen obras -");
			}
		}
	}
}