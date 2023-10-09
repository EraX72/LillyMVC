using LillyMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace LillyMVC.View
{
    public class MainView
    {
        public void DisplayResult(double moneySaved, double washingMachinePrice)
        {
            if (moneySaved >= washingMachinePrice)
            {
                Console.WriteLine($"Yes!{moneySaved - washingMachinePrice:F2}");
            }
            else
            {
                Console.WriteLine($"No!{washingMachinePrice - moneySaved:F2}");
            }
        }
        public Money GetUserlnprint() 
        {
            Console.Write("Enter Lili's age:");
                int age = int.Parse( Console.ReadLine() );
            Console.Write("Enter washing mashine price:");
            double washingMashinePrice = double.Parse( Console.ReadLine() );
            Console.Write("Enter toy price:"):
                int toyPrice = int.Parse( Console.ReadLine() );
            return new Money
        }
        Age = age, WashingMachinePrice = washingmashineprice, ToyPrice = toyprice
    }
}
