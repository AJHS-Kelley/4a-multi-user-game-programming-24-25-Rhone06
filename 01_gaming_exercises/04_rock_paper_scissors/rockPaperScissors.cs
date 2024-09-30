using System;

class rockPaperScissors {
  static void Main() {
  // PLAYER VARIABLES
  string playerName = "Test Player";
  int playerScore = 0;
  string playerCHoice = "";

  // CPU VARAIBLES
  int cpuScore = 0;
  string cpuChoice = "";

  Console.WriteLine("Welcome To a wonderful game of Rock, Paper, Scissors!\n");
  Console.WriteLine("Please type your preffered name and press ENTER. \n");
  playerName = Console.ReadLine();
  Console.WriteLine($"Greetings {playerName}. Is this correct?\n");
  Console.WriteLine("Please type yes or no, then press ENTER.\n");
  string isCorrect = Console.ReadLine().ToLower();

  if (isCorrect == "yes")
  {
    Console.WriteLine($"Splendid! I'll call you {playerName}.\n");
  }
  else if (isCorrect == "no")
  {
    Console.WriteLine("Please type your preffered name and press ENTER. \n");
    playerName = Console.ReadLine();
  }
  else
  {
    Console.WriteLine("Unable to determine your answer. Please try again. \n");
  }

  Console.WriteLine("""
  +===========================================================+ 
  |                                                           |
  |     WELCOME TO THE ROCK, PAPER, SCISSORS CHALLENGE!       |
  +===========================================================+
  You will select from Rock, Paper, or Scissors. 
  The CPU will select one of those choices at random. 
  Then a winner will be determined using the following rules:
  -- Rock Beats Scissors
  -- Paper Beats Rock 
  -- Scissors Beats Paper 

  The winner will receive a point. 
  The first player to score 5 points will be declared the winner.
  """);

  }
}