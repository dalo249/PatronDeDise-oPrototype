namespace EjemploPrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.Edad = 42;
            p1.FechaNacimiento = Convert.ToDateTime("1977-01-01");
            p1.Nombre = "Jack Daniels";
            p1.InfoId = new InfoId(666);

            // Realizar una copia superficial de p1 y asignarla a p2.
            Persona p2 = p1.CopiaSuperficial();
            // Realizar una copia profunda de p1 y asignarla a p3.
            Persona p3 = p1.CopiaProfunda();

            // Mostrar los valores de p1, p2 y p3.
            Console.WriteLine("Valores originales de p1, p2, p3:");
            Console.WriteLine("   Valores de la instancia p1:");
            MostrarValores(p1);
            Console.WriteLine("   Valores de la instancia p2:");
            MostrarValores(p2);
            Console.WriteLine("   Valores de la instancia p3:");
            MostrarValores(p3);

            // Cambiar los valores de las propiedades de p1 y mostrar los valores de p1,
            // p2 y p3.
            p1.Edad = 32;
            p1.FechaNacimiento = Convert.ToDateTime("1900-01-01");
            p1.Nombre = "Frank";
            p1.InfoId.NumeroId = 7878;
            Console.WriteLine("\nValores de p1, p2 y p3 después de los cambios en p1:");
            Console.WriteLine("   Valores de la instancia p1:");
            MostrarValores(p1);
            Console.WriteLine("   Valores de la instancia p2 (los valores de referencia han cambiado):");
            MostrarValores(p2);
            Console.WriteLine("   Valores de la instancia p3 (todo se mantuvo igual):");
            MostrarValores(p3);
        }

        public static void MostrarValores(Persona p)
        {
            Console.WriteLine("      Nombre: {0:s}, Edad: {1:d}, Fecha de Nacimiento: {2:MM/dd/yy}",
                p.Nombre, p.Edad, p.FechaNacimiento);
            Console.WriteLine("      ID#: {0:d}", p.InfoId.NumeroId);
        }
    }
  
}