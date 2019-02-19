using System;
using System.Collections.Generic;
using System.Linq;

namespace PadawansTask9
{
    public class CartesianCoordinates
    {
        public static List<Point> GetNeighbors(Point point, int range, params Point[] points)
        {
            if (range < 0)
                throw new ArgumentException();
            if (points == null)
                throw new ArgumentNullException();

            List<Point> neighbours = new List<Point>();

            foreach (Point somePoint in points)
            {
                if (Math.Abs(somePoint.X - point.X)<=range && Math.Abs(somePoint.Y - point.Y) <= range)
                    neighbours.Add(somePoint);
            }
            return neighbours;
        }
    }
}