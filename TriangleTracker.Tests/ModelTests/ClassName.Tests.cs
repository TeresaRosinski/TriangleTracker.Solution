using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleKindTests
  {
    [TestMethod]
    public void Triangle_SidesShouldBeEqual_True()
    {
      Triangle.TriangleKind practiceTri = new Triangle.TriangleKind(3, 3, 3);
      Assert.AreEqual(true, practiceTri.EquilateralChecker(3, 3, 3));
    }
    [TestMethod]
    public void Triangle_ShouldBeAnIsoscelesTriangle_True()
    {
      Triangle.TriangleKind practiceTri2 = new Triangle.TriangleKind(4, 4, 2);
      Assert.AreEqual(true, practiceTri2.IsoscelesChecker(4, 4, 2));
    }
  }
}
  