using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Introduccion.Csharp.Models
{
    public class OperasBas
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Resultado { get; set; }

        public void Suma()
        {
            this.Resultado = this.Num1 + this.Num2;

        }

        public void Resta()
        {
            this.Resultado = (this.Num1 - this.Num2);
        }

        public void Multiplicacion()
        {
            this.Resultado = (this.Num1 * this.Num2);
        }

        public void Division()
        {
            this.Resultado = (this.Num1 / this.Num2);
        }
    }
}