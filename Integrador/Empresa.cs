using System;
using System.Collections;

namespace Integrador
{
	public class Empresa
	{
		/*Atributos*/
		private string nombre;
		private ArrayList obras = new ArrayList();
		private ArrayList grupos = new ArrayList();
		/*Constructor*/
		public Empresa(string nombre)
		{
			this.nombre = nombre;
		}
		/*Propiedades*/
		public string Nombre
		{
			set{nombre = value;}
			get{return nombre;}
		}
		public ArrayList Obras
		{
			get{return obras;}
		}
		public ArrayList Grupos
		{
			get{return grupos;}
		}
		/*¨Métodos*/
		public void agregarObra(Obra ob1)
		{
			obras.Add(ob1);
		}
	}
}