//Collections example, Ja'Shaun Rhone, v0.0
using System;
using System.Linq;
using System.Collections; 

class 04_Collections {
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



  } // DO NOT DELETE EVER, 3 SPACES INDENTED FROM THE LEFT
} // DO NOT DELETE EVER, ALWAYS TOUCHING LEFT MARGIN