namespace Alapok
{
    /// <summary>
    /// Szorzótáblák kiíratására szolgáló osztály.
    /// </summary>
    static class Szorzótábla
    {
        //Kimenet: szorzótábla 1 - 10-ig
        /*
        1-es szorzótábla
        1 x 1 = 1
        1 x 2 = 2
        1 x 3 = 3
        1 x 4 = 4
        1 x 5 = 5
        1 x 6 = 6
        1 x 7 = 7
        1 x 8 = 8
        1 x 9 = 9
        1 x 10 = 10

        2-es szorzótábla
        ...
        */
        static void Noob()
        {
            for (int alap = 1; alap <= 10; alap++)
            {
                Console.WriteLine(alap + ". szorzótábla");
                Console.WriteLine(alap + " X 1 = " + alap * 1);
                Console.WriteLine(alap + " X 2 = " + alap * 2);
                Console.WriteLine(alap + " X 3 = " + alap * 3);
                Console.WriteLine(alap + " X 4 = " + alap * 4);
                Console.WriteLine(alap + " X 5 = " + alap * 5);
                Console.WriteLine(alap + " X 6 = " + alap * 6);
                Console.WriteLine(alap + " X 7 = " + alap * 7);
                Console.WriteLine(alap + " X 8 = " + alap * 8);
                Console.WriteLine(alap + " X 9 = " + alap * 9);
                Console.WriteLine(alap + " X 10 = " + alap * 10);
                Console.WriteLine();
            }
        }
        static void ExpertNoob()
        {
            for (int alap = 1; alap <= 10; alap++)
            {
                Console.WriteLine(alap + ". szorzótábla");
                int szorzó = 1;
                Console.WriteLine(alap + " X " + szorzó + " = " + alap * szorzó++);
                Console.WriteLine(alap + " X " + szorzó + " = " + alap * szorzó++);
                Console.WriteLine(alap + " X " + szorzó + " = " + alap * szorzó++);
                Console.WriteLine(alap + " X " + szorzó + " = " + alap * szorzó++);
                Console.WriteLine(alap + " X " + szorzó + " = " + alap * szorzó++);
                Console.WriteLine(alap + " X " + szorzó + " = " + alap * szorzó++);
                Console.WriteLine(alap + " X " + szorzó + " = " + alap * szorzó++);
                Console.WriteLine(alap + " X " + szorzó + " = " + alap * szorzó++);
                Console.WriteLine(alap + " X " + szorzó + " = " + alap * szorzó++);
                Console.WriteLine(alap + " X " + szorzó + " = " + alap * szorzó++);
                Console.WriteLine();
            }
        }
        static void Pro()
        {
            for (int alap = 1; alap <= 10; alap++)
            {
                Console.WriteLine(alap + ". szorzótábla");
                for (int szorzó = 1; szorzó <= 10; szorzó++)
                {
                    Console.WriteLine(alap + " X " + szorzó + " = " + alap * szorzó);
                }
                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        static double SzamBekeres(string uzenet)
        {
            Console.Write(uzenet);
            string input = Console.ReadLine()!;
            double output = double.Parse(input);
            return output;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double a = SzamBekeres("Adja meg az a együttható értékét: ");
                double b = SzamBekeres("Adja meg az b együttható értékét: ");
                double c = SzamBekeres("Adja meg az c együttható értékét: ");
                double d = b * b - 4 * a * c;

                if (d < 0)
                {
                    Console.WriteLine("Nincs megoldása a valós számok halmazán.");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    if (d == 0)
                    {
                        Console.WriteLine($"Egy megoldása van a valós számok halmazán. ({x1})");
                    }
                    else
                    {
                        double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                        Console.WriteLine($"Két megoldása van a valós számok halmazán. ({x1}, {x2})");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Folytatáshoz nyomjon Enter-t!");
                Console.ReadLine();
            
            }
        }
    }
}
