Random random = new Random();

int numberToGuess;
bool gamePlaying = true;
bool gameOver = false;

while (gamePlaying)
{
    GetNumberToGuess();

    Console.WriteLine("I am thinking of a number between 1 - 10");

    while (!gameOver)
    {
        Console.Write("Guess: ");

        int guess = Convert.ToInt32(Console.ReadLine());

        if (guess == numberToGuess)
        {
            Console.WriteLine($"You win! The number was {numberToGuess}");
            gameOver = true;
        }
        else
        {
            Console.WriteLine("Sorry, guess again!");
        }
    }

    Console.Write("Play again? Y/N: ");

    string playAgainAnswer = Console.ReadLine()!;

    if (playAgainAnswer == "y" || playAgainAnswer == "Y")
    {
        gameOver = false;
        continue;
    }
    else
    {
        gamePlaying = false;
    }
}

void GetNumberToGuess()
{
    numberToGuess = random.Next(1, 11);
}