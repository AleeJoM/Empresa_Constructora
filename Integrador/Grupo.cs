using System;
using System.Collections;

namespace Integrador
{
	public class Grupo
	{
		/*Atributos*/
		private int codigodobra;
		private int nrodgrupo;
		private ArrayList listadobreros; 
		/*Constructor*/
		public Grupo(){
			
		}
		public Grupo(int codigodobra, int nrodgrupo)
		{
			this.codigodobra = codigodobra;
			this.nrodgrupo = nrodgrupo;
			listadobreros = new ArrayList();
		}
		/*constructor vacio*/

		/*Propiedades*/
		public int Codigodobra
		{
			set{codigodobra = value;}
			get{return codigodobra;}
		}
		public int Nrodgrupo
		{
			set{nrodgrupo = value;}
			get{return nrodgrupo;}
		}
		public ArrayList Listadobreros
		{
			get{return listadobreros;}
		}
		/*Métodos*/
		public void agregarObrero(Obrero obrero)
		{
			listadobreros.Add(obrero);
		}
		public void elimarObrero(Obrero obrero)
		{
			listadobreros.Remove(obrero);
		}
		public int cantidadObrero()
		{
			return listadobreros.Count;
		}
		public void existeObrero()
		{
			listadobreros.Contains(listadobreros);
		}
		public Grupo verObrero(int i)
		{
		   return (Grupo) this.listadobreros[i];
			
		}
		public ArrayList todoslosObreros()
		{
			return listadobreros;
		}
	}
}