using BrownianMotionModel;
using BrownianMotionService;
using System;

namespace RuchyBrownaConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Ile punktów chcesz wygenerować: ");
            int n = 0;
            while (int.TryParse(Console.ReadLine(), out n) == false || n < 1)
            {
                Console.Write("Błąd danych wejściowych. Spróbuj ponownie: ");
            }

            var brownPoints = BrownPoint.GenerateNPoints(n);
            BrownianMotionVector vec = new BrownianMotionVector();


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Punkt {i + 1} ma współrzędne {brownPoints[i]}");               
            }

            var vector = vec.CalculateVector(brownPoints[brownPoints.Count - 1]);
            Console.WriteLine($"Wektor = {vector}");

            Console.WriteLine("Podaj nazwę pliku do zapisania danych: ");
            string filePath = Console.ReadLine();

            BrownianMotionSaveToCsv saveToCsv = new BrownianMotionSaveToCsv();

            var result = saveToCsv.SaveBrownianMotionPointsToCsvFile(filePath, brownPoints);

            while (result != Result.Ok())
            {
                Console.WriteLine($"Wystąpił błąd: {result.Error}.\r\nSpróbuj ponownie wybierając plik:");
                filePath = Console.ReadLine();
                result = saveToCsv.SaveBrownianMotionPointsToCsvFile(filePath, brownPoints);
            }

            Console.Write("Zakończono działanie programu. Kliknij enter aby zakończyć.");
            Console.ReadLine();
        }
    }
}
