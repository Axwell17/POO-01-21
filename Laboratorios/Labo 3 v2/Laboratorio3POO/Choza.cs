using System;

namespace Laboratorio3POO
{
    public class Choza : Habitacion, IHabitacion
    {
        public Choza(string nombre, double costo = 100) : base(nombre, costo)
        {
        }
        public void llegarHabitacion() => Console.WriteLine("Se le entregaron las llaves de la choza {0}, un poco de madera y aceites aromaticos. Que disfrute su estadia", nombre);
        
        public void abandonarHabitacion() => Console.WriteLine("El cliente entrega las llaves de la choza {0}, la madera y los aceites aromaticos. Que tenga feliz viaje", nombre);

        public void reservarHabitacion()
        {
            throw new NotImplementedException();
        }

        public void procesarPago()
        {
            throw new NotImplementedException();
        }

        public void mostrarReservas()
        {
            throw new NotImplementedException();
        }
    }
}