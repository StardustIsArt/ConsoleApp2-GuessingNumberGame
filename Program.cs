namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hey there! Can you guess the secret number?");

        const int MAX_USER_INPUT = 100;
        const int MIN_USER_INPUT = 0;
        const int MAX_AMOUNT_OF_TRIES = 4;
        
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
                Console.WriteLine($"Too Low! Try again! You have {triesLeft} tries left. What is your new guess?");
                userNumberInput = int.Parse(Console.ReadLine());
                // if triesLeft equals 0 then stop.
            }
            if (userNumberInput > secretNumber)
            {
                Console.WriteLine($"Too High! Try again! You have {triesLeft} tries left. What is your new guess?");
                userNumberInput = int.Parse(Console.ReadLine());
                // if triesLeft equals 0 then stop.
            }
            
            // Things to work on... shows the same triesLeft after switching from too low or too high.
            // I need to have something be returned after the last guess. Are they wrong? etc...
            // output if they are within 5 numbers of secret guess
            // When the counter gets down to 0 it needs to stop and restart the game.
            // Look up documentation for Math.Abs vs Range check
        }
        
    }
}