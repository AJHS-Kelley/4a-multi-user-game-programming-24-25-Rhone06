using Sysytem;
class guessNumber {
 static void Main() {
    Random r = new Random(); 

    int val = r.Next(1, 50);
    int guess = 0;
    bool correct = false;

    Console.WriteLine(" I'm Thinking of a number between 1 & 50.\n");

    while (!correct)

    Console.Write("Guess: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out guess))
    {
        Console.WriteLine("That's Not a Number..\n");
        continue; 
    }

    if (guess < val)
    {
        Console.WriteLine ("Not Quite, The number I'm thinking of is higher than")
    }

 }
}
 