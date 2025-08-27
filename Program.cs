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

        for (int i = 0; i < 5; i++)
        {
            if (secretNumber == userNumberInput)
            {
                Console.WriteLine("You won!");
                break;
            }
            if (userNumberInput > MAX_USER_INPUT || userNumberInput < MIN_USER_INPUT)
            {
                Console.WriteLine("Input a valid number!");
                break;
            }
            
           // for (int j = 0;  j < 5; j++) {
                int triesLeft = i;
                if (userNumberInput < secretNumber)
                {
                    Console.WriteLine($"Too Low! Try again! You have {triesLeft} amount of tries left.");
                }

                if (userNumberInput > secretNumber)
                {
                    Console.WriteLine($"Too High! Try again! You have {triesLeft} amount of tries left.");
                }

            //}
        }
        
       
        
        
        
        /*else
        {
            Console.WriteLine("You lost! Try again!");
        }*/
    }
}