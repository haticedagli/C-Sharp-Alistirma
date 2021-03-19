using System;

namespace haticeEtogluVizeÖdevi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number1 = 0;
            int number2 = 0;
            int firstPerson = 0;
            int secondPerson = 0;
            int dice;
            Console.WriteLine("\n\nBirinci oyuncu zar atmak icin tusa basiniz. \n\n");
            Console.ReadKey();
            number1 = rnd.Next(1, 7);
            Console.WriteLine(number1 + "\n");
            Console.WriteLine("\n\nIkinci oyuncu zar atmak icin tusa basiniz. \n\n");
            Console.ReadKey();
            number2 = rnd.Next(1, 7);
            Console.WriteLine(number2 + "\n");

            if (number1 >= number2)
            {
                firstPerson = 1;
                secondPerson = 2;
                Console.WriteLine("\n\nBirinci oyuncu oyuna başlayacaktır.\n \n");
            }
            else
            {
                firstPerson = 2;
                secondPerson = 1;
                Console.WriteLine("\n\nIkinci oyuncu oyuna başlayacaktır. \n");
            }

            number1 = 0;
            number2 = 0;

            while (true)
            {
                Console.WriteLine(firstPerson + ". oyuncu zar atmak icin tusa basiniz. \n");
                Console.ReadKey();
                dice = rnd.Next(1, 7);
                number1 = number1 + dice;
                Console.WriteLine(firstPerson + ". oyuncunun atmis oldugu zar : " + dice + "  \n");
                number1 = calculateSnakesAndStairs(number1);
                Console.WriteLine(firstPerson + ". oyuncunun konumu : " + number1 + "  \n");

                if(number1 >= 100)
                {
                    Console.WriteLine(firstPerson + ". oyuncu oyunu kazanmistir. \n");
                    break;
                }


                Console.WriteLine(secondPerson + ". oyuncu zar atmak icin tusa basiniz. \n");
                Console.ReadKey();
                dice = rnd.Next(1, 7);
                number2 = number2 + dice;
                Console.WriteLine(secondPerson + ". oyuncunun atmis oldugu zar : " + dice + "  \n");
                number1 = calculateSnakesAndStairs(number1);
                Console.WriteLine(secondPerson + ". oyuncunun konumu : " + number2 + "  \n");

                if (number2 >= 100)
                {
                    Console.WriteLine(secondPerson + ". oyuncu oyunu kazanmistir. \n");
                    break;
                }
            }
            Console.ReadKey();
        }

        public static int calculateSnakesAndStairs(int number)
        {
            if(number == 18) {
                Console.WriteLine("Eyvah! Yılana denk geldin. \n");
                return 6;
            }
            if (number == 48)
            {
                Console.WriteLine("Eyvah! Yılana denk geldin. \n");
                return 12;
            }
            if (number == 72)
            {
                Console.WriteLine("Eyvah! Yılana denk geldin. \n");
                return 69;
            }
            if (number == 94)
            {
                Console.WriteLine("Eyvah! Yılana denk geldin. \n");
                return 34;
            }
            if (number == 96)
            {
                Console.WriteLine("Eyvah! Yılana denk geldin. \n");
                return 85;
            }
            if (number == 98)
            {
                Console.WriteLine("Eyvah! Yılana denk geldin. \n");
                return 78;
            }
            if (number == 61)
            {
                Console.WriteLine("Eyvah! Yılana denk geldin. \n");
                return 41;
            }
            if (number == 7) {
                Console.WriteLine("Sansli gunundesin. Merdivene denk geldin. \n");
                return 27;
            }
            if (number == 20) {
                Console.WriteLine("Sansli gunundesin. Merdivene denk geldin. \n");
                return 43;
            }
            if (number == 36)
            {
                Console.WriteLine("Sansli gunundesin. Merdivene denk geldin. \n");
                return 64;
            }
            if (number == 65)
            {
                Console.WriteLine("Sansli gunundesin. Merdivene denk geldin. \n");
                return 76;
            }
            if (number == 88)
            {
                Console.WriteLine("Sansli gunundesin. Merdivene denk geldin. \n");
                return 92;
            }
            if (number == 80)
            {
                Console.WriteLine("Sansli gunundesin. Merdivene denk geldin. \n");
                return 81;
            }
            return number;
        }

        
    }
}
