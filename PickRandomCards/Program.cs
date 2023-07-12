namespace PickRandomCards;

internal static class Program
{
    public static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            if (args[0] == "-d")
            {
                if (args.Length == 1)
                {
                    foreach (var card in CardPicker.PickSomeCards(10)) Console.WriteLine(card);
                    Environment.Exit(0);
                }

                if (int.TryParse(args[1], out var cardNumArg))
                {
                    foreach (var card in CardPicker.PickSomeCards(cardNumArg)) Console.WriteLine(card);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("usage should be -d [int]");
                    Environment.Exit(1);
                }
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