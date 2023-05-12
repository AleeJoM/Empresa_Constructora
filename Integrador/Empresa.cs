using System;
using System.Collections;

namespace Integrador
{
	public class Empresa
	{
		/*Atributos*/
		private string nombre;
		private string mail;
		private int cuit;
		private ArrayList listadobras = new ArrayList();
		private ArrayList listadgrupos = new ArrayList();
		private ArrayList listadobreros = new ArrayList();
		private ArrayList listadempresas = new ArrayList();
		/*Constructor*/
		public Empresa(string nombre, int cuit, string mail)
		{
			this.nombre = nombre;
			this.cuit = cuit;
			this.mail = mail;
		}
		/*Constructor vacio*/
		public Empresa()
		{
			
		}
		/*Propiedades*/
		public string Nombre {
			set{ nombre = value; }
			get{ return nombre; }
		}
		public int Cuit {
			set{ cuit = value; }
			get { return cuit; }
		}
		public string Mail {
			set{ mail = value; }
			get{ return mail; }
		}
		public ArrayList Listadobras {
			get{ return listadobras; }
		}
		public ArrayList Listadgrupos {
			get{ return listadgrupos; }
		}
		public ArrayList Listadobreros {
			get{ return listadobreros; }
		}
		public ArrayList Listadempresas {
			get{ return listadempresas; }
		}
		
		/*¨Métodos*/
		public void agregarEmpresa(Empresa empresa)
		{
			listadempresas.Add(empresa);
		}
		public void agregarObra(Obra obra)
		{
			listadobras.Add(obra);
		}
		public void agregarGrupo(Grupo grupo)
		{
			listadgrupos.Add(grupo);
		}
		public void agregarObrero(Obrero obrero)
		{
			listadobreros.Add(obrero);
		}
		public void elimarEmpresa(Empresa empresa)
		{
			listadempresas.Remove(empresa);
		}
		public void elimarObra(Obra obra)
		{
			listadobras.Remove(obra);
		}
		public void elimarGrupo(Grupo grupo)
		{
			listadgrupos.Remove(grupo);
		}
		public void elimarObrero(Obrero obrero)
		{
			listadobreros.Remove(obrero);
		}
		public int cantidadEmpresas()
		{
			return listadempresas.Count;
		}	
		public int cantidadObra()
		{
			return listadobras.Count;
		}
		public int cantidadGrupo()
		{
			return listadgrupos.Count;
		}
		public int cantidadObrero()
		{
			return listadobreros.Count;
		}
		public void existeEmpresa()
		{
			listadempresas.Contains(listadempresas);
		}
		public void existeObra()
		{
			listadobras.Contains(listadobras);
		}
		public void existeGrupo()
		{
			listadgrupos.Contains(listadgrupos);
		}
		public void existeObrero()
		{
			listadobreros.Contains(listadobreros);
		}
		public void verEmpresa()
		{
			foreach(Empresa e in Listadempresas){
				Console.WriteLine(e);
			}
		}
		public void verObras()
		{
			foreach(Empresa e in Listadobras){
				Console.WriteLine(e);
			}
		}
		public void verGrupo()
		{
			foreach(Empresa e in Listadgrupos){
				Console.WriteLine(e);
			}
		}
		public void verObrero()
		{
			foreach(Empresa e in Listadobreros){
				Console.WriteLine(e);
			}
			
		}
		public ArrayList todaslasEmpresas()
		{
			return listadempresas;
		}
		public ArrayList todaslasObras()
		{
			return listadobras;
		}
		public ArrayList todoslosGrupos()
		{
			return listadgrupos;
		}
		public ArrayList todoslosObreros()
		{
			return listadobreros;
		}
	}
}