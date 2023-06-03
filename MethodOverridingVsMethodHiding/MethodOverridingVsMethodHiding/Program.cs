public class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("I am a base class Print Method");
    }
}

public class DeriverdClass : BaseClass
{
    public new void Print() { Console.WriteLine("I am a Derived Class Print Method"); }
}

public class Progam
{
    public static void Main(string[] args)
    {
        BaseClass b = new DeriverdClass();
        b.Print();
    }
}