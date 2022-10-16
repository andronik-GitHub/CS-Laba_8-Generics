using System;

class Ex1
{
    static void Main()
    {
        int Num = Convert.ToInt32(Console.ReadLine());

        Box<string?>[] boxs = new Box<string?>[Num];

        for (int i = 0; i < Num; i++)
            boxs[i] =  new(Console.ReadLine());

        for (int i = 0; i < Num; i++)
            Console.WriteLine(boxs[i]);


        Console.ReadKey();
    }
}