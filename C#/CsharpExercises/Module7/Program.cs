using System;
using System.Collections.Generic;

namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapeList = AskForListOfShapes();
            PrintAllShapes(shapeList);

        }

        private static void PrintAllShapes(List<Shape> shapeList)
        {
                int triangles = 0;
                int rectangles = 0;
                int circles = 0;

            foreach (Shape s in shapeList)
            {

                //Console.WriteLine(s.tString);
                if (s is Triangle)
                {
                    triangles++;
                    var t = (Triangle)s;
                    Console.WriteLine(t.tString);
                }

                else if (s is Rectangel)
                {
                    rectangles++;
                    var r = (Rectangel)s;
                    Console.WriteLine(r.tString);
                }

                else if (s is Circle)
                {
                    circles++;
                    var c = (Circle)s;
                    Console.WriteLine(c.tString);
                }

                else
                Console.WriteLine();
            }

            string trianglesString = triangles + " triangles";
            string rectanglesString = rectangles + " rectangles";
            string circlesString = circles + " circles";

            Console.WriteLine($"You selected {trianglesString} and {rectanglesString} and {circlesString}");


        }

        private static List<Shape> AskForListOfShapes()
        {
            List<Shape> shapelist = new List<Shape>();

            char s;


            do
            {
                Console.Write("Select (T)riangle, (R)ectangle, (C)ircle or(D)one: ");

                s = char.Parse(Console.ReadLine().ToLower().Trim());


                if (s == 't')
                {

                    Console.Write("Enter base of triangle: ");
                    decimal baseTriangle = decimal.Parse(Console.ReadLine());

                    Console.Write("Enter height of triangle: ");
                    decimal heightTriangle = decimal.Parse(Console.ReadLine());

                    var triangle = new Triangle();
                    triangle.Height = heightTriangle;
                    triangle.Base = baseTriangle;

                    shapelist.Add(triangle);

                }

                if (s == 'r')
                {
                    Console.Write("Enter height of rectangle: ");
                    decimal heightRectangle = decimal.Parse(Console.ReadLine());

                    Console.Write("Enter length of rectangle: ");
                    decimal lengthRectangle = decimal.Parse(Console.ReadLine());

                    var rectangle = new Rectangel();
                    rectangle.Height = heightRectangle;
                    rectangle.Length = lengthRectangle;

                    shapelist.Add(rectangle);

                }

                if (s == 'c')
                {
                    Console.Write("Enter radius of circle: ");
                    decimal radiusCircle = decimal.Parse(Console.ReadLine());

                    var circle = new Circle();
                    circle.Radius = radiusCircle;

                    shapelist.Add(circle);
                }





            } while (s != 'd');

            return shapelist;
        }

        
    }
}
