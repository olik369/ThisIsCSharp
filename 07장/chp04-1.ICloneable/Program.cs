using static System.Console;
using System;

class MyClass : ICloneable
{
    public int MyField1;
    public int MyField2;

    public object Clone()
    {
        MyClass clone = new MyClass();
        clone.MyField1 = this.MyField1;
        clone.MyField2 = this.MyField2;

        return clone;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass source = new MyClass();
        source.MyField1 = 10;
        source.MyField2 = 20;

        MyClass target = source.Clone() as MyClass;
        target.MyField2 = 30;
        WriteLine($"{source.MyField1} {source.MyField2}");
        WriteLine($"{target.MyField1} {target.MyField2}");
    }
}
