using System; 
using System.Collections.Generic;

namespace Triangle
{
  public class TriangleKind
  {
   
  }
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter 3 numbers: ");
      string userInput = Console.ReadLine();
      int lengths = int.Parse(userInput);
    }
  }
}

    // if (this.side1 === this.side2 && this.side1 === this.side3)
      // {
      //   return "Equilateral Triangle";
    //   }
    //   else if (this.side1 === this.side2 || this.side1 === this.side3)
    //   {
    //     return "Isosceles Triangle";
    //   }
    //   else if (this.side1 != this.side2 && this.side1 != this.side3 && this.side2 != this.side3)
    //   {
    //     return "Scalene Triangle";
    //   }
    //   else
    //   {
    //     return "Not triangle";
    //   }
    // 