using System;

class Ex3
{
    static void Main()
    {
        int Num = Convert.ToInt32(Console.ReadLine());

        Box<string?>[] boxs = new Box<string?>[Num];

        for (int i = 0; i < Num; i++)
            boxs[i] = new(Console.ReadLine());

        string?[] index = Console.ReadLine().Split(' ');


        Spawing<Box<string?>>(boxs, index);

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