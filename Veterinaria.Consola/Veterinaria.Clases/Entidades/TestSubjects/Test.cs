using System;
using System.Collections.Generic;
using Veterinaria.Clases.Entidades;

namespace Veterinaria.Clases.Entidades.TestSubjects
{
    public class Test
    {
        private List<Hospital> hosEjemplos = new List<Hospital>();
        private List<Turno> turEjemplos = new List<Turno>();
        Turno t1;
        Turno t2;
        Turno t3;
        Turno t4;
        Turno t5;
        Turno t6;
        Hospital h1;
        Hospital h2;
        Hospital h3;
        Hospital h4;
        Hospital h5;
        Hospital h6;
        Hospital h7;
        Hospital h8;



        public Test()
        {
            t1 = new Turno(new Doctor("Pancho", "Cargoso", 123456, 011454545), 13);
            t2 = new Turno(new Doctor("Carla", "Rubio", 37224, 011434545), 14);
            t3 = new Turno(new Doctor("Rodrigo", "Mosca", 77784, 011424545), 15);
            t4 = new Turno(new Doctor("Rodolfo", "Claus", 09876, 011457545), 16);
            t5 = new Turno(new Doctor("Panzo", "Sancha", 4327, 011450545), 17);
            t6 = new Turno(new Doctor("Fede", "Rampazzo", 0111, 011459545), 18);
            turEjemplos.Add(t1);
            turEjemplos.Add(t2);
            turEjemplos.Add(t3);
            turEjemplos.Add(t4);
            turEjemplos.Add(t5);
            turEjemplos.Add(t6);

            Hospital h1 = new Hospital("Santa Catalina", "Chacabuco 800", "Diagnostico de Perros", turEjemplos);
            Hospital h2 = new Hospital("MediCat", "Callao 120", "Emergencias Gatunas", turEjemplos);
            Hospital h3 = new Hospital("Bellezas Peludas", "Albatroz 1560", "Cirugia Estetica", turEjemplos);
            Hospital h4 = new Hospital("AnimalCare", "Peron 3780", "Diagnostico Animal General", turEjemplos);
            Hospital h5 = new Hospital("Enfermucho", "Saenz Peña 210", "Diagnostico de Perros", turEjemplos);
            Hospital h6 = new Hospital("Miau miau hace au au", "Parana 3", "Emergencias Gatunas", turEjemplos);
            Hospital h7 = new Hospital("San Pedro", "San Pedro 2560", "Cirugia Estetica", turEjemplos);
            Hospital h8 = new Hospital("Vet & Care", "Sarmiento 400", "Diagnostico Animal General", turEjemplos);
            hosEjemplos.Add(h1);
            hosEjemplos.Add(h2);
            hosEjemplos.Add(h3);
            hosEjemplos.Add(h4);
            hosEjemplos.Add(h5);
            hosEjemplos.Add(h6);
            hosEjemplos.Add(h7);
            hosEjemplos.Add(h8);

        }











        public void llenar(List<Hospital> hospitales)
        {
            foreach(Hospital hospital in hosEjemplos)
            {
                hospitales.Add(hospital);
            }
        }

    }
}
