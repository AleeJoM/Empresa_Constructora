using System;

namespace Integrador
{
	public class Obra
	{
		/*Atributos*/
		private string nombreprop;
		private int dniprop;
		private int codigodobra;
		private string tipodobra;
		private int diasdejec;
		private double estado;
		private int nrodgrupo;
		private decimal costo;
		/*Constructor*/
		public Obra(string nombreprop, int dniprop, int codigodobra, string tipodobra, int diasdejec, double estado, int nrodgrupo, decimal costo)
		{
			this.nombreprop = nombreprop;
			this.dniprop = dniprop;
			this.codigodobra = codigodobra;
			this.tipodobra = tipodobra;
			this.diasdejec = diasdejec;
			this.estado = estado;
			this.nrodgrupo = nrodgrupo;
			this.costo = costo;
		}
		/*constructor vacio*/
		public Obra(){
			
		}
		/*Propiedades*/
		public string Nombreprop
		{
			set{nombreprop = value;}
			get{return nombreprop;}
		}
		public int Dni
		{
			set{dniprop = value;}
			get{return dniprop;}
		}
		public int Codigodobra
		{
			set{codigodobra = value;}
			get{return codigodobra;}
		}
		public string Tipodobra
		{
			set{tipodobra = value;}
			get{return tipodobra;}
		}
		public int Diasdejec
		{
			set{diasdejec = value;}
			get{return diasdejec;}
		}
		public double Estado
		{
			set{estado = value;}
			get{return estado;}
		}
		public int Nrodgrupo
		{
			set{nrodgrupo = value;}
			get{return nrodgrupo;}
		}
		public decimal Costo
		{
			set{costo = value;}
			get{return costo;}
		}
	}
}