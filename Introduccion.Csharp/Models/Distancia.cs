using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Introduccion.Csharp.Models
{
    public class Distancia
    {
        public double x1 { get; set; }
        public double x2 { get; set; }
        public double y1 { get; set; }
        public double y2 { get; set; }
        public double distancia { get; set; }

        public void CalcularDistancia()
        {
            this.distancia = Math.Sqrt(
                Math.Pow(this.x2 - this.x1, 2) +
                Math.Pow(this.y2 - this.y1, 2)
            );
        }
    }
}