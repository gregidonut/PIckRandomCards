namespace PickRandomCards;

internal static class Program
{
    public static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            Console.WriteLine("unexpected arg/s: ");
            foreach (var arg in args) Console.WriteLine(arg);

            Environment.Exit(1);
        }

        Console.WriteLine("Hello, World!");
    }
}