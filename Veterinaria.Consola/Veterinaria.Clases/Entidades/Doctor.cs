using System;
namespace Veterinaria.Clases.Entidades
{
    public class Doctor
    {
        private string nombre;
        private string apellido;
        private string especialidad;
        private int matricula;

        public Doctor(string nombre, string apellido, string especialidad, int matricula)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.especialidad = especialidad;
            this.matricula = matricula;
        }
    }
}
