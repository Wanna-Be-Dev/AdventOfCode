namespace AdventOfCode
{
    class Day1
    {
        public static Dictionary<string, int> dict = new Dictionary<string, int>
        {
            { "one", 1},
            { "two" , 2},
            { "three" , 3},
            { "four" , 4},
            { "five" , 5},
            { "six" , 6},
            { "seven" , 7},
            { "eight" , 8},
            { "nine" , 9},
        };
        public static string file = @"C:\Users\grman\Desktop\deleteafter\Day1\InputData.txt";
        //public static string file = "ConsoleApp1/Data/DataInput";
        static void First()
        {
            double amount = 0;
            // To read a text file line by line 
            if (File.Exists(file))
            {
                // Store each line in array of strings 
                string[] lines = File.ReadAllLines(file);
                foreach (string ln in lines)
                {
                    List<char> numLine = ln.ToList();

                    List<int> numbers = new List<int>();

                    string key = "";

                    for (int i = 0; i < numLine.Count; i++)
                    {
                        if (!(System.Char.IsDigit(numLine[i])))
                        {
                            key += numLine[i];
                            for (int j = 1; j < 5; j++)
                            {
                                try
                                {
                                    if (key.Length < 6)
                                    {
                                        key += numLine[i + j].ToString();
                                        //Console.WriteLine(key);
                                    }
                                    else
                                        break;
                                    if (dict.ContainsKey(key))
                                    {
                                        numbers.Add(dict[key]);
                                        //Console.WriteLine(dict[key]);
                                        key = "";
                                    }
                                }
                                catch (ArgumentOutOfRangeException e)
                                {

                                    break;
                                }

                            }
                            key = "";
                        }
                        else
                        {
                            numbers.Add(numLine[i] - '0');


                        }
                        Console.WriteLine(numLine.Count);
                    }
                    //amount += numbers[0] * 10 + numbers.Last();


                    if (numbers.Count == 1)
                        amount += numbers[0] * 10 + numbers[0];
                    else
                        amount += numbers[0] * 10 + numbers[numbers.Count - 1];
                }
                //Console.WriteLine(amount);
            }

        }
    }
}

/*
one
two
three
four 
five 
six
seven
eight
nine */