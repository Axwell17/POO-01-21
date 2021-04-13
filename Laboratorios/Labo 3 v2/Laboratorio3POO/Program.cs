using System;
using System.Collections.Generic;


namespace Laboratorio3POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel h = new Hotel("Hotel La Realeza");
            Cabana c = new Cabana("Cabana Nueva");
            Menu(ref h);
        }

        static void Menu(ref Hotel hab)
        {
            int option = 0;
            do
            {
                Console.WriteLine("----- MENU -----");
                Console.WriteLine("1. Hacer una reserva");
                Console.WriteLine("2. Entregar habitacion");
                Console.WriteLine("3. Abandonar habitacion");
                Console.WriteLine("4. Mostrar reservas");
                Console.WriteLine("5. Salir");
                option = Convert.ToInt32(Console.ReadLine());
                string nHabitacion, tHabitacion;
                Habitacion hEncontrada;

                switch (option)
                {
                    case 1:
                        
                        hab.reservarHabitacion();
                        break;
                    case 2:
                        hab.llegarHabitacion();
                        break;
                    case 3:
                        hab.abandonarHabitacion();
                        break;
                    case 4:
                        hab.mostrarReservas();
                        break;
                    case 5:break;
                    default: 
                        Console.WriteLine("Ingrese una opcion valida");
                        break;
                }

            } while (option != 5);

        }

    }
}