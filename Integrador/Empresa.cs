using System;
using System.Collections;

namespace Integrador
{
	public class Empresa
	{
		/*Atributos*/
		private string nombre;
		private string mail;/*se lo agregue para que no quede tan vacia la empresa*/
		private string direccion;/*se lo agregue para que no quede tan vacia la empresa*/
		private ArrayList obras = new ArrayList();
		private ArrayList grupos = new ArrayList();
		private ArrayList listadeEmpresas = new ArrayList();
		/*Constructor*/
		public Empresa(string nombre, string mail, string direccion)
		{
			this.nombre = nombre;
			this.mail = mail;
			this.direccion = direccion;
		}
		/*Propiedades*/
		public string Nombre
		{
			set{nombre = value;}
			get{return nombre;}
		}
		public string Mail
		{
			set{mail = value;}
			get{return mail;}
		}
		public string Direccion
		{
			set{direccion = value;}
			get{return direccion;}
		}
		public ArrayList Obras
		{
			get{return obras;}
		}
		public ArrayList Grupos
		{
			get{return grupos;}
		}
		public ArrayList ListaEmpresas
		{
			get{return grupos;}
		}
		/*¨Métodos*/
		public void agregarObra(Obra ob1)
		{
			obras.Add(ob1);
		}
		/*lo agregue para probar agregar empresa, cualquier cosa lo borramos*/
		public void agregarEmpresa(Empresa empresa)
		{
			listadeEmpresas.Add(empresa);
		}
		/*agregue el metodo imprimir*/
		public void imprimirEmpresa(){
			Console.WriteLine("Nombre {0}, Mail {1}, Direccion {2}" + nombre + mail + direccion);
		}
	}
}