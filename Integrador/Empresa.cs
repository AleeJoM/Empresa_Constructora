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
		private ArrayList listadobras;
		private ArrayList listadgrupos;
		private ArrayList listadobreros;
		private ArrayList listadempresas;
		/*Constructor*/
		public Empresa(string nombre, string mail, int cuit)
		{
			this.nombre = nombre;
			this.mail = mail;
			this.cuit = cuit;
			listadobras = new ArrayList();
			listadgrupos = new ArrayList();
			listadobreros = new ArrayList();
			listadempresas = new ArrayList();
			
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
		public bool existeEmpresa()
		{
			return listadempresas.Contains(listadempresas);
		}
		public bool existeObra()
		{
			return listadobras.Contains(listadobras);
		}
		public bool existeGrupo()
		{
			return listadgrupos.Contains(listadgrupos);
		}
		public bool existeObrero()
		{
			return listadobreros.Contains(listadobreros);
		}

		public Empresa verEmpresa(int i){
			return (Empresa) this.listadempresas[i];
		}
		public Empresa verObra(int i){
			return (Empresa) this.listadobras[i];
		}
		public Empresa verGrupo(int i){
			return (Empresa) this.listadgrupos[i];
		}
		public Empresa verObrero(int i){
			return (Empresa) this.listadobreros[i];
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
