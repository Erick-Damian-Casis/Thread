using System;
using System.Threading;

namespace Hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Thread corredor1 = new Thread(Carrera.Corredor);
            Thread corredor2 = new Thread(Carrera.Corredor);
            Thread corredor3 = new Thread(Carrera.Corredor);
            Thread corredor4 = new Thread(Carrera.Corredor);

            corredor1.Start("Ferrari");
            corredor2.Start("Lamborghini");
            corredor3.Start("Renault");
            corredor4.Start("Maserati");

            corredor1.Join();
            corredor2.Join();
            corredor3.Join();
            corredor4.Join();
            
         
        }

        static void MetodoPorEjecutar()
        {
            var hiloActual = Thread.CurrentThread;
            hiloActual.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine("Hilo actual {0}: ",hiloActual.ManagedThreadId);
            Console.WriteLine("Mi cultura es {0}: ", hiloActual.CurrentCulture);

            var random = new Random();

            for (int i =0; i <= 10; i++) 
            {
                Console.WriteLine("hilo {0} indice {1}", hiloActual.ManagedThreadId, i);
                Thread.Sleep(random.Next(100,500));
            }

           
        }

    }
}
