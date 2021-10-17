using System.Collections.Generic;
using Models;


namespace Repositories{

    public static class StudentsRepo{
        
        public static List<Student> Students = new List<Student>(){
            new Student() { Id = 1, Nume = "Isac", Prenume = "Eduard", Facultate = "AC", AnStudiu = 4, Medie = 8},
            new Student() { Id = 2, Nume = "Ionescu", Prenume = "Dorin", Facultate = "ETC", AnStudiu = 2, Medie = 7},
            new Student() { Id = 3, Nume = "Stefan", Prenume = "Catalin", Facultate = "ET", AnStudiu = 4, Medie = 10},
            new Student() { Id = 4, Nume = "Melut", Prenume = "Catalin", Facultate = "MEC", AnStudiu = 3, Medie = 6},
            new Student() { Id = 5, Nume = "Popescu", Prenume = "Florin", Facultate = "AC", AnStudiu = 4, Medie = 7},
            new Student() { Id = 6, Nume = "Demian", Prenume = "Lavinia", Facultate = "ETC", AnStudiu = 4, Medie = 9},
        };
   
    }
}