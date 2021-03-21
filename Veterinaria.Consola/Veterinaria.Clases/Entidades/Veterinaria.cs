using System;
namespace Veterinaria.Clases
{
    public class Veterinaria
    {
        private string dueño;
        private string direccion;
        private string especialidad;
        private float camillas;


        public Veterinaria(string dueño, string direccion, string especialidad, float camillas)
        {
            this.dueño = dueño;
            this.direccion = direccion;
            this.especialidad = especialidad;
            this.camillas = camillas;
        }
    }
}
