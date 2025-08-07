namespace Assignment
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id : {Id}, Name : {Name}";
        }
    }
    internal static class Helpers
    {
        public static void Reverse<T>(T[] Arr)
        {
            int Length = Arr.Length;
            T[] TempArray = (T[])Arr.Clone();
            for (int i = 0; i <= Length - 1; i++)
            {
                Arr[i] = TempArray[Length - i - 1];
            }
        }
    }
}
