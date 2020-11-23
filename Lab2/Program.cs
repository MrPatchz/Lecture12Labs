/// Lab No.12 Project No.2
/// File Name:     Lab2.cs
/// @author:       Jacques Zwielich
/// Date:          Nov. 23, 2020
///
/// Problem Statement: Create a test programs that uses optional parameters, named parameter and variable number of parameters
///    
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Create a method that takes vaiable parameters. Prints out the order
/// 2. Create a struct that has optional paramters for if there is cheese and the name
/// 3. Create a main that creates two sets of tacos one using the default parameter and one using named parameters
/// 4. use the order method to print out both out orders using variable parameter!
using System;

namespace Lab2
{
    class Program
    {
        public static void order(params tacos[] list)
        {
            Console.WriteLine("Your order is:");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i].totalTaco + " " + list[i].name + (list[i].isGuac? " tacos with Guac": " tacos without guac") + (list[i].isCheese ? " and cheese" : " and no cheese"));
            }
            Console.WriteLine();
        }
        public struct tacos
        {
            public bool isGuac;
            public int totalTaco;
            public bool isCheese;
            public string name;
            public tacos (bool isGuac, int totalTaco, bool isCheese = true, string name = "Carnitas")
            {
                this.isGuac = isGuac;
                this.totalTaco = totalTaco;
                this.isCheese = isCheese;
                this.name = name;
            }
        }
 
        static void Main(string[] args)
        {
            tacos first = new tacos(totalTaco: 5, isGuac: true, name: "Carne Asada", isCheese: false);
            tacos second = new tacos(true, 3);
            order(first, second);
        }
    }
}
