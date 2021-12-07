namespace TriangleTracker

{
  public class Triangle
  {
    public int Side1 {get; set;}
    public int Side2 {get; set;}
    public int Side3 {get; set;}

    public Triangle(int side1, int side2, int side3)
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }

    public string CheckTriangle()
    {
      if(Side1 == Side2 && Side1 == Side3 && Side2 == Side3){
        return "Your triangle is Equilateral";
      } else if(Side1 == Side2 || Side2 == Side3 || Side1 == Side3){
        return "Your triangle is Isosceles";
      } else if(Side1+Side2 <= Side3 || Side2+Side3 <= Side1 || Side1+Side3 <= Side2){
        return "This is not a triangle";
      }
      return "fill in later";
    }

  }
}