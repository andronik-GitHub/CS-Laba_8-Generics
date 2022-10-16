using System;

class Ex0
{
    static void Main()
    {
        Box<int> box1 = new(123123);
        Console.WriteLine(box1);

        Box<string> box2 = new("life in a box");
        Console.WriteLine(box2);


        Console.ReadKey();
    }
}