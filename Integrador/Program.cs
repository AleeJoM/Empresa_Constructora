using System;

namespace Integrador
{
	class Program
	{
		public static void Main(string[] args)
		{
			bool continuar = true;
			int opcion;
			Empresa empresa = new Empresa();
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
						nuevaEmpresa(opcion, empresa);
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
						agregarObra(opcion, empresa);
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
			Console.WriteLine(" 1- Crear empresa");
			Console.WriteLine(" 2- Agregar nueva obra");
			Console.WriteLine(" 3- Modificar estado de avance de obra");
			Console.WriteLine(" 4- Listado de obras");
			Console.WriteLine(" 5- Contratar nuevo obrero");
			Console.WriteLine(" 6- Eliminar obrero");
			Console.WriteLine(" 7- Lista de obreros");
			Console.WriteLine(" 8- Lista de obras finalizadas");
			Console.WriteLine("");
			Console.WriteLine(" 0- Salir");
			Console.WriteLine("------------------------------------");
			Console.WriteLine("Ingrese una opcion: ");
		}
		public static void nuevaEmpresa(int opcion, Empresa empresa){
			string nombre;
			string mail;
			int cuit;
			Console.Write("Ingrese Nombre de la empresa: ");
			nombre = Console.ReadLine();
			Console.Write("Ingrese Mail de la empresa: ");
			mail = Console.ReadLine();
			Console.Write("Ingrese CUIT de la empresa: ");
			cuit = int.Parse(Console.ReadLine());
			
			empresa.agregarEmpresa(empresa);
		}
		public static void agregarObra(int opcion, Empresa empresa){
			string nombreprop;
			int dniprop;
			int codigodobra;
			string tipodobra;
			int diadejec;
			double estado;
			int nrodgrupo;
			decimal costo;
			Console.WriteLine("Ingrese los datos de la Obra:");
			Console.Write("Ingrese Nombre del propietario: ");
			nombreprop = Console.ReadLine();
			Console.Write("Ingrese DNI del propietario: ");
			dniprop = int.Parse(Console.ReadLine());
			Console.Write("Ingrese TIPO de obra: ");
			tipodobra = Console.ReadLine();
			Console.Write("Ingrese el Costo de la obra: ");
			costo = decimal.Parse(Console.ReadLine());
			Console.Write("Ingrese CODIGO DE OBRA: ");
			codigodobra = int.Parse(Console.ReadLine());
			Console.Write("Ingrese Dias de ejecucion: ");
			diadejec = int.Parse(Console.ReadLine());
			Console.Write("Ingrese Estado de la obra: ");
			estado = double.Parse(Console.ReadLine());
			Console.Write("Ingrese el Numero de grupo: ");
			nrodgrupo = int.Parse(Console.ReadLine());
			Obra nuevaobra = new Obra();
			empresa.agregarObra(nuevaobra);
			
			
		}
		public static void modificarAvance(){}
		public static void listadObras(){}
		public static void contratarObrero(){}
		public static void eliminarObrero(){}
		public static void listadObreros(){}
		public static void listadObrasFin(){}
		
		
	}
}