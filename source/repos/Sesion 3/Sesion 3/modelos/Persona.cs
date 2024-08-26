using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_3.modelos
{
    internal class Persona
    {
       public Persona() { }
        public string Nombre { get; set; }
        public DateTime FechaNac {  get; set; }

        public int CalcularEdad()
        {
            int edad = 0;
            try
            {
                edad = DateTime.Now.Year - FechaNac.Year;
            }catch(Exception ex)
            {
                Console.WriteLine($"Ocurrio un error:  {ex.Message}");
            }
            
            return edad;
  
        }

        public string EvaluarEdad()
            {
            if (CalcularEdad() >= 180) return "Mayor de edad";
            return "Menor de edad";
            }
                
        
    }
}
