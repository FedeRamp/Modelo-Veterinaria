/*me imagino un programa para encontrar una veterinaria según una especialización
 * y poder buscar un doctor en esa veterinaria para reservar un chequeo*/

//Tuve que cambiar el nombre Veterinaria a Hospital, es un namespace no un typo?!?//

using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.Clases.Entidades;
using Veterinaria.Clases.Entidades.TestSubjects;

namespace Veterinaria.Consola
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            List<Hospital> hospitales = new List<Hospital>();

            Test test = new Test();
            test.llenar(hospitales);

            while (true)
            {
                string[] principalOpciones = { "ver mis turnos", "reservar nuevo turno" };
                Menu principal = new Menu("En que puedo ayudar?", principalOpciones);

                switch (principal.elegir())
                {


                    case 1:
                        bool vacio = true;
                        foreach (Hospital hospital in hospitales)
                        {
                            if (hospital.TurnosReservados != "")
                            {
                                Console.WriteLine(hospital.TurnosReservados);
                                vacio = false;
                            }
                        }
                        if (vacio) Console.WriteLine("No hay turnos reservados aun");
                        break;

                    case 2:
                        List<string> especialidades = new List<string>();
                        string titEspecialidad = "Que especialidad busca?";
                        foreach (Hospital hospital in hospitales)
                        {
                            if (especialidades.SingleOrDefault(espec => espec == hospital.Especialidad) == null)
                            {
                                especialidades.Add(hospital.Especialidad);
                            }
                        }
                        Menu menuEspecs = new Menu(titEspecialidad, especialidades.ToArray());
                        string especElegida = especialidades[menuEspecs.elegir()];
                        List<Hospital> hospDisponibles = new List<Hospital>();
                        foreach (Hospital hospital in hospitales)
                        {
                            if (hospital.Especialidad == especElegida) hospDisponibles.Add(hospital);
                        }
                        string titHospital = hospDisponibles.Count + " hospitales disponibles :";
                        string[] descHospitales = new string[hospDisponibles.Count];
                        for (int i = 0; i < hospDisponibles.Count; i++)
                        {
                            descHospitales[i] = descHospitales[i].ToString();
                        }
                        Menu menuHospitales = new Menu(titHospital, descHospitales);
                        Hospital hospitalElegido = hospDisponibles[menuHospitales.elegir()];
                        string titTurnos = "Turnos disponibles: ";
                        Menu menuTurnos = new Menu(titTurnos, hospitalElegido.TurnosDisponibles);
                        hospitalElegido.reservarTurno(menuTurnos.elegir());
                        break;
                }

            }
        }
    }
}
