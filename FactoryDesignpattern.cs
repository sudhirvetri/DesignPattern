using System;


//interface
public interface Ishape

{
    void Draw();
}

//concrete implementation
public class Circle : Ishape
{
    public void Draw()
    {
        Console.WriteLine("Circle");
    }
}

public class Rectangle : Ishape
{
    public void Draw()
    {
        Console.WriteLine("Rectangle");
    }
}

public class Square : Ishape
{
    public void Draw()
    {
        Console.WriteLine("Square");
    }
}

//factory class
public class ShapeFactory
{
    public Ishape Getshape(string shapetype)
    {
        switch(shapetype.ToUpper())
        {
            case "CIRCLE":
                return new Circle();
            case "RECTANGLE":
                return new Rectangle();
            case "SQUARE":
                return new Square();
            default:
                throw new ArgumentException("Unknown shape type");
        }
    }
}


class Program {
  static void Main() {
      ShapeFactory shape = new ShapeFactory();
     
      Ishape result1 = shape.Getshape("RECTANGLE");
      result1.Draw();
      
      Ishape result2 = shape.Getshape("Circle");
      result2.Draw();
      
      Ishape result3 = shape.Getshape("Trapezoid");
      result3.Draw();
      
      //shape.Getshape("Rectangle");
      //shape.Getshape("Trapezoid");

    
  }
}
