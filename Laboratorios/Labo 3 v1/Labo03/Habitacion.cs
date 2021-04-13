using System.Collections.Generic;

namespace Labo03
{
    public class Habitacion
    {
        public string nombre;
        public double precio;
        public string cliente;

        protected List<bool> habitaciones;

        public Habitacion(string nombre, double precio, string cliente)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cliente = cliente;
            habitaciones = new List<bool> {false, true, false, false};
        }
    }
}