using System;
using System.Collections;

namespace Integrador
{
	class Program
	{
		public static void Main(string[] args)
		{
			bool continuar = true;
			int opcion;
			Empresa empresa = new Empresa();
			Grupo grupo = new Grupo();
			while (continuar) {
				menu();
				opcion = int.Parse(Console.ReadLine());
				switch (opcion) {
					case 1:
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
					case 2:
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
					case 3:
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 3 - Modificar estado de avance de obra");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
						modificarAvance(opcion,empresa);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 4:
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 4 - Listado de obras");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
						listadObras(opcion,empresa);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 5:
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 5 - Contratar nuevo obrero");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
						contratarObrero(opcion, empresa, grupo);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 6:
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 6 - Eliminar obrero");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
						eliminarObrero(opcion, empresa, grupo);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 7:
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 7 - Lista de obreros");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
						listadObreros(opcion,empresa, grupo);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 8:
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 8 - Lista de obras finalizadas");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
						listadObrasFin(opcion,empresa);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 0:
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
		public static void nuevaEmpresa(int opcion, Empresa empresa)
		{
			string nombre;
			string mail;
			int cuit;
			Console.Write("Ingrese Nombre de la empresa: ");
			nombre = Console.ReadLine();
			Console.Write("Ingrese Mail de la empresa: ");
			mail = Console.ReadLine();
			Console.Write("Ingrese CUIT de la empresa: ");
			cuit = int.Parse(Console.ReadLine());
			Empresa nuevaEmpresa = new Empresa(nombre,mail,cuit);
			empresa.agregarEmpresa(nuevaEmpresa);
		}
		public static void agregarObra(int opcion, Empresa empresa)
		{
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
			Obra nuevaobra = new Obra(nombreprop,dniprop,tipodobra,costo,codigodobra,diadejec,estado,nrodgrupo);
			empresa.agregarObra(nuevaobra);
			
			
		}
		public static void modificarAvance(int opcion, Empresa empresa)
		{
			if(empresa.Listadobras.Count != 0 ){
				int codigodeobra;
				Console.WriteLine("Ingrese codigo de obra a modificar: ");
				codigodeobra = int.Parse(Console.ReadLine());
				foreach(Obra obramod in empresa.Listadobras){
					if(obramod.Codigodobra == codigodeobra){
						double estado;
						Console.WriteLine("Ingrese el nuevo estado de obra: ");
						estado = double.Parse(Console.ReadLine());
						obramod.Estado = estado;
						Console.WriteLine("Estado modificado exitosamente!");
						break;
					}
				}
			}
			
			else {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Ninguna obra para modificar!");
				Console.ForegroundColor = ConsoleColor.White;
			}
		}
		public static void listadObras(int opcion, Empresa empresa)
		{
			ArrayList obras = empresa.todaslasObras();
			if(obras.Count > 0){

				foreach(Obra ele in obras){
					Console.WriteLine("Los datos de las obras son: ");
					Console.WriteLine("Nombre del propietario: " + ele.Nombreprop);
					Console.WriteLine("DNI del propietario: " + ele.Dni);
					Console.WriteLine("Tipo de obra: " + ele.Tipodobra);
					Console.WriteLine("Costo: " + ele.Costo);
					Console.WriteLine("Codigo de la obra: " + ele.Codigodobra);
					Console.WriteLine("Dias de ejecucion: " + ele.Diasdejec);
					Console.WriteLine("Estado de la obra: " + ele.Estado);
					Console.WriteLine("Numero de grupo de obreros: " + ele.Nrodgrupo);
					
				}
			}else{
				Console.WriteLine("No hay obras ingresadas!");
			}
			Console.ReadKey();
		}
		public static void contratarObrero(int opcion, Empresa empresa, Grupo grupo)
		{
			string nombre;
			string apellido;
			int dni;
			int legajo;
			string cargo;
			int nrodgrupo;
			Console.WriteLine("Ingrese los datos del obrero: ");
			Console.Write("Ingrese nombre: ");
			nombre = Console.ReadLine();
			Console.Write("Ingrese Apellido: ");
			apellido = Console.ReadLine();
			Console.Write("Ingrese DNI: ");
			dni = int.Parse(Console.ReadLine());
			Console.Write("Ingrese Legajo: ");
			legajo = int.Parse(Console.ReadLine());
			Console.Write("Ingrese Cargo: ");
			cargo = Console.ReadLine();
			Console.Write("Ingrese Numero de grupo: ");
			nrodgrupo = int.Parse(Console.ReadLine());
			
			Obrero nuevoObrero = new Obrero (nombre,apellido,dni,legajo,cargo,nrodgrupo);
			empresa.agregarObrero(nuevoObrero);
			grupo.agregarObrero(nuevoObrero);
			
			Console.WriteLine("Obrero creado exitosamente!");
			
		}
		public static void eliminarObrero(int opcion, Empresa empresa, Grupo grupo)
		{
			if(empresa.Listadobreros.Count != 0 && grupo.Listadobreros.Count != 0){
				int Ndegrupo;
				int dniEliminar;
				bool esta= false;
				Console.Write("Ingrese DNI del obrero a eliminar: ");
				dniEliminar = int.Parse(Console.ReadLine());
				Console.Write("Ingrese Nro de grupo del obrero a eliminar: ");
				Ndegrupo = int.Parse(Console.ReadLine());
				foreach(Obrero obreroEliminar in empresa.Listadobreros){
					if(obreroEliminar.Dni == dniEliminar && obreroEliminar.Nrodgrupo == Ndegrupo){
						esta =true;
						empresa.elimarObrero(obreroEliminar);
						grupo.elimarObrero(obreroEliminar);
					}else{
						Console.WriteLine("1 O MÁS DATOS INCORRECTOS");
					}
				}
				if(esta){
					Console.WriteLine("Obrero Eliminado exitosamente!");
					Console.ReadKey();
				}
			}else{
				Console.WriteLine("No se encontro obrero para eliminar");
			}
			
		}
		public static void listadObreros(int opcion, Empresa empresa, Grupo grupo){
			ArrayList obreros = empresa.todoslosObreros();
			if(obreros.Count > 0){

				foreach(Obrero ele in obreros){
					Console.WriteLine("Los datos de los obreros son: ");
					Console.WriteLine("Nombre: " + ele.Nombre);
					Console.WriteLine("Apellido: " + ele.Apellido);
					Console.WriteLine("DNI: " + ele.Dni);
					Console.WriteLine("Legajo: " + ele.Legajo);
					Console.WriteLine("Cargo: " + ele.Cargo);
					Console.WriteLine("Numero de grupo: " + ele.Nrodgrupo);
					
				}
			}else{
				Console.WriteLine("No hay obreros ingresados!");
			}
			Console.ReadKey();

		}
		
		public static void listadObrasFin(int opcion, Empresa empresa)
		{
			if(empresa.Listadobras.Count != 0){
				double finobra = 100;
				foreach(Obra obrafin in empresa.Listadobras){
					if(obrafin.Estado == finobra){
						Console.WriteLine("las obras finalizadas son: " + obrafin.Nombreprop);
					}
				}	
			}
			else {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Ninguna obra sin finalizar!");
				Console.ForegroundColor = ConsoleColor.White;
			}
			
		}
		
		
	}
}