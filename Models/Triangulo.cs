using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public class Triangulo : Forma
    {

        private double Base;
        private double Altura;

        public Triangulo (double baSe, double altura){

            Base = baSe;
            Altura = altura;
       
        }

        public double CalcularArea()
        {
            return Base * Altura;
        }

        public double CalcularPerimetro()
        {
            throw new NotImplementedException();
        }
    }
}