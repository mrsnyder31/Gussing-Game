using System;

Console.WriteLine("Can you guess the secret number? ");
Console.Write("Select your difficulty.  ");

Random r = new Random();
int SecretNumber = r.Next(1, 100);


// Console.WriteLine(SecretNumber);

Console.WriteLine(@"
1) Easy - Eight guesses.
2) Medium - Six guesses.
3) Hard - Four guesses.
4) CHEATER - Infinite guesses.
");

string difficulty = Console.ReadLine().ToLower();
int GuessLimit = 0;

if (int.Parse(difficulty) == 1)
{
    GuessLimit = 8;
}
else if (int.Parse(difficulty) == 2)
{
    GuessLimit = 6;
}
else if (int.Parse(difficulty) == 3)
{
    GuessLimit = 4;
}
else if (int.Parse(difficulty) == 4)
{
    GuessLimit = 42;
}


Console.WriteLine("Start Guessing!");

while (GuessLimit != 0 || GuessLimit == 42)
{
    Console.WriteLine($"");
    if (GuessLimit < 10)
    {
        GuessLimit--;

    }
    string answer = Console.ReadLine().ToLower();

    if (GuessLimit == 0)
    {
        Console.WriteLine("Better luck next time!");
    }

    else if (int.Parse(answer) > SecretNumber)
    {


        if (int.Parse(answer) >= (SecretNumber + 50))
        {

            Console.WriteLine("You overshot it there.. Like big time.");


        }
        else if (int.Parse(answer) >= (SecretNumber + 30))
        {

            Console.WriteLine($"It's for sure a much smaller number?");

        }
        else if (int.Parse(answer) == (SecretNumber + 6))
        {

            Console.WriteLine("Still too big...");

        }

        else if (int.Parse(answer) == (SecretNumber + 1))
        {

            Console.WriteLine("So close... No more hints though.");

        }

        else if (int.Parse(answer) == (SecretNumber + 2))
        {

            Console.WriteLine("So close... Smaller.");

        }
        else if (int.Parse(answer) == (SecretNumber + 3))
        {

            Console.WriteLine("Almost... A smidge too big.");

        }
        else if (int.Parse(answer) == (SecretNumber + 4))
        {

            Console.WriteLine("Almost... A bit too big.");

        }
        else if (int.Parse(answer) == (SecretNumber + 5))
        {

            Console.WriteLine("A bit too big i think...");

        }
        else
        {
            Console.WriteLine("Smaller..");

        }

    }
    else if (int.Parse(answer) < SecretNumber)
    {

        if (int.Parse(answer) <= (SecretNumber - 50))
        {
            Console.WriteLine($"Really {answer}?? Maybe guess a much bigger number?");

        }
        else if (int.Parse(answer) <= (SecretNumber - 30))
        {

            Console.WriteLine($"It's still a much bigger number?");

        }
        else if (int.Parse(answer) == (SecretNumber - 1))
        {

            Console.WriteLine("So close... No more hints though.");

        }
        else if (int.Parse(answer) == (SecretNumber - 2))
        {

            Console.WriteLine("So close... Bigger.");

        }
        else if (int.Parse(answer) == (SecretNumber - 3))
        {

            Console.WriteLine("Almost... A smidge too small.");

        }
        else if (int.Parse(answer) == (SecretNumber - 4))
        {

            Console.WriteLine("Almost... A bit too small.");

        }
        else if (int.Parse(answer) == (SecretNumber - 5))
        {

            Console.WriteLine("Close, but it's bigger..");

        }
        else if (int.Parse(answer) == (SecretNumber - 6))
        {

            Console.WriteLine("Still too small...");

        }
        else
        {
            Console.WriteLine("Bigger..");

        }

    }
    else
    {
        if (GuessLimit < 10)
        {
            Console.WriteLine("WOW! You're a genius or maybe just lucky... Congrats!");
            break;

        }
        else
        {
            Console.WriteLine("wow... you got it... yay...");
            break;
        }
    }

    if (GuessLimit < 10)
    {
        Console.WriteLine($"You have {GuessLimit} attempts left.");
    }
    else
    {
        Console.WriteLine($"You have CHEATER attempts left.");
    }
}

