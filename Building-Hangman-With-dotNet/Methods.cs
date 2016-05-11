private static void DrawHangman(string displayToPlayer, List<char> incorrectGuesses, List<char> correctGuesses)
{
    Console.Clear();
    Console.Write("Good Guesses: ");
    foreach (var c in correctGuesses)
    {
        Console.Write(c + " ");
    }
    Console.WriteLine();

    Console.Write("Bad Guesses: ");
    foreach (var c in incorrectGuesses)
    {
        Console.Write(c + " ");
    }
    Console.WriteLine();


    Console.WriteLine("Your word to guess: " + displayToPlayer);

    var wrong = incorrectGuesses.Count;

    Console.WriteLine(@"______   ");
    Console.WriteLine(@"|     |  ");
    if (wrong > 0) Console.WriteLine(@"|     O  ");
    if (wrong > 1) Console.WriteLine(@"|    /|\ ");
    if (wrong > 2) Console.WriteLine(@"|     |  ");
    if (wrong > 3) Console.WriteLine(@"|    / \ ");

    for (var i = 0; i < 5 - wrong; i++)
    {
        Console.WriteLine(@"|        ");
    }

    Console.WriteLine(@"|        ");
    if (wrong > 4) Console.WriteLine(@"|--      --");
    else Console.WriteLine(@"|---------");
    if (wrong > 4) Console.WriteLine(@"  |      |");
}


private static string GetRandomWord()
{
    var words = new[]
    {
        "acre", "recall", "policeman", "memory", "deeply", "firelace", "university"
    };

    //var words = File.ReadAllLines(@"C:\projects\HangmanCrash\HangmanCrash\hangmanwords.txt");

    var r = new Random();
    var position = r.Next(words.Length);

    return words[position];

}
