using System;
using System.Linq;

    

namespace InterSectionOfCircles
{

    public class Point
    {
        public int X { get; set; }
    public int Y { get; set; }
    }
    public class Circle
    {
        public int radius { get; set; }
        public Point Center { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            

            Circle[] Circle = new Circle[2];
            Point[] Center = new Point[2];

            for (int i = 0; i < 2; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                int X = int.Parse(input[0]);
                int Y = int.Parse(input[1]);
                Center[i] = new Point();
                Center[i].X= X;
                Center[i].Y = Y;
                Circle[i] = new Circle();
                Circle[i].Center = Center[i];
                Circle[i].radius = int.Parse(input[2]);
            }

            if(Intersect(Circle[0], Circle[1]))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }

        private static bool Intersect(Circle circle1, Circle circle2)
        {
            bool intersect = false;
            double a = circle1.Center.X - circle2.Center.X;
            double b = circle1.Center.Y - circle2.Center.Y;
            double distance = Math.Sqrt((a * a) + (b * b));
            if(distance <= circle1.radius + circle2.radius)
            {
                intersect = true;
            }
            return intersect;
        }
    }
}
