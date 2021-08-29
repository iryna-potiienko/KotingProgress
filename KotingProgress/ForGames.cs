using System;

namespace KotingProgress
{
    public static class ForGames
    {
        public static void PlayFor()
        {
            int i, j;
            int smallest, largest;
            int num;
            num = 100;
            smallest = largest = 1;
            for (i = 2, j = num / 2; (i <= num / 2) & (j >= 2); i++, j--)
            {
                if ((smallest == 1) & ((num % i) == 0))
                    smallest = i;
                if ((largest == 1) & ((num % j) == 0))
                    largest = j;
            }

            Console.WriteLine("Наибольший множитель: " + largest);
            Console.WriteLine("Наименьший множитель: " + smallest);
        }

        public static void SimpleFor()
        {
            //int i, j;
            for(int i=0, j=10; i < 10; i++, j--)
                Console.WriteLine("i и j: " + i + " " + j);
        }
    }
}