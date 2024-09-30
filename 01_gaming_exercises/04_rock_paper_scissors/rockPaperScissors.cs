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
  


  }
}