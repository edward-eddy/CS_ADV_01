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

        public static int[] GetEven(int[] list)
        {
            int EvenCount = 0;
            foreach (int i in list)
            {
                if (i % 2 == 0)
                    EvenCount++;
            }
            int[] Return = new int[EvenCount];
            int Index = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] % 2 == 0)
                {
                    Return[Index++] = list[i];
                }
            }
            return Return;
        }
    }
}
