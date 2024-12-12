// Data tyes and operators Ja'Shaun Rhone
using System;
class dataTypesOperators {
  static void Main() {
  // This is a comment, it gets ignored.
  // pleaseexcusemydearauntsally

  /*
  This is still a comment

  */

  // DATA TYPES
  //C# is STATICALLY TYPED -- once a variable has a data type, it cannot change

  // Float - float -- decimal numbers, +/- including 0.0

  // Double - double -- decimal numbers, +/- including 0.0 <-- MOST COMMONLY USED DECIMAL

  // Intergers - int -- whole numbers, +/-, including 0 

  // VARIABLES ARE 'BUCKETS' WITH A NAME TO STORE DATA INSIDE

  // DECLARING (CREATING VALUES)
  // Method #1 -- Declared But Not Assighn
  // dataType variableName;

  int myInteger; 
  double myDouble;

  // Method #2 -- Declare AND Assighn 
  int myInteger2 = 6;
  double myDouble2 = 3.57D;

  // Strings -- collections of letters, numbers, special characters.
  string myString = "The One Piece Is Real.";

  // Boolean -- bool - True or False values
  bool myBool = true;
  bool fireResistance = true;
  bool hasPurpleKey = false; 

  // Character -- char -- a single character 
  char myChar = 'A'; 

  // ASSIGHNING VALUES AFTER DECLERATION 

  myInteger = 1; 
  myDouble = 2.0D; 

  // PRINT VARIABLES TO THE CONSOLE  TERMINAL
  // Console.WriteLine(myInteger - 25); 
  // Console.WriteLine(myDouble + 2.5D);
    
  // // PRINT VARIABLES TO THE CONSOLE  TERMINAL
  // Console.WriteLine(myInteger); 
  // Console.WriteLine(myDouble);

  //OPERATORS -- ARITHMETIC
  // Addition
  int myNewInt  = myNewInt + myInteger2;
  double myNewDouble = myDouble + myDouble2;

  // SUBTRACTION 
  myNewNumber = myDouble + myInteger1;

  // DIVISION
  myNewNumber = myDouble / myInteger1;

  // MULTIPLICATION
  myNewNumber = myDouble * myInteger1;

  // MODULOUS -- Divides, then returns the REMAINDER
  // Most commonly used to determine EVEN or ODD
  myNewNumber = myDouble % 2;

  int students = 6;
  int numSlices = 36;
  int leftOvers;

  leftOvers = numSlices % students;  

  // Increment / Decrement -- Most frequently used in loops
  int x = 0; 
  x++; // What is equal to x now?
  // Increment ++ add tot the current value and and puts the new value into the bucket

  // Decrement -- subtracts 1 from the current value and puts the new value into the bucket

  // Special assighnment Operators 
  x += 1; 
  x *= 1;
  x -= 1;
  x /= 1;
  x %= 1;

  // Take current value, preform the calculation. putnew value into bucket

  // COMPARISON OPERATORS
  // EVALUATE THE EXPRESSION, RETURN true and false
  int y = 5;
  int z = 3;

  // IS-EQUAL-TO == is the value on the left equal to the right?
  // Console.WriteLine( y == z);

  // // NOT-EQUAL-TO != is the value on the left not equal to the right?
  // Console.WriteLine(y != z);

  //GREATER THAN >
  // Console.WriteLine(y > z);
  // //GREATER THAN-OR-EQUAL-TO >=
  // Console.WriteLine(y >= z);
  // //LESS THAN <
  // Console.WriteLine(y < z);
  // //LESS THAN-OR-EQUAL-TO <=
  // Console.WriteLine(y <= z);

  // LOGICAL OPERATORS 
  int b = 1;
  double c = 2.0D;
  string favColor = "Blue";
  //Logical and && -- all statements must be True 
  // Console.Writeline(b > 1 && c != 5.0D); // false because b is not 1
  // Console.Writeline(b == 1 && c < 10.0D); // both are true whole explanation is true
  // // If one expression most likely to be false, check for it first
  // Console.Writeline(hasPurpleKey == true && playerLevel > 5);
  // Console.Writeline(hasPurpleKey == true && playerLevel > 5 && hasFlameThrower == true && timeRemaining > 99);

  // // Logical || -- ONE statement must be true
  // Console.Writeline(b > 1 || c != 5.0D);  // true because c is not equal to c
  // Console.Writeline(b == 2 || c > 10.0D); // false bc both expressions are false 
  // // Check for statements most likely to br true first!
  // Console.Writeline(hasBlueKey == true && playerLevel > 3);

  // Logical NOT! -- returns the opposite value of expressions 
  Console.Writeline((b > -1 ));// true   
  Console.Writeline(!(b > -1 ));// False

  // READING USER INPUT FROM THE CONSOLE / TERMINAL
  Console.WriteLine("What is your player name? Type it and press ENTER. \n");

  // CREATE A VARAIBLE TO STORE DATA
  string playerName = Console.ReadLine();
  // Console.ReadLine()ONLY RETURNS STRING DATA TYPES.
  Console.WriteLine("What is your age? Type it and press ENTER. \n");
  string age = Console.ReadLine();
  Console.WriteLine(age + age);
  // ADDING string data types together is called CONCATENATION

  // PRINT THE VARIABLE TO THE SCREEN
  //Console.WriteLine("Your player name is" + playerName);
  
  // INPUTING NUMBERS FROM THE CONSOLE 
  Console.WriteLine("How many French fries can you eat in 5 minutes? ");
  int numFries = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine(numFries- + numFries); 

 }
}