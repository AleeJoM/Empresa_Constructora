using System;
using System.Collections;

namespace Integrador
{
	public class Empresa
	{
		/*Atributos*/
		private string nombre;
		private string mail;
		private string direccion;
		private ArrayList listaObras;
		private ArrayList listaGrupos;
//		private ArrayList listaEmpresas;
		/*Constructor*/
		public Empresa(string nombre, string mail, string direccion)
		{
			this.nombre = nombre;
			this.mail = mail;
			this.direccion = direccion;
			listaObras  = new ArrayList();
			listaGrupos  = new ArrayList();
//			listaEmpresas  = new ArrayList();
		}
//		/*Constructor vacio para poder crear y utilizar los metodos*/
//		public Empresa()
//		{			
//		}
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
		public ArrayList ListaObras
		{
			get{return listaObras;}
		}
		public ArrayList ListaGrupos
		{
			get{return listaGrupos;}
		}
//		public ArrayList ListaEmpresas
//		{
//			get{return listaEmpresas;}
//		}
		/*Métodos*/
		public void agregarObraEMP(Obra ob1)
		{
			listaObras.Add(ob1);
		}
		public void agregarGrupo(Grupo g1)
		{
			listaGrupos.Add(g1);
		}
//		public void agregarEmpresa(Empresa e1)
//		{
//			listaEmpresas.Add(e1);
//		}
		public void eliminarObra(int ob1)
		{
			listaObras.Remove(ob1);
		}
		public void eliminarGrupo(int g1)
		{
			listaGrupos.Remove(g1);
		}
//		public void eliminarEmpresa(int e1)
//		{
//			listaEmpresas.Remove(e1);
//		}
		public int cantidadObra()
		{ 
			return listaObras.Count;
		}
		public int cantidadGrupo()
		{ 
			return listaGrupos.Count;
		}
//		public int cantidadEmpresa()
//		{ 
//			return listaEmpresas.Count;
//		}
		public bool existeObra(Obra ob1)
		{
			return listaObras.Contains(ob1);
		}
		public bool existeGrupo(Grupo g1)
		{
			return listaGrupos.Contains(g1);
		}
//		public bool existeEmpresa(Empresa e1)
//		{
//			return listaEmpresas.Contains(e1);
//		}
		public Obra verObra(int i)
		{ 
			return (Obra)listaObras[i];
		}
		public Grupo verGrupo(int i)
		{ 
			return (Grupo)listaGrupos[i];
		}
//		public Empresa verEmpresa(int i)
//		{ 
//			return (Empresa)listaEmpresas[i];
//		}
		public ArrayList todasObras()
		{
			return listaObras;
		}
		public ArrayList todosGrupos()
		{
			return listaGrupos;
		}	
//		public ArrayList todasEmpresas()
//		{
//			return listaEmpresas;
//		}
	}
}