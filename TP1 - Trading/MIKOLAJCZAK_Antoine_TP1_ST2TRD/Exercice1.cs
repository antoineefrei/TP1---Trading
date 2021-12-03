using System;

namespace TP1___Trading
{
    public class Exercice1
    {
        private static int AskParameter()
        {
            bool controle = false;
            int result=0 ;
            
            while (controle != true)
            {
                
                Console.WriteLine("Please choose a number to display his multiplication table :");
                controle = int.TryParse(Console.ReadLine(), out result);

               
            }

            return result;
        }

        public void DisplayTable()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine('\n' + "table de " + i  + '\n');

                for (int j = 1; j < 11; j++)
                {
                    Console.WriteLine(i + "*" + j + " =" + i*j);
                }
            }
        }

        public void DisplayOdsElem()
        {
            int res = 0;
            
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine('\n' + "ods element of table of  " + i  + '\n');

                for (int j = 1; j < 11; j++)
                {
                    res = i * j;

                    if (res % 2 == 1)
                    {
                        Console.WriteLine(i + "*" + j + " =" + i*j);
                    }
                    
                }
            }
        }

        public void DisplayChoice()
        {
            int choix = 0;
            
            choix = AskParameter();

            Console.WriteLine('\n' + "table de " + choix  + '\n');
            for (int k = 1; k < 11; k++)
            {
                Console.WriteLine(choix + "*" + k + " =" + choix*k);
            }
            
        }
    }
}