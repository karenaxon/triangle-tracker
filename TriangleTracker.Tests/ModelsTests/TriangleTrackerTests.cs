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
    public void CheckTriangle_IsEquilateral_Equil()
    {
      Triangle triangle1 = new Triangle(3, 3, 3);
      Assert.AreEqual("Your triangle is Equilateral", triangle1.CheckTriangle());
    }

    [TestMethod]
    public void CheckTriangle_IsIsosceles_Isosceles()
    {
      Triangle triangle1 = new Triangle(3,3,4);
      Assert.AreEqual("Your triangle is Isosceles", triangle1.CheckTriangle());
    }

    [TestMethod]
    public void CheckTriangle_IsNotaTriangle_NotTriangle()
    {
      Triangle triangle1 = new Triangle(2,3,6);
      Assert.AreEqual("This is not a triangle", triangle1.CheckTriangle());
    }

  }
}
