using System;

class Program 
{ 
  static void Main () 
  {
    Console.WriteLine("Please enter a number: ");
    string userInput = Console.ReadLine();
    int userNum = int.Parse(userInput);
      for (int i = 0 ; i <= userNum; i++)
      {
        if(i % 5 == 0 && i % 3 == 0)
        {
          Console.WriteLine("ping-pong");
        }
        else if (i % 5 == 0)
        {
          Console.WriteLine("ping");
        }
        else if (i % 3 == 0)
        {
          Console.WriteLine("pong");
        }
        else 
        {
          Console.WriteLine(i);
        }
      }
    }
  }


        // stringOutput = Convert.ToString(i);
        // stringOutput = i;
        // Console.WriteLine(stringOutput);
        //output.Add(Convert.ToString(i));
        // Console.WriteLine(output);
        // stringOutput=""; 
      //}
      //Console.Write(output);
      // foreach (string element in output);
      // {
      //   Console.Write(string.Join(element + ", "));
      // }
            
            
      //Console.WriteLine(output);
      //userInput=5;
      //stringOutput="2";
      //output=["1","2"]