namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hey there! Can you guess the secret number?");

        const int MAX_USER_INPUT = 100;
        const int MIN_USER_INPUT = 0;
        
        Random rng = new Random();
        int secretNumber = rng.Next(0, 100);
        Console.Write("What is your guess for the secret number: ");
        int userNumberInput = int.Parse(Console.ReadLine());

  
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
        for (int i = 0; i < 5; i++)
        {
            int triesLeft = 4;
            while (triesLeft > 0)
            {
                if (userNumberInput < secretNumber)
                {
                    Console.WriteLine($"Too Low! Try again! You have {triesLeft} amount of tries left.");
                    // if triesLeft equals 0 then stop.
                }

                if (userNumberInput > secretNumber)
                {
                    Console.WriteLine($"Too High! Try again! You have {triesLeft} amount of tries left.");
                   // if triesLeft equals 0 then stop.
                }
                Console.Write("What is your next guess for the secret number? ");
                int.Parse(Console.ReadLine());
                triesLeft = triesLeft - 1;
               
            }
           
            // When the counter gets down to 0 it needs to stop and restart the game.

            // for everytime the guess is wrong 
            // make them input a new guess
            // output how many tries they have left
            // output if they are too high or too low (separately)
            // output if they are within 5 numbers of secret guess

            // Need to put a limit on guesses. Can use return to stop while loop?
            // Look up documentation for Math.Abs vs Range check

        }
    }
}