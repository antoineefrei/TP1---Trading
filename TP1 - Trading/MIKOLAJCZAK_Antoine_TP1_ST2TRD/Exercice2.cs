using System;

namespace TP1___Trading
{
    public class Exercice2
    {
        private static int AskUserForParameter()
        {
            bool controle = false;
            int result=0 ;
            
            while (controle != true)
            {
                
                Console.WriteLine("Please choose a number :");
                controle = int.TryParse(Console.ReadLine(), out result);

               
            }
            return result;
        }
        public void PrimeNumber()
        {
            int start;
            int end = 1000;
            bool prime = true;

            for (start = 2; start <= end; start++)
            {
                for (int j = 2; j < start; j++)
                {
                    if (start % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (!prime)
                {
                    prime = true;
                }
                else
                {
                    Console.WriteLine(start);
                }
            }
        }
        
        
        public void Fibo()
        {
            int choix;
            int F0 = 1;
            int F1 = 1;
            int F2 = 0;
            
            
            choix = AskUserForParameter();
            
            if (choix == 0)
            {
                Console.WriteLine("F(0) = " +F0);
            }

            if (choix == 1)
            {
                Console.WriteLine("F(1) = " +F1);
            }
            else
            {
                for (int i = 2; i <= choix; i++)
                {
                    F2 = F1 + F0;
                    F0 = F1;
                    F1 = F2;

                    
                }
                Console.WriteLine("F("+choix+") is "+ F2);
            }
        }

        public void factorielle()
        {
            int choix = AskUserForParameter();
            int res = 1;
            

            if (choix == 0)
            {
                Console.WriteLine("factorielle of " + choix + "is " +1);
            }
            else
            {
                for (int i = 1; i <= choix; i++)
                {
                    res = res * i;
                }
                Console.WriteLine("factorielle of " + choix + " is " +res);
            }
        }
    }
}