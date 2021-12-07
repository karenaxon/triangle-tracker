using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    
    [TestMethod]
    public void GetSide_CreateASideOfTriangle_ReturnANumber()
    {
      Triangle triangle1 = new Triangle(3, 2, 1);
      Assert.AreEqual(2, triangle1.Side2);
    }

    [TestMethod]
    public void CheckTriangle_IsEquilateral_True()
    {
      Triangle triangle1 = new Triangle(3, 3, 3);
      Assert.AreEqual(true, triangle1.CheckTriangle());
    }

  }
}
