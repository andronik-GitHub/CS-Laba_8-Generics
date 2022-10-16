using System;

class Ex10
{
    static void Main()
    {
        string?[] temp = Console.ReadLine().Split(' ');
        Tuple<string, string> tuple1 = new(temp[0] + " " + temp[1], temp[2]);

        temp = Console.ReadLine().Split(' ');
        Tuple<string, int> tuple2 = new(temp[0], Convert.ToInt32(temp[1]));

        temp = Console.ReadLine().Split(' ');
        Tuple<int, float> tuple3 = new(Convert.ToInt32(temp[0]), Convert.ToSingle(temp[1]));


        Console.WriteLine("\n" + tuple1);
        Console.WriteLine(tuple2);
        Console.WriteLine(tuple3);



        Console.ReadKey();
    }
}