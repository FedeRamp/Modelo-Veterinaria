using System;
namespace Veterinaria.Clases.Entidades
{
    public class Turno
    {
        private Doctor doctorACargo;
        private int horaTurno;

        public Turno(Doctor doctorACargo, int horaTurno)
        {
            this.doctorACargo = doctorACargo;
            this.horaTurno = horaTurno;
        }

        public Doctor DoctorACargo { get => doctorACargo; set => doctorACargo = value; }
        public int Hora { get => horaTurno; }
        public string Print
        {
            get
            {
                return "Turno a la(s) "+ horaTurno + "hs, con " + doctorACargo.ToString() ;
            }
        }
    }
}
