using System;
namespace Calculator
{
  class Calculator
  {
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

    public static int calculator(string equation)
    {
      string[] equationSeparated = separateBySpace(equation);
      int counter = 0;
      int previousValue = 0;
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

      int val = -1;
      return val;
    }

    static void Main(string[] args)
    {
      int val = calculator("1 + 1 - 1");
      Console.WriteLine(val);
    }
  }
}
