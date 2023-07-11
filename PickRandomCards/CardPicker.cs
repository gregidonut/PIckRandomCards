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
        throw new NotImplementedException();
    }

    private static string RandomeValue()
    {
        throw new NotImplementedException();
    }
}