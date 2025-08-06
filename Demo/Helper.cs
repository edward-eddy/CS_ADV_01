namespace Demo
{
    // Generic Class
    internal static class Helper/*<T>*/
    {
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


        #region Generic SWAP Method & Method
        // Generic SWAP Method
        public static void SWAP<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }

        public static void Print(string data)
        {
            Console.WriteLine(data);
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