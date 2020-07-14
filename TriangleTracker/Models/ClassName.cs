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
      Console.WriteLine("Enter the length of the first side of your triangle: ");
      string userInput1 = Console.ReadLine();
      int length1 = int.Parse(userInput1);

      Console.WriteLine("Enter the length of the second side of your triangle: ");
      string userInput2 = Console.ReadLine();
      int length2 = int.Parse(userInput2);

      Console.WriteLine("Enter the length of the third side of your triangle: ");
      string userInput3 = Console.ReadLine();
      int length3 = int.Parse(userInput3);
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