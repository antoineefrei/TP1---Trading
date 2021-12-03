using System;


namespace TP1___Trading
{
    public class Exercice3
    {
        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) -4);
        }

        public void GestionException()
        {
            var eq = 0;
           
            for (int i = -3; i <= 3; i++) {
                try
                {
                    eq = 10 / PowerFunction(i);
                    Console.WriteLine("f(" + i + ") = " + eq);
                }
                catch (DivideByZeroException)
                { 
                    Console.WriteLine("Division by zero.");
                }

                    
            }
        }
    }
}