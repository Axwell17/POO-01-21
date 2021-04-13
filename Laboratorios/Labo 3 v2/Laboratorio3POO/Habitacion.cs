using System.Collections.Generic;

namespace Laboratorio3POO
{
    public class Habitacion
    {
        public string nombre { get; set; }
        public double costo { get; set; }

        protected List<bool> habitaciones { get; set; }
        
        

        public Habitacion(string nombre, double costo)
        {
            this.nombre = nombre;
            this.costo = costo;
            habitaciones = new List<bool> {false, false, false, false};
        }
    }
}