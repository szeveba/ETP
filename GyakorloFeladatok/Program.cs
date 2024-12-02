namespace GyakorloFeladatok
{
    static class Feladatok
    {
        static void TippelosV1()
        {
            //típus változónév = érték;
            Random r = new Random();
            int veletlenSzam = r.Next(1, 101);
            int probalkozasokSzama = 1;
            Console.WriteLine("Gondoltam egy egész számra 1 és 100 között. Találd ki!");
            string input = Console.ReadLine()!;
            int tippeltSzam = int.Parse(input);
            while (tippeltSzam != veletlenSzam)
            {
                Console.WriteLine($"A tippelt szám {(tippeltSzam > veletlenSzam ? "kisebb" : "nagyobb")} mint amire gondoltam.");
                input = Console.ReadLine()!;
                tippeltSzam = int.Parse(input);
                probalkozasokSzama++;
            }
            Console.WriteLine("Gratulálok, eltaláltad! Próbálkozások száma: " + probalkozasokSzama);
        }
        public static void TippelosV2()
        {
            Random random = new Random();
            int veletlenSzam = random.Next(1, 101);
            int probalkozasokSzama = 1;
            int tippeltSzam = 0;
            Console.WriteLine("Gondoltam egy egész számra 1 és 100 között. Találd ki!");

            do
            {
                try
                {
                    Console.Write("Tipp: ");
                    string input = Console.ReadLine()!;
                    tippeltSzam = int.Parse(input);
                    if (tippeltSzam == veletlenSzam)
                    {
                        Console.WriteLine("Gratulálok, eltaláltad! Próbálkozások száma: " + probalkozasokSzama);
                    }
                    else
                    {
                        Console.WriteLine($"A tippelt szám {(tippeltSzam > veletlenSzam ? "kisebb" : "nagyobb")} mint amire gondoltam.");
                        probalkozasokSzama++;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Hibás a bemenet amit adtál, csak számot adhatsz meg!");
                }
            } while (tippeltSzam != veletlenSzam);
        }
        public static void TippelosV3()
        {
            Random random = new Random();
            int veletlenSzam = random.Next(1, 101);
            int probalkozasokSzama = 1;
            int tippeltSzam = 0;
            Console.WriteLine("Gondoltam egy egész számra 1 és 100 között. Találd ki!");

            do
            {
                tippeltSzam = ReadInt("Tipp: ");
                if (tippeltSzam == veletlenSzam)
                {
                    Console.WriteLine("Gratulálok, eltaláltad! Próbálkozások száma: " + probalkozasokSzama);
                }
                else
                {
                    Console.WriteLine($"A tippelt szám {(tippeltSzam > veletlenSzam ? "kisebb" : "nagyobb")} mint amire gondoltam.");
                    probalkozasokSzama++;
                }

            } while (tippeltSzam != veletlenSzam);
        }
        public static double ReadDouble(string message)
        {
            double result;
            Console.Write(message);
            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Átalakítás sikertelen, adjon meg egy valós számot: ");
            }
            return result;
        }
        public static int ReadInt(string message)
        {
            int result;
            Console.Write(message);
            string? input = Console.ReadLine();
            while (!int.TryParse(input, out result))
            {
                Console.WriteLine("Átalakítás sikertelen, megadott hibás érték: "+input);
                Console.Write(message);
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladatok.TippelosV3();
        }
    }
}
