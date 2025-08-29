namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hey there! Can you guess the secret number?");

        const int MAX_USER_INPUT = 100;
        const int MIN_USER_INPUT = 0;
        const int MAX_AMOUNT_OF_TRIES = 5;
        const int CLOSE_RANGE = 5; 
        
        Random rng = new Random();
        int secretNumber = rng.Next(MIN_USER_INPUT, MAX_USER_INPUT);
        Console.Write("What is your guess for the secret number: ");
        int userNumberInput = int.Parse(Console.ReadLine());
        int triesLeft = 5;
        
        for (int i = 0; i < MAX_AMOUNT_OF_TRIES; i++)
        {
            triesLeft = triesLeft - 1;  
            if (secretNumber == userNumberInput)
            {
                Console.WriteLine("You won!");
                return;
            }
            if (userNumberInput > MAX_USER_INPUT || userNumberInput < MIN_USER_INPUT)
            {
                Console.WriteLine("Input a valid number!");
                return;
            }
            if (userNumberInput < secretNumber)
            {
                Console.WriteLine($"Too Low! Try again! \nYou have {triesLeft} tries left. \nWhat is your new guess: ");
                userNumberInput = int.Parse(Console.ReadLine());
            }
            if (userNumberInput >= secretNumber - CLOSE_RANGE && userNumberInput <= secretNumber + CLOSE_RANGE)
            {
                Console.WriteLine("You are close!");
            }
            if (userNumberInput > secretNumber)
            {
                Console.WriteLine($"Too High! Try again! \nYou have {triesLeft} tries left. \nWhat is your new guess: ");
                userNumberInput = int.Parse(Console.ReadLine());
            }
            if (triesLeft == 0)
            {
                Console.WriteLine($"You Lost! Restart the game.");
            }
            // Things to work on... shows the same triesLeft after switching from too low or too high.
            // Look up documentation for Math.Abs vs Range check
        }
    }
}