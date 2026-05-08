using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Introduccion.Csharp.Models
{
    public class Multiplicacion
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public int Total { get; set; }

        public string Resultado { get; set; }

        public void MostrarMultiplicacion()
        {
            Resultado = "";
            Total = 0;
            for (int i = 1; i <= this.Num2; i++)
            {
                this.Resultado += this.Num1;
                this.Total += this.Num1;
                if (i < this.Num2)
                {
                    this.Resultado += "+";
                }
            }

            this.Resultado += "=" + this.Total;
        }
    }
}