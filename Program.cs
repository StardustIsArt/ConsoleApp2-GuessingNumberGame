namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's make a High/Low Number Guessing game for you all to play!");
        
        Random rng = new Random();
        int randomNumber = rng.Next(0, 10);
        Console.Write("Choose a random number:");
        int userNumberInput = int.Parse(Console.ReadLine());

        if (randomNumber == userNumberInput)
        {
            Console.WriteLine("You won!");
        }
        else
        {
            Console.WriteLine("You lost! Try again!");
        }
    }
}