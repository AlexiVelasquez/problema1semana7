using System;

namespace problema1semana7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de n: ");
            int n = int.Parse(Console.ReadLine());

            double sumaResultados = 0;

            for (int i = 1; i <= n; i++)
            {
                double resultado = ((16.0 - i) / (3.0 * i));
                Console.WriteLine("resultado :"+resultado);
                sumaResultados += resultado;


            }
            Console.WriteLine(sumaResultados.ToString("F4"));

            Console.ReadKey();
            
        }   
    }
}
