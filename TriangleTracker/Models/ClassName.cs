using System; 
using System.Collections.Generic;

namespace Triangle
{
  public class TriangleKind 
  {
    public int Side1;
    public int Side2;
    public int Side3;

    public TriangleKind(int side1, int side2, int side3)
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }
  public bool EquilateralChecker(int side1, int side2, int side3)
    {
      return false; 
    }
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

      TriangleKind thisTriangle = new TriangleKind(length1, length2, length3);

    
    }
  }
}

  
    //   else if (length1 === length2 || length1 === length3)
    //   {
    //     return "Isosceles Triangle";
    //   }
    //   else if (length1 != length2 && length1 != length3 && length2 != length3)
    //   {
    //     return "Scalene Triangle";
    //   }
    //   else
    //   {
    //     return "Not triangle";
    //   }
    // 