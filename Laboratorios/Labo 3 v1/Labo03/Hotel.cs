using System;

namespace Labo03
{
    public class Hotel : Habitacion, IHabitacion
    {
        public Hotel(string nombre,  string cliente, double precio = 200) : base(nombre, precio, cliente)
        {
            
        }

        public void llegarHabitacion() => Console.WriteLine("Se le han entregado las llaves de la habitacion {0} al cliente. Disfrute su estadia", nombre);


        public void abandonarHabitacion() =>
            Console.WriteLine("El cliente ha entregado las llaves de la habitacion {0}. Feliz viaje", nombre);
    }
}