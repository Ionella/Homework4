using System;

namespace Homework4;
class Calculator
{ public static void Implimemtare() 
    {
        Console.WriteLine(" Dati primul numar:");
        int numar1 = int.Parse(Console.ReadLine());

        Console.WriteLine(" Dati al doilea numar:");
        int numar2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Alege operatia + sau - ");
        char semn = Console.ReadKey().KeyChar;

        if (semn == '+')
        {
            long suma = numar1 + numar2;
            Console.WriteLine("\nSuma este: " + suma);
        }

        if (semn == '-')
        {
            int diferenta = numar1 - numar2;
            Console.WriteLine("\nDiferenta este: " + diferenta);
        }
    } 
}

class Temperatura
{ public static void ConversiaCtoF()

    { Console.WriteLine("Introduceti temperatura in grade Celsius");
      float celsius = float.Parse(Console.ReadLine());

      double fahrenheit = celsius * 9 / 5 + 32;

      Console.WriteLine("Grade in Fahrenheit sunt: " + fahrenheit);     
    }
}

class MasaCorporala
{ public static void CalculareaIMC()

    { Console.WriteLine("Introdu greutatea corporala (kg): ");
      int greutate = int.Parse(Console.ReadLine());

      Console.WriteLine("Introdu inaltimea (m): ");
      float inaltime = float.Parse(Console.ReadLine());

      float IMC = greutate/(inaltime * inaltime);
      Console.WriteLine("Indeciul de masa corporala este: " + IMC);
    } 
}

class Program
{
    static void Main(string[] args)
    { Calculator.Implimemtare();
      Temperatura.ConversiaCtoF();
      MasaCorporala.CalculareaIMC();
    }
}