using System;

namespace Integrador
{
	class Program
	{
		public static void Main(string[] args)
		{
			Empresa empresa = new Empresa();
			Grupo grupo = new Grupo();
			string opcion = menu();
			while (opcion != "0"){
				switch(opcion){
					case "1":
						addEmpresa(opcion,empresa);
						opcion = menu();
						break;
					case "2":
						agregarObra(opcion,empresa);
						break;
					case "3":
						modificarEstado();
						break;
					case "4":
						listaObras(opcion,empresa);
						break;
					case "5":
						contratarObrero();
						break;
					case "6":
						eliminarObrero(opcion,empresa, grupo);
						break;
					case "7":
						listaObreros(opcion, grupo);
						break;
					case "8":
						listaObrasFin();
						break;
					default:
						Console.Clear();
						Console.Write("Ingreso una Opcion incorrecta!");
						opcion = menu();
						break;	
				}
			}
		
		
		
		}
		public static string menu(){
				Console.WriteLine("\n------------------------------------" +
			              		  "\n             MENU                 " +
						  		  "\n------------------------------------" +
						  		  "\n                                    " +
						  		  "\n   1- Crear Empresa           " +
						  		  "\n   2 - Agregar nueva obra     " +
						  		  "\n   3 - Modificar estado de avance de obra     " +
						  		  "\n   4 - Listado de obras       " +
						  		  "\n   5 - Contratar nuevo obrero     " +
						  		  "\n   6 - Eliminar obrero     " +
						 		  "\n   7 - Lista de obreros    " +
						  		  "\n   8 - Lista de obras finalizadas   " +
						  		  "\n                                   " +
						  		  "\n   0 - Salir           " +
						  		  "\n   Ingrese una opcion:  " );
			//Devuelvo la opcion ingresada en formato string para evitar errores
			return Console.ReadLine();
		}
		public static string subMenu(){

			Console.WriteLine("\n------------------------------------" +
			                  "\n\n          SUBMENU                 " +
			                  "\n------------------------------------" +
						  	  "\n                                    " +
						  	  "\n   1- Volver al menu          " +
						  	  "\n   0- Salir                   " +
						  	  "\n\n Ingrese la opcion:                   " );
			
			return Console.ReadLine();
			                  
		}
		public static void resultadoSubmenu(string opcion){
			//Guardo la opcion elegida por el usuario
			string submenu =  subMenu();
			switch(submenu){
				case "1":
					Console.Clear();
					opcion = menu();
					break;
				case "2":
					Environment.Exit(0);/*Environment.exit es un metodo que nos brinda c# para indicar si se completo correctamente o si ocurrio un error, si el parametro fuera 0 es que finalizo correctamente, distinto ocurrio un error*/
					return;
				default:
					Console.Clear();
					Console.Write("Ingreso una Opcion incorrecta!");
					resultadoSubmenu(opcion);/* vuelvo a llamar a la funcion y vuelva ingresar las opciones correcta*/
					break;
			}
		}
		public static void addEmpresa(string opcion, Empresa empresa){
			Console.Clear();
			int intentos = 3;
			/*3 intentos para agregar bien la empresa, ya pensando en exception*/
			while(intentos > 0){
					Console.Write("Ingrese el nombre de la empresa: ");
					string nombreEmpresa = Console.ReadLine();
					Console.Write("Ingrese el mail de la empresa: ");
					string mailEmpresa = Console.ReadLine();
					Console.Write("Ingrese la direccion de la empresa: ");
					string direccion = Console.ReadLine();
					/*arranco el constructor de la empresa*/
					Empresa nuevaEmpresa = new Empresa(nombreEmpresa, mailEmpresa, direccion);
					empresa.agregarEmpresa(nuevaEmpresa); /*llamo al metodo de agregar empresa que esta en la clase empresa y la cargo en la lista*/
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("Empresa creada Exitosamente!"+
					                 "\n");

					nuevaEmpresa.imprimirEmpresa();
					Console.ForegroundColor = ConsoleColor.White;
					
					intentos=-1;/*pongo en -1 la variable para que no ingrese al while nuevamente*/
			}
			resultadoSubmenu(opcion);
		}
		public static void agregarObra(string opcion, Empresa empresa){
			Console.Clear();
			int intentos = 3;
			string nombrePropietario;
			int dniPropietario;
			int codigodeobra;
			string tipodeobra;
			int diasdejecucion;
			int nrodegrupo;
			double costo;
			
			/*pensando en posible exception utilizamos intentos para que sean solo 3 en agregar bien la obra*/
			while(intentos > 0 ){
					Console.WriteLine("Ingrese el nombre del propietario: ");
					nombrePropietario = Console.ReadLine();
					Console.WriteLine("Ingrese el DNI del propietario: ");
					dniPropietario = int.Parse(Console.ReadLine());
					Console.WriteLine("Ingrese el tipo de obra: ");
					tipodeobra = Console.ReadLine();
					Console.WriteLine("Ingrese costo de obra: ");
					costo = double.Parse(Console.ReadLine());
					Console.WriteLine("Ingrese el codigo de obra: ");
					codigodeobra = int.Parse(Console.ReadLine());
					Console.WriteLine("Ingrese la cantidad de dias estimados de ejecucion: ");
					diasdejecucion = int.Parse(Console.ReadLine());
					Console.WriteLine("Ingrese Numero de grupo de obreros: ");
					nrodegrupo = int.Parse(Console.ReadLine());
					
					/*arranco el constructor de la obra, pero sin estado, porque no podemos iniciar una obra con el estado en 50% o si?*/
					Obra nuevaObra = new Obra(nombrePropietario, dniPropietario, tipodeobra, costo, codigodeobra, diasdejecucion, nrodegrupo);
					empresa.agregarObra(nuevaObra);
					
					Console.Write("Has creado exitosamente la obra");
					nuevaObra.imprimirObra();
					intentos = -1;/*para que no entre al bucle otra vez*/
			}
			
			
		}
		public static void modificarEstado(){
			
		}
		public static void listaObras(string opcion, Empresa empresa){
			if(empresa.Obras.Count !=0){
				foreach(Obra obra in empresa.Obras){
					obra.imprimirObra();
				}
			}
			
		}
		public static void contratarObrero(){
			
		}
		public static void eliminarObrero(string opcion, Empresa empresa, Grupo grupo){
			Obrero dniobrero = new Obrero();
			int dniEliminar;
			Console.WriteLine("Ingrese el DNI del obrero a eliminar: ");
			dniEliminar = int.Parse(Console.ReadLine());
			if(dniEliminar == dniobrero.Dni){
				empresa.eliminarObrero();
				grupo.eliminarObrero(dniEliminar);
				Console.WriteLine("Obrero Eliminado con exito");
			}
			else{
				Console.WriteLine("No se encontro ningun Obrero con ese DNI");
			}
			
		}
		public static void listaObreros( string opcion, Grupo grupo){
			if(grupo.Obreros.Count != 0 ){
				foreach(Obrero obrero in grupo.Obreros){
					obrero.imprimirObrero();
				}
			}
			else{
				Console.WriteLine("Lista vacia");
			}
			resultadoSubmenu(opcion);
		}
		public static void listaObrasFin(){
			
		}		

	}
}