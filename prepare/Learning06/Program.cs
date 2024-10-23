using System;
using System.Drawing;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning06 World!");



        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("red", 3);
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("blue", 4, 5);
        shapes.Add(r1);

        Circle c1 = new Circle("Green", 6);
        shapes.Add(c1);


        //TEST
        //double areaSquare = s1.GetArea();

        //Console.WriteLine(areaSquare);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");

        }


    }




}
