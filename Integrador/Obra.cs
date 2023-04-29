using System;

namespace Integrador
{
	public class Obra
	{
		/*Atributos*/
		private string nombre;
		private int dni;
		private int cod_obra;
		private string tipo_obra;
		private int dias_ejec;
		private double estado;
		private int nro_grupo;
		private double costo;/*lo pase a double porque porque capaz alguno pone 1.500.000 aunque despues podria ir una exception*/
		
		/*Constructor*/
		public Obra(string nombre, int dni, int cod_obra, string tipo_obra, int dias_ejec, double estado, int nro_grupo, double costo)
		{
			this.nombre = nombre;
			this.dni = dni;
			this.cod_obra = cod_obra;
			this.tipo_obra = tipo_obra;
			this.dias_ejec = dias_ejec;
			this.estado = estado;
			this.nro_grupo = nro_grupo;
			this.costo = costo;
		}
		/*constructor para agregar obra, el estado lo necesito para devolver cuanto avanzo la obra. */
		public Obra(string nombre, int dni,string tipo_obra,double costo, int cod_obra,int dias_ejec, int nro_grupo)
		{
			this.nombre = nombre;
			this.dni = dni;
			this.cod_obra = cod_obra;
			this.tipo_obra = tipo_obra;
			this.dias_ejec = dias_ejec;
			this.nro_grupo = nro_grupo;
			this.costo = costo;
		}
		
		/*Propiedades*/
		public string Nombre
		{
			set{nombre = value;}
			get{return nombre;}
		}
		public int Dni
		{
			set{dni = value;}
			get{return dni;}
		}
		public int Cod_obra
		{
			set{cod_obra = value;}
			get{return cod_obra;}
		}
		public string Tipo_obra
		{
			set{tipo_obra = value;}
			get{return tipo_obra;}
		}
		public int Dias_ejec
		{
			set{dias_ejec = value;}
			get{return dias_ejec;}
		}
		public double Estado
		{
			set{estado = value;}
			get{return estado;}
		}
		public int Nro_grupo
		{
			set{nro_grupo = value;}
			get{return nro_grupo;}
		}
		public double Costo
		{
			set{costo = value;}
			get{return costo;}
		}
		/*Métodos*/
		public void imprimirObra(){/*agregado*/
				Console.WriteLine("  Datos de la Obra: " +
			                      "\n Nombre del Propietario {0} "+
			                      "\n Dni del Propietario {1} " +
			                      "\n Tipo de obra: {2} " +
			                      "\n Costo: {3} "+
			                      "\n Codigo : {4} " +
			                      "\n Dias que tarda en ejecutarse: {5} " +
			                      "\n Numero de grupo de obreros: {6} " +
			                      nombre, dni, tipo_obra, costo, cod_obra, dias_ejec, nro_grupo);
		}
		
	}
}