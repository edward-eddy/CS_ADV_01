namespace Demo
{
    internal struct Point : IComparable
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

        public int CompareTo(object? obj)
        {
            Point point = (Point)obj;
            if (X == point.X) return Y.CompareTo(point.Y);
            return X.CompareTo(point.X);
        }
    }
}
