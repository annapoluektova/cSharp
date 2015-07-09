/*
 * The course code: COMP 1202
 * Student ID: 100786356
 * Author: Anna Poluektova
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1202_W13_LT2A_PoluektovaAnna
{
    class Poluektova_ChairApp
    {
        static void Main(string[] args)
        {
            DisplayWelcome();
            while (true)
            {
                int quantitychair;
                string typechair;
                AskForQuantityOfChair(out quantitychair);
                if (quantitychair < 0)
                {
                    quantitychair = 0;
                }
                AskForTypeOfChair(out typechair);
                if ((quantitychair >= 0) && (typechair == "P" || (typechair == "M") || (typechair == "p") || (typechair == "m")))
                {
                    Poluektova_Chair ChairObject = new Poluektova_Chair(typechair, quantitychair);
                    ChairObject.displayTypeQuantityTotalSalesPrice();

                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Error");
                    Console.ReadKey();
                }
            }
        }
        

        //methods
        public static void DisplayWelcome()
        {
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*                    Welcome to Sales Chairs                    *");
            Console.WriteLine("*              Your Saleswoman is Anna Poluektova               *");
            Console.WriteLine("*****************************************************************");
        }
        public static void AskForTypeOfChair(out string typechair)
        {
            Console.WriteLine("The choice of the type of Chair (p/m)");
            typechair = Console.ReadLine();

        }
        public static void AskForQuantityOfChair(out int quantitychair)
        {
            Console.WriteLine("Enter the quantity of Chairs");
            quantitychair = Convert.ToInt32(Console.ReadLine());

        }

    }
}
