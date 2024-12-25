
public class Calculator
{
    public double X { get; set; }
    public double Y { get; set; }

    public Calculator(double x, double y)
    {
        X = x; Y = y;
    }
    public double Add()
    {
        return X + Y;
    }

    public double Sub()
    {
        return Y - X;
    }

    public double Mul()
    {
        return X * Y;
    }

    public string Div()
    {
        if (Y == 0)
        {
            return "Cannot divided by zero";
        }
        return (X/Y).ToString();

    }
}
class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter X :");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Y :");
        double y = Convert.ToDouble(Console.ReadLine());
        Calculator calculator = new Calculator(x, y);

        Console.WriteLine("\nResults :");
        Console.WriteLine("Add : " + calculator.Add());
        Console.WriteLine($"Sub : {calculator.Sub()}");
        Console.WriteLine($"Mul : {calculator.Mul()}");
        Console.WriteLine($"Div : {calculator.Div()}");



    }
}


