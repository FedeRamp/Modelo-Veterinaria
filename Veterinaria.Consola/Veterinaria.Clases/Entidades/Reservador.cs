using System;
using System.Collections.Generic;

namespace Veterinaria.Clases.Entidades
{
    public class Reservador
    {
        private List<Turno> turnos = new List<Turno>();
        private int ultimoIndex = 0;
        public Reservador()
        {
        }

        public void agendarTurno(Doctor doctor, int hora, Veterinaria veterinaria)
        {
            Turno turno = new Turno(doctor, hora, veterinaria, ultimoIndex);
            turnos.Add(turno);
        }
    }
}
