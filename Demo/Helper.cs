namespace Demo
{
    // Generic Class
    internal static class Helper/*<T>*/
    {
        public static void BubbleSort<T>(T[] Arr) where T : IComparable<T>
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (Arr[j].CompareTo(Arr[j + 1]) > 0)
                            SWAP(ref Arr[j], ref Arr[j + 1]);
                    }
                }
            }
        }

        #region Non Generic Bubble Sort
        //public static void BubbleSort(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (Arr[j] > Arr[j + 1])
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //            }
        //        }
        //    }
        //} 
        #endregion

        #region Generic Linear Search Method
        //Generic Linear Search Method
        public static int LinearSearch<T>(T[] Arr, T Value)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Arr[i].Equals(Value)) return i;
                }
            }
            return -1;
        }

        public static int LinearSearch<T>(T[] Arr, T Value, IEqualityComparer<T> equalityComparer)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (equalityComparer.Equals(Arr[i], Value)) return i;
                }
            }
            return -1;
        }
        #endregion

        #region Non Generic Linear Search Method
        //public static int LinearSearch(int[] Arr, int Value)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            if (Arr[i] == Value) return i;
        //        }
        //    }
        //    return -1;
        //} 
        #endregion


        #region Generic SWAP Method
        // Generic SWAP Method
        public static void SWAP<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }
        #endregion

        #region Methods
        //public static void Print(string data)
        //{
        //    Console.WriteLine(data);
        //} 

        public static void PrintArray<T>(T[] Arr)
        {
            foreach (T t in Arr)
            {
                Console.WriteLine($"{t} ");
            }
        }
        #endregion

        #region Non Generic SWAP
        //public static void SWAP(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static void SWAP(ref double X, ref double Y)
        //{
        //    double Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static void SWAP(ref Point X, ref Point Y)
        //{
        //    Point Temp = X;
        //    X = Y;
        //    Y = Temp;
        //} 
        #endregion

    }
}