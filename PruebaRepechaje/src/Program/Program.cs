using Library;
using System;

public class Program
{
    public static void Main()
    {
        FactorialHandler h1 = new FactorialHandler();
        SumaHandler h2 = new SumaHandler();
        h1.setNext(h2);

        while(true)
        {
            string dato = "";
            Console.WriteLine("¿Qué operación desea realizar? (Suma o Factorial)");
            dato = h1.Handle(Console.ReadLine());
            if(dato == "Ha elegido factorial, Ingrese un número: ")
            {
                try
                {
                Console.WriteLine(dato);
                Console.WriteLine(h1.Handle(Console.ReadLine()));
                }
                catch(System.Exception)
                {
                    Console.WriteLine("El valor que usted ingresó es inválido.");
                }
            }
            else if(dato == "Ha elegido Sumar, ingrese un número: ")
            {
                try
                {                
                Console.WriteLine(dato);
                dato = h1.Handle(Console.ReadLine());
                while(dato == "Ingrese un número (digite 'Nada' para finalizar)")
                {
                    dato = h1.Handle(Console.ReadLine());
                    Console.WriteLine(dato);
                }
                }
                catch(System.Exception)
                {
                    Console.WriteLine("El valor que usted ingresó es inválido");
                }
            }
            else
            {
                Console.WriteLine(dato);
            }

        }

        
    }
}