using System;
using Veterinaria.Clases.Entidades;
using System.Collections.Generic;

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
        public List<Turno> TurnosDisponibles { get => turnosDisponibles; }
        public string TurnosReservados
        {
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

        public bool tryAñadirTurno(Turno turno)
        {
            if (Validador.validarTurno(this, turno))
            {
                this.turnosDisponibles.Add(turno);
                return true;
            }
            else
            {
                return false;
            }

        }
        public void reservarTurno(int hora)
        {
            for(int i = 0; i < turnosDisponibles.Count; i++)
            {
                if(turnosDisponibles[i].Hora == hora)
                {
                    turnosReservados.Add(turnosDisponibles[i]);
                    turnosDisponibles.RemoveAt(i);
                }
            }
        }

        public string toString()
        {
            return this.nombre + ", " + this.direccion;
        }
        
    }
}
