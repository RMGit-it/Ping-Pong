using System;
using System.Collections.Generic;

public class Program 
{ 
  public static void Main () 
  {
    Console.WriteLine("Please enter a number: ");
    int userInput = int.Parse(Console.ReadLine());
    List<string> output = new List<string>();
    if (userInput <= 0 || userInput >= 1000 ) {
      Console.WriteLine("This is not a valid number");
    } else {
      //List<string> output = new List<string>();
      
      string stringOutput=""; 
      for (int i=1; i<=userInput; i++)
      {
        stringOutput = Convert.ToString(i);
        // stringOutput = i;
        // Console.WriteLine(stringOutput);
        output.Add(stringOutput);
        // Console.WriteLine(output);
        // stringOutput=""; 
      }
      Console.Write(output);
      
            
      //Console.WriteLine(output);
      //userInput=5;
      //stringOutput="2";
      //output=["1","2"]
    }
  }
}

