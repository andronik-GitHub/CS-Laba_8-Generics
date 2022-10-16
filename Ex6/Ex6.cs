using System;

class Ex6
{
    static void Main()
    {
        int Num = Convert.ToInt32(Console.ReadLine());
        string? temp;

        Box<float>[] boxs = new Box<float>[Num];

        for (int i = 0; i < Num; i++)
        {
            temp = Console.ReadLine();

            if (temp != null)
                boxs[i] = new(Convert.ToSingle(temp));
        }

        temp = Console.ReadLine();

        if (temp != null)
            Console.WriteLine(Cheking<Box<float>>(boxs, Convert.ToSingle(temp)));


        Console.ReadKey();
    }

    static int Cheking<T>(T[] arr, float value)
    {
        int num = 0;

        foreach (T temp in arr)
            if (temp is Box<float> tempArr)
                if (tempArr.CompareMethod(value)) num++;

        return num;
    }
}