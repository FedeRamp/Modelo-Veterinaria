using System;
using System.Linq;
using Veterinaria.Clases.Entidades;
using System.Collections.Generic;
using Veterinaria.Clases.Exceptions;

namespace Veterinaria.Clases.Entidades
{
    public class Hospital
    {
        private string nombre;

        private string direccion;
        private string especialidad;
        private List<Turno> turnosDisponibles = new List<Turno>();
        private List<Turno> turnosReservados = new List<Turno>();

        public Hospital(string nombre, string direccion, string especialidad, List<Turno> turnos)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.especialidad = especialidad;
            this.turnosDisponibles = turnos;
        }


        //getters & setters//
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public List<Turno> Turnos { get => turnosDisponibles; }
        public string[] TurnosDisponibles {
            get
            {
                string[] resultado = new string[turnosDisponibles.Count];
                for(int i = 0; i < turnosDisponibles.Count; i++)
                {
                    resultado[i] = turnosDisponibles[i].Print;
                }
                return resultado;
            }
        }
        public string TurnosReservados
        {  //Trae un string en forma de lista de todos los turnos
            get
            {
                string resultado = "";
                foreach (Turno turno in turnosReservados)
                {
                    resultado += "\nTurno con: " + turno.DoctorACargo + " a la(s) " + turno.Hora;
                }
                return resultado;
            }
        }
        public List<Turno> TurnosDisponibles1 { get => turnosDisponibles; }

        public void tryAñadirTurno(Turno turno)
        {       //Si el turno ya existe, arroja una exception
            try
            {
                Validador.validarTurno(this, turno);
                this.turnosDisponibles.Add(turno);
            }
            catch(TurnoExisteException tee)
            {
                Console.WriteLine(tee.Message);
            }
        }
        public void reservarTurno(int index)
        {  //Movemos el turno elegido de los disponibles hacia los reservados
            Turno turnoElegido = turnosDisponibles[index];
            turnosReservados.Add(turnoElegido);
            turnosDisponibles.Remove(turnoElegido);
        }

        public string toString()
        { //Method para imprimir la info de este hospital
            return this.nombre + ", " + this.direccion;
        }
        
    }
}
