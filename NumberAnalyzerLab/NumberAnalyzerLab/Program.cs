Console.WriteLine("Please enter your name");
string userName = Console.ReadLine();

bool playAgain = false;

do
{
    
    Console.WriteLine($"Hello {userName}. Please enter a number between 1 and 100:");
    int userNumber = int.Parse(Console.ReadLine());

    if (userNumber < 60 && userNumber % 2 != 0)
    {
        Console.WriteLine($"{userName}, your number was {userNumber}, which is odd and less than 60");
    }
    else if (userNumber < 25 && userNumber >= 2 && userNumber % 2 == 0)
    {
        Console.WriteLine($"{userName}, your number is even and less than 25");
    }
    else if (userNumber >= 26 && userNumber <= 60 && userNumber % 2 == 0)
    {
        Console.WriteLine($"{userName}, your number is even and between 26 and 60 inclusive");
    }
    else if (userNumber > 60 && userNumber <= 100 && userNumber % 2 == 0)
    {
        Console.WriteLine($"{userName}, your number was {userNumber}, which is even and greater than 60");
    }
    else if (userNumber > 60 && userNumber <= 100 && userNumber % 2 != 0)
    {
        Console.WriteLine($"{userName}, you entered {userNumber}, which is odd and greater than 60");
    }
    else
    {
        Console.WriteLine("This number is not within the range");
    }
    Console.WriteLine("Would you like to play again? Yes/No");
    playAgain = Console.ReadLine().ToLower().Trim() == "yes" ? true : false;
} while (playAgain == true);

Console.WriteLine("Thank you for playing!");
    




