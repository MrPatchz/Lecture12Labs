using System;
using System.Collections.Generic;
using System.IO;

namespace Lab_1
{
    class Program
    {

    struct name
        {
            public int rank;
            public int uses;
            public name(int newRank, int newUses)
            {
                rank = newRank;
                uses = newUses;
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, name> boyNames = new Dictionary<string, name>();
            Dictionary<string, name> girlNames = new Dictionary<string, name>();

            System.IO.StreamReader boyFile = new System.IO.StreamReader(@"C:\Users\Patchz\source\repos\Lecture12Labs\Lab 1\boynames.txt");
            System.IO.StreamReader girlFile = new System.IO.StreamReader(@"C:\Users\Patchz\source\repos\Lecture12Labs\Lab 1\girlnames.txt");

            string line;
            int count = 0;
            //Stores all boy names and number of uses
            while ((line = boyFile.ReadLine()) != null)
            {
                string key = "";
                string element = "";
                count++;
                int word = 0;
                foreach (char letter in line)
                {
                    
                    if (letter == ' ')
                    {
                        word++;
                    }
                    else if (word == 0)
                    {
                        key += letter;
                    }
                    else
                    {
                        element += letter;
                    }
                }
                name temp = new name(count, Int32.Parse(element));
                boyNames.Add(key, temp);
            }
            count = 0;
            //Store all girl names and numbers of uses
            while ((line = girlFile.ReadLine()) != null)
            {
                string key = "";
                string element = "";
                count++;
                int word = 0;
                foreach (char letter in line)
                {
                    
                    if (letter == ' ')
                    {
                        word++;
                    }
                    else if (word == 0)
                    {
                        key += letter;
                    }
                    else
                    {
                        element += letter;
                    }
                }
                name temp = new name(count, Int32.Parse(element));
                girlNames.Add(key, temp);
            }
            //Prompt the user to enter a name
            Console.Out.Write("Please enter a name: ");
            string choice = "";
            choice = Console.In.ReadLine();
            //Print out rank of name if it exists
            name girlReturn;
            name boyReturn;
            if (girlNames.ContainsKey(choice))
            {
                girlReturn = girlNames[choice];
            }
            else
            {
                girlReturn = new name(0, 0);
            }
            if (boyNames.ContainsKey(choice))
            {
                boyReturn = boyNames[choice];
            }
            else
            {
                boyReturn = new name(0, 0);
            }
            
            Console.Out.WriteLine("The boy name " + choice + " is ranked " + boyReturn.rank + " with " + boyReturn.uses + " uses." );
            Console.Out.WriteLine("The girl name " + choice + " is ranked " + girlReturn.rank + " with " + girlReturn.uses + " uses.");
        }

        
    }
}
