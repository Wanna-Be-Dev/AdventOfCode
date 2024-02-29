using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Day3
    {
        //2 red cubes, 13 green cubes, and 14 blue cubes
        public static string file = @"C:\Users\grman\Desktop\deleteafter\AdeventOfCode\AdventOfCode\AdventOfCode\Input\2023\Day3.txt";
        //public static string file = "ConsoleApp1/Data/DataInput";
        static void First()
        {
            Console.WriteLine(file);
            // To read a text file line by line 
            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                for(int i = 1; i < lines.Length; i++)
                {
                    char[] above = lines[i-1].ToCharArray();
                    char[] characters = lines[i].ToCharArray();
                    char[] below = lines[i + 1].ToCharArray();

                    for (int j = 0; j < characters.Length; j++)
                    {
                        List<int> numbers = new List<int>();
                        bool isTouching = false;
                        if (char.IsDigit(characters[j]))
                        {
                            numbers.Add(int.Parse(characters[j].ToString()));
                        }
                        if(numbers.Count == 3)
                        {
                            for(int x = 0; x < 3 ;x++)
                            {

                            }
                        }
                    }

                }
               
            }

        }
        static void Main(string[] args)
        {
            First();
        }
    }
}
