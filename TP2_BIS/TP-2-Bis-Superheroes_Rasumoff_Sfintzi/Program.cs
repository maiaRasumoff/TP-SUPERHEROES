namespace TP_2_Bis_Superheroes_Rasumoff_Sfintzi;

using System;

class Program
{
    static Superheroe superheroe1, superheroe2;

    static void Main()
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Cargar Datos Superhéroe 1");
            Console.WriteLine("2. Cargar Datos Superhéroe 2");
            Console.WriteLine("3. Competir!");
            Console.WriteLine("4. Salir");

            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    superheroe1 = ObtenerSuperheroe(1);
                    if (superheroe1 != null)
                        Console.WriteLine("Se ha creado el superhéroe: " + superheroe1.Nombre);
                    break;

                case 2:
                    superheroe2 = ObtenerSuperheroe(2);
                    if (superheroe2 != null)
                        Console.WriteLine($"Se ha creado el superhéroe {superheroe2.Nombre}");
                    break;

                case 3:
                    Pelear();
                    break;

                case 4:
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static Superheroe ObtenerSuperheroe(int numero)
    {
        Console.WriteLine("Ingrese los datos del Superhéroe" + numero);
        Console.WriteLine("Nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ciudad: ");
        string ciudad = Console.ReadLine();
        Console.WriteLine("Peso: ");
        double peso = double.Parse(Console.ReadLine());
        Console.WriteLine("Fuerza (entre 1 y 100): ");
        double fuerza = double.Parse(Console.ReadLine());
        Console.WriteLine("Velocidad (entre 1 y 100): ");
        double velocidad = double.Parse(Console.ReadLine());

        if (fuerza < 1 || fuerza > 100 || velocidad < 1 || velocidad > 100)
        {
            Console.WriteLine("Error: Fuerza y velocidad deben estar entre 1 y 100.");
            return null;
        }

        return new Superheroe(nombre, ciudad, peso, fuerza, velocidad);
    }

    static void Pelear()
    {
        if (superheroe1 == null || superheroe2 == null)
        {
            Console.WriteLine("Error: No se pueden competir porque falta cargar datos de algún superhéroe.");
            return;
        }

        double skillSuperheroe1 = superheroe1.ObtenerSkill();
        double skillSuperheroe2 = superheroe2.ObtenerSkill();

        Console.WriteLine("Skill de: " + superheroe1.Nombre + ": " + skillSuperheroe1);
        Console.WriteLine("Skill de" + superheroe2.Nombre + " : "+ skillSuperheroe2);

        if (skillSuperheroe1 > skillSuperheroe2)
        {
            if (skillSuperheroe1 - skillSuperheroe2 >= 30)
                Console.WriteLine("Ganó:"+ superheroe1.Nombre + "por amplia diferencia");
            else if (skillSuperheroe1 - skillSuperheroe2 >= 10)
                Console.WriteLine("Ganó: " + superheroe1.Nombre + ". ¡Fue muy parejo!");
            else
                Console.WriteLine("Ganó" + superheroe1.Nombre+ ". ¡No le sobró nada!");
        }
        else if (skillSuperheroe2 > skillSuperheroe1)
        {
            if (skillSuperheroe2 - skillSuperheroe1 >= 30)
                Console.WriteLine("Ganó" + superheroe2.Nombre + "por amplia diferencia");
            else if (skillSuperheroe2 - skillSuperheroe1 >= 10)
                Console.WriteLine("Ganó" + superheroe2.Nombre + ". ¡Fue muy parejo!");
            else
                Console.WriteLine("Gano: " + superheroe2.Nombre + ". ¡No le sobró nada!");
        }
        else
        {
            Console.WriteLine("Empate!!");
        }
    }
}