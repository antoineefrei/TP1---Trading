using System;

namespace TP1___Trading
{
    public class Exercice4
    {
         public int AskDimensionOfWidth()
        {
            bool controle = false;
            int result=0 ;
            
            while (controle != true)
            {
                
                Console.WriteLine("Please enter the width of the rectangle :");
                controle = int.TryParse(Console.ReadLine(), out result);

               
            }

            return result;
        }
        
        public int AskDimensionOfHeight()
        {
            bool controle = false ;
            int result=0 ;
            
            while (controle != true)
            {
                controle = false;
                Console.WriteLine("Please enter the height of the rectangle :");
                controle = int.TryParse(Console.ReadLine(), out result);

            }

            return result;
        }

        
        
        private static void TracerLeRectangleHaut (int width, int height)
        {
            Console.Write("0");
            for (int i = 0; i < height - 2; i++)
            {
                Console.Write("-");
            }
            Console.Write("0" + '\n');
        }

        private static void TracerCorpsRectangle(int width, int height)
        {
            
            
            bool premier = false;
            for (int i = 0; i < width - 2; i++)
            {
                int x = i % 3;
                Console.Write("|");
                for (int j = 0; j < height -2; j++)
                {
                    int y = j % 3;
                    if (x == y)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                    
                }
                Console.Write("|" + '\n');
                
            }
        }
        
        private static void TracerLeRectangleBas (int width, int height)
        {
            Console.Write("0");
            for (int i = 0; i < height - 2; i++)
            {
                Console.Write("-");
            }
            Console.Write("0" + '\n');
        }

        public void TracerRectangleComplet(int width, int height)
        {
            TracerLeRectangleHaut(width, height);
            TracerCorpsRectangle(width, height);
            TracerLeRectangleBas(width, height);
        }
    }
}