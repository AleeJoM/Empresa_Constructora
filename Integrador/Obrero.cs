using System;

namespace Integrador
{
	public class Obrero
	{
		/*Atributos*/
		private string nombre;
		private string apellido;
		private int dni;
		private int legajo;
		private string cargo;
		private int nrodgrupo;
		/*Constructor*/
		public Obrero(string nombre, string apellido, int dni, int legajo, string cargo, int nrodgrupo)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.dni = dni;
			this.legajo = legajo;
			this.cargo = cargo;
			this.nrodgrupo = nrodgrupo;
		}
		/*constructor vacio*/
		public Obrero(){
			
		}
		/*Propiedades*/
		public string Nombre
		{
			set{nombre = value;}
			get{return nombre;}
		}
		public string Apellido
		{
			set{apellido = value;}
			get{return apellido;}
		}
		public int Dni
		{
			set{dni = value;}
			get{return dni;}
		}
		public int Legajo
		{
			set{legajo = value;}
			get{return legajo;}
		}
		public string Cargo
		{
			set{cargo = value;}
			get{return cargo;}
		}
		public int Nrodgrupo
		{
			set{nrodgrupo = value;}
			get{return nrodgrupo;}
		}
	}
}