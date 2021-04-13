using System;

namespace Labo03
{
    public class Choza : Habitacion, IHabitacion
    {
        public Choza(string nombre,  string cliente, double precio = 100) : base(nombre, precio, cliente)
        {
        }

        public void llegarHabitacion()
            => Console.WriteLine("Se le han entregado las llaves, madera y aceites aromaticos de la choza {0}. Disfrute su estadia", nombre);

        public void abandonarHabitacion()
            => Console.WriteLine("El cliente ha entregado las llaves, la madera y los aceites aromaticos de la choza {0}. Feliz viaje", nombre);
    }
}