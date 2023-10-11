using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using nMaterie;

namespace nStudent {
	public class Student
	{
		public string Nume { get; set; }
		public string Prenume { get; set; }
		public List<Materie> Materii { get; set; }

		public Student(string nume, string prenume) {
			this.Nume = nume;
			this.Prenume = prenume;
			Materii = new List<Materie>();
		}

		public void AdaugaMaterie(string titlu, string durata) {
			Materii.Add(new Materie(titlu, durata));
		}

		public void Print() {
			Console.WriteLine($"Studentul {Nume} {Prenume} invata urmatoarele materii:");
			foreach (Materie mat in Materii) {
				mat.Print();
			}
			Console.WriteLine("\n");
		}
	}
}