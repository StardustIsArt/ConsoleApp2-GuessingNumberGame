namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's make a High/Low Number Guessing game for you all to play!");
        
        Random rng = new Random();
        int randomNumber = rng.Next(0, 10);


    }
}