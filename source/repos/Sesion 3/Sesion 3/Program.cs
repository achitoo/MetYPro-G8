using Sesion_3.modelos;

namespace Sesion_3
{
    internal class Program
    {
        /* Calcular la edad de una persona si es mayor o menor de edad */
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            string nombre;
            DateTime fechanac;
            Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Fecha de nacimiento ");
            fechanac = DateTime.Parse(Console.ReadLine());
            persona.Nombre = nombre; 
            persona.FechaNac = fechanac;
            Console.WriteLine(persona.EvaluarEdad());
            

        }
    }
}
