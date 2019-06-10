using System;
namespace Calculator
{
  class Calculator
  {
    static int counter = 0;

    public static int computation(int val1, int val2, string constructor)
    {
      switch(constructor){
        case("+"):
          return (val1 + val2);
        case("-"):
          return (val1 - val2);
        case("*"):
          return (val1 * val2);
        case("/"):
          return (val1 / val2);
        Console.WriteLine("Invalid constructor used");
      }
      return -1;
    }

    public static string[] separateBySpace(string equation)
    {
      string[] equationSeparated = equation.Split(' ');
      return equationSeparated;
    }

    public static int calculator(string equation, int oldValue)
    {
      string[] equationSeparated = separateBySpace(equation);
      int previousValue = oldValue;
      int n;

      if(counter == 0)
      {
        if(equationSeparated.Length == 0)
        {
          Console.WriteLine("Nothing to calculate");
          return -1;
        }
        else if (int.TryParse(equationSeparated[0], out n) == false)
        {
          Console.WriteLine("Incorrect Values used");
          return -1;
        }
        else
        {
          counter = 1;
          previousValue = Int32.Parse(equationSeparated[0]);
          for (int i = 1; i<equationSeparated.Length-1; i++)
          {
            previousValue = computation(previousValue, Int32.Parse(equationSeparated[i+1]), equationSeparated[i]);
            i += 1;
          }
          return previousValue;
        }
      }
      else
      {
        for (int i = 0; i<equationSeparated.Length-1; i++)
        {
          previousValue = computation(previousValue, Int32.Parse(equationSeparated[i+1]), equationSeparated[i]);
          i += 1;
        }
        return previousValue;
      }

      int val;
      return val;
    }

    static void Main(string[] args)
    {
      int oldValue = 0;
      //int val = calculator("1 + 1 - 1 - 1", oldValue);
      //oldValue = val;
      //val = calculator("+ 1 / 1 + 2", oldValue);
      //Console.WriteLine(val);

      string val = "";
      bool helper = true;
      Console.WriteLine("Welcome to the the Simple Calculator if you need to stop the program type: exit");
      while(helper == true)
      {
        Console.Write("Enter Integer: ");
        val = Console.ReadLine();
        if(val.ToLower().Trim() == "exit")
        {
          helper = false;
          break;
        }
        oldValue = calculator(val, oldValue);
        Console.WriteLine(oldValue);
      }

    }
  }
}
