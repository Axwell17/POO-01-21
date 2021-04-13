using System;
using System.Collections.Generic;

namespace Labo03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Habitacion> reservas = new List<Habitacion>();
            Menu(ref reservas);
        }

        static void Menu(ref List<Habitacion> reservas)
        {
            int opcion = 0;
            string tReserva, nHabitacion;
            Habitacion hEncontrada;
            do
            {
                Console.WriteLine("----- MENU -----");
                Console.WriteLine("1. Hacer una reservacion");
                Console.WriteLine("2. Entregar habitacion");
                Console.WriteLine("3. Abandonar habitacion");
                Console.WriteLine("4. Mostrar las reservaciones");
                Console.WriteLine("5. Salir");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Habitacion nuevaReservacion = hacerReserva();
                        if (nuevaReservacion != null)
                        {
                            reservas.Add(nuevaReservacion);
                        }
                        break;
                    case 2:
                        tReserva = tipoHabitacion();
                        Console.WriteLine("Escriba el nombre de la habitacion que ha reservado: ");
                        nHabitacion = Console.ReadLine();

                        hEncontrada = reservas.Find(habitacion => habitacion.nombre.Equals($"{tReserva}-{nHabitacion}"));

                        if (hEncontrada != null)
                        {
                            switch (tReserva)
                            {
                                case "HOTEL":
                                    Hotel h = (Hotel) hEncontrada;
                                    h.llegarHabitacion();
                                    break;
                                case "CABANA":
                                    Cabana c = (Cabana) hEncontrada;
                                    c.llegarHabitacion();
                                    break;
                                case "CHOZA":
                                    Choza ch = (Choza) hEncontrada;
                                    ch.llegarHabitacion();
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("La habitacion de tipo {0} con el nombre {1} no se encuentra reservada", tReserva, nHabitacion);
                        }
                        break;
                    case 3:
                        tReserva = tipoHabitacion();
                        Console.WriteLine("Escriba el nombre de la habitacion que ha reservado: ");
                        nHabitacion = Console.ReadLine();

                        hEncontrada = reservas.Find(habitacion => habitacion.nombre.Equals($"{tReserva}-{nHabitacion}"));

                        if (hEncontrada != null)
                        {
                            switch (tReserva)
                            {
                                case "HOTEL":
                                    Hotel h = (Hotel) hEncontrada;
                                    h.abandonarHabitacion();
                                    break;
                                case "CABANA":
                                    Cabana c = (Cabana) hEncontrada;
                                    c.abandonarHabitacion();
                                    break;
                                case "CHOZA":
                                    Choza ch = (Choza) hEncontrada;
                                    ch.abandonarHabitacion();
                                    break;
                            }
                            reservas.Remove(hEncontrada);
                        }
                        else
                        {
                            Console.WriteLine("La habitacion de tipo {0} con el nombre {1} no se ha encontrado", tReserva, nHabitacion);
                        }
                        break;
                    case 4:
                        mostrarReservas(reservas);
                        break;
                    case 5: break;
                    default: 
                        Console.WriteLine("Ingrese una opcion valida");
                        break;
                }

            } while (opcion != 5);
        }

        static void mostrarReservas(List<Habitacion> reservas)
        {
            Console.WriteLine("--- RESERVAS ---");
            reservas.ForEach(habitacion => Console.WriteLine("{0} reservada por {1}", habitacion.nombre, habitacion.cliente));
        }

        static string tipoHabitacion()
        {
            int opcion;
            Console.WriteLine("--- TIPO DE HABITACION ----");
            Console.WriteLine("1. Hotel");
            Console.WriteLine("2. Cabana");
            Console.WriteLine("3. Choza");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    return "HOTEL";
                case 2:
                    return "CABANA";
                case 3:
                    return "CHOZA";
                default: return null;
            }
        }

        static Habitacion hacerReserva()
        {
            int opcion;
            string nHabitacion, nCliente;
            do
            {
                Console.WriteLine("--- TIPOS DE HABITACION ---");
                Console.WriteLine("1. Hotel");
                Console.WriteLine("2. Cabana");
                Console.WriteLine("3. Choza");
                Console.WriteLine("4. Regresar");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre de la habitacion de hotel que desea reservar: ");
                        nHabitacion = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del cliente: ");
                        nCliente = Console.ReadLine();
                        Hotel h = new Hotel($"HOTEL-{nHabitacion}", nCliente);
                        procesarPago(h.precio);
                        Console.WriteLine("Habitacion {0} reservada", nHabitacion);
                        return h;
                    case 2:
                        Console.WriteLine("Ingrese el nombre de la cabana que desea reservar: ");
                        nHabitacion = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del cliente: ");
                        nCliente = Console.ReadLine();
                        Cabana c = new Cabana($"CABANA-{nHabitacion}", nCliente);
                        procesarPago(c.precio);
                        Console.WriteLine("Habitacion {0} reservada", nHabitacion);
                        return c;
                    case 3:
                        Console.WriteLine("Ingrese el nombre de la choza que desea reservar: ");
                        nHabitacion = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del cliente: ");
                        nCliente = Console.ReadLine();
                        Choza ch = new Choza($"CHOZA-{nHabitacion}", nCliente);
                        procesarPago(ch.precio);
                        Console.WriteLine("Habitacion {0} reservada", nHabitacion);
                        return ch;
                    case 4: return null;
                    default: 
                        Console.WriteLine("Ingrese una opcion valida");
                        break;
                }
            } while (opcion != 4);

            return null;
        }

        static void procesarPago(double costo)
        {
            int opcion;
            do
            {
                Console.WriteLine("--- METODO DE PAGO ---");
                Console.WriteLine("1. Efectivo");
                Console.WriteLine("2. Tarjeta de credito/debito");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("El cliente ha pagado {0} en efectivo", costo);
                        break;
                    case 2:
                        Console.WriteLine("Se ha efectuado el cobro a su tarjeta de credito/debito de {0}", costo);
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        break;
                }
            } while (opcion != 1 && opcion != 2);

    }
    }
}