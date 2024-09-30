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

  Console.WriteLine($"""
  +===========================================================+ 
  |                                                       *.  |
  |   .       WELCOME TO ROCK, PAPER, SCISSORS! :)            |
  |   *.                                                      |
  +===========================================================+
  {playerName}, You will select from Rock, Paper, or Scissors. 
  The CPU will select one of those choices at random. 
  Then a winner will be determined using the following rules:
  -- Rock Beats Scissors
  -- Paper Beats Rock 
  -- Scissors Beats Paper 

  The winner will receive a point. 
  The first player to score 5 points will be declared the winner.
  Wishing you the best {playerName}.
  """);



  while (playerScore < 5 && cpuScore < 5)
  {
  // Print the scores. 
  Console.WriteLine($"Your Score: {playerScore}\nCPU Score: {cpuScore}\n");

  // Allow player to select R, P, S.
  Console.WriteLine("Please select Rock, Paper, or Scissors. Type your answer and press ENTER.\n"); 
  playerChoice = Console.ReadLine().ToLower();
  if (playerChoice != "rock" && playerChoice != "paper" & playerChoice != "scissors")
  {
    Console.Writeline("Please choose rock, paper, or scissors. Type your answer and press ENTER.\n");
    playerChoice = Console.ReadLine().ToLower(). 
  }

  // Allow CPU to select randomly.
  Random rnd = new Random();
  int cpuRand = rnd.Next(0,2); 

  if (cpuRand == 0)
  {
    cpuChoice = "rock";
  }
  else if (cpuRand == 1)
  {
    cpuChoice = "paper";
  }
  else if (cpuRand == 2)
  {
    cpuChoice = "scissors"
  }
  else
  {
    Console.WriteLine("Unable to determine CPU choice.\n");
  }
  Console.WriteLine("CPU choice" + cpuChoice);

  // Compare the two choices and determine the winner.
  if (playerChoice == "rock" && cpuChoice == "paper")
  {
    
  }

  }

  }
}