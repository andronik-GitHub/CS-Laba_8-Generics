using System;
using System.Globalization;

class Ex7
{
    static void Main()
    {
        Input_Output();


        Console.ReadKey();
    }

    static void Input_Output()
    {
        Box<string> box = new();

        string?[] temp = new string[] { "" };


        while (temp[0]?.ToLower() != "end")
        {
            temp = Console.ReadLine().Split(' ');

            if (temp[0]?.ToLower() == "add")
                box.Add(temp[1]);

            if (temp[0]?.ToLower() == "remove")
                box.Remove(Convert.ToInt32(temp[1]));

            if (temp[0]?.ToLower() == "contains")
                if (box.Contains(temp[1])) box.newArr.Add("True");
                else box.newArr.Add("False");

            if (temp[0]?.ToLower() == "swap")
                box.Swap(Convert.ToInt32(temp[1]), Convert.ToInt32(temp[2]));

            if (temp[0]?.ToLower() == "greater")
                box.newArr.Add(Convert.ToString(box.Greater(temp[1])));

            if (temp[0]?.ToLower() == "max")
                box.Max();

            if (temp[0]?.ToLower() == "min")
                box.Min();

            if (temp[0]?.ToLower() == "print")
            {
                Console.WriteLine();
                box.Print(box);
            }
        }
    }
}