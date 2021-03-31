using System;
namespace Veterinaria.Clases.Exceptions
{
    public class TurnoExisteException : Exception
    {

        public override string Message
        {
            get => "Ese turno ya existe";
        }
    }
}
