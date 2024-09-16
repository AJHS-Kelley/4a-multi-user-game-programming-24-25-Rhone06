using System;
class guessNumber {
 static void Main(string[] args) {
    Random r = new Random(); 
    playerGuess
    int val = r.Next(1, 50);
    int guess;
    int allowedTries = 15; 
    int numberOfTries = 1;
    bool correct = false;

    Console.WriteLine(" I'm Thinking of a number between 1 & 50.\n");

    while (!correct)
    {
    Console.Write("Guess: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out guess))
    {
        Console.WriteLine("That's Not a Number..\n");
        continue; 
    }

    if (playerGuess < val)
    {
        Console.WriteLine ("Not Quite, The number I'm thinking of is Higher than that number.\n");
    }
    else if (playerGuess > val)
    {
        Console.WriteLine ("Not Quite, The number I'm thinking of is Lower than that number.\n");
    }
    else 
    {
        correct = true;
        Console.WriteLine("You guessed right, you win!");
        break;
    }

    Console.WriteLine($"You have {allowedTries - numberOfTries} tries left. Please enter another number:\n");
  }
 }
}
