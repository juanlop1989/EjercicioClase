using System;

namespace EjercicioClase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear objetos de la clase SuperHeroe
            SuperHeroe superHeroe1 = new SuperHeroe("Iron Man", "Tony Stark", "New York", true, new SuperPoder("Inteligente", "Produce un campo de energía que puede lanzar objetos", 5));
            SuperHeroe superHeroe2 = new SuperHeroe("Spider-Man", "Peter Parker", "New York", true, new SuperPoder("Velocidad y Fuerza", "Tiene una velocidad sobrehumana", 3));
            SuperHeroe superHeroe3 = new SuperHeroe("Thor", "Thor Odinson", "Asgard", false, new SuperPoder("Super Fuerza", "Tiene el poder del martillo Mjolnir", 8));

            // Mostrar información de los superhéroes
            Console.WriteLine("Información de los superhéroes:");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Primer SuperHeroe");
            Console.WriteLine($"Nombre: {superHeroe1.Nombre}");
            Console.WriteLine($"Identidad Secreta: {superHeroe1.IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {superHeroe1.Ciudad}");
            Console.WriteLine($"¿Puede Volar?: {(superHeroe1.PuedeVolar? "Si" : "No")}");
            Console.WriteLine($"Super Poder: {superHeroe1.SuperPoder.Nombre}");
            Console.WriteLine($"Descripción: {superHeroe1.SuperPoder.Descripcion}");
            Console.WriteLine($"Nivel: {superHeroe1.SuperPoder.Nivel}");

            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Segundo SuperHeroe");
            Console.WriteLine($"Nombre: {superHeroe2.Nombre}");
            Console.WriteLine($"Identidad Secreta: {superHeroe2.IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {superHeroe2.Ciudad}");
            Console.WriteLine($"¿Puede Volar?: {(superHeroe2.PuedeVolar ? "Si" : "No")}");
            Console.WriteLine($"Super Poder: {superHeroe2.SuperPoder.Nombre}");
            Console.WriteLine($"Descripción: {superHeroe2.SuperPoder.Descripcion}");
            Console.WriteLine($"Nivel: {superHeroe2.SuperPoder.Nivel}");

            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Tercer SuperHeroe");
            Console.WriteLine($"Nombre: {superHeroe3.Nombre}");
            Console.WriteLine($"Identidad Secreta: {superHeroe3.IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {superHeroe3.Ciudad}");
            Console.WriteLine($"¿Puede Volar?: {(superHeroe3.PuedeVolar ? "Si" : "No")}");
            Console.WriteLine($"Super Poder: {superHeroe3.SuperPoder.Nombre}");
            Console.WriteLine($"Descripción: {superHeroe3.SuperPoder.Descripcion}");
            Console.WriteLine($"Nivel: {superHeroe3.SuperPoder.Nivel}");


        }
    }

}