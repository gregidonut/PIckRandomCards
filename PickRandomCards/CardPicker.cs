namespace PickRandomCards;

public class CardPicker
{
    public static string[] PickSomeCards(int numberOfCards)
    {
        var pickedCards = new string[numberOfCards];

        for (var i = 0; i < numberOfCards; i++)
            pickedCards[i] = RandomeValue() + " of " + RandomeSuit();

        return pickedCards;
    }

    private static string RandomeSuit()
    {
        var suits = new[]
        {
            "Spades",
            "Diamonds",
            "Hearts",
            "Clover"
        };

        var rnd = new Random();

        return suits[rnd.Next(suits.Length)];
    }

    private static string RandomeValue()
    {
        throw new NotImplementedException();
    }
}