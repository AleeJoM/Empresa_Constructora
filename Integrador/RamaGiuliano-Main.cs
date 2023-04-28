using System;

namespace Integrador
{
	public class RamaGiuliano_Main //Por las dudas hago el main en una rama aparte
	{
		string opcion = menu();
		
		public /*static*/ string menu(){
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
		public /*static*/ string subMenu(){
			Console.WriteLine("\n------------------------------------" +
			                  "\n\n          SUBMENU                 " +
			                  "\n------------------------------------" +
						  	  "\n                                    " +
						  	  "\n   1- Volver al menu          " +
						  	  "\n   0- Salir                   " +
						  	  "\n\n Ingrese la opcion:                   " );
			
			return Console.ReadLine();
			                  
		}
		public /*static*/ void resultadoSubmenu(string opcion){
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
		public /*static*/ void agregarEmpresa(){
			
		}
		public /*static*/ void agregarObra(){
			
		}
		public /*static*/ void modificarEstado(){
			
		}
		public /*static*/ void listaObras(){
			
		}
		public /*static*/ void contratarObrero(){
			
		}
		public /*static*/ void eliminarObrero(){
			
		}
		public /*static*/ void listaObreros(){
			
		}
		public /*static*/ void listaObrasFin(){
			
		}
		
		
	}

}
