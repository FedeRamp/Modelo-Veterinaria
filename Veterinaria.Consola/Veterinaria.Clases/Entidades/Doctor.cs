using System;
namespace Veterinaria.Clases.Entidades
{
    public class Doctor
    {
        private string nombre;
        private string apellido;
        private int matricula;
        private int telefonoContacto;

        public Doctor(string nombre, string apellido, int matricula, int telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.matricula = matricula;
            this.telefonoContacto = telefono;
        }

        //Getters & Setters
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public int Matricula { get => matricula; }
        public int TelefonoContacto { get => telefonoContacto; set => telefonoContacto = value; }
        public override string ToString()
        {
            return this.nombre + " " + this.apellido;
        }
    }
}
