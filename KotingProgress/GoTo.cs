using System;

namespace KotingProgress
{
    public class GoTo
    {
        public static void SwitchGoto()
        {
            for (int i = 1; i < 5; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine("В ветви case 1");
                        goto case 3;
                    case 2:
                        Console.WriteLine("В ветви case 2");
                        goto case 1;
                    case 3:
                        Console.WriteLine("В ветви case 3");
                        goto default;
                    default:
                        Console.WriteLine("В ветви default");
                        break;
                }

                Console.WriteLine();
            }
// goto case 1; // Ошибка! Безусловный переход к оператору switch недопустим.
        }
        
        public static void Use_GoTo() {
            int i=0, j=0, k=0;
            for(i=0; i < 10; i++) {
                for(j=0; j < 10; j++ )
                {
                    if (j == 2) goto stop; 
                    for(k=0; k < 10; k++) {
                        Console.WriteLine("i, j, k: " + i + " " + j + " " + k);
                        //if(k == 3) goto stop;
                    }
                }
            }
            stop:
            Console.WriteLine("Остановлено! i, j, k: " + i +
                              ", " + j + " " + k);
        }
    }
}