using System;

namespace Laboratorio3POO
{
    public class Hotel : Habitacion, IHabitacion
    {
        public Hotel(string nombre, double costo = 200) : base(nombre, costo)
        {
        }

        public void llegarHabitacion()
        {
            int eleccion;
            bool flagReserva = false;
            do
            {
                Console.WriteLine("Ingrese el numero de la habitacion reservada: ");
                eleccion = Convert.ToInt32(Console.ReadLine());

                if (eleccion > 0 && eleccion < 5)
                {
                    if (habitaciones[eleccion - 1])
                    {
                        Console.WriteLine("Se le entregan las llaves de la habitacion {0} del hotel {1}. Que disfrute su estadia", eleccion, nombre);
                        flagReserva = false;
                    }
                    else
                    {
                        flagReserva = true;
                        Console.WriteLine("La habitacion {0} no se encuentra reservada. Selecciona otra habitacion que si este reservada", eleccion);
                    }
                }
                else
                {
                    Console.WriteLine("Esa habitacion no existe en nuestro hotel. Selecciona una nuevamente");
                }
                
            } while (eleccion < 1 || eleccion > 4 || flagReserva);
        }


        public void abandonarHabitacion()
        {
            int eleccion;
            bool flagReserva = false;
            do
            {
                Console.WriteLine("Ingrese el numero de la habitacion reservada: ");
                eleccion = Convert.ToInt32(Console.ReadLine());

                if (eleccion > 0 && eleccion < 5)
                {
                    if (habitaciones[eleccion - 1])
                    {
                        habitaciones[eleccion - 1] = false;
                        Console.WriteLine("El cliente entrega las llaves de la habitacion {0} del hotel {1}. Que tenga feliz viaje", eleccion, nombre);
                        flagReserva = false;
                    }
                    else
                    {
                        flagReserva = true;
                        Console.WriteLine("La habitacion {0} no se encuentra reservada. Selecciona otra habitacion que si este reservada", eleccion);
                    }
                }
                else
                {
                    Console.WriteLine("Esa habitacion no existe en nuestro hotel. Selecciona una nuevamente");
                }
                
            } while (eleccion < 1 || eleccion > 4 || flagReserva);
        }

        public void reservarHabitacion()
        {
            Console.WriteLine("--- Habitaciones disponibles ---");
            for (int i = 0; i < habitaciones.Count; i++)
            {
                if (!habitaciones[i])
                {
                    Console.WriteLine("Habitacion {0} - Disponible", i+1); 
                }
                else
                {
                    Console.WriteLine("Habitacion {0} - Reservada", i+1); 
                }
            }
            int eleccion;
            bool flagReserva = false;
            do
            {
                Console.WriteLine("Ingrese el numero de la habitacion que desea reservar: ");
                eleccion = Convert.ToInt32(Console.ReadLine());

                if (eleccion > 0 && eleccion < 5)
                {
                    if (!habitaciones[eleccion - 1])
                    {
                        procesarPago();
                        habitaciones[eleccion - 1] = true;
                        Console.WriteLine("Habitacion {0} reservada.", eleccion);
                        flagReserva = false;
                    }
                    else
                    {
                        flagReserva = true;
                        Console.WriteLine("La habitacion {0} ya se encuentra reservada. Selecciona otra habitacion que si este disponible", eleccion);
                    }
                }
                else
                {
                    Console.WriteLine("Esa habitacion no existe en nuestro hotel. Selecciona una nuevamente");
                }
                
            } while (eleccion < 1 || eleccion > 4 || flagReserva);
            
        }
        
        public void procesarPago()
        {
            string nCliente;
            
            Console.Write("Ingrese el nombre del cliente: ");
            nCliente = Console.ReadLine();
            int option;
            do
            {
                Console.WriteLine("Seleccione su metodo de pago: ");
                Console.WriteLine("1. Efectivo");
                Console.WriteLine("2. Tarjeta de debito/credito");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("El cliente {0} ha pagado en efectivo ${1} dolares",  nCliente, costo);
                        break;
                    case 2:
                        Console.WriteLine("Se le ha efectuado el cargo de ${1} a la tarjeta de credito/debito del cliente {0}",  nCliente, costo);
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        break;
                }
            } while (option != 1 && option != 2);
        }

        public void mostrarReservas()
        {
            Console.WriteLine("--- Habitaciones reservadas ---");
            for (int i = 0; i < habitaciones.Count; i++)
            {
                if (habitaciones[i])
                {
                    Console.WriteLine("Habitacion {0}", i+1); 
                }
            }
        }
    }
}