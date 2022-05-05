namespace Inheritance;

public class Rectangle
{
    public Rectangle(double l,double b)
        {
            length =l;
            breadth =b;
        }
    double length ;
    double breadth;

    public double GetArea() => length + breadth;
    public double GetPerimeter() => 2*(length +breadth);   
    
    }
    public class square : Rectangle 
        {
            public Square(double side): base (side, side )
            {

            }
        }
public class Rectangle: Shape ,I2DShape, IHaveDiagonal
    {
        
    }
public class Triangle
    {
        double = r;
    }

public class Circle
{
    public Circle(double l,double b)
        {
            length =l;
            breadth =b;
        }
    double length ;
    double breadth;

    public double GetArea() => length + breadth;
    public double GetPerimeter() => 2*(length +breadth);   
