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
  }
}
  