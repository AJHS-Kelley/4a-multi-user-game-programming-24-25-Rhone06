//Collections example, Ja'Shaun Rhone, v0.0
using System;
using System.Linq;
using System.Collections; 

class Collections {
  static void Main() {

  /*
  In C# an collection is known as an ARRAY.
  -- EACH ITEM IN THE ARRAY IS KNOWN AS AN ELEMENT.
  -- NUMBER OF ELEMENTS IN THE ARRAY CANNOT BE CHANGED.
  -- CONTENTS OF EACH ELEMENT CAN CHANGE.
  -- ARRAYS ARE ORDERED, MEANING EACH ITEM HAS A FIXED POSITION.
  -- POSITION OF EACH ELEMENT IS CALLED THE INDEX.
  -- FIRST ELEMENT INDEX IS 0. 
  */

  //DECLARING AND DEFYING AN ARRAY. 
  string[] breakfastFoods = {"Cereal", "eggs", "Toast", "Hash Brown", "Bagel"};
  int[] testScore = {0, 25, 50, 75, 90};
  double[] GPA = {0.27D, 1.99D, 4.02D, 0.0D, 3.25D};

  // Print Array contents -- All Elements on Single Line
  Console.WriteLine("The elements of each array are:\n");
  Console.WriteLine("breakFastFoods: \n" + String.Join(", ", breakfastFoods));
  Console.WriteLine(); // Print an empty line to the screen.

  // Print Array Elements on Seperate Lines
  Console.WriteLine("The elements of each array are:\n");
  Console.WriteLine("testScore: \n" + String.Join("\n", testScore));
  Console.WriteLine(); // Print an empty line to the scree

  // How long is my array? DETERMINING ARRAY LENGTH 
  Console.WriteLine("The lenght of the breakfastFoods array is: " + breakfastFoods.Length);
  // .Length is known as PROPERTY of the array.  

  // Accessing Elments in the array with the index
  Console.WriteLine("The first element in breakFastFoods is: " + breakfastFoods[0]);
  // PRIN THE 2nd ELEMENT OF THE testScores array. 
  Console.WriteLine("The second element in testScores is: " + testScore [1]);
  //PRINT THE 3rd ELEMENT OF THE GPA array. 
  Console.WriteLine("The third element in GPA is: " + GPA [2]);

  } // DO NOT DELETE EVER, 3 SPACES INDENTED FROM THE LEFT
} // DO NOT DELETE EVER, ALWAYS TOUCHING LEFT MARGIN