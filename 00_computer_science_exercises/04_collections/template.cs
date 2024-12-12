//Collections example, Ja'Shaun Rhone, v0.0
using System;
using System.Linq;
using System.Collections; 

class Collections {
  static void Main() {

  /*
  // In C# an collection is known as an ARRAY.
  // -- EACH ITEM IN THE ARRAY IS KNOWN AS AN ELEMENT.
  // -- NUMBER OF ELEMENTS IN THE ARRAY CANNOT BE CHANGED.
  // -- CONTENTS OF EACH ELEMENT CAN CHANGE.
  // -- ARRAYS ARE ORDERED, MEANING EACH ITEM HAS A FIXED POSITION.
  // -- POSITION OF EACH ELEMENT IS CALLED THE INDEX.
  // -- FIRST ELEMENT INDEX IS 0. 
  // */

  // //DECLARING AND DEFYING AN ARRAY. 
  // string[] breakfastFoods = {"Cereal", "eggs", "Toast", "Hash Brown", "Bagel"};
  // int[] testScores = {0, 25, 50, 75, 90};
  // double[] GPA = {0.27D, 1.99D, 4.02D, 0.0D, 3.25D};
  
  // // Print Array contents -- All Elements on Single Line
  // // Console.WriteLine("The elements of each array are:\n");
  // // Console.WriteLine("breakFastFoods: \n" + String.Join(", ", breakfastFoods));
  // // Console.WriteLine(); // Print an empty line to the screen.

  // /* Print Array Elements on Seperate Lines
  // Console.WriteLine("The elements of each array are:\n");
  // Console.WriteLine("testScores: \n" + String.Join("\n", testScores));
  // Console.WriteLine(); // Print an empty line to the scree

  // // How long is my array? DETERMINING ARRAY LENGTH 
  // Console.WriteLine("The lenght of the breakfastFoods array is: " + breakfastFoods.Length);
  // // .Length is known as PROPERTY of the array.  

  // // Accessing Elments in the array with the index
  // Console.WriteLine("The first element in breakFastFoods is: " + breakfastFoods[0]);
  // // PRIN THE 2nd ELEMENT OF THE  array. 
  // Console.WriteLine("The second element in  is: " + testScores [1]);
  // //PRINT THE 3rd ELEMENT OF THE GPA array. 
  // Console.WriteLine("The third element in GPA is: " + GPA [2]);
  
  // // Shortcut to any item in an Array
  // //Console.WriteLine("The last element of breakFastFoods is: " + breakfastFoods[breakfastFoods.Length - 1]); 
  // //Console.WriteLine("The last element of testScores is: " + testScores[testScores.Length - 1]); 

  // // Changing an array
  // breakfastFoods[2] = "Burnt Toast";
  // testScores[3] = 80;
  // GPA[1] = 2.0D;
  // Console.WriteLine("The elements of each array are:\n");
  // Console.WriteLine("breakFastFoods: \n" + String.Join(", ", breakfastFoods));
  // Console.WriteLine(); // Print an empty line to the screen.
  // */

  // // COMMON ERRORS WITH ARRAYS
  // //Console.WriteLine(breakfastFoods[99]);  // Index Out of Bounds -- Accessing index that does not exist in the array

  // // testScores[0] = "99"; // Error message "Cannot implicitly convert type `string' to `int'" -- Trying to put incorrect data type into array

  // // COMMON ARRAY METHODS --  Ways to work with the array data.
  // // Sorting an array
  // int[] intArr = {7, 0, -4, 9, 16, -9, 5, 23, 2, -1,};
  // string[] zooAnimals = {"Girrafe, Zebra, Monkey, Bird, Snake, Spider, Lizard, Elephant, Lion, Panther"};

  // Array.Sort(intArr); 
  // Array.Sort(zooAnimals);
  // // Array.Sort will sort string arrays ALPHABETICALLY A-Z and numerical arrays from least to greatest 
  // Console.WriteLine("The elements of each array are:\n");
  // Console.WriteLine("zooAnimals after Array.Sort(): \n" + String.Join(", ", zooAnimals));
  // Console.WriteLine(); // Print an empty line to the screen.

  // // Finding the MIN, MAX, AND SUM for numerical arrays.
  // Console.WriteLine("The MINIMUM value for intArr is: " + intArr.Min());
  // Console.WriteLine("The MAXIMUM value for intArr is: " + intArr.Max());
  // Console.WriteLine("The SUM value for intArr is: " + intArr.Sum());

  // ArrayList --> Basically an array you can add/remove elements from.
  var exampleArrList = new ArrayList(); // Create a new ArrayList. 
  // Adding elements to an ARrayList use .Add()
  // .Add
  exampleArrList.Add(5);
  exampleArrList.Add("Sonic OVA");
  exampleArrList.Add(false);
  exampleArrList.Add(2.5D);

  // Create ArrayList with Values
  var exampleArrList2 = new ArrayList()
    {
      -10, "First Name", "Black", false, 25.25D, 205000, 1.8D      
    }; 

  // Console.WriteLine(exampleArrList[2]);
  // Console.WriteLine(exampleArrList[5]);

  // Insering to a specific position in the ArrayList
  // Use.Insert(index, value)
  // exampleArrList.Insert(3, "Tainted blood.\n");
  // exampleArrList.Insert(5, -69);
  
  // .Remove(value) removes the FIRST OCCURENCE of the item from the ArrayList.
  var newList = new ArrayList()
    {
      -5, 5, 10, -15, -5, 20, 32, -20, 50
    };
  // Console.WriteLine(newList[0]);
  // newList.Remove(-10);
  //Console.WriteLine(newList[0]);  

  // Deleting based on Index number.
  // .RemoveAt(calue) --> deletes the item at the specified index
  // newList.RemoveAt(4);

  // Delete the First Item
  // newList.RemoveAt(0);

  // Delete the last item
  // newList.RemoveAt(newList.Length - 1);

  // Remove an entire range of elements.
  // .RemoveRange(Firstindex, lastIndex)
  // newList.RemoveRange(3, 8)

  // Shortcut to delete from one item through end of list.
  // newList.RemoveRange(4, newList.Length - 1);

  // Does the ArrayList contain a certain value?
  // .Contains(Value) returns ture if the list has that value, false otherwise. 
  var playerInventory = new ArrayList()
    {
      "Axe", "Torch", "Flashbang", "Medkit", "Mushroom", "Knife"
    };

  Console.WriteLine(playerInventory.Contains("Fishing Pole"));
  Console.WriteLine(playerInventory.Contains("Axe"));

  if (playerInventory.Contains("Red Key"));


  } // DO NOT DELETE EVER, 3 SPACES INDENTED FROM THE LEFT
} // DO NOT DELETE EVER, ALWAYS TOUCHING LEFT MARGIN