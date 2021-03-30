/*me imagino un programa para encontrar una veterinaria según una especialización
 * y poder buscar un doctor en esa veterinaria para reservar un chequeo*/

//Tuve que cambiar el nombre Veterinaria a Hospital, es un namespace no un typo?!?//

using System;
using System.Collections.Generic;
using Veterinaria.Clases.Entidades;

namespace Veterinaria.Consola
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Hospital> hospitales = new List<Hospital>();
            string mensajeInicial = "En que lo puedo ayudar?" +
                                     "\n\t1.Ver mis turnos" +
                                     "\n\t2.Reservar nuevo turno";
            int opcionElegidaPrincipal = Validador.pedirInt(mensajeInicial);
            if(opcionElegidaPrincipal == 1)
            {
                bool vacio = true;
                foreach(Hospital hospital in hospitales)
                {
                    if (hospital.TurnosReservados != "")
                    {
                        Console.WriteLine(hospital.TurnosReservados);
                        vacio = false;
                    }
                }
                if (vacio) Console.WriteLine("No hay turnos reservados aun");
                
            } else if(opcionElegidaPrincipal == 2)
            {
                List<Hospital> hospDisponibles = new List<Hospital>();
                string especialidadElegida = Validador.pedirString("Que especialidad busca?");
                foreach(Hospital hospital in hospitales)
                {
                    if(hospital.Especialidad == especialidadElegida)
                    {
                        hospDisponibles.Add(hospital);
                    }
                }
                Console.WriteLine("Hay " + hospDisponibles.Count + " hospitales disponibles");
                if(hospDisponibles.Count > 0)
                {
                    string mensajeDisponibles = "Elija un hospital\n";
                    for(int i = 0; i < hospDisponibles.Count; i++)
                    {
                        mensajeDisponibles += (i+1 + ". " + hospDisponibles[i].toString() +"\n");
                    }
                    int indiceHospital = Validador.pedirInt(mensajeDisponibles);
                }
            }
        }
    }
}
