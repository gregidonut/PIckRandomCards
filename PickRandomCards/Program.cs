namespace PickRandomCards;

internal static class Program
{
    public static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            if (args[0] == "-d")
            {
                foreach (var card in CardPicker.PickSomeCards(10)) Console.WriteLine(card);
                Environment.Exit(0);
            }

            Console.WriteLine("unexpected arg/s: ");
            foreach (var arg in args) Console.WriteLine(arg);

            Environment.Exit(1);
        }

        Console.Write("Enter the number of cards to pick: ");
        var line = Console.ReadLine();
        if (int.TryParse(line, out var numberOfCards))
        {
            foreach (var card in CardPicker.PickSomeCards(numberOfCards)) Console.WriteLine(card);
            Environment.Exit(0);
        }

        Console.WriteLine("Unable to convert input into number..");
        Environment.Exit(1);
    }
}