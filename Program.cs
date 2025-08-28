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
            triesLeft = triesLeft - 1;   // why isn't this returning the countdown?
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
                Console.WriteLine("Too Low! Try again!");
                // if triesLeft equals 0 then stop.
            }
            if (userNumberInput > secretNumber)
            {
                Console.WriteLine("Too High! Try again!");
                // if triesLeft equals 0 then stop.
            }
            Console.Write($"You have {triesLeft} tries left. What is your next guess for the secret number? ");
            int.Parse(Console.ReadLine());
            
            // I have noticed for every new guess the output is as the prior one before (or the first output) ex. "Too High".
            // why is it not rechecking the number against the arguments?
            // When the counter gets down to 0 it needs to stop and restart the game.
            // output if they are too high or too low (separately)
            // output if they are within 5 numbers of secret guess
            // Look up documentation for Math.Abs vs Range check
        }
        
    }
}