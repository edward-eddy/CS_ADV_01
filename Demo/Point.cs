namespace Demo
{
    internal class Point : IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        //public int CompareTo(object? obj)
        //{
        //    Point point = (Point)obj;

        //    if (X == point.X)
        //        return Y.CompareTo(point.Y);

        //    return X.CompareTo(point.X);
        //}

        //public int CompareTo(object? obj)
        //{
        //    if (obj != null)
        //    {
        //        Point point = (Point)obj;

        //        if (X == point.X)
        //            return Y.CompareTo(point.Y);

        //        return X.CompareTo(point.X);
        //    }
        //    return 1;
        //}

        //public int CompareTo(object? obj)
        //{
        //    // 1. is Conditional Operator

        //    if (obj is not null)
        //    {
        //        if (obj is Point point)
        //        {
        //            //Point point = (Point)obj;

        //            if (X == point.X)
        //                return Y.CompareTo(point.Y);

        //            return X.CompareTo(point.X);
        //        }
        //    }
        //    return 1;
        //}

        public int CompareTo(object? obj)
        {
            // 1. as Casting Operator

            Point point = obj as Point;
            if (point is not null)
            {
                if (X == point.X)
                    return Y.CompareTo(point.Y);

                return X.CompareTo(point.X);
            }
            return 1;
        }
    }
}
