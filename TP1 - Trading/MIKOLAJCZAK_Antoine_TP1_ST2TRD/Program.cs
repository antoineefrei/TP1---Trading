using System;

namespace TP1___Trading
{
    internal class Program
    {




        public static void Main(string[] args)
        {

        
            
            
            var exo1 = new Exercice1();
            var exo2 = new Exercice2();
            var exo3 = new Exercice3();
            var exo4 = new Exercice4();
            var exo5 = new Exercice5();
            
            
            
            Console.WriteLine('\n' + "Exercice 1" + '\n');
            
            exo1.DisplayTable();
            exo1.DisplayOdsElem();
            exo1.DisplayChoice();
            
            Console.WriteLine('\n' + "Exercice 2"+ '\n');
            
            exo2.PrimeNumber();
            exo2.Fibo();
            exo2.factorielle();
            
            Console.WriteLine('\n' + "Exercice 3"+ '\n');
            
            exo3.GestionException();
            
            Console.WriteLine('\n' + "Exercice 4"+ '\n');
            
            exo4.TracerRectangleComplet(exo4.AskDimensionOfWidth(),exo4.AskDimensionOfHeight());
            
            Console.WriteLine('\n' + "Exercice 5"+ '\n');
            
            exo5.ChristmasPinewood();
            
        }
    }
}