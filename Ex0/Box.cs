using System;

class Box<T>
{
    public T value;

    public Box(T value) { this.value = value; }

    public override string ToString()
    {
        Type type = typeof(T);
        return type.FullName + ": " + value;
    }
}