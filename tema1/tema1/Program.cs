using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using nStudent;


    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Legian", "Andrei");
            Student student2 = new Student("Crestez", "Alexia");

            student1.AdaugaMaterie("Programare Functionala", "4 ore");
            student1.AdaugaMaterie("Probabilitati & Statistica", "5 ore");
            student1.AdaugaMaterie("SGBD", "4 ore");
            student1.AdaugaMaterie("Sisteme de Operare", "4 ore");
            student1.AdaugaMaterie("Algoritmi Fundamentali", "6 ore");
            student1.AdaugaMaterie("Dezvoltarea Aplicatiilor Web", "4 ore");

            student2.AdaugaMaterie("Bazele Programarii", "3 ore");
            student2.AdaugaMaterie("Microeconomie", "3 ore");
            student2.AdaugaMaterie("Matematica Aplicata in Economie", "3 ore");
            student2.AdaugaMaterie("Introducere in Administrarea Afacerilor", "3 ore");
            student2.AdaugaMaterie("Introducere in Contabilitate", "3 ore");
            student2.AdaugaMaterie("Limba Franceza", "1.5 ore");
            student2.AdaugaMaterie("Limba Engleza", "1.5 ore");
            student2.AdaugaMaterie("Educatie Fizica si Sport", "1.5 ore");

        List<Student> listaStudenti = new List<Student> { student1, student2 };

            foreach (var student in listaStudenti) {
                student.Print();
            }
        }
    }

