using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    internal class Complejos
    {
        double valorA, valorB, valorC, valorD;
        List<double> list = new List<double>();
        
        //Creamos el constructor
        public Complejos(double valorA, double valorB, double valorC, double valorD)
        {
            this.valorA = valorA;
            this.valorB = valorB;
            this.valorC = valorC;
            this.valorD = valorD;
        }

        //Encapsulamos las variables, para que sean propiedades de solo lectura
        public double ValorA { get => valorA; }
        public double ValorB { get => valorB; }
        public double ValorC { get => valorC; }
        public double ValorD { get => valorD; }


        
        //Procedemos a crear los diferentes métodos que realizaremos con los valores antes mencionados
        public String Suma()
        {
            //Fórmula:
            //(a, b) + (c, d) = (a + c, b + d);
            double parteReal = valorA + valorC;
            double parteImaginaria = valorB + valorD;

            return $"La suma correspondiente es: ({Math.Round(parteReal,5)}, {Math.Round(parteImaginaria,5)}i)\n";
        }

        public String Resta()
        {
            //Fórmula:
            //(a, b) - (c, d) = (a - c, b - d);
            double parteReal = valorA - valorC;
            double parteImaginaria = valorB - valorD;

            return $"La resta correspondiente es: ({Math.Round(parteReal,5)}, {Math.Round(parteImaginaria,5)}i)\n";

        }

        public String Multiplicacion()
        {
            //Fórmula:
            //(a, b) * (c, d) = (a * c – b* d, a*d + b * c)
            double parteReal = valorA * valorC - valorB * valorD;
            double parteImaginaria = valorA * valorD + valorB * valorC;

            return $"La multiplicacion correspondiente es: ({Math.Round(parteReal,5)}, {Math.Round(parteImaginaria,5)}i)\n";

        }
        public String Division()
        {
            //Fórmula:
            //(a, b) / (c, d) = ((a * c + b * d) / (c2 + d2), (b * c – a* d) / (c2 + d2))
            double parteReal = (valorA * valorC + valorB * valorD) / (Math.Pow(valorC, 2) + Math.Pow(valorD, 2));
            double parteImaginaria = (valorB * valorC - valorA * valorD) / (Math.Pow(valorC, 2) + Math.Pow(valorD, 2));

            return $"La división correspondiente es: \n  {Math.Round(parteReal,5)}\n-------------\n  {Math.Round(parteImaginaria,5)}i\n";
        }


    }
}
