namespace Assignment
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }

        public Range(T min, T max)
        {
            if (max.CompareTo(min) >= 0)
            {
                Min = min;
                Max = max;
            }
            else
            {
                Min = max;
                Max = min;
                Console.WriteLine($"Min : {max}, Max : {min}");
            }
        }

        public bool IsInRange(T Value)
        {
            return Value.CompareTo(Min) >= 0 && Value.CompareTo(Max) <= 0;
        }

        public dynamic GetLength()
        {
            try
            {
                return (dynamic)Max - (dynamic)Min + 1;
            }
            catch
            {
                return -1;
            }
        }
    }
}
