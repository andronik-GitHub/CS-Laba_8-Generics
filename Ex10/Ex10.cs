using System;

class Ex10
{
    static void Main()
    {
        string[] temp = Console.ReadLine().Split(' ');
        (string Name, string Address) = (temp[0] + " " + temp[1], temp[2]);
        Tuple<string, string> tuple1 = new(Name, Address);

        temp = Console.ReadLine().Split(' ');
        (Name, int LitersOfBeer) = (temp[0], Convert.ToInt32(temp[1]));
        Tuple<string, int> tuple2 = new(Name, LitersOfBeer);

        temp = Console.ReadLine().Split(' ');
        (int IntValue, float FloatValue) = (Convert.ToInt32(temp[0]), Convert.ToSingle(temp[1]));
        Tuple<int, float> tuple3 = new(IntValue, FloatValue);


        Console.WriteLine("\n" + tuple1);
        Console.WriteLine(tuple2);
        Console.WriteLine(tuple3);



        Console.ReadKey();
    }
}