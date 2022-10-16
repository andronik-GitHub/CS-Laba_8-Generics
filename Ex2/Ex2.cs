using System;

class Ex2
{
    static void Main()
    {
        int Num = Convert.ToInt32(Console.ReadLine());

        Box<int>[] boxs = new Box<int>[Num];

        for (int i = 0; i < Num; i++)
            boxs[i] = new(Convert.ToInt32(Console.ReadLine()));

        for (int i = 0; i < Num; i++)
            Console.WriteLine(boxs[i]);


        Console.ReadKey();
    }
}