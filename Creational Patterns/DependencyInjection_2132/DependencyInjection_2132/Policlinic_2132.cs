// Policlinic_2132.cs
using System;

namespace DependencyInjection_2132
{
    public class Policlinic_2132 : IPoliclinic_2132
    {
        public void AddPoliklinik(string poliklinikName)
        {
            Console.WriteLine($"{poliklinikName} added.");
        }

        public void RemovePoliklinik(string poliklinikName)
        {
            Console.WriteLine($"{poliklinikName} removed.");
        }

        public void PoliklinikNotFound(string poliklinikName)
        {
            Console.WriteLine($"Poliklinik {poliklinikName} not found.");
        }
    }
}