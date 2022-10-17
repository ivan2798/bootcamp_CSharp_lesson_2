using System;

// Hello World! program
namespace C_Sharp_lesson2
{
    class Program
    {
        // intellisense

        static void Main(string[] args)
        {
            Console.WriteLine(Suma(7,5.3));
            
        }

        //expresion bodied
        static int Suma(int operador1, int operador2) => operador1 + operador2;

        static int Suma(int numero1, double numero2) => numero1;

        static int Suma(int numero1, int numero2, int numero3, int numero4) => numero1 + numero2;


    }
}