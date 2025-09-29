internal class CardPicker
{
    static Random random = new Random();
    public static string[] PickSomeCards(int numberOfCard)
    {
        string[] cards = new string[numberOfCard];
        for (int i = 0; i < numberOfCard; i++)
        {
            cards[i] = RandomValue() + " " + RandomSuit();

        }
        return cards;
    }

    private static string RandomSuit()
    {
        int value = random.Next(1, 5);
        if (value == 1) return "pik";
        if (value == 2) return "cherve";
        if (value == 3) return "tref";
        return "byben";
    }

    private static string RandomValue()
    {
        int value = random.Next(1, 14);
        if (value == 1) return "Tyz";
        if (value == 11) return "Balet";
        if (value == 12) return "Dama";
        if (value == 13) return "Korol";
        return value.ToString();
    }
}