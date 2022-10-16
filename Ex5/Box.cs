using System;

class Box<T> where T : IComparable<T>
{
    public T value;

    public Box(T value) { this.value = value; }

    public override string ToString()
    {
        Type type = typeof(T);
        return type.FullName + ": " + value;
    }

    public bool CompareMethod(T other)
    {
        if (value.CompareTo(other) > 0) return true;
        return false;
    }
}