using System;

namespace ConsoleApp_ConsoleApp_2023C2_EF_CF_12E
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EscuelaContext())
            {
                var std = new Estudiante()
                {
                    EstudianteNombre = "Maria del Carmen"
                };
                context.Estudiante.Add(std);
                context.SaveChanges();
            }
            Console.WriteLine("Nuevo Estudiante agregado!");
            Console.ReadKey();
        }
    }
}
