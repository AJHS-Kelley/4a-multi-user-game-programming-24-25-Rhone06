using System;

class rockPaperScissors {
  static void Main() {
  // PLAYER VARIABLES

  int playerScore = 0;
  string playerChoice = "";

  // CPU VARAIBLES
  int cpuScore = 0;
  string cpuChoice = "";

  

  // TESTING GAME LOOP 
  int loopCount = 0;
  int loopsReqs = 0; // Req / Reqs is 


  while (playerScore < 5 && cpuScore < 5)
  {
  // Print the scores. 
  Console.WriteLine($"Your Score: {playerScore}\nCPU Score: {cpuScore}\n");

  // Allow player to select R, P, S.
  Console.WriteLine("Please select Rock, Paper, or Scissors. Type your answer and press ENTER.\n"); 
  playerChoice = Console.ReadLine().ToLower();
  if (playerChoice != "rock" && playerChoice != "paper" & playerChoice != "scissors")
  {
    Console.WriteLine("Please choose rock, paper, or scissors. Type your answer and press ENTER.\n");
    playerChoice = Console.ReadLine().ToLower(); 
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
    cpuChoice = "scissors";
  }
  else
  {
    Console.WriteLine("Unable to determine CPU choice.\n");
  }
  Console.WriteLine("CPU choice" + cpuChoice);

  // Compare the two choices and determine the winner.
  if (playerChoice == "rock" && cpuChoice == "paper")
  {
    Console.WriteLine($"{playerName}, You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine($"The CPU wins, try again {playerName}.\n");
    cpuScore++; 
  }
  else if (playerChoice == "rock" && cpuChoice == "scissors")
  {
    Console.WriteLine($"{playerName}, You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine($"You Win {playerName}!\n");
    playerScore++; 
  }
  else if (playerChoice == "rock" && cpuChoice == "rock")
  {
    Console.WriteLine($"{playerName}, You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("It's a draw!\n");
  }
  else if (playerChoice == "paper" && cpuChoice == "scissors")
  {
    Console.WriteLine($"{playerName}, You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine($"The CPU wins, try again {playerName}.\n");
    cpuScore++;
  }
  else if (playerChoice == "paper" && cpuChoice == "rock")
  {
    Console.WriteLine($"{playerName}, You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine($"You Win {playerName}.\n");
    playerScore++;
  }
    else if (playerChoice == "paper" && cpuChoice == "paper")
  {
    Console.WriteLine($"{playerName}, You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("It's a draw!\n");
  }
    else if (playerChoice == "scissors" && cpuChoice == "rock")
  {
    Console.WriteLine($"{playerName}, You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine($"The CPU wins, try again {playerName}.\n");
    cpuScore++;
  }
  else if (playerChoice == "scissors" && cpuChoice == "paper")
  {
    Console.WriteLine($"{playerName}, You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine($"You Win {playerName}.\n");
    playerScore++;
  }
    else if (playerChoice == "scissors" && cpuChoice == "scissors")
  {
    Console.WriteLine($"{playerName}, You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("It's a draw!\n");
  }

  if (playerScore > cpuScore)
  {
    Console.WriteLine($"Congratulations {playerName}, you are the winner!\n");
  }
  else
  {
    Console.WriteLine("The CPU has defeated you :(\n");
  }
  }

  }
}