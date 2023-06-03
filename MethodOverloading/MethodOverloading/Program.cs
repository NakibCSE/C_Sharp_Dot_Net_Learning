
public class Program
{
    public static void Main(string[] args)
    {
        

    }

    public static void Add(int FN, int LN) { Console.WriteLine($"The some of the given number is = {FN + LN}"); }
    public static void Add(string FN, int LN) { Console.WriteLine($"{FN} {LN}"); }
    public static void Add(int FN,  double LN) { Console.WriteLine($"{FN + LN}"); }
    public static int Add(int Number1, int Number2, int number3) { return Number1 + Number2 + number3; }
    public static int Add(int number1, int number2, out int number3) { return number3 = number1 + number2;}

}