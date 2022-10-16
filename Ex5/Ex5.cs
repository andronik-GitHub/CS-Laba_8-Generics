using System;

class Ex5
{
    static void Main()
    {
        int Num = Convert.ToInt32(Console.ReadLine());
        string? temp;

        Box<string>[] boxs = new Box<string>[Num];

        for (int i = 0; i < Num; i++)
        {
            temp = Console.ReadLine();

            if (temp != null)
                boxs[i] = new(temp);
        }

        temp = Console.ReadLine();


        if (temp != null)
            Console.WriteLine(Cheking<Box<string>>(boxs, temp));


        Console.ReadKey();
    }

    static int Cheking<T>(T[] arr, string value)
    {
        int num = 0;


        foreach (T temp in arr)
            if (temp is Box<string> tempArr)
                if (tempArr.CompareMethod(value)) num++;

        return num;
    }
}