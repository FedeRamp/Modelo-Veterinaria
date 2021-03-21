using System;
namespace Veterinaria.Clases.Entidades
{
    public class Turno
    {
        private Doctor doctorACargo;
        private int horaTurno;
        private Veterinaria veterinaria;
        private int id;

        public Turno(Doctor doctorACargo, int horaTurno, Veterinaria veterinaria, int id)
        {
            this.doctorACargo = doctorACargo;
            this.horaTurno = horaTurno;
            this.veterinaria = veterinaria;
            this.id = id;
        }
    }
}
