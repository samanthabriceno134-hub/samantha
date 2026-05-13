using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenidos a la venta de tickets en el estadio Rigoberto López Pérez");

        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.WriteLine("\nTipos de tickets disponibles:");
        Console.WriteLine("1. General - 100");
        Console.WriteLine("2. Preferencial - 200");
        Console.WriteLine("3. VIP - 300");

        Console.Write("\nSeleccione el tipo de ticket (1-3): ");
        int opcion = int.Parse(Console.ReadLine());

        int precio_ticket = 0;
        string tipo = "";

        switch (opcion)
        {
            case 1:
                precio_ticket = 100;
                tipo = "General";
                break;

            case 2:
                precio_ticket = 200;
                tipo = "Preferencial";
                break;

            case 3:
                precio_ticket = 300;
                tipo = "VIP";
                break;

            default:
                Console.WriteLine("Opción inválida");
                break;
        }

        Console.WriteLine("\n----- FACTURA -----");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Tipo de Ticket: " + tipo);
        Console.WriteLine("Total a pagar: " + precio_ticket);
    }
}