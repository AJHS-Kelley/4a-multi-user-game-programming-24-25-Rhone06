using System;
class FolowControlSructures {
  static void Main() {
  // these blocks of code are used to control how the program executes,
  // Basically, these blocks of code allow for decisions to be made

  // int age = 44
  // double = cheeseBurgers = 1.25D; 
  // string favFlavor = "Butterscotch"
  // bool afraidSnakes = false; 

  // // Can i vote
  // if (age >= 18 ) // (age >= 18) is the CONDITIONAL STATEMENT
  // {
  //   Console.WriteLine("You can vote! \n"); 
  // }
  // else if (age >=16 )// Check this next Line #13 is false
  // {
  //   Console.WriteLine("You are NOT old enough to vote, but you may register. \n");
  // }
  // else 
  // {
  //   Console.WriteLine(" You are NOT old enough to vote, chubs.\n"); 
  // }

  /*
  You can have a single if statement by itself
  If you can have an else you must also have an if
  you can have as many else if statements if needed
  FOR NOW, USE THE else condition TO PRINT ERROR MESSAGES
  */
  
  // int day = 1;
  // switch(day)
  // {

  //   case 1:
  //     Console.Writeline("It's Monday.\n");
  //     break; 
  //   case 2:
  //     Console.Writeline("It's Tuesday.\n");
  //     break; 
  //   case 3: 
  //     Console.Writeline("It's Wednesday.\n");
  //     break;
  //   // case 4- 6
  //   case 7: 
  //   Console.WriteLine("It's Sundays, go rest.\n");
  //   break;
  // }


 /*
 // while Loops are like musical chairs
 // use while loops if you DO NOT KNOW how many loops you need
 // the code will run as long as the condition is true
 // while loop syntax:
 */


  // int z = 0;
  // while (z <= 100) // What do i replace CONDITIONAL_EXPRESSION
  // {
  //   Console.WriteLine(z);
  //   z++;
  // }
  
  // int y = 100;
  // while (y >= 0) // What do i replace CONDITIONAL_EXPRESSION
  // {
  //   Console.WriteLine(y);
  //   y--;
  // }

  // for loops are like playing go fish
  // you know how many cards are in your hand
  // used when you know how many loops you need ahead of time

  /* 
  for (statement1; statement2; statement3;)
  {
    code to run each loop
  } 

  statement1 = code to run ONE TIME before the loop starts
  statement2 = CONDITIONAL EXPRESSION to check EACH TIME before loop runs
  statement3 = code to run AFTER each loop

  Each 'trip' through the loop is called in ITERATION. 
  */

  //  Counting to 10 with 'for' loops
  // for (int i = 0; i < 10; i++)
  // {
  //   Console.WriteLine(i); 
  // }

 for (int i = 10; i >= 0; i--)
  {
    Console.WriteLine(i); 
  }

  for (int i = 0; i <= 10 ; i++)
  {
    Console.WriteLine(i);
  }


  }
}