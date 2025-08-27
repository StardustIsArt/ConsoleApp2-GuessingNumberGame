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

        // user should be able to guess 5 times. If they get it right they win. if they get it wrong they have 4 more
        // times to guess correctly. If they are close to the answer by 5 then it outputs "You're close!"
        // Need to put a limit on guesses.
        // Look up documentation for Math.Abs vs Range check

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
            Console.WriteLine($"Too Low! Try again! You have {triesLeft} amount of tries left.");
            Console.Write("What is your next guess for the secret number?");
            int.Parse(Console.ReadLine());
        }
      
        // How do I make the counter backwards --> look into documentation for that.
        
        // for everytime the guess is wrong 
            // make them input a new guess
            // output how many tries they have left
            // output if they are too high or too low (seperately)
            // output if they are within 5 numbers of secret guess
        
        if (userNumberInput > secretNumber)
        {
            Console.WriteLine($"Too High! Try again! You have {triesLeft} amount of tries left.");
        }
        for (int i = 0; i < 5; i++)
        { 
           // int triesLeft = 5;
            /*   while (triesLeft > 0)
                         {
                             Console.Write($"Too Low, you have {triesLeft} tries left! Try again: ");
                             triesLeft = triesLeft - 1;
                         }
             */
            //}
        }
    }
}