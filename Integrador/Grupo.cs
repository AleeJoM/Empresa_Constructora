using System;
using System.Collections;

namespace Integrador
{
	public class Grupo
	{
		/*Atributos*/
		private int cod_obra;
		private int nro_grupo;
		private ArrayList listaObreros;
		/*Constructor*/
		public Grupo(int cod_obra, int nro_grupo)
		{
			this.cod_obra = cod_obra;
			this.nro_grupo = nro_grupo;
			listaObreros  = new ArrayList();
		}
		/*Constructor vacio*/
		public Grupo()
		{
		}
		/*Propiedades*/
		public int Cod_obra
		{
			set{cod_obra = value;}
			get{return cod_obra;}
		}
		public int Nro_grupo
		{
			set{nro_grupo = value;}
			get{return nro_grupo;}
		}
		public ArrayList ListaObreros
		{
			get{return listaObreros;}
		}
		/*Métodos*/
		public void agregarObrero(Obrero ob1)
		{
			listaObreros.Add(ob1);
		}
		public void eliminarObrero(Obrero ob1)
		{
			listaObreros.Remove(ob1);
		}
		public int cantidadObrero()
		{ 
			return listaObreros.Count;
		}
		public bool existeObrero(Obrero ob1)
		{
			return listaObreros.Contains(ob1);
		}
		public Obrero verObrero(int i)
		{ 
			return (Obrero)listaObreros[i];
		}
		public ArrayList todosObreros()
		{
			return listaObreros;
		}
	}
}