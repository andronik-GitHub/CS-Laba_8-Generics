using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

class Box<T> where T : IComparable<T>
{
    public List<T> Arr;
    public List<T> newArr;

    public Box()
    {
        Arr = new List<T>();
        newArr = new List<T>();
    }

    public override string ToString()
    {
        StringBuilder SB = new StringBuilder();

        foreach (T element in newArr)
            SB.AppendLine($"{element}");

        foreach (T element in Arr)
            SB.AppendLine($"{element}");

        return SB.ToString();
    }

    public void Add(T element) => Arr.Add(element);

    public void Print(Box<T> arr) => Console.Write(arr);

    public T Max()
    {
        T max = Arr[0];

        foreach (T t in Arr)
            if (t.CompareTo(max) > 0) max = t;

        newArr.Add(max);
        return max;
    }

    public T Min()
    {
        T min = Arr[0];

        foreach (T t in Arr)
            if (t.CompareTo(min) < 0) min = t;

        newArr.Add(min);
        return min;
    }

    public void Remove(int index) => Arr.RemoveAt(index);

    public bool Contains(T element)
    {
        if (Arr.Contains(element)) return true;

        return false;
    }

    public void Swap(int index1, int index2)
    {
        T temp = Arr[index1];
        Arr[index1] = Arr[index2];
        Arr[index2] = temp;
    }

    public int Greater(T element)
    {
        int num = 0;

        foreach (T t in Arr)
            if (t.CompareTo(element) > 0) num++;

        return num;
    }
}