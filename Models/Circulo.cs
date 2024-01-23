using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOO.Models;



namespace DesafioPOO.Models
{
    public class Circulo : Forma
    {
        public double Raio {get; set;}
        public Circulo(double raio){
            Raio = raio;
        }


        public double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }


        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio ;
        }
    }
}