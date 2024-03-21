namespace ConsoleApp3;

public class OverFillException : Exception
{
    public OverFillException(string? message) : base(message)
    {
        Console.WriteLine(message);
    }
    
}