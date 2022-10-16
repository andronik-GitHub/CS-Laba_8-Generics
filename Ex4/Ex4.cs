using System;

class Ex4
{
    static void Main()
    {
        int Num = Convert.ToInt32(Console.ReadLine());

        Box<int>[] boxs = new Box<int>[Num];

        for (int i = 0; i < Num; i++)
            boxs[i] = new(Convert.ToInt32(Console.ReadLine()));

        string?[] index = Console.ReadLine().Split(' ');


        Spawing<Box<int>>(boxs, index);

        for (int i = 0; i < Num; i++)
            Console.WriteLine(boxs[i]);


        Console.ReadKey();
    }

    static void Spawing<T>(T[] arr, string?[] str)
    {
        T temp = arr[Convert.ToInt32(str[0])];
        arr[Convert.ToInt32(str[0])] = arr[Convert.ToInt32(str[1])];
        arr[Convert.ToInt32(str[1])] = temp;
    }
}