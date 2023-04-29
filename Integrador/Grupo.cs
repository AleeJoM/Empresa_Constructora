using System;
using System.Collections;

namespace Integrador
{
	public class Grupo
	{
		/*Atributos*/
		private int cod_obra;
		private int nro_grupo;
		private ArrayList obreros = new ArrayList();
		/*Constructor*/
		public Grupo(int cod_obra, int nro_grupo)
		{
			this.cod_obra = cod_obra;
			this.nro_grupo = nro_grupo;
		}
		/*Constructor vacio para poder iniciar un nuevo objeto y utilizar los metodos*/
		public Grupo(){
			
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
		public ArrayList Obreros
		{
			get{return obreros;}
		}
		/*Métodos*/
		public void agregarObrero(Obrero obre1)
		{
			obreros.Add(obre1);
		}
		public void eliminarObrero(int obrero)/*se lo agregue por enunciado dice que hay que eliminar un obrero de la clase grupo*/
		{
			obreros.Remove(obrero);
		}
	}
}