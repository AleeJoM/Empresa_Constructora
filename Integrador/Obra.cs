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
		private int estado;
		private int nro_grupo;
		private double costo;
		/*Constructor*/
		public Obra(string nombre, int dni, int cod_obra, string tipo_obra, int dias_ejec, int estado, int nro_grupo, double costo)
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
		/*Constructor para agregar obra, sin estado*/
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
		public Obra()
		{
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
		public int Estado
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
		public void imprimirObra()
		{
				Console.WriteLine("Datos de la obra: \n" + "Nombre del Propietario {0}\n" + "DNI del propietario {1}\n" + "Tipo de obra: {2}\n" + "Costo: {3}\n" + "Codigo : {4}\n" + "Días que tarda en ejecutarse: {5}\n" + "Estado de avance de la obra: {6} %\n" + "Numero de grupo de obreros: {7}\n", nombre, dni, tipo_obra, costo, cod_obra, dias_ejec, estado, nro_grupo);
		}
		
	}
}