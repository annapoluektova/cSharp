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
    class Poluektova_Chair
    {
        string typeChair;
        int quantityChair;
        int costChair;
        string chairType;
 
        //default constructor
        public Poluektova_Chair()
        {
 
        }

        //constructor with two arguments
        public Poluektova_Chair(string typeC, int quantityC)
        {
            typeChair = typeC;
            quantityChair = quantityC;
            if (typeC == "p" || typeC == "P")
            {
                chairType = "p";
                costChair = 200;
            }
            else if (typeC == "m" || typeC == "M")
            {
                chairType = "m";
                costChair = 100;
            }
        }
        
        public int totalSalesPrice
        {
            get
            { 
                return (quantityChair * costChair);
            }
        }

        public void displayTypeQuantityTotalSalesPrice()
        {
            Console.WriteLine("Type of Chair: " + chairType);
            Console.WriteLine("Quantity: " + quantityChair);
            Console.WriteLine("Total Sales Price: " + totalSalesPrice);
        }
    }
}
