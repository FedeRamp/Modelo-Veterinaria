using System;
namespace Veterinaria.Clases.Exceptions
{
    public class ArrayVacioException : Exception
    {

        public override string Message => "El array dado esta vacio";
    }
}
