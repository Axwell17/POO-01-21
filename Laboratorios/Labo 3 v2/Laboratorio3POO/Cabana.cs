using System;

namespace Laboratorio3POO
{
    public class Cabana : Habitacion, IHabitacion
    {
        public Cabana(string nombre, double costo = 150) : base(nombre, costo)
        {
        }
        
        public void llegarHabitacion() => Console.WriteLine("Se le entregaron las llaves de la cabaña {0} y algo de leña para la chimenea. Que disfrute su estadia", nombre);
        
        public void abandonarHabitacion() => Console.WriteLine("El cliente entrega las llaves de la cabaña {0} y la leña. Que tenga feliz viaje", nombre);
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