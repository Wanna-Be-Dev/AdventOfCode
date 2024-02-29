using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Day2
    {
        public static string file = @"C:\Users\grman\Desktop\deleteafter\AdeventOfCode\AdventOfCode\AdventOfCode\Input\2023\Day2.txt";
        //public static string file = "ConsoleApp1/Data/DataInput";
        static void First()
        {
            double amount = 0;

            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                foreach (string ln in lines)
                {
                    int Id;
                    string[] games = ln.Split(':');
                    Id = int.Parse(games[0].Split(' ')[1]);

                    string[] rounds = games[1].Split(';');

                    int score = 0;
                    int len = rounds.Length;

                    int[] RGBHigh = new int[3];
                    foreach (var sub in rounds)
                    {
                        int[] RGB = new int[3];
                        string[] turn = sub.Split(", ");
                        for(int i = 0; i < turn.Length; i++)
                        {
                            switch (turn[i].Substring(turn[i].LastIndexOf(' ') + 1))
                            {
                                case "red":
                                    RGB[0] = int.Parse(turn[i].Substring(0, turn[i].LastIndexOf(' ')));
                                    break;
                                case "green":
                                    RGB[1] = int.Parse(turn[i].Substring(0, turn[i].LastIndexOf(' ')));  
                                    break;
                                case "blue":
                                    RGB[2] = int.Parse(turn[i].Substring(0, turn[i].LastIndexOf(' ')));
                                    break;
                            }       
                        }
                        if (RGB[0] <= 12 && RGB[1] <= 13 && RGB[2] <= 14)
                            score++;
                    }
                    if (score == len)
                        amount += Id;
                }
                Console.WriteLine(amount);
            }
        }
        static void Second()
        {
            double power = 0;
            // To read a text file line by line 
            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                foreach (string ln in lines)
                {
                    int Id;
                    string[] games = ln.Split(':');
                    Id = int.Parse(games[0].Split(' ')[1]);

                    string[] rounds = games[1].Split(';');

                    int len = rounds.Length;

                    int[] RGBHigh = new int[3];
                    foreach (var sub in rounds)
                    {
                        int[] RGB = new int[3];
                        string[] turn = sub.Split(", ");
                        for (int i = 0; i < turn.Length; i++)
                        {
                            switch (turn[i].Substring(turn[i].LastIndexOf(' ') + 1))
                            {
                                case "red":
                                    RGB[0] = int.Parse(turn[i].Substring(0, turn[i].LastIndexOf(' ')));
                                    RGBHigh[0] = RGBHigh[0] < RGB[0] ? RGB[0] : RGBHigh[0];
                                    break;
                                case "green":
                                    RGB[1] = int.Parse(turn[i].Substring(0, turn[i].LastIndexOf(' ')));
                                    RGBHigh[1] = RGBHigh[1] < RGB[1] ? RGB[1] : RGBHigh[1];
                                    break;
                                case "blue":
                                    RGB[2] = int.Parse(turn[i].Substring(0, turn[i].LastIndexOf(' ')));
                                    RGBHigh[2] = RGBHigh[2] < RGB[2] ? RGB[2] : RGBHigh[2];
                                    break;
                            }
                        }
                    }
                    power += RGBHigh[0] * RGBHigh[1] * RGBHigh[2];
                }
                Console.WriteLine(power);
            }

        }
    }
  
}
