namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's make a High/Low Number Guessing game for you all to play!");

        const int MAX_USER_INPUT = 100;
        const int MIN_USER_INPUT = 0;
        
        Random rng = new Random();
        int randomNumber = rng.Next(0, 10);
        Console.Write("Choose a random number: ");
        int userNumberInput = int.Parse(Console.ReadLine());

        if (randomNumber == userNumberInput)
        {
            Console.WriteLine("You won!");
        }
        if (userNumberInput > MAX_USER_INPUT | userNumberInput < MIN_USER_INPUT)
        {
            for (int i = 0; i < 5; i++)
            {
                int triesLeft = int.Parse(i);
                Console.WriteLine($"You lost! Try again! You have {triesLeft} amount of tries left.");
            }
            
           
        }
        
        
        /*else
        {
            Console.WriteLine("You lost! Try again!");
        }*/
    }
}