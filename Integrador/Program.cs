using System;
using System.Collections;

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
//						mostrarObras(emp1);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 5 :
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 5 - Eliminar obrero");
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
						Console.WriteLine(" 6 - Lista de obreros");
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
			Console.WriteLine(" 5 - Eliminar obrero");
			Console.WriteLine(" 6 - Lista de obreros");
			Console.WriteLine(" 7 - Lista de obras finalizadas");
			Console.WriteLine("");
			Console.WriteLine(" 0 - Salir");
			Console.WriteLine("");
			Console.WriteLine("------------------------------------");
			Console.WriteLine("Ingrese una opcion: ");
		}
//		public static void nuevaEmpresa(Empresa e1)
//		{
//			if(e1.cantidadEmpresa() < 1)
//			{
//				Console.Write("Ingrese el nombre de la empresa: ");
//				string nombreEmpresa = Console.ReadLine();
//				Console.Write("Ingrese el mail de la empresa: ");
//				string mailEmpresa = Console.ReadLine();
//				Console.Write("Ingrese la dirección de la empresa: ");
//				string direccion = Console.ReadLine();
//				Empresa emp1 = new Empresa(nombreEmpresa, mailEmpresa, direccion);
//				e1.agregarEmpresa(emp1);
//				Console.ForegroundColor = ConsoleColor.Green;
//				Console.WriteLine("Empresa creada Exitosamente!"+"\n");
//				Console.ForegroundColor = ConsoleColor.White;
//			}
//			else
//			{
//				Console.WriteLine("Cupo de empresas excedido");
//			}
//		}
		public static void agregarObra(Empresa e1)
		{
			if(e1.cantidadObra() <= 1)
			{
				Console.WriteLine("Ingrese el nombre del propietario: ");
				string nombrePropietario = Console.ReadLine();
				Console.WriteLine("Ingrese el DNI del propietario: ");
				int dniPropietario = int.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese el tipo de obra: ");
				string tipodeobra = Console.ReadLine();
				Console.WriteLine("Ingrese costo de obra: ");
				double costo = double.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese el codigo de obra: ");
				int codigodeobra = int.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese la cantidad de dias estimados de ejecucion: ");
				int diasdejecucion = int.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese Numero de grupo de obreros: ");
				int nrodegrupo = int.Parse(Console.ReadLine());
				Obra ob1 = new Obra(nombrePropietario, dniPropietario, tipodeobra, costo, codigodeobra, diasdejecucion, nrodegrupo);
				e1.agregarObraEMP(ob1);
				Console.WriteLine("Has creado exitosamente la obra");
			}
			else
			{
				Console.WriteLine("Cupo de obras completo");
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
					if(elem.Cod_obra == codigo)
					{
						Console.WriteLine("Modifique el estado en el que se encuentra la obra: ");
						int estado = int.Parse(Console.ReadLine());
						elem.Estado = estado;
					}
					else
					{
						Console.WriteLine("Código incorrecto \n");
					}
				}
			}
			if(!existe)
			{
				Console.WriteLine("Debe agregar una obra primero \n");
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
					Console.WriteLine("Ingrese el código de obra a buscar: ");
					int codigo = int.Parse(Console.ReadLine());
					if(elem.Cod_obra == codigo)
					{
						elem.imprimirObra();
					}
					else
					{
						Console.WriteLine("Código de obra erróneo");
					}
				}
			}
			if(!existe)
			{
				Console.WriteLine("No existen obras");
			}
		}
		public static void contratarObrero(){
			
		}
//		public static void eliminarObrero(string opcion, Empresa empresa, Grupo grupo){
//			Obrero dniobrero = new Obrero();
//			int dniEliminar;
//			Console.WriteLine("Ingrese el DNI del obrero a eliminar: ");
//			dniEliminar = int.Parse(Console.ReadLine());
//			if(dniEliminar == dniobrero.Dni){
//				empresa.eliminarObrero();
//				grupo.eliminarObrero(dniEliminar);
//				Console.WriteLine("Obrero Eliminado con exito");
//			}
//			else{
//				Console.WriteLine("No se encontro ningun Obrero con ese DNI");
//			}
//
//		}
		public static void listaObreros( string opcion, Grupo grupo){
			if(grupo.ListaObreros.Count != 0 ){
				foreach(Obrero obrero in grupo.ListaObreros){
					obrero.imprimirObrero();
				}
			}
			else{
				Console.WriteLine("Lista vacia");
			}
//			resultadoSubmenu(opcion);
		}
		public static void listaObrasFin(){
			
		}

	}
}