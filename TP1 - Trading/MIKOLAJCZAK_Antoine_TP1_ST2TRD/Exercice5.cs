using System;

namespace TP1___Trading
{
    public class Exercice5 
    {
        private static int SizePinewoodChoice()
        {
            bool controle = false;
            int result=3 ;
            
            while ((controle != true) )
            {
                
                Console.WriteLine("Please choose the size of your pinewood between 3 and 20:");
                controle = int.TryParse(Console.ReadLine(), out result);

                if (result <3 || result >20)
                {
                    controle = false;
                }
            }

            return result;
        }

        private static void PinewoodBody(int size)
        {
            
            string etoile = "";
            
            for (int i = 0; i < size; i++)
            {
                etoile = "";
                
                for (int j = 0; j < 2*i+1; j++)
                {
                    etoile += "*";
                }
                Console.WriteLine("{0}", etoile.PadLeft(size+i));
                etoile = "";
            }
            
            PinewoodTrunk(size);
        }

        public void ChristmasPinewood()
        {
            PinewoodBody(SizePinewoodChoice());
        }
        private static void PinewoodTrunk(int size)
        {
            string trunk = "| |";
            
            Console.WriteLine("{0}", trunk.PadLeft(size+1));
        }
    }
}