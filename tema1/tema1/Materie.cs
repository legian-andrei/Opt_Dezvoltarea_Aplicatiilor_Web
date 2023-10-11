using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nMaterie
{
	public class Materie
	{
		public string Titlu { get; set; }
		public string Durata { get; set; }

		public Materie(string titlu, string durata)
		{
			this.Titlu = titlu;
			this.Durata = durata;
		}

		public void Print()
		{
			Console.WriteLine($"	- {Titlu}, durata: {Durata}");
		}
	}
}