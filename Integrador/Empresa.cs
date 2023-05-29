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
		private ArrayList listaObreros;
		/*Constructor*/
		public Empresa(string nombre, string mail, string direccion)
		{
			this.nombre = nombre;
			this.mail = mail;
			this.direccion = direccion;
			listaObras  = new ArrayList();
			listaGrupos  = new ArrayList();
			listaObreros = new ArrayList();
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
		public ArrayList ListaObras
		{
			get{return listaObras;}
		}
		public ArrayList ListaGrupos
		{
			get{return listaGrupos;}
		}
		public ArrayList ListaObreros
		{
			get{return listaObreros;}
		}
		/*Métodos*/
		public void agregarObra(Obra ob1)
		{
			listaObras.Add(ob1);
		}
		public void agregarGrupo(Grupo g1)
		{
			listaGrupos.Add(g1);
		}
		public void agregarObrero(Obrero ob1)
		{
			listaObreros.Add(ob1);
		}
		public void eliminarObra(Obra ob1)
		{
			listaObras.Remove(ob1);
		}
		public void eliminarGrupo(Grupo g1)
		{
			listaGrupos.Remove(g1);
		}
		public void eliminarObrero(Obrero ob1)
		{
			listaObreros.Remove(ob1);
		}
		public int cantidadObra()
		{ 
			return listaObras.Count;
		}
		public int cantidadGrupo()
		{ 
			return listaGrupos.Count;
		}
		public int cantidadObrero()
		{ 
			return listaObreros.Count;
		}
		public bool existeObra(Obra ob1)
		{
			return listaObras.Contains(ob1);
		}
		public bool existeGrupo(Grupo g1)
		{
			return listaGrupos.Contains(g1);
		}
		public bool existeObrero(Obrero ob1)
		{
			return listaObreros.Contains(ob1);
		}
		public Obra verObra(int i)
		{ 
			return (Obra)listaObras[i];
		}
		public Grupo verGrupo(int i)
		{ 
			return (Grupo)listaGrupos[i];
		}
		public Obrero verObrero(int i)
		{ 
			return (Obrero)listaObreros[i];
		}
		public ArrayList todasObras()
		{
			return listaObras;
		}
		public ArrayList todosGrupos()
		{
			return listaGrupos;
		}
		public ArrayList todosObreros()
		{
			return listaObreros;
		}
	}
}