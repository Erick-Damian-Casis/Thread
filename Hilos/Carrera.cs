using System;
using System.Threading;

namespace Hilos
{
    class Carrera 
    {
        public static void Corredor(object obj) 
        {
            var nombre = (string)obj;
            var pasos = 0;
            var random = new Random();
            while (pasos < 10000) 
            {
                pasos += random.Next(0,300);
                Console.WriteLine("Corredor {0} va a {1} km/h", nombre, pasos);
                Thread.Sleep(10);
            }
            Console.WriteLine("{0} a llego a la meta. ************Felicidades!***************", nombre);
        }
    }
}
