using System;
using System.Reflection;

namespace Actividad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta = "1";

            //Con este ciclo While lograremos repetir el código las ocasiones que el usuario desee
            while (respuesta == "1")
            {
                Console.Clear();
                double[] valorUsuario = new double[4];
                string letra = "";
                int bandera = 1;

                //Si el usuario se equivocó presionando una letra y no un número, este condicional repite el proceso para que el usuario ingrese los daos nuevamente
                while (bandera == 1)
                {

                    for (int i = 0; i < 4; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                letra = "A";
                                break;
                            case 1:
                                letra = "B";
                                break;
                            case 2:
                                letra = "C";
                                break;
                            case 3:
                                letra = "D";
                                break;
                        }

                        Console.WriteLine($"Por favor ingresa el valor {letra}");
                        try
                        {
                            valorUsuario[i] = double.Parse(Console.ReadLine());
                            bandera = 0;
                        }
                        catch
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("¡Error!, se ha ingresado un valor no numérico");
                            Console.ResetColor();
                            Thread.Sleep(2500);
                            Console.Clear();
                            Console.WriteLine("Intentemos nuevamente");
                            bandera = 1;
                            break;
                        }
                    }
                }

                //Creamos nuestro objeto con nombre "operacion1" en base a la clase Complejor, con los datos que le pedimos al usuario.
                Complejos operacion1 = new Complejos(valorUsuario[0], valorUsuario[1], valorUsuario[2], valorUsuario[3]);

                Console.WriteLine(operacion1.Suma());
                Console.WriteLine(operacion1.Resta());
                Console.WriteLine(operacion1.Multiplicacion());
                Console.WriteLine(operacion1.Division());

                Console.WriteLine("¿Desea volver a realizar otra operación?\n - Marque 1 para hacer otra operación. \n - Marque cualquier carácter para finalizar");
                respuesta = Console.ReadLine();

            }
        }
    }
}