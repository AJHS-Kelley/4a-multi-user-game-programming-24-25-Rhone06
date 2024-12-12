using System;
class guessNumber {
 static void Main(string[] args) {
    Random r = new Random(); 
    int val = r.Next(1, 51);
    int playerGuess;
    int allowedTries = 15; 
    int numberOfTries = 0;
    bool correct = false;

    Console.WriteLine(" I'm thinking of a number between 1 & 50.\n");

    while (!correct)
    {
    Console.Write("Guess: ");
    string input = Console.ReadLine();
	numberOfTries++;

    if (!int.TryParse(input, out playerGuess))
    {
        Console.WriteLine("That's Not a Number..\n");
        continue; 
    }

    if (playerGuess < val)
    {
        Console.WriteLine ($"Not quite, The number I'm thinking of is Higher than {playerGuess}.\n");
    }
    else if (playerGuess > val)
    {
        Console.WriteLine ($"Not quite, The number I'm thinking of is Lower than {playerGuess}.\n");
    }
    else 
    {
        correct = true;
        Console.WriteLine("You guessed right, you win!");
        break;
    }
    
    if (allowedTries == 0) 
    Console.WriteLine("You lose, try Again?\n"); 
	

	if(playerGuess != val)
    Console.WriteLine($"You have {allowedTries - numberOfTries} tries left. Please enter another number:\n");
		
  }
 }
}
