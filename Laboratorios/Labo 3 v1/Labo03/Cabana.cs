using System;

namespace Labo03
{
    public class Cabana : Habitacion, IHabitacion
    {
        public Cabana(string nombre,  string cliente, double precio = 150) : base(nombre, precio, cliente)
        {
        }

        public void llegarHabitacion() 
            => Console.WriteLine("Se le han entregado las llaves y un poco de lena de la cabana {0} al cliente. Disfrute su estadia", nombre);

        public void abandonarHabitacion() 
            => Console.WriteLine("El cliente ha entregado las llaves y la madera de la cabana {0}. Feliz viaje", nombre);
    }
}