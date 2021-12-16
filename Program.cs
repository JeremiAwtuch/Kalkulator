using System;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator został uruchomiony.");

            while (true)
            {

                try
                {
                    Console.WriteLine("Podaj pierwszą liczbę:");
                    var number1 = GetInput();

                    Console.WriteLine("Jaką operację chcesz wykonać? (możliwe operacje: '+', '-', '*', '/'.)");
                    var operation = Console.ReadLine();

                    Console.WriteLine("Podaj drugą liczbę:");
                    var number2 = GetInput();

                    var result = Calculate(number1, number2, operation);

                    Console.WriteLine($"Wynik działania: {Math.Round(result, 2)}.\n");

                }
                catch (Exception ex)
                {
  
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static double GetInput()
        {
            if (!double.TryParse(Console.ReadLine(), out double input))
                throw new Exception("Nie wykryto liczby.\n");

            return input;
        }

        private static double Calculate(double number1, double number2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                case "*":
                    return number1 * number2;
                case "/":
                    return number1 / number2;
                default:
                    throw new Exception("Błąd operacji! Sprawdź poprawność polecenia i spróbuj jeszcze raz.\n");
            }
        }
    }
}