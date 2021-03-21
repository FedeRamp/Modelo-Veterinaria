using System;
using Veterinaria.Clases.Entidades;
using System.Collections.Generic;

namespace Veterinaria.Clases
{
    public class Veterinaria
    {
        private string dueño;
        private string direccion;
        private string especialidad;
        private int camillas;
        private List<Doctor> doctores = new List<Doctor>();

        public Veterinaria(string dueño, string direccion, string especialidad, int camillas)
        {
            this.dueño = dueño;
            this.direccion = direccion;
            this.especialidad = especialidad;
            this.camillas = camillas;
        }


        //getters & setters//
        public string Direccion { get => direccion;}
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public int Camillas { get => camillas; set => camillas = value; }



        public void añadirDoctor(Doctor doctor)
        {
            this.doctores.Add(doctor);
        }
        
    }
}
