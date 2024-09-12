using System;
class Strings {
 static void Main() {

// In c#  ALL STRINGS MUST USE DOUBLE QUOTES"  "

// string greeting = "Hello Stranger, pleased to meet you. What's your name?\n";
// string goodbye = "Till we meet again.\n";

// In c# strings are treated like an object that has properties and methods. 
// PROPERTIES -- things that describe the object such as length, values, data type, etc.
// METHODS -- Built in functions related to that object

// Length is an important property for strings
// Console.WriteLine(greeting.Length);
// Console.WriteLine(goodbye.Length);

// if (greeting.Length > goodbye.Length)
// {
//  Console.WriteLine("This greeting has more characters than goodbye.\n");
// }

// Useful string Methods
// Console.WriteLine(greeting.ToUpper()); // Make Entire String UPPERCASE
// Console.WriteLine(greeting.ToLower()); // Make Entire String Lowercase

// String Concatenation "Con-Cat-Uh-Nation
// string comboString = greeting + goodbye; 
// Console.WriteLine(comboString);

// String Concatenation Method #2
// string comboString2 = string.Concat(greeting, goodbye);
// Console.WriteLine(comboString2);

// String interpolation -- Substituting variables into strings.
// string comboString3 = $"My greeting is {greeting} and my goodbye is {goodbye}.\n";
// Console.WriteLine(comboString3); 

// Substituting Variables into strings method 2
// Console.WriteLine("My greeting is " + greeting + "and my goodbye is " + goodbye + ".\n");

// Accessing Parts of Strings
// Index is a specific location of a character in a string
// ALL String indexes start at 0
// Console.WriteLine(goodbye[0]); // Print the character at index 0
// Console.WriteLine(goodbye[4]); // print the character at index 4

// Where is it in my string? 
// Console.WriteLine(greeting.IndexOf("y")); 

// Finding parts of a string
string fullName = "Maurice Hedgehog";

// What letter 
int lastInitial = fullName.IndexOf("H"); 

// Find the Substring 
string lastName = fullName.Substring (lastInitial);

// Print it. 
Console.WriteLine(lastName); 




  }
}